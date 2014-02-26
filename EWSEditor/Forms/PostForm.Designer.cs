﻿namespace EWSEditor.Common
{
    partial class PostForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmboAuthentication = new System.Windows.Forms.ComboBox();
            this.lblAuthentication = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.GoRun = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmboVerb = new System.Windows.Forms.ComboBox();
            this.cmboContentType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownTimeoutSeconds = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoadExample = new System.Windows.Forms.Button();
            this.btnSaveExample = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUserAgent = new System.Windows.Forms.TextBox();
            this.chkTranslateF = new System.Windows.Forms.CheckBox();
            this.chkPragmaNocache = new System.Windows.Forms.CheckBox();
            this.chkAllowRedirect = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOptions = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteHeader = new System.Windows.Forms.Button();
            this.btnAddHeaders = new System.Windows.Forms.Button();
            this.grpHttpVerbOptions = new System.Windows.Forms.GroupBox();
            this.chkRawPost = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeoutSeconds)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOptions)).BeginInit();
            this.grpHttpVerbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmboAuthentication);
            this.groupBox1.Controls.Add(this.lblAuthentication);
            this.groupBox1.Controls.Add(this.txtDomain);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(8, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmboAuthentication
            // 
            this.cmboAuthentication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboAuthentication.FormattingEnabled = true;
            this.cmboAuthentication.Items.AddRange(new object[] {
            "DefaultNetworkCredentials",
            "DefaultCredentials",
            "Basic",
            "NTLM",
            "Kerberos",
            "Negotiate",
            "Digest"});
            this.cmboAuthentication.Location = new System.Drawing.Point(90, 14);
            this.cmboAuthentication.Name = "cmboAuthentication";
            this.cmboAuthentication.Size = new System.Drawing.Size(211, 21);
            this.cmboAuthentication.TabIndex = 95;
            this.cmboAuthentication.Text = "DefaultNetworkCredentials";
            this.cmboAuthentication.SelectedIndexChanged += new System.EventHandler(this.cmboAuthentication_SelectedIndexChanged);
            // 
            // lblAuthentication
            // 
            this.lblAuthentication.AutoSize = true;
            this.lblAuthentication.Location = new System.Drawing.Point(6, 16);
            this.lblAuthentication.Name = "lblAuthentication";
            this.lblAuthentication.Size = new System.Drawing.Size(78, 13);
            this.lblAuthentication.TabIndex = 73;
            this.lblAuthentication.Text = "Authentication:";
            // 
            // txtDomain
            // 
            this.txtDomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDomain.Location = new System.Drawing.Point(90, 89);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(211, 20);
            this.txtDomain.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Location = new System.Drawing.Point(90, 40);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(211, 20);
            this.txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(90, 64);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(211, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Domain:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Password:";
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(34, 196);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(1037, 20);
            this.txtUrl.TabIndex = 46;
            this.txtUrl.Text = "https://mail.contoso.com/EWS/Exchange.asmx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "URL:";
            // 
            // txtRequest
            // 
            this.txtRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequest.Location = new System.Drawing.Point(3, 25);
            this.txtRequest.MaxLength = 0;
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRequest.Size = new System.Drawing.Size(1060, 160);
            this.txtRequest.TabIndex = 64;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(3, 16);
            this.txtResponse.MaxLength = 0;
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(1060, 179);
            this.txtResponse.TabIndex = 66;
            // 
            // GoRun
            // 
            this.GoRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoRun.Location = new System.Drawing.Point(995, 11);
            this.GoRun.Name = "GoRun";
            this.GoRun.Size = new System.Drawing.Size(76, 23);
            this.GoRun.TabIndex = 68;
            this.GoRun.Text = "Run";
            this.GoRun.UseVisualStyleBackColor = true;
            this.GoRun.Click += new System.EventHandler(this.GoRun_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "ContentType:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Verb:";
            // 
            // cmboVerb
            // 
            this.cmboVerb.FormattingEnabled = true;
            this.cmboVerb.Items.AddRange(new object[] {
            "POST",
            "GET",
            "PUT"});
            this.cmboVerb.Location = new System.Drawing.Point(102, 20);
            this.cmboVerb.Name = "cmboVerb";
            this.cmboVerb.Size = new System.Drawing.Size(120, 21);
            this.cmboVerb.TabIndex = 73;
            this.cmboVerb.Text = "POST";
            // 
            // cmboContentType
            // 
            this.cmboContentType.FormattingEnabled = true;
            this.cmboContentType.Items.AddRange(new object[] {
            "text/xml",
            "text/html"});
            this.cmboContentType.Location = new System.Drawing.Point(102, 55);
            this.cmboContentType.Name = "cmboContentType";
            this.cmboContentType.Size = new System.Drawing.Size(120, 21);
            this.cmboContentType.TabIndex = 74;
            this.cmboContentType.Text = "text/xml";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "Timeout Seconds:";
            // 
            // numericUpDownTimeoutSeconds
            // 
            this.numericUpDownTimeoutSeconds.Location = new System.Drawing.Point(102, 82);
            this.numericUpDownTimeoutSeconds.Name = "numericUpDownTimeoutSeconds";
            this.numericUpDownTimeoutSeconds.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTimeoutSeconds.TabIndex = 76;
            this.numericUpDownTimeoutSeconds.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnLoadExample);
            this.panel2.Controls.Add(this.btnSaveExample);
            this.panel2.Location = new System.Drawing.Point(233, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 30);
            this.panel2.TabIndex = 91;
            // 
            // btnLoadExample
            // 
            this.btnLoadExample.Location = new System.Drawing.Point(3, 3);
            this.btnLoadExample.Name = "btnLoadExample";
            this.btnLoadExample.Size = new System.Drawing.Size(105, 23);
            this.btnLoadExample.TabIndex = 47;
            this.btnLoadExample.Text = "Load Example";
            this.btnLoadExample.UseVisualStyleBackColor = true;
            this.btnLoadExample.Click += new System.EventHandler(this.btnLoadExample_Click);
            // 
            // btnSaveExample
            // 
            this.btnSaveExample.Location = new System.Drawing.Point(114, 3);
            this.btnSaveExample.Name = "btnSaveExample";
            this.btnSaveExample.Size = new System.Drawing.Size(104, 23);
            this.btnSaveExample.TabIndex = 45;
            this.btnSaveExample.Text = "Save Example";
            this.btnSaveExample.UseVisualStyleBackColor = true;
            this.btnSaveExample.Click += new System.EventHandler(this.btnSaveExample_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLoadSettings);
            this.panel1.Controls.Add(this.btnSaveSettings);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 30);
            this.panel1.TabIndex = 90;
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Location = new System.Drawing.Point(3, 3);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(105, 23);
            this.btnLoadSettings.TabIndex = 49;
            this.btnLoadSettings.Text = "Load Settings";
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(114, 3);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(104, 23);
            this.btnSaveSettings.TabIndex = 50;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(616, 13);
            this.label10.TabIndex = 92;
            this.label10.Text = "Note: This is the URL to the Exchange Web Service for the Mailbox.  Example:  htt" +
    "ps://mail.contoso.com/EWS/Exchange.asmx ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 93;
            this.label11.Text = "UserAgent:";
            // 
            // txtUserAgent
            // 
            this.txtUserAgent.Location = new System.Drawing.Point(102, 110);
            this.txtUserAgent.Name = "txtUserAgent";
            this.txtUserAgent.Size = new System.Drawing.Size(121, 20);
            this.txtUserAgent.TabIndex = 94;
            // 
            // chkTranslateF
            // 
            this.chkTranslateF.AutoSize = true;
            this.chkTranslateF.Location = new System.Drawing.Point(237, 84);
            this.chkTranslateF.Margin = new System.Windows.Forms.Padding(2);
            this.chkTranslateF.Name = "chkTranslateF";
            this.chkTranslateF.Size = new System.Drawing.Size(82, 17);
            this.chkTranslateF.TabIndex = 95;
            this.chkTranslateF.Text = "Translate: F";
            this.chkTranslateF.UseVisualStyleBackColor = true;
            // 
            // chkPragmaNocache
            // 
            this.chkPragmaNocache.AutoSize = true;
            this.chkPragmaNocache.Checked = true;
            this.chkPragmaNocache.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPragmaNocache.Location = new System.Drawing.Point(237, 58);
            this.chkPragmaNocache.Margin = new System.Windows.Forms.Padding(2);
            this.chkPragmaNocache.Name = "chkPragmaNocache";
            this.chkPragmaNocache.Size = new System.Drawing.Size(113, 17);
            this.chkPragmaNocache.TabIndex = 96;
            this.chkPragmaNocache.Text = "Pragma: no-cache";
            this.chkPragmaNocache.UseVisualStyleBackColor = true;
            // 
            // chkAllowRedirect
            // 
            this.chkAllowRedirect.AutoSize = true;
            this.chkAllowRedirect.Location = new System.Drawing.Point(237, 111);
            this.chkAllowRedirect.Margin = new System.Windows.Forms.Padding(2);
            this.chkAllowRedirect.Name = "chkAllowRedirect";
            this.chkAllowRedirect.Size = new System.Drawing.Size(94, 17);
            this.chkAllowRedirect.TabIndex = 97;
            this.chkAllowRedirect.Text = "AllowRedirect:";
            this.chkAllowRedirect.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(4, 233);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtRequest);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.txtResponse);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 388);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Request:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Response:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOptions);
            this.groupBox2.Controls.Add(this.btnDeleteHeader);
            this.groupBox2.Controls.Add(this.btnAddHeaders);
            this.groupBox2.Location = new System.Drawing.Point(364, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(380, 113);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Headers - (select row to use delete button)";
            // 
            // dgvOptions
            // 
            this.dgvOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colValue});
            this.dgvOptions.Location = new System.Drawing.Point(5, 13);
            this.dgvOptions.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOptions.Name = "dgvOptions";
            this.dgvOptions.Size = new System.Drawing.Size(332, 95);
            this.dgvOptions.TabIndex = 20;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colName.FillWeight = 150F;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 60;
            // 
            // colValue
            // 
            this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colValue.FillWeight = 150F;
            this.colValue.HeaderText = "Value";
            this.colValue.Name = "colValue";
            this.colValue.Width = 59;
            // 
            // btnDeleteHeader
            // 
            this.btnDeleteHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteHeader.Image = global::EWSEditor.Properties.Resources.StatusAnnotations_Blocked_16xLG;
            this.btnDeleteHeader.Location = new System.Drawing.Point(341, 51);
            this.btnDeleteHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteHeader.Name = "btnDeleteHeader";
            this.btnDeleteHeader.Size = new System.Drawing.Size(32, 32);
            this.btnDeleteHeader.TabIndex = 19;
            this.btnDeleteHeader.UseVisualStyleBackColor = true;
            this.btnDeleteHeader.Click += new System.EventHandler(this.btnDeleteHeader_Click);
            // 
            // btnAddHeaders
            // 
            this.btnAddHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddHeaders.Image = global::EWSEditor.Properties.Resources.action_add_16xLG;
            this.btnAddHeaders.Location = new System.Drawing.Point(342, 15);
            this.btnAddHeaders.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddHeaders.Name = "btnAddHeaders";
            this.btnAddHeaders.Size = new System.Drawing.Size(32, 32);
            this.btnAddHeaders.TabIndex = 14;
            this.btnAddHeaders.UseVisualStyleBackColor = true;
            this.btnAddHeaders.Click += new System.EventHandler(this.btnAddHeaders_Click);
            // 
            // grpHttpVerbOptions
            // 
            this.grpHttpVerbOptions.Controls.Add(this.groupBox2);
            this.grpHttpVerbOptions.Controls.Add(this.chkPragmaNocache);
            this.grpHttpVerbOptions.Controls.Add(this.label7);
            this.grpHttpVerbOptions.Controls.Add(this.chkAllowRedirect);
            this.grpHttpVerbOptions.Controls.Add(this.cmboContentType);
            this.grpHttpVerbOptions.Controls.Add(this.label9);
            this.grpHttpVerbOptions.Controls.Add(this.cmboVerb);
            this.grpHttpVerbOptions.Controls.Add(this.chkTranslateF);
            this.grpHttpVerbOptions.Controls.Add(this.label8);
            this.grpHttpVerbOptions.Controls.Add(this.numericUpDownTimeoutSeconds);
            this.grpHttpVerbOptions.Controls.Add(this.txtUserAgent);
            this.grpHttpVerbOptions.Controls.Add(this.label11);
            this.grpHttpVerbOptions.Location = new System.Drawing.Point(322, 40);
            this.grpHttpVerbOptions.Name = "grpHttpVerbOptions";
            this.grpHttpVerbOptions.Size = new System.Drawing.Size(749, 148);
            this.grpHttpVerbOptions.TabIndex = 100;
            this.grpHttpVerbOptions.TabStop = false;
            // 
            // chkRawPost
            // 
            this.chkRawPost.AutoSize = true;
            this.chkRawPost.Location = new System.Drawing.Point(8, 171);
            this.chkRawPost.Margin = new System.Windows.Forms.Padding(2);
            this.chkRawPost.Name = "chkRawPost";
            this.chkRawPost.Size = new System.Drawing.Size(280, 17);
            this.chkRawPost.TabIndex = 101;
            this.chkRawPost.Text = "Raw HTTP POST (You specify full headers and body)";
            this.chkRawPost.UseVisualStyleBackColor = true;
            this.chkRawPost.CheckedChanged += new System.EventHandler(this.chkRawPost_CheckedChanged);
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 623);
            this.Controls.Add(this.chkRawPost);
            this.Controls.Add(this.grpHttpVerbOptions);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GoRun);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "PostForm";
            this.Text = "EWS POST";
            this.Load += new System.EventHandler(this.PostForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeoutSeconds)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOptions)).EndInit();
            this.grpHttpVerbOptions.ResumeLayout(false);
            this.grpHttpVerbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button GoRun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmboVerb;
        private System.Windows.Forms.ComboBox cmboContentType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeoutSeconds;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLoadExample;
        private System.Windows.Forms.Button btnSaveExample;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUserAgent;
        private System.Windows.Forms.ComboBox cmboAuthentication;
        private System.Windows.Forms.Label lblAuthentication;
        private System.Windows.Forms.CheckBox chkTranslateF;
        private System.Windows.Forms.CheckBox chkPragmaNocache;
        private System.Windows.Forms.CheckBox chkAllowRedirect;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvOptions;
        private System.Windows.Forms.Button btnDeleteHeader;
        private System.Windows.Forms.Button btnAddHeaders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.GroupBox grpHttpVerbOptions;
        private System.Windows.Forms.CheckBox chkRawPost;
    }
}