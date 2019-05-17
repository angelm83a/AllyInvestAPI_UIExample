namespace PapaYorkieInvestment
{
    partial class YorkieMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YorkieMainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txCKValue = new System.Windows.Forms.TextBox();
            this.txCSValue = new System.Windows.Forms.TextBox();
            this.txTKValue = new System.Windows.Forms.TextBox();
            this.txTSValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtURLRoot = new System.Windows.Forms.TextBox();
            this.txtURLFolder = new System.Windows.Forms.TextBox();
            this.txtURLFileName = new System.Windows.Forms.TextBox();
            this.txtURLSymbols = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClearURL = new System.Windows.Forms.Button();
            this.btnClearCK = new System.Windows.Forms.Button();
            this.btnClearCS = new System.Windows.Forms.Button();
            this.btnClearTK = new System.Windows.Forms.Button();
            this.btnClearTS = new System.Windows.Forms.Button();
            this.btnMakeCall = new System.Windows.Forms.Button();
            this.btnSaveXML = new System.Windows.Forms.Button();
            this.btnEditSettings = new System.Windows.Forms.Button();
            this.btnClearMessageBox = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.txMessageBox = new System.Windows.Forms.RichTextBox();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.txSavePath = new System.Windows.Forms.TextBox();
            this.btnReloadSettings = new System.Windows.Forms.Button();
            this.tsLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabelTime,
            this.tsProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 514);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(942, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToToolStripMenuItem
            // 
            this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            this.howToToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.howToToolStripMenuItem.Text = "How to...";
            this.howToToolStripMenuItem.Click += new System.EventHandler(this.HowToToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CK";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CS";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "TK";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "TS";
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(43, 53);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(422, 24);
            this.txtURL.TabIndex = 1;
            // 
            // txCKValue
            // 
            this.txCKValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txCKValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCKValue.Location = new System.Drawing.Point(43, 81);
            this.txCKValue.Name = "txCKValue";
            this.txCKValue.Size = new System.Drawing.Size(722, 24);
            this.txCKValue.TabIndex = 7;
            // 
            // txCSValue
            // 
            this.txCSValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txCSValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCSValue.Location = new System.Drawing.Point(43, 109);
            this.txCSValue.Name = "txCSValue";
            this.txCSValue.Size = new System.Drawing.Size(722, 24);
            this.txCSValue.TabIndex = 9;
            // 
            // txTKValue
            // 
            this.txTKValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txTKValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTKValue.Location = new System.Drawing.Point(43, 135);
            this.txTKValue.Name = "txTKValue";
            this.txTKValue.Size = new System.Drawing.Size(722, 24);
            this.txTKValue.TabIndex = 11;
            // 
            // txTSValue
            // 
            this.txTSValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txTSValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTSValue.Location = new System.Drawing.Point(43, 163);
            this.txTSValue.Name = "txTSValue";
            this.txTSValue.Size = new System.Drawing.Size(722, 24);
            this.txTSValue.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Add your main URL or split it";
            // 
            // txtURLRoot
            // 
            this.txtURLRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURLRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURLRoot.Location = new System.Drawing.Point(471, 53);
            this.txtURLRoot.Name = "txtURLRoot";
            this.txtURLRoot.Size = new System.Drawing.Size(69, 24);
            this.txtURLRoot.TabIndex = 2;
            // 
            // txtURLFolder
            // 
            this.txtURLFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURLFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURLFolder.Location = new System.Drawing.Point(546, 53);
            this.txtURLFolder.Name = "txtURLFolder";
            this.txtURLFolder.Size = new System.Drawing.Size(69, 24);
            this.txtURLFolder.TabIndex = 3;
            // 
            // txtURLFileName
            // 
            this.txtURLFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURLFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURLFileName.Location = new System.Drawing.Point(621, 53);
            this.txtURLFileName.Name = "txtURLFileName";
            this.txtURLFileName.Size = new System.Drawing.Size(69, 24);
            this.txtURLFileName.TabIndex = 4;
            // 
            // txtURLSymbols
            // 
            this.txtURLSymbols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURLSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURLSymbols.Location = new System.Drawing.Point(696, 53);
            this.txtURLSymbols.Name = "txtURLSymbols";
            this.txtURLSymbols.Size = new System.Drawing.Size(69, 24);
            this.txtURLSymbols.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(468, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Root";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(543, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Folder";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(618, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "File Name";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(693, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Symbols";
            // 
            // btnClearURL
            // 
            this.btnClearURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearURL.BackColor = System.Drawing.Color.Silver;
            this.btnClearURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearURL.Location = new System.Drawing.Point(772, 53);
            this.btnClearURL.Name = "btnClearURL";
            this.btnClearURL.Size = new System.Drawing.Size(75, 23);
            this.btnClearURL.TabIndex = 6;
            this.btnClearURL.Text = "CLEAR";
            this.btnClearURL.UseVisualStyleBackColor = false;
            this.btnClearURL.Click += new System.EventHandler(this.BtnClearURL_Click);
            // 
            // btnClearCK
            // 
            this.btnClearCK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearCK.BackColor = System.Drawing.Color.Silver;
            this.btnClearCK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCK.Location = new System.Drawing.Point(772, 82);
            this.btnClearCK.Name = "btnClearCK";
            this.btnClearCK.Size = new System.Drawing.Size(75, 23);
            this.btnClearCK.TabIndex = 8;
            this.btnClearCK.Text = "CLEAR";
            this.btnClearCK.UseVisualStyleBackColor = false;
            this.btnClearCK.Click += new System.EventHandler(this.BtnClearCK_Click);
            // 
            // btnClearCS
            // 
            this.btnClearCS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearCS.BackColor = System.Drawing.Color.Silver;
            this.btnClearCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCS.Location = new System.Drawing.Point(772, 109);
            this.btnClearCS.Name = "btnClearCS";
            this.btnClearCS.Size = new System.Drawing.Size(75, 23);
            this.btnClearCS.TabIndex = 10;
            this.btnClearCS.Text = "CLEAR";
            this.btnClearCS.UseVisualStyleBackColor = false;
            this.btnClearCS.Click += new System.EventHandler(this.BtnClearCS_Click);
            // 
            // btnClearTK
            // 
            this.btnClearTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearTK.BackColor = System.Drawing.Color.Silver;
            this.btnClearTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTK.Location = new System.Drawing.Point(772, 137);
            this.btnClearTK.Name = "btnClearTK";
            this.btnClearTK.Size = new System.Drawing.Size(75, 23);
            this.btnClearTK.TabIndex = 12;
            this.btnClearTK.Text = "CLEAR";
            this.btnClearTK.UseVisualStyleBackColor = false;
            this.btnClearTK.Click += new System.EventHandler(this.BtnClearTK_Click);
            // 
            // btnClearTS
            // 
            this.btnClearTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearTS.BackColor = System.Drawing.Color.Silver;
            this.btnClearTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTS.Location = new System.Drawing.Point(772, 163);
            this.btnClearTS.Name = "btnClearTS";
            this.btnClearTS.Size = new System.Drawing.Size(75, 23);
            this.btnClearTS.TabIndex = 14;
            this.btnClearTS.Text = "CLEAR";
            this.btnClearTS.UseVisualStyleBackColor = false;
            this.btnClearTS.Click += new System.EventHandler(this.BtnClearTS_Click);
            // 
            // btnMakeCall
            // 
            this.btnMakeCall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMakeCall.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMakeCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeCall.Location = new System.Drawing.Point(9, 445);
            this.btnMakeCall.Name = "btnMakeCall";
            this.btnMakeCall.Size = new System.Drawing.Size(118, 66);
            this.btnMakeCall.TabIndex = 17;
            this.btnMakeCall.Text = "&MAKE CALL";
            this.btnMakeCall.UseVisualStyleBackColor = false;
            this.btnMakeCall.Click += new System.EventHandler(this.BtnMakeCall_Click);
            // 
            // btnSaveXML
            // 
            this.btnSaveXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveXML.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSaveXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveXML.Location = new System.Drawing.Point(167, 445);
            this.btnSaveXML.Name = "btnSaveXML";
            this.btnSaveXML.Size = new System.Drawing.Size(118, 66);
            this.btnSaveXML.TabIndex = 18;
            this.btnSaveXML.Text = "&SAVE XML";
            this.btnSaveXML.UseVisualStyleBackColor = false;
            this.btnSaveXML.Click += new System.EventHandler(this.BtnSaveXML_Click);
            // 
            // btnEditSettings
            // 
            this.btnEditSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditSettings.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnEditSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSettings.Location = new System.Drawing.Point(494, 445);
            this.btnEditSettings.Name = "btnEditSettings";
            this.btnEditSettings.Size = new System.Drawing.Size(118, 66);
            this.btnEditSettings.TabIndex = 20;
            this.btnEditSettings.Text = "&EDIT SETTINGS";
            this.btnEditSettings.UseVisualStyleBackColor = false;
            this.btnEditSettings.Click += new System.EventHandler(this.BtnEditSettings_Click);
            // 
            // btnClearMessageBox
            // 
            this.btnClearMessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearMessageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClearMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMessageBox.Location = new System.Drawing.Point(329, 445);
            this.btnClearMessageBox.Name = "btnClearMessageBox";
            this.btnClearMessageBox.Size = new System.Drawing.Size(118, 66);
            this.btnClearMessageBox.TabIndex = 19;
            this.btnClearMessageBox.Text = "&CLEAR MESSAGE";
            this.btnClearMessageBox.UseVisualStyleBackColor = false;
            this.btnClearMessageBox.Click += new System.EventHandler(this.BtnClearMessageBox_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(813, 445);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 66);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "E&XIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(853, 53);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(78, 134);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "C&LEAR ALL";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // txMessageBox
            // 
            this.txMessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMessageBox.Location = new System.Drawing.Point(9, 193);
            this.txMessageBox.Name = "txMessageBox";
            this.txMessageBox.Size = new System.Drawing.Size(921, 213);
            this.txMessageBox.TabIndex = 16;
            this.txMessageBox.Text = "";
            // 
            // btnSavePath
            // 
            this.btnSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSavePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSavePath.Location = new System.Drawing.Point(9, 412);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(118, 23);
            this.btnSavePath.TabIndex = 12;
            this.btnSavePath.Text = "Select &Path";
            this.btnSavePath.UseVisualStyleBackColor = false;
            this.btnSavePath.Click += new System.EventHandler(this.BtnSavePath_Click);
            // 
            // txSavePath
            // 
            this.txSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txSavePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSavePath.Location = new System.Drawing.Point(133, 411);
            this.txSavePath.Name = "txSavePath";
            this.txSavePath.Size = new System.Drawing.Size(797, 24);
            this.txSavePath.TabIndex = 10;
            // 
            // btnReloadSettings
            // 
            this.btnReloadSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReloadSettings.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnReloadSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadSettings.Location = new System.Drawing.Point(658, 445);
            this.btnReloadSettings.Name = "btnReloadSettings";
            this.btnReloadSettings.Size = new System.Drawing.Size(118, 66);
            this.btnReloadSettings.TabIndex = 21;
            this.btnReloadSettings.Text = "&RELOAD SETTINGS";
            this.btnReloadSettings.UseVisualStyleBackColor = false;
            this.btnReloadSettings.Click += new System.EventHandler(this.btnReloadSettings_Click);
            // 
            // tsLabelTime
            // 
            this.tsLabelTime.Name = "tsLabelTime";
            this.tsLabelTime.Size = new System.Drawing.Size(37, 17);
            this.tsLabelTime.Text = "Time ";
            // 
            // tsProgressBar
            // 
            this.tsProgressBar.Name = "tsProgressBar";
            this.tsProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // YorkieMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(942, 536);
            this.Controls.Add(this.btnSavePath);
            this.Controls.Add(this.txMessageBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClearMessageBox);
            this.Controls.Add(this.btnReloadSettings);
            this.Controls.Add(this.btnEditSettings);
            this.Controls.Add(this.btnSaveXML);
            this.Controls.Add(this.btnMakeCall);
            this.Controls.Add(this.btnClearTS);
            this.Controls.Add(this.btnClearTK);
            this.Controls.Add(this.btnClearCS);
            this.Controls.Add(this.btnClearCK);
            this.Controls.Add(this.btnClearURL);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txSavePath);
            this.Controls.Add(this.txTSValue);
            this.Controls.Add(this.txTKValue);
            this.Controls.Add(this.txCSValue);
            this.Controls.Add(this.txCKValue);
            this.Controls.Add(this.txtURLSymbols);
            this.Controls.Add(this.txtURLFolder);
            this.Controls.Add(this.txtURLFileName);
            this.Controls.Add(this.txtURLRoot);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "YorkieMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papa Yorkie Investments";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txCKValue;
        private System.Windows.Forms.TextBox txCSValue;
        private System.Windows.Forms.TextBox txTKValue;
        private System.Windows.Forms.TextBox txTSValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtURLRoot;
        private System.Windows.Forms.TextBox txtURLFolder;
        private System.Windows.Forms.TextBox txtURLFileName;
        private System.Windows.Forms.TextBox txtURLSymbols;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClearURL;
        private System.Windows.Forms.Button btnClearCK;
        private System.Windows.Forms.Button btnClearCS;
        private System.Windows.Forms.Button btnClearTK;
        private System.Windows.Forms.Button btnClearTS;
        private System.Windows.Forms.Button btnMakeCall;
        private System.Windows.Forms.Button btnSaveXML;
        private System.Windows.Forms.Button btnEditSettings;
        private System.Windows.Forms.Button btnClearMessageBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.RichTextBox txMessageBox;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.TextBox txSavePath;
        private System.Windows.Forms.Button btnReloadSettings;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelTime;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
    }
}

