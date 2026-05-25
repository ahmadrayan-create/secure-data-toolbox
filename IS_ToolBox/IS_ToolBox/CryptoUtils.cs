using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System;

namespace IS_ToolBox
{
    public static class CryptoUtils
    {
        // Caesar cipher (letters only, preserve case, non-letters unchanged)
        public static string CaesarEncrypt(string plain, int shift)
        {
            if (plain == null) return string.Empty;
            shift = ((shift % 26) + 26) % 26;
            var sb = new StringBuilder(plain.Length);
            foreach (char ch in plain)
            {
                if (char.IsLetter(ch))
                {
                    char offset = char.IsUpper(ch) ? 'A' : 'a';
                    char enc = (char)((((ch - offset) + shift) % 26) + offset);
                    sb.Append(enc);
                }
                else
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString();
        }

        public static string CaesarDecrypt(string cipher, int shift)
        {
            return CaesarEncrypt(cipher, 26 - (shift % 26));
        }

        // Rail Fence (simple implementation)
        public static string RailFenceEncrypt(string plain, int rails)
        {
            if (string.IsNullOrEmpty(plain) || rails <= 1) return plain;
            var rows = new string[rails].Select(_ => new StringBuilder()).ToArray();
            int r = 0;
            int dir = 1;
            foreach (char c in plain)
            {
                rows[r].Append(c);
                r += dir;
                if (r == rails - 1 || r == 0) dir *= -1;
            }
            return string.Concat(rows.Select(x => x.ToString()));
        }

        public static string RailFenceDecrypt(string cipher, int rails)
        {
            if (string.IsNullOrEmpty(cipher) || rails <= 1) return cipher;
            int n = cipher.Length;

            var counts = new int[rails];
            int r = 0, dir = 1;
            for (int i = 0; i < n; i++)
            {
                counts[r]++;
                r += dir;
                if (r == rails - 1 || r == 0) dir *= -1;
            }

            var rows = new string[rails].Select(_ => new StringBuilder()).ToArray();
            int pos = 0;
            for (int row = 0; row < rails; row++)
            {
                rows[row].Append(cipher.Substring(pos, counts[row]));
                pos += counts[row];
            }

            var result = new StringBuilder();
            var pointers = new int[rails];
            r = 0; dir = 1;
            for (int i = 0; i < n; i++)
            {
                result.Append(rows[r][pointers[r]++]);
                r += dir;
                if (r == rails - 1 || r == 0) dir *= -1;
            }
            return result.ToString();
        }

        // Vigenere (letters only, preserve case)
        public static string VigenereEncrypt(string plain, string key)
        {
            if (string.IsNullOrEmpty(plain)) return string.Empty;
            if (string.IsNullOrEmpty(key)) return plain;
            var sb = new StringBuilder();
            int ki = 0;
            foreach (char ch in plain)
            {
                if (!char.IsLetter(ch))
                {
                    sb.Append(ch);
                    continue;
                }
                char kch = key[ki % key.Length];
                int shift = char.IsLetter(kch) ? (char.ToUpper(kch) - 'A') : 0;
                char offset = char.IsUpper(ch) ? 'A' : 'a';
                char enc = (char)((((ch - offset) + shift) % 26) + offset);
                sb.Append(enc);
                ki++;
            }
            return sb.ToString();
        }

        public static string VigenereDecrypt(string cipher, string key)
        {
            if (string.IsNullOrEmpty(cipher)) return string.Empty;
            if (string.IsNullOrEmpty(key)) return cipher;
            var sb = new StringBuilder();
            int ki = 0;
            foreach (char ch in cipher)
            {
                if (!char.IsLetter(ch))
                {
                    sb.Append(ch);
                    continue;
                }
                char kch = key[ki % key.Length];
                int shift = char.IsLetter(kch) ? (char.ToUpper(kch) - 'A') : 0;
                char offset = char.IsUpper(ch) ? 'A' : 'a';
                char dec = (char)((((ch - offset) - shift + 26) % 26) + offset);
                sb.Append(dec);
                ki++;
            }
            return sb.ToString();
        }

        // SHA-256 hex
        public static string Sha256Hex(string input)
        {
            if (input == null) input = string.Empty;
            using (var sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }

        // Generate a cryptographically secure random salt (returns Base64)
        public static string GenerateSaltBase64(int sizeBytes = 16)
        {
            var salt = new byte[sizeBytes];
            using (var rng = System.Security.Cryptography.RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }

        // Compute PBKDF2-derived key and return hex string (recommended for password hashing)
        public static string ComputePbkdf2Hex(string password, string saltBase64, int iterations = 100_000, int outputBytes = 32)
        {
            if (password == null) password = string.Empty;
            byte[] salt = Convert.FromBase64String(saltBase64);
            using (var derive = new System.Security.Cryptography.Rfc2898DeriveBytes(password, salt, iterations, System.Security.Cryptography.HashAlgorithmName.SHA256))
            {
                byte[] key = derive.GetBytes(outputBytes);
                return BitConverter.ToString(key).Replace("-", "").ToLowerInvariant();
            }
        }





        // Simple salted SHA-256 (classroom demo only)
        public static string ComputeSaltedSha256Hex(string password, string saltBase64)
        {
            if (password == null) password = string.Empty;
            byte[] salt = Convert.FromBase64String(saltBase64);
            byte[] pwdBytes = Encoding.UTF8.GetBytes(password);
            byte[] combined = new byte[salt.Length + pwdBytes.Length];
            Buffer.BlockCopy(salt, 0, combined, 0, salt.Length);
            Buffer.BlockCopy(pwdBytes, 0, combined, salt.Length, pwdBytes.Length);
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hash = sha.ComputeHash(combined);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }




    }
}
