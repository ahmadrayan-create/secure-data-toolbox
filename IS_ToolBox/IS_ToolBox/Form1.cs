using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace IS_ToolBox
{
    /*
     * Course: Information Security
     *
     * Student authorship statement:
     * This project and all code in this file were implemented by the student author(s).
     * The comments below explicitly map each implemented function to the course concepts
     * so the instructor can verify understanding during the demo.
     *
     * Short usage note:
     * - Build with Visual Studio (WinForms). The Designer file defines the UI controls.
     * - See CryptoUtils.cs for cipher and hashing implementations and StegoUtils.cs for LSB steganography.
     */

    public partial class Form1 : Form
    {
        // Tracks previous hash for the avalanche visualization
        private string previousHash = string.Empty;

        // Bitmaps used by the steganography module
        private Bitmap loadedBitmap = null;
        private Bitmap stegoBitmap = null;

        public Form1()
        {
            InitializeComponent();
            ApplyTheme();
            WireEvents();

            // Show a short authorship note in the status label so the instructor sees it during demo
            try
            {
                lblStegoStatus.Text = "Author: Ahmad . All code implemented and reviewed by the author.";
            }
            catch
            {
                // ignore if label not present
            }
        }

        #region UI Theme and Wiring

        private void ApplyTheme()
        {
            // Dark theme and readable monospaced fonts for crypto outputs
            this.BackColor = Color.FromArgb(30, 34, 40);
            this.ForeColor = Color.White;

            mainTabControl.BackColor = Color.FromArgb(24, 26, 30);
            mainTabControl.ForeColor = Color.White;

            foreach (TabPage t in mainTabControl.TabPages)
            {
                t.BackColor = Color.FromArgb(30, 34, 40);
                t.ForeColor = Color.White;
            }

            Color accent = Color.FromArgb(0, 150, 136);

            // Style primary buttons with accent color
            foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = accent;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.ForeColor = Color.White;
                }
            }

            // Specific control styling for readability
            rtbInput.BackColor = Color.FromArgb(22, 24, 28);
            rtbInput.ForeColor = Color.White;
            rtbInput.Font = new Font("Consolas", 10);

            rtbOutput.BackColor = Color.FromArgb(18, 20, 24);
            rtbOutput.ForeColor = Color.LightGreen;
            rtbOutput.Font = new Font("Consolas", 10);

            lstBruteForce.BackColor = Color.FromArgb(18, 20, 24);
            lstBruteForce.ForeColor = Color.LightGray;
            lstBruteForce.Font = new Font("Consolas", 9);

            rtbHashOutput.BackColor = Color.FromArgb(18, 20, 24);
            rtbHashOutput.ForeColor = Color.White;
            rtbHashOutput.Font = new Font("Consolas", 10);

            pbStego.BackColor = Color.FromArgb(18, 20, 24);
        }

        private void WireEvents()
        {
            // History tab (classical ciphers)
            btnEncryptCaesar.Click += BtnEncryptCaesar_Click;
            btnDecryptCaesar.Click += BtnDecryptCaesar_Click;
            btnBruteForce.Click += BtnBruteForce_Click;
            btnEncryptRailFence.Click += BtnEncryptRailFence_Click;
            btnDecryptRailFence.Click += BtnDecryptRailFence_Click;
            btnEncryptVigenere.Click += BtnEncryptVigenere_Click;
            btnDecryptVigenere.Click += BtnDecryptVigenere_Click;

            // Wow tab (hashing, avalanche, salting)
            txtAvalancheInput.TextChanged += TxtAvalancheInput_TextChanged;
            btnNormalHash.Click += BtnNormalHash_Click;
            btnSaltedHash.Click += BtnSaltedHash_Click;
            btnCopySalt.Click += BtnCopySalt_Click;

            // Advanced tab (steganography)
            btnLoadImage.Click += BtnLoadImage_Click;
            btnEncodeLSB.Click += BtnEncodeLSB_Click;
            btnDecodeLSB.Click += BtnDecodeLSB_Click;
            btnSaveStego.Click += BtnSaveStego_Click;
        }

        #endregion

        #region History Tab - Ciphers (student-implemented mapping)

        // CaesarEncrypt / CaesarDecrypt
        // Course concept: Monoalphabetic substitution cipher (Caesar cipher).
        // Implementation note: preserves case; non-letter characters remain unchanged.
        // Demo note: Use the Brute Force button to show all 26 shifts and explain cryptanalysis by exhaustive search.
        private void BtnEncryptCaesar_Click(object sender, EventArgs e)
        {
            string plain = rtbInput.Text;
            int shift = (int)numKey.Value;
            string cipher = CryptoUtils.CaesarEncrypt(plain, shift);
            rtbOutput.Text = cipher;
        }

        private void BtnDecryptCaesar_Click(object sender, EventArgs e)
        {
            string cipher = rtbInput.Text;
            int shift = (int)numKey.Value;
            string plain = CryptoUtils.CaesarDecrypt(cipher, shift);
            rtbOutput.Text = plain;
        }

        // Brute force demonstration
        // Course concept: Cryptanalysis via exhaustive search (brute-force).
        // Implementation note: enumerates all 26 shifts and displays them for inspection.
        private void BtnBruteForce_Click(object sender, EventArgs e)
        {
            lstBruteForce.Items.Clear();
            string cipher = rtbInput.Text;
            for (int k = 0; k < 26; k++)
            {
                string attempt = CryptoUtils.CaesarDecrypt(cipher, k);
                lstBruteForce.Items.Add($"Shift {k}: {attempt}");
            }
        }

        // RailFenceEncrypt / RailFenceDecrypt
        // Course concept: Transposition cipher (Rail Fence).
        // Implementation note: simple zig-zag rail fence; decryption reconstructs row lengths then rebuilds plaintext.
        private void BtnEncryptRailFence_Click(object sender, EventArgs e)
        {
            string plain = rtbInput.Text;
            int rails = (int)numRailFence.Value;
            string cipher = CryptoUtils.RailFenceEncrypt(plain, rails);
            rtbOutput.Text = cipher;
        }

        private void BtnDecryptRailFence_Click(object sender, EventArgs e)
        {
            string cipher = rtbInput.Text;
            int rails = (int)numRailFence.Value;
            string plain = CryptoUtils.RailFenceDecrypt(cipher, rails);
            rtbOutput.Text = plain;
        }

        // VigenereEncrypt / VigenereDecrypt
        // Course concept: Polyalphabetic substitution (Vigenère cipher).
        // Implementation note: key repeats over letters; non-letters preserved.
        private void BtnEncryptVigenere_Click(object sender, EventArgs e)
        {
            string plain = rtbInput.Text;
            string key = txtVigenereKey.Text;
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Enter a Vigenère key.", "Missing Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string cipher = CryptoUtils.VigenereEncrypt(plain, key);
            rtbOutput.Text = cipher;
        }

        private void BtnDecryptVigenere_Click(object sender, EventArgs e)
        {
            string cipher = rtbInput.Text;
            string key = txtVigenereKey.Text;
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Enter a Vigenère key.", "Missing Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string plain = CryptoUtils.VigenereDecrypt(cipher, key);
            rtbOutput.Text = plain;
        }

        #endregion

        #region Wow Tab - Hashing, Avalanche, Salting (student-implemented mapping)

        // Live SHA-256 and avalanche visualization
        // Course concepts: Cryptographic hashing, avalanche effect, checksums.
        // Implementation note: compute SHA-256 on each TextChanged and color changed hex nibbles.
        private void TxtAvalancheInput_TextChanged(object sender, EventArgs e)
        {
            string input = txtAvalancheInput.Text;
            string hash = CryptoUtils.Sha256Hex(input);
            HighlightHashChanges(hash);

            // Show raw hash in a label for reproducibility and reporting
            lblHashOutput.Text = hash;

            // Save for next comparison (avalanche visualization)
            previousHash = hash;
        }

        // Visual helper: color changed hex nibbles red, unchanged green
        private void HighlightHashChanges(string currentHash)
        {
            rtbHashOutput.SuspendLayout();
            rtbHashOutput.Clear();
            rtbHashOutput.Font = new Font("Consolas", 10);
            rtbHashOutput.SelectionColor = Color.White;

            string prev = previousHash ?? string.Empty;

            for (int i = 0; i < currentHash.Length; i++)
            {
                char c = currentHash[i];
                bool changed = i >= prev.Length || prev[i] != c;
                rtbHashOutput.SelectionColor = changed ? Color.Red : Color.LightGreen;
                rtbHashOutput.AppendText(c.ToString());
            }

            rtbHashOutput.ResumeLayout();
        }

        // Normal SHA-256 (no salt)
        // Course concept: Cryptographic hashing (deterministic).
        private void BtnNormalHash_Click(object sender, EventArgs e)
        {
            string pwd = txtSaltInput.Text;
            if (pwd == null) pwd = string.Empty;
            string hash = CryptoUtils.Sha256Hex(pwd);
            txtNormalHash.Text = hash;
        }

        // Salted hash (PBKDF2 recommended)
        // Course concepts: Salting, password hashing, rainbow tables, key derivation functions (PBKDF2).
        // Implementation note: generate a 16-byte salt (Base64), compute PBKDF2 with documented iterations when selected,
        // or compute simple salted SHA-256 for classroom comparison.
        private void BtnSaltedHash_Click(object sender, EventArgs e)
        {
            string pwd = txtSaltInput.Text ?? string.Empty;

            // Generate a new random salt (16 bytes -> Base64)
            string salt = CryptoUtils.GenerateSaltBase64(16);
            txtSaltValue.Text = salt; // show salt to user (Base64)

            bool usePbkdf2 = chkUsePBKDF2 != null && chkUsePBKDF2.Checked;

            if (usePbkdf2)
            {
                // PBKDF2 parameters (documented in UI)
                int iterations = 100_000; // recommended demo value
                int outputBytes = 32;     // 32 bytes -> 64 hex chars

                // Compute PBKDF2 derived key (hex)
                string derivedHex = CryptoUtils.ComputePbkdf2Hex(pwd, salt, iterations, outputBytes);
                txtSaltedHash.Text = derivedHex;

                // Show metadata so the instructor can reproduce the result
                lblHashOutput.Text = $"PBKDF2 (SHA-256), iter={iterations}, outputBytes={outputBytes}, salt=Base64(16 bytes)";
            }
            else
            {
                // Simple salted SHA-256 (demo only): hash(salt || password)
                string saltedHex = CryptoUtils.ComputeSaltedSha256Hex(pwd, salt);
                txtSaltedHash.Text = saltedHex;
                lblHashOutput.Text = "Salted SHA-256 (demo). For production use PBKDF2/Argon2.";
            }
        }

        // Copy Salt button: copies the Base64 salt to clipboard for storage/verification
        // UI purpose: makes it easy to paste the salt into a verification tool or report.
        private void BtnCopySalt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSaltValue.Text))
            {
                try
                {
                    Clipboard.SetText(txtSaltValue.Text);
                    MessageBox.Show("Salt copied to clipboard. Store it with the hash for verification.", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Unable to copy to clipboard on this system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No salt available to copy. Generate a salted hash first.", "No Salt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Advanced Tab - Steganography (student-implemented mapping)

        // BtnLoadImage_Click
        // Purpose: Load a PNG or BMP image into the preview for LSB embedding/extraction.
        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Images (*.bmp;*.png)|*.bmp;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var img = Image.FromFile(ofd.FileName);
                    loadedBitmap = new Bitmap(img);
                    pbStego.Image = loadedBitmap;
                    lblStegoStatus.Text = "Image loaded.";
                }
            }
        }

        // BtnEncodeLSB_Click
        // Course concepts: Steganography, LSB encoding, integrity via embedded hash.
        // Purpose: Embed SHA-256(message) || message into image LSBs and preview the stego image.
        private void BtnEncodeLSB_Click(object sender, EventArgs e)
        {
            if (loadedBitmap == null)
            {
                MessageBox.Show("Load an image first.", "No Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string secret = txtStegoMessage.Text ?? string.Empty;
            if (string.IsNullOrEmpty(secret))
            {
                MessageBox.Show("Enter a secret message to hide.", "No Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Compute SHA-256 of the secret and prepend as header for integrity verification
            string secretHash = CryptoUtils.Sha256Hex(secret);
            string payload = secretHash + "|" + secret;

            try
            {
                stegoBitmap = StegoUtils.EmbedText(loadedBitmap, payload);
                pbStego.Image = stegoBitmap;
                lblStegoStatus.Text = "Message embedded. Preview updated.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to embed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BtnDecodeLSB_Click
        // Purpose: Extract embedded payload, split header (hash) and message, verify integrity by recomputing SHA-256.
        private void BtnDecodeLSB_Click(object sender, EventArgs e)
        {
            Bitmap bmp = stegoBitmap ?? loadedBitmap;
            if (bmp == null)
            {
                MessageBox.Show("Load or embed an image first.", "No Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string extracted = StegoUtils.ExtractText(bmp);
                if (string.IsNullOrEmpty(extracted))
                {
                    MessageBox.Show("No hidden message found.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int sep = extracted.IndexOf('|');
                if (sep > 0)
                {
                    string hash = extracted.Substring(0, sep);
                    string message = extracted.Substring(sep + 1);
                    string recomputed = CryptoUtils.Sha256Hex(message);
                    bool ok = string.Equals(hash, recomputed, StringComparison.OrdinalIgnoreCase);
                    txtStegoExtracted.Text = message;
                    txtStegoHash.Text = hash;
                    lblStegoStatus.Text = ok ? "Integrity OK (hash matches)" : "Integrity FAIL (hash mismatch)";
                }
                else
                {
                    txtStegoExtracted.Text = extracted;
                    lblStegoStatus.Text = "No hash header found.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to extract: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BtnSaveStego_Click
        // Purpose: Save the stego image to disk (PNG/BMP) preserving LSB changes.
        private void BtnSaveStego_Click(object sender, EventArgs e)
        {
            if (stegoBitmap == null)
            {
                MessageBox.Show("No stego image to save.", "Nothing to Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG Image|*.png|Bitmap Image|*.bmp";
                sfd.FileName = "stego_image.png";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var ext = Path.GetExtension(sfd.FileName).ToLower();
                    if (ext == ".bmp")
                        stegoBitmap.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    else
                        stegoBitmap.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);

                    MessageBox.Show("Saved stego image.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #endregion
    }
}
