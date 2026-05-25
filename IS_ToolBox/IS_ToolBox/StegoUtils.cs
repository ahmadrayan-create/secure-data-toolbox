using System;
using System.Drawing;
using System.Linq;
using System.Text;

namespace IS_ToolBox
{
    public static class StegoUtils
    {
        // Embed text into bitmap using LSB of RGB channels.
        // Format: payload string (we expect small messages). We store length header (32-bit) then bytes.
        public static Bitmap EmbedText(Bitmap source, string payload)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (payload == null) payload = string.Empty;

            byte[] data = Encoding.UTF8.GetBytes(payload);
            int dataLen = data.Length;

            byte[] lenBytes = BitConverter.GetBytes(dataLen);
            byte[] full = new byte[4 + dataLen];
            Array.Copy(lenBytes, 0, full, 0, 4);
            Array.Copy(data, 0, full, 4, dataLen);

            int capacity = source.Width * source.Height * 3; // bits available (1 bit per channel)
            if (full.Length * 8 > capacity)
                throw new InvalidOperationException("Image too small for payload.");

            Bitmap bmp = new Bitmap(source.Width, source.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            int w = source.Width;
            int h = source.Height;
            int byteIndex = 0;
            int bitIndex = 0;

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    Color px = source.GetPixel(x, y);
                    int r = px.R;
                    int g = px.G;
                    int b = px.B;

                    if (byteIndex < full.Length)
                    {
                        int bit = (full[byteIndex] >> (7 - bitIndex)) & 1;
                        r = (r & ~1) | bit;
                        bitIndex++;
                        if (bitIndex == 8) { bitIndex = 0; byteIndex++; }
                    }
                    if (byteIndex < full.Length)
                    {
                        int bit = (full[byteIndex] >> (7 - bitIndex)) & 1;
                        g = (g & ~1) | bit;
                        bitIndex++;
                        if (bitIndex == 8) { bitIndex = 0; byteIndex++; }
                    }
                    if (byteIndex < full.Length)
                    {
                        int bit = (full[byteIndex] >> (7 - bitIndex)) & 1;
                        b = (b & ~1) | bit;
                        bitIndex++;
                        if (bitIndex == 8) { bitIndex = 0; byteIndex++; }
                    }

                    Color newPx = Color.FromArgb(r, g, b);
                    bmp.SetPixel(x, y, newPx);
                }
            }

            return bmp;
        }

        // Extract text from bitmap (reads length header then bytes)
        public static string ExtractText(Bitmap source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            int w = source.Width;
            int h = source.Height;

            var bytes = new System.Collections.Generic.List<byte>();
            int currentByte = 0;
            int bitsFilled = 0;

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    Color px = source.GetPixel(x, y);
                    int[] channels = new int[] { px.R, px.G, px.B };
                    foreach (int ch in channels)
                    {
                        int bit = ch & 1;
                        currentByte = (currentByte << 1) | bit;
                        bitsFilled++;
                        if (bitsFilled == 8)
                        {
                            bytes.Add((byte)currentByte);
                            bitsFilled = 0;
                            currentByte = 0;
                        }
                    }
                }
            }

            if (bytes.Count < 4) return string.Empty;
            int len = BitConverter.ToInt32(bytes.Take(4).ToArray(), 0);
            if (len <= 0 || len > (bytes.Count - 4)) return string.Empty;

            byte[] payload = bytes.Skip(4).Take(len).ToArray();
            return Encoding.UTF8.GetString(payload);
        }
    }
}
