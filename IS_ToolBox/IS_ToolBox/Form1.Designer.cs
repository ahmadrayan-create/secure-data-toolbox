namespace IS_ToolBox
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TabPage tabWow;
        private System.Windows.Forms.TabPage tabAdvanced;

        // History controls
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label lblCaesarKey;
        private System.Windows.Forms.NumericUpDown numKey;
        private System.Windows.Forms.Button btnEncryptCaesar;
        private System.Windows.Forms.Button btnDecryptCaesar;
        private System.Windows.Forms.Button btnBruteForce;
        private System.Windows.Forms.ListBox lstBruteForce;
        private System.Windows.Forms.Label lblBruteForce;
        private System.Windows.Forms.Label lblRailFence;
        private System.Windows.Forms.NumericUpDown numRailFence;
        private System.Windows.Forms.Button btnEncryptRailFence;
        private System.Windows.Forms.Button btnDecryptRailFence;
        private System.Windows.Forms.Label lblVigenereKey;
        private System.Windows.Forms.TextBox txtVigenereKey;
        private System.Windows.Forms.Button btnEncryptVigenere;
        private System.Windows.Forms.Button btnDecryptVigenere;

        // Wow controls
        private System.Windows.Forms.Label lblAvalancheInput;
        private System.Windows.Forms.TextBox txtAvalancheInput;
        private System.Windows.Forms.Label lblLiveHash;
        private System.Windows.Forms.RichTextBox rtbHashOutput;
        private System.Windows.Forms.Label lblSaltDemo;
        private System.Windows.Forms.TextBox txtSaltInput;
        private System.Windows.Forms.Button btnNormalHash;
        private System.Windows.Forms.Button btnSaltedHash;
        private System.Windows.Forms.Label lblNormalHash;
        private System.Windows.Forms.TextBox txtNormalHash;
        private System.Windows.Forms.Label lblSaltValue;
        private System.Windows.Forms.TextBox txtSaltValue;
        private System.Windows.Forms.Label lblSaltedHash;
        private System.Windows.Forms.TextBox txtSaltedHash;
        private System.Windows.Forms.Button btnCopySalt;
        private System.Windows.Forms.CheckBox chkUsePBKDF2;

        private System.Windows.Forms.Label lblHashOutput;


        // Advanced controls
        private System.Windows.Forms.Label lblStegoPreview;
        private System.Windows.Forms.PictureBox pbStego;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Label lblStegoMessage;
        private System.Windows.Forms.TextBox txtStegoMessage;
        private System.Windows.Forms.Button btnEncodeLSB;
        private System.Windows.Forms.Button btnDecodeLSB;
        private System.Windows.Forms.Label lblStegoExtracted;
        private System.Windows.Forms.TextBox txtStegoExtracted;
        private System.Windows.Forms.Label lblStegoHash;
        private System.Windows.Forms.TextBox txtStegoHash;
        private System.Windows.Forms.Button btnSaveStego;
        private System.Windows.Forms.Label lblStegoStatus;

        // Additional UX helpers
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel rightPanelHistory;
        private System.Windows.Forms.Panel rightPanelAdvanced;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mainTabControl = new TabControl();
            tabHistory = new TabPage();
            lblInput = new Label();
            rtbInput = new RichTextBox();
            lblOutput = new Label();
            rtbOutput = new RichTextBox();
            rightPanelHistory = new Panel();
            lblCaesarKey = new Label();
            numKey = new NumericUpDown();
            btnEncryptCaesar = new Button();
            btnDecryptCaesar = new Button();
            btnBruteForce = new Button();
            lblBruteForce = new Label();
            lstBruteForce = new ListBox();
            lblRailFence = new Label();
            numRailFence = new NumericUpDown();
            btnEncryptRailFence = new Button();
            btnDecryptRailFence = new Button();
            lblVigenereKey = new Label();
            txtVigenereKey = new TextBox();
            btnEncryptVigenere = new Button();
            btnDecryptVigenere = new Button();
            tabWow = new TabPage();
            lblHashOutput = new Label();
            lblAvalancheInput = new Label();
            txtAvalancheInput = new TextBox();
            lblLiveHash = new Label();
            rtbHashOutput = new RichTextBox();
            lblSaltDemo = new Label();
            txtSaltInput = new TextBox();
            btnNormalHash = new Button();
            btnSaltedHash = new Button();
            lblNormalHash = new Label();
            txtNormalHash = new TextBox();
            lblSaltValue = new Label();
            txtSaltValue = new TextBox();
            lblSaltedHash = new Label();
            txtSaltedHash = new TextBox();
            chkUsePBKDF2 = new CheckBox();
            btnCopySalt = new Button();
            tabAdvanced = new TabPage();
            lblStegoPreview = new Label();
            pbStego = new PictureBox();
            rightPanelAdvanced = new Panel();
            btnLoadImage = new Button();
            lblStegoMessage = new Label();
            txtStegoMessage = new TextBox();
            btnEncodeLSB = new Button();
            btnDecodeLSB = new Button();
            lblStegoExtracted = new Label();
            txtStegoExtracted = new TextBox();
            lblStegoHash = new Label();
            txtStegoHash = new TextBox();
            btnSaveStego = new Button();
            lblStegoStatus = new Label();
            toolTip = new ToolTip(components);
            mainTabControl.SuspendLayout();
            tabHistory.SuspendLayout();
            rightPanelHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numKey).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRailFence).BeginInit();
            tabWow.SuspendLayout();
            tabAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbStego).BeginInit();
            rightPanelAdvanced.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(tabHistory);
            mainTabControl.Controls.Add(tabWow);
            mainTabControl.Controls.Add(tabAdvanced);
            mainTabControl.ForeColor = Color.FromArgb(230, 230, 235);
            mainTabControl.Location = new Point(12, 12);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(1076, 676);
            mainTabControl.TabIndex = 0;
            // 
            // tabHistory
            // 
            tabHistory.BackColor = Color.FromArgb(28, 31, 36);
            tabHistory.Controls.Add(lblInput);
            tabHistory.Controls.Add(rtbInput);
            tabHistory.Controls.Add(lblOutput);
            tabHistory.Controls.Add(rtbOutput);
            tabHistory.Controls.Add(rightPanelHistory);
            tabHistory.Location = new Point(4, 24);
            tabHistory.Name = "tabHistory";
            tabHistory.Padding = new Padding(10);
            tabHistory.Size = new Size(1068, 648);
            tabHistory.TabIndex = 0;
            tabHistory.Text = "History - Ciphers";
            // 
            // lblInput
            // 
            lblInput.ForeColor = Color.FromArgb(160, 170, 180);
            lblInput.Location = new Point(20, 8);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(300, 18);
            lblInput.TabIndex = 0;
            lblInput.Text = "Plaintext / Ciphertext (Input)";
            // 
            // rtbInput
            // 
            rtbInput.BackColor = Color.FromArgb(34, 40, 49);
            rtbInput.BorderStyle = BorderStyle.FixedSingle;
            rtbInput.Font = new Font("Consolas", 10F);
            rtbInput.ForeColor = Color.FromArgb(230, 230, 235);
            rtbInput.Location = new Point(20, 30);
            rtbInput.Name = "rtbInput";
            rtbInput.Size = new Size(480, 220);
            rtbInput.TabIndex = 1;
            rtbInput.Text = "";
            toolTip.SetToolTip(rtbInput, "Type or paste the message you want to encrypt/decrypt here.");
            // 
            // lblOutput
            // 
            lblOutput.ForeColor = Color.FromArgb(160, 170, 180);
            lblOutput.Location = new Point(20, 252);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(300, 18);
            lblOutput.TabIndex = 2;
            lblOutput.Text = "Result (Output)";
            // 
            // rtbOutput
            // 
            rtbOutput.BackColor = Color.FromArgb(34, 40, 49);
            rtbOutput.BorderStyle = BorderStyle.FixedSingle;
            rtbOutput.Font = new Font("Consolas", 10F);
            rtbOutput.ForeColor = Color.LightGreen;
            rtbOutput.Location = new Point(20, 274);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.ReadOnly = true;
            rtbOutput.Size = new Size(480, 220);
            rtbOutput.TabIndex = 3;
            rtbOutput.Text = "";
            toolTip.SetToolTip(rtbOutput, "Encrypted or decrypted output appears here.");
            // 
            // rightPanelHistory
            // 
            rightPanelHistory.BackColor = Color.FromArgb(30, 34, 40);
            rightPanelHistory.Controls.Add(lblCaesarKey);
            rightPanelHistory.Controls.Add(numKey);
            rightPanelHistory.Controls.Add(btnEncryptCaesar);
            rightPanelHistory.Controls.Add(btnDecryptCaesar);
            rightPanelHistory.Controls.Add(btnBruteForce);
            rightPanelHistory.Controls.Add(lblBruteForce);
            rightPanelHistory.Controls.Add(lstBruteForce);
            rightPanelHistory.Controls.Add(lblRailFence);
            rightPanelHistory.Controls.Add(numRailFence);
            rightPanelHistory.Controls.Add(btnEncryptRailFence);
            rightPanelHistory.Controls.Add(btnDecryptRailFence);
            rightPanelHistory.Controls.Add(lblVigenereKey);
            rightPanelHistory.Controls.Add(txtVigenereKey);
            rightPanelHistory.Controls.Add(btnEncryptVigenere);
            rightPanelHistory.Controls.Add(btnDecryptVigenere);
            rightPanelHistory.Location = new Point(520, 20);
            rightPanelHistory.Name = "rightPanelHistory";
            rightPanelHistory.Size = new Size(520, 480);
            rightPanelHistory.TabIndex = 4;
            // 
            // lblCaesarKey
            // 
            lblCaesarKey.ForeColor = Color.FromArgb(160, 170, 180);
            lblCaesarKey.Location = new Point(10, 8);
            lblCaesarKey.Name = "lblCaesarKey";
            lblCaesarKey.Size = new Size(200, 18);
            lblCaesarKey.TabIndex = 0;
            lblCaesarKey.Text = "Caesar Shift (0-25)";
            // 
            // numKey
            // 
            numKey.Location = new Point(10, 30);
            numKey.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numKey.Name = "numKey";
            numKey.Size = new Size(120, 23);
            numKey.TabIndex = 1;
            toolTip.SetToolTip(numKey, "Select numeric shift for Caesar cipher.");
            numKey.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnEncryptCaesar
            // 
            btnEncryptCaesar.BackColor = Color.FromArgb(45, 140, 240);
            btnEncryptCaesar.FlatStyle = FlatStyle.Flat;
            btnEncryptCaesar.ForeColor = Color.White;
            btnEncryptCaesar.Location = new Point(150, 28);
            btnEncryptCaesar.Name = "btnEncryptCaesar";
            btnEncryptCaesar.Size = new Size(160, 30);
            btnEncryptCaesar.TabIndex = 2;
            btnEncryptCaesar.Text = "Encrypt Caesar";
            toolTip.SetToolTip(btnEncryptCaesar, "Encrypt the input using the Caesar cipher and the selected shift.");
            btnEncryptCaesar.UseVisualStyleBackColor = false;
            // 
            // btnDecryptCaesar
            // 
            btnDecryptCaesar.BackColor = Color.FromArgb(70, 80, 90);
            btnDecryptCaesar.FlatStyle = FlatStyle.Flat;
            btnDecryptCaesar.ForeColor = Color.White;
            btnDecryptCaesar.Location = new Point(320, 28);
            btnDecryptCaesar.Name = "btnDecryptCaesar";
            btnDecryptCaesar.Size = new Size(160, 30);
            btnDecryptCaesar.TabIndex = 3;
            btnDecryptCaesar.Text = "Decrypt Caesar";
            toolTip.SetToolTip(btnDecryptCaesar, "Decrypt the input using the Caesar cipher and the selected shift.");
            btnDecryptCaesar.UseVisualStyleBackColor = false;
            // 
            // btnBruteForce
            // 
            btnBruteForce.BackColor = Color.FromArgb(60, 70, 85);
            btnBruteForce.FlatStyle = FlatStyle.Flat;
            btnBruteForce.ForeColor = Color.White;
            btnBruteForce.Location = new Point(10, 70);
            btnBruteForce.Name = "btnBruteForce";
            btnBruteForce.Size = new Size(200, 34);
            btnBruteForce.TabIndex = 4;
            btnBruteForce.Text = "Brute Force (show all 26 shifts)";
            toolTip.SetToolTip(btnBruteForce, "Generate all 26 Caesar shift attempts for quick cryptanalysis.");
            btnBruteForce.UseVisualStyleBackColor = false;
            // 
            // lblBruteForce
            // 
            lblBruteForce.ForeColor = Color.FromArgb(160, 170, 180);
            lblBruteForce.Location = new Point(10, 110);
            lblBruteForce.Name = "lblBruteForce";
            lblBruteForce.Size = new Size(200, 18);
            lblBruteForce.TabIndex = 5;
            lblBruteForce.Text = "Brute Force Results";
            // 
            // lstBruteForce
            // 
            lstBruteForce.BackColor = Color.FromArgb(34, 40, 49);
            lstBruteForce.Font = new Font("Consolas", 9F);
            lstBruteForce.ForeColor = Color.LightGray;
            lstBruteForce.ItemHeight = 14;
            lstBruteForce.Location = new Point(10, 130);
            lstBruteForce.Name = "lstBruteForce";
            lstBruteForce.Size = new Size(480, 116);
            lstBruteForce.TabIndex = 6;
            toolTip.SetToolTip(lstBruteForce, "All 26 Caesar shift outputs appear here for inspection.");
            // 
            // lblRailFence
            // 
            lblRailFence.ForeColor = Color.FromArgb(160, 170, 180);
            lblRailFence.Location = new Point(10, 260);
            lblRailFence.Name = "lblRailFence";
            lblRailFence.Size = new Size(300, 18);
            lblRailFence.TabIndex = 7;
            lblRailFence.Text = "Rail Fence (number of rails)";
            // 
            // numRailFence
            // 
            numRailFence.Location = new Point(10, 282);
            numRailFence.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numRailFence.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numRailFence.Name = "numRailFence";
            numRailFence.Size = new Size(120, 23);
            numRailFence.TabIndex = 8;
            toolTip.SetToolTip(numRailFence, "Choose rails for the Rail Fence transposition cipher.");
            numRailFence.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnEncryptRailFence
            // 
            btnEncryptRailFence.BackColor = Color.FromArgb(45, 140, 240);
            btnEncryptRailFence.FlatStyle = FlatStyle.Flat;
            btnEncryptRailFence.ForeColor = Color.White;
            btnEncryptRailFence.Location = new Point(150, 280);
            btnEncryptRailFence.Name = "btnEncryptRailFence";
            btnEncryptRailFence.Size = new Size(160, 30);
            btnEncryptRailFence.TabIndex = 9;
            btnEncryptRailFence.Text = "Encrypt RailFence";
            toolTip.SetToolTip(btnEncryptRailFence, "Encrypt using Rail Fence transposition.");
            btnEncryptRailFence.UseVisualStyleBackColor = false;
            // 
            // btnDecryptRailFence
            // 
            btnDecryptRailFence.BackColor = Color.FromArgb(70, 80, 90);
            btnDecryptRailFence.FlatStyle = FlatStyle.Flat;
            btnDecryptRailFence.ForeColor = Color.White;
            btnDecryptRailFence.Location = new Point(320, 280);
            btnDecryptRailFence.Name = "btnDecryptRailFence";
            btnDecryptRailFence.Size = new Size(160, 30);
            btnDecryptRailFence.TabIndex = 10;
            btnDecryptRailFence.Text = "Decrypt RailFence";
            toolTip.SetToolTip(btnDecryptRailFence, "Decrypt Rail Fence transposition.");
            btnDecryptRailFence.UseVisualStyleBackColor = false;
            // 
            // lblVigenereKey
            // 
            lblVigenereKey.ForeColor = Color.FromArgb(160, 170, 180);
            lblVigenereKey.Location = new Point(10, 330);
            lblVigenereKey.Name = "lblVigenereKey";
            lblVigenereKey.Size = new Size(300, 18);
            lblVigenereKey.TabIndex = 11;
            lblVigenereKey.Text = "Vigenère Key (letters only)";
            // 
            // txtVigenereKey
            // 
            txtVigenereKey.BackColor = Color.FromArgb(34, 40, 49);
            txtVigenereKey.ForeColor = Color.FromArgb(230, 230, 235);
            txtVigenereKey.Location = new Point(10, 352);
            txtVigenereKey.Name = "txtVigenereKey";
            txtVigenereKey.Size = new Size(300, 23);
            txtVigenereKey.TabIndex = 12;
            toolTip.SetToolTip(txtVigenereKey, "Enter the Vigenère key used for encryption/decryption.");
            // 
            // btnEncryptVigenere
            // 
            btnEncryptVigenere.BackColor = Color.FromArgb(45, 140, 240);
            btnEncryptVigenere.FlatStyle = FlatStyle.Flat;
            btnEncryptVigenere.ForeColor = Color.White;
            btnEncryptVigenere.Location = new Point(320, 350);
            btnEncryptVigenere.Name = "btnEncryptVigenere";
            btnEncryptVigenere.Size = new Size(160, 30);
            btnEncryptVigenere.TabIndex = 13;
            btnEncryptVigenere.Text = "Encrypt Vigenère";
            toolTip.SetToolTip(btnEncryptVigenere, "Encrypt input using the Vigenère cipher and provided key.");
            btnEncryptVigenere.UseVisualStyleBackColor = false;
            // 
            // btnDecryptVigenere
            // 
            btnDecryptVigenere.BackColor = Color.FromArgb(70, 80, 90);
            btnDecryptVigenere.FlatStyle = FlatStyle.Flat;
            btnDecryptVigenere.ForeColor = Color.White;
            btnDecryptVigenere.Location = new Point(320, 390);
            btnDecryptVigenere.Name = "btnDecryptVigenere";
            btnDecryptVigenere.Size = new Size(160, 30);
            btnDecryptVigenere.TabIndex = 14;
            btnDecryptVigenere.Text = "Decrypt Vigenère";
            toolTip.SetToolTip(btnDecryptVigenere, "Decrypt input using the Vigenère cipher and provided key.");
            btnDecryptVigenere.UseVisualStyleBackColor = false;
            // 
            // tabWow
            // 
            tabWow.BackColor = Color.FromArgb(28, 31, 36);
            tabWow.Controls.Add(lblHashOutput);
            tabWow.Controls.Add(lblAvalancheInput);
            tabWow.Controls.Add(txtAvalancheInput);
            tabWow.Controls.Add(lblLiveHash);
            tabWow.Controls.Add(rtbHashOutput);
            tabWow.Controls.Add(lblSaltDemo);
            tabWow.Controls.Add(txtSaltInput);
            tabWow.Controls.Add(btnNormalHash);
            tabWow.Controls.Add(btnSaltedHash);
            tabWow.Controls.Add(lblNormalHash);
            tabWow.Controls.Add(txtNormalHash);
            tabWow.Controls.Add(lblSaltValue);
            tabWow.Controls.Add(txtSaltValue);
            tabWow.Controls.Add(lblSaltedHash);
            tabWow.Controls.Add(txtSaltedHash);
            tabWow.Controls.Add(chkUsePBKDF2);
            tabWow.Controls.Add(btnCopySalt);
            tabWow.Location = new Point(4, 24);
            tabWow.Name = "tabWow";
            tabWow.Padding = new Padding(10);
            tabWow.Size = new Size(1068, 648);
            tabWow.TabIndex = 1;
            tabWow.Text = "Wow - Hashing & Avalanche";
            // 
            // lblHashOutput
            // 
            lblHashOutput.Font = new Font("Consolas", 9F);
            lblHashOutput.ForeColor = Color.LightGray;
            lblHashOutput.Location = new Point(20, 430);
            lblHashOutput.Name = "lblHashOutput";
            lblHashOutput.Size = new Size(600, 20);
            lblHashOutput.TabIndex = 0;
            toolTip.SetToolTip(lblHashOutput, "Full SHA-256 hash (raw) for the current input.");
            // 
            // lblAvalancheInput
            // 
            lblAvalancheInput.ForeColor = Color.FromArgb(160, 170, 180);
            lblAvalancheInput.Location = new Point(20, 8);
            lblAvalancheInput.Name = "lblAvalancheInput";
            lblAvalancheInput.Size = new Size(219, 19);
            lblAvalancheInput.TabIndex = 0;
            lblAvalancheInput.Text = "Live Input (type to see SHA-256 update)";
            // 
            // txtAvalancheInput
            // 
            txtAvalancheInput.BackColor = Color.FromArgb(34, 40, 49);
            txtAvalancheInput.Font = new Font("Consolas", 11F);
            txtAvalancheInput.ForeColor = Color.FromArgb(230, 230, 235);
            txtAvalancheInput.Location = new Point(20, 30);
            txtAvalancheInput.Name = "txtAvalancheInput";
            txtAvalancheInput.Size = new Size(600, 25);
            txtAvalancheInput.TabIndex = 1;
            toolTip.SetToolTip(txtAvalancheInput, "Type text here to observe the avalanche effect in the hash below.");
            // 
            // lblLiveHash
            // 
            lblLiveHash.ForeColor = Color.FromArgb(160, 170, 180);
            lblLiveHash.Location = new Point(20, 70);
            lblLiveHash.Name = "lblLiveHash";
            lblLiveHash.Size = new Size(259, 19);
            lblLiveHash.TabIndex = 2;
            lblLiveHash.Text = "Live SHA-256 (changed hex chars highlighted)";
            // 
            // rtbHashOutput
            // 
            rtbHashOutput.BackColor = Color.FromArgb(34, 40, 49);
            rtbHashOutput.Font = new Font("Consolas", 10F);
            rtbHashOutput.ForeColor = Color.FromArgb(230, 230, 235);
            rtbHashOutput.Location = new Point(20, 92);
            rtbHashOutput.Name = "rtbHashOutput";
            rtbHashOutput.ReadOnly = true;
            rtbHashOutput.Size = new Size(600, 60);
            rtbHashOutput.TabIndex = 3;
            rtbHashOutput.Text = "";
            // 
            // lblSaltDemo
            // 
            lblSaltDemo.ForeColor = Color.FromArgb(160, 170, 180);
            lblSaltDemo.Location = new Point(20, 170);
            lblSaltDemo.Name = "lblSaltDemo";
            lblSaltDemo.Size = new Size(158, 19);
            lblSaltDemo.TabIndex = 4;
            lblSaltDemo.Text = "Salting Demo (anti-rainbow)";
            // 
            // txtSaltInput
            // 
            txtSaltInput.BackColor = Color.FromArgb(34, 40, 49);
            txtSaltInput.ForeColor = Color.FromArgb(230, 230, 235);
            txtSaltInput.Location = new Point(20, 192);
            txtSaltInput.Name = "txtSaltInput";
            txtSaltInput.Size = new Size(300, 23);
            txtSaltInput.TabIndex = 5;
            toolTip.SetToolTip(txtSaltInput, "Enter a password to demonstrate normal vs salted hashing.");
            // 
            // btnNormalHash
            // 
            btnNormalHash.BackColor = Color.FromArgb(70, 80, 90);
            btnNormalHash.FlatStyle = FlatStyle.Flat;
            btnNormalHash.ForeColor = Color.White;
            btnNormalHash.Location = new Point(340, 190);
            btnNormalHash.Name = "btnNormalHash";
            btnNormalHash.Size = new Size(120, 30);
            btnNormalHash.TabIndex = 6;
            btnNormalHash.Text = "Normal Hash";
            toolTip.SetToolTip(btnNormalHash, "Compute SHA-256 of the entered password (no salt).");
            btnNormalHash.UseVisualStyleBackColor = false;
            // 
            // btnSaltedHash
            // 
            btnSaltedHash.BackColor = Color.FromArgb(45, 140, 240);
            btnSaltedHash.FlatStyle = FlatStyle.Flat;
            btnSaltedHash.ForeColor = Color.White;
            btnSaltedHash.Location = new Point(480, 190);
            btnSaltedHash.Name = "btnSaltedHash";
            btnSaltedHash.Size = new Size(120, 30);
            btnSaltedHash.TabIndex = 7;
            btnSaltedHash.Text = "Salted Hash";
            toolTip.SetToolTip(btnSaltedHash, "Generate a random salt (GUID) and compute salted SHA-256.");
            btnSaltedHash.UseVisualStyleBackColor = false;
            btnSaltedHash.Click += BtnSaltedHash_Click;
            // 
            // lblNormalHash
            // 
            lblNormalHash.ForeColor = Color.FromArgb(160, 170, 180);
            lblNormalHash.Location = new Point(20, 230);
            lblNormalHash.Name = "lblNormalHash";
            lblNormalHash.Size = new Size(158, 19);
            lblNormalHash.TabIndex = 8;
            lblNormalHash.Text = "Normal SHA-256";
            // 
            // txtNormalHash
            // 
            txtNormalHash.BackColor = Color.FromArgb(34, 40, 49);
            txtNormalHash.ForeColor = Color.LightGray;
            txtNormalHash.Location = new Point(20, 252);
            txtNormalHash.Name = "txtNormalHash";
            txtNormalHash.ReadOnly = true;
            txtNormalHash.Size = new Size(580, 23);
            txtNormalHash.TabIndex = 9;
            // 
            // lblSaltValue
            // 
            lblSaltValue.ForeColor = Color.FromArgb(160, 170, 180);
            lblSaltValue.Location = new Point(20, 290);
            lblSaltValue.Name = "lblSaltValue";
            lblSaltValue.Size = new Size(158, 19);
            lblSaltValue.TabIndex = 10;
            lblSaltValue.Text = "Salt (GUID)";
            // 
            // txtSaltValue
            // 
            txtSaltValue.BackColor = Color.FromArgb(34, 40, 49);
            txtSaltValue.ForeColor = Color.LightGray;
            txtSaltValue.Location = new Point(20, 312);
            txtSaltValue.Name = "txtSaltValue";
            txtSaltValue.ReadOnly = true;
            txtSaltValue.Size = new Size(580, 23);
            txtSaltValue.TabIndex = 11;
            // 
            // lblSaltedHash
            // 
            lblSaltedHash.ForeColor = Color.FromArgb(160, 170, 180);
            lblSaltedHash.Location = new Point(20, 350);
            lblSaltedHash.Name = "lblSaltedHash";
            lblSaltedHash.Size = new Size(167, 19);
            lblSaltedHash.TabIndex = 12;
            lblSaltedHash.Text = "Salted SHA-256";
            // 
            // txtSaltedHash
            // 
            txtSaltedHash.BackColor = Color.FromArgb(34, 40, 49);
            txtSaltedHash.ForeColor = Color.LightGray;
            txtSaltedHash.Location = new Point(20, 372);
            txtSaltedHash.Name = "txtSaltedHash";
            txtSaltedHash.ReadOnly = true;
            txtSaltedHash.Size = new Size(580, 23);
            txtSaltedHash.TabIndex = 13;
            // 
            // chkUsePBKDF2
            // 
            chkUsePBKDF2.Checked = true;
            chkUsePBKDF2.CheckState = CheckState.Checked;
            chkUsePBKDF2.ForeColor = Color.FromArgb(160, 170, 180);
            chkUsePBKDF2.Location = new Point(20, 405);
            chkUsePBKDF2.Name = "chkUsePBKDF2";
            chkUsePBKDF2.Size = new Size(300, 20);
            chkUsePBKDF2.TabIndex = 14;
            chkUsePBKDF2.Text = "Use PBKDF2 (recommended for password hashing)";
            toolTip.SetToolTip(chkUsePBKDF2, "When checked, salted hash will be derived using PBKDF2 (secure).");
            // 
            // btnCopySalt
            // 
            btnCopySalt.BackColor = Color.FromArgb(70, 80, 90);
            btnCopySalt.FlatStyle = FlatStyle.Flat;
            btnCopySalt.ForeColor = Color.White;
            btnCopySalt.Location = new Point(620, 310);
            btnCopySalt.Name = "btnCopySalt";
            btnCopySalt.Size = new Size(80, 24);
            btnCopySalt.TabIndex = 15;
            btnCopySalt.Text = "Copy Salt";
            toolTip.SetToolTip(btnCopySalt, "Copy the generated salt to clipboard for storage.");
            btnCopySalt.UseVisualStyleBackColor = false;
            btnCopySalt.Click += BtnCopySalt_Click;
            // 
            // tabAdvanced
            // 
            tabAdvanced.BackColor = Color.FromArgb(28, 31, 36);
            tabAdvanced.Controls.Add(lblStegoPreview);
            tabAdvanced.Controls.Add(pbStego);
            tabAdvanced.Controls.Add(rightPanelAdvanced);
            tabAdvanced.Location = new Point(4, 24);
            tabAdvanced.Name = "tabAdvanced";
            tabAdvanced.Padding = new Padding(10);
            tabAdvanced.Size = new Size(1068, 648);
            tabAdvanced.TabIndex = 2;
            tabAdvanced.Text = "Advanced - Steganography";
            // 
            // lblStegoPreview
            // 
            lblStegoPreview.ForeColor = Color.FromArgb(160, 170, 180);
            lblStegoPreview.Location = new Point(20, 8);
            lblStegoPreview.Name = "lblStegoPreview";
            lblStegoPreview.Size = new Size(147, 19);
            lblStegoPreview.TabIndex = 0;
            lblStegoPreview.Text = "Image Preview";
            // 
            // pbStego
            // 
            pbStego.BackColor = Color.FromArgb(34, 40, 49);
            pbStego.BorderStyle = BorderStyle.FixedSingle;
            pbStego.Location = new Point(20, 30);
            pbStego.Name = "pbStego";
            pbStego.Size = new Size(640, 420);
            pbStego.SizeMode = PictureBoxSizeMode.Zoom;
            pbStego.TabIndex = 1;
            pbStego.TabStop = false;
            toolTip.SetToolTip(pbStego, "Loaded image will be shown here. Use high-resolution PNG/BMP for best results.");
            // 
            // rightPanelAdvanced
            // 
            rightPanelAdvanced.BackColor = Color.FromArgb(30, 34, 40);
            rightPanelAdvanced.Controls.Add(btnLoadImage);
            rightPanelAdvanced.Controls.Add(lblStegoMessage);
            rightPanelAdvanced.Controls.Add(txtStegoMessage);
            rightPanelAdvanced.Controls.Add(btnEncodeLSB);
            rightPanelAdvanced.Controls.Add(btnDecodeLSB);
            rightPanelAdvanced.Controls.Add(lblStegoExtracted);
            rightPanelAdvanced.Controls.Add(txtStegoExtracted);
            rightPanelAdvanced.Controls.Add(lblStegoHash);
            rightPanelAdvanced.Controls.Add(txtStegoHash);
            rightPanelAdvanced.Controls.Add(btnSaveStego);
            rightPanelAdvanced.Controls.Add(lblStegoStatus);
            rightPanelAdvanced.Location = new Point(680, 20);
            rightPanelAdvanced.Name = "rightPanelAdvanced";
            rightPanelAdvanced.Size = new Size(380, 580);
            rightPanelAdvanced.TabIndex = 2;
            // 
            // btnLoadImage
            // 
            btnLoadImage.BackColor = Color.FromArgb(45, 140, 240);
            btnLoadImage.FlatStyle = FlatStyle.Flat;
            btnLoadImage.ForeColor = Color.White;
            btnLoadImage.Location = new Point(10, 8);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(160, 34);
            btnLoadImage.TabIndex = 0;
            btnLoadImage.Text = "Load Image";
            toolTip.SetToolTip(btnLoadImage, "Load a PNG or BMP image to embed/extract hidden data.");
            btnLoadImage.UseVisualStyleBackColor = false;
            // 
            // lblStegoMessage
            // 
            lblStegoMessage.ForeColor = Color.FromArgb(160, 170, 180);
            lblStegoMessage.Location = new Point(10, 56);
            lblStegoMessage.Name = "lblStegoMessage";
            lblStegoMessage.Size = new Size(100, 23);
            lblStegoMessage.TabIndex = 1;
            lblStegoMessage.Text = "Secret message to hide";
            // 
            // txtStegoMessage
            // 
            txtStegoMessage.BackColor = Color.FromArgb(34, 40, 49);
            txtStegoMessage.ForeColor = Color.FromArgb(230, 230, 235);
            txtStegoMessage.Location = new Point(10, 78);
            txtStegoMessage.Multiline = true;
            txtStegoMessage.Name = "txtStegoMessage";
            txtStegoMessage.Size = new Size(360, 120);
            txtStegoMessage.TabIndex = 2;
            toolTip.SetToolTip(txtStegoMessage, "Enter the secret message. A SHA-256 hash will be prepended for integrity verification.");
            // 
            // btnEncodeLSB
            // 
            btnEncodeLSB.BackColor = Color.FromArgb(45, 140, 240);
            btnEncodeLSB.FlatStyle = FlatStyle.Flat;
            btnEncodeLSB.ForeColor = Color.White;
            btnEncodeLSB.Location = new Point(10, 210);
            btnEncodeLSB.Name = "btnEncodeLSB";
            btnEncodeLSB.Size = new Size(160, 34);
            btnEncodeLSB.TabIndex = 3;
            btnEncodeLSB.Text = "Embed (LSB)";
            toolTip.SetToolTip(btnEncodeLSB, "Embed the secret message into the loaded image using LSB technique.");
            btnEncodeLSB.UseVisualStyleBackColor = false;
            // 
            // btnDecodeLSB
            // 
            btnDecodeLSB.BackColor = Color.FromArgb(70, 80, 90);
            btnDecodeLSB.FlatStyle = FlatStyle.Flat;
            btnDecodeLSB.ForeColor = Color.White;
            btnDecodeLSB.Location = new Point(190, 210);
            btnDecodeLSB.Name = "btnDecodeLSB";
            btnDecodeLSB.Size = new Size(160, 34);
            btnDecodeLSB.TabIndex = 4;
            btnDecodeLSB.Text = "Extract (LSB)";
            toolTip.SetToolTip(btnDecodeLSB, "Extract hidden message from the currently loaded/stego image.");
            btnDecodeLSB.UseVisualStyleBackColor = false;
            // 
            // lblStegoExtracted
            // 
            lblStegoExtracted.ForeColor = Color.FromArgb(160, 170, 180);
            lblStegoExtracted.Location = new Point(10, 260);
            lblStegoExtracted.Name = "lblStegoExtracted";
            lblStegoExtracted.Size = new Size(100, 23);
            lblStegoExtracted.TabIndex = 5;
            lblStegoExtracted.Text = "Extracted message";
            // 
            // txtStegoExtracted
            // 
            txtStegoExtracted.BackColor = Color.FromArgb(34, 40, 49);
            txtStegoExtracted.ForeColor = Color.LightGray;
            txtStegoExtracted.Location = new Point(10, 282);
            txtStegoExtracted.Multiline = true;
            txtStegoExtracted.Name = "txtStegoExtracted";
            txtStegoExtracted.ReadOnly = true;
            txtStegoExtracted.Size = new Size(360, 120);
            txtStegoExtracted.TabIndex = 6;
            toolTip.SetToolTip(txtStegoExtracted, "Extracted secret message will appear here after extraction.");
            // 
            // lblStegoHash
            // 
            lblStegoHash.ForeColor = Color.FromArgb(160, 170, 180);
            lblStegoHash.Location = new Point(10, 410);
            lblStegoHash.Name = "lblStegoHash";
            lblStegoHash.Size = new Size(100, 23);
            lblStegoHash.TabIndex = 7;
            lblStegoHash.Text = "Embedded SHA-256 (header)";
            // 
            // txtStegoHash
            // 
            txtStegoHash.BackColor = Color.FromArgb(34, 40, 49);
            txtStegoHash.ForeColor = Color.LightGray;
            txtStegoHash.Location = new Point(10, 432);
            txtStegoHash.Name = "txtStegoHash";
            txtStegoHash.ReadOnly = true;
            txtStegoHash.Size = new Size(360, 23);
            txtStegoHash.TabIndex = 8;
            toolTip.SetToolTip(txtStegoHash, "SHA-256 hash that was embedded alongside the message for integrity verification.");
            // 
            // btnSaveStego
            // 
            btnSaveStego.BackColor = Color.FromArgb(70, 80, 90);
            btnSaveStego.FlatStyle = FlatStyle.Flat;
            btnSaveStego.ForeColor = Color.White;
            btnSaveStego.Location = new Point(10, 470);
            btnSaveStego.Name = "btnSaveStego";
            btnSaveStego.Size = new Size(160, 34);
            btnSaveStego.TabIndex = 9;
            btnSaveStego.Text = "Save Stego Image";
            toolTip.SetToolTip(btnSaveStego, "Save the image with embedded data (use PNG/BMP to preserve LSB).");
            btnSaveStego.UseVisualStyleBackColor = false;
            // 
            // lblStegoStatus
            // 
            lblStegoStatus.ForeColor = Color.FromArgb(255, 128, 255);
            lblStegoStatus.Location = new Point(10, 515);
            lblStegoStatus.Name = "lblStegoStatus";
            lblStegoStatus.Size = new Size(360, 38);
            lblStegoStatus.TabIndex = 10;
            lblStegoStatus.Text = "Status: Idle";
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(24, 26, 30);
            ClientSize = new Size(1100, 700);
            Controls.Add(mainTabControl);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.FromArgb(230, 230, 235);
            Name = "Form1";
            Text = "IS Toolbox — Cryptography & Security Labs";
            mainTabControl.ResumeLayout(false);
            tabHistory.ResumeLayout(false);
            rightPanelHistory.ResumeLayout(false);
            rightPanelHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numKey).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRailFence).EndInit();
            tabWow.ResumeLayout(false);
            tabWow.PerformLayout();
            tabAdvanced.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbStego).EndInit();
            rightPanelAdvanced.ResumeLayout(false);
            rightPanelAdvanced.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
