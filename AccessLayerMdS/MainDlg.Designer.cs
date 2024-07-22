namespace AccessLayerMdS
{
    partial class MainDlg
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSingleRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdClient = new System.Windows.Forms.TextBox();
            this.buttonFileFlux = new System.Windows.Forms.Button();
            this.radioButtonTest = new System.Windows.Forms.RadioButton();
            this.radioButtonProduzione = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonDPM = new System.Windows.Forms.RadioButton();
            this.radioButtonSALMVig = new System.Windows.Forms.RadioButton();
            this.radioButtonSALMPnr = new System.Windows.Forms.RadioButton();
            this.radioButtonSALMPsd = new System.Windows.Forms.RadioButton();
            this.radioButtonSISMRes = new System.Windows.Forms.RadioButton();
            this.radioButtonSISMSemires = new System.Windows.Forms.RadioButton();
            this.radioButtonSISMTer = new System.Windows.Forms.RadioButton();
            this.radioButtonAVN_NSM = new System.Windows.Forms.RadioButton();
            this.radioButtonAVN_NSR = new System.Windows.Forms.RadioButton();
            this.radioButtonAVN_SM = new System.Windows.Forms.RadioButton();
            this.radioButtonAVN_SR = new System.Windows.Forms.RadioButton();
            this.radioButtonDIR = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGetInfo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabelFile = new System.Windows.Forms.LinkLabel();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIdRun = new System.Windows.Forms.TextBox();
            this.linkLabelJSON = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCodReg = new System.Windows.Forms.TextBox();
            this.textBoxAnnoRif = new System.Windows.Forms.TextBox();
            this.textBoxPeriodoRif = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.buttonClearOutput = new System.Windows.Forms.Button();
            this.buttonVerificaStato = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.radioButtonDISPOVIG = new System.Windows.Forms.RadioButton();
            this.radioButtonEMURPS = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSingleRecord
            // 
            this.buttonSingleRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSingleRecord.Location = new System.Drawing.Point(819, 55);
            this.buttonSingleRecord.Name = "buttonSingleRecord";
            this.buttonSingleRecord.Size = new System.Drawing.Size(121, 40);
            this.buttonSingleRecord.TabIndex = 3;
            this.buttonSingleRecord.Text = "Invia Record Singolo";
            this.buttonSingleRecord.UseVisualStyleBackColor = true;
            this.buttonSingleRecord.Click += new System.EventHandler(this.buttonSingleRecord_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Client";
            // 
            // textBoxIdClient
            // 
            this.textBoxIdClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIdClient.Location = new System.Drawing.Point(86, 32);
            this.textBoxIdClient.Name = "textBoxIdClient";
            this.textBoxIdClient.Size = new System.Drawing.Size(319, 20);
            this.textBoxIdClient.TabIndex = 3;
            // 
            // buttonFileFlux
            // 
            this.buttonFileFlux.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFileFlux.Location = new System.Drawing.Point(819, 5);
            this.buttonFileFlux.Name = "buttonFileFlux";
            this.buttonFileFlux.Size = new System.Drawing.Size(121, 40);
            this.buttonFileFlux.TabIndex = 2;
            this.buttonFileFlux.Text = "Invia File Flusso";
            this.buttonFileFlux.UseVisualStyleBackColor = true;
            this.buttonFileFlux.Click += new System.EventHandler(this.buttonFileFlux_Click);
            // 
            // radioButtonTest
            // 
            this.radioButtonTest.AutoSize = true;
            this.radioButtonTest.Checked = true;
            this.radioButtonTest.Location = new System.Drawing.Point(3, 3);
            this.radioButtonTest.Name = "radioButtonTest";
            this.radioButtonTest.Size = new System.Drawing.Size(46, 17);
            this.radioButtonTest.TabIndex = 0;
            this.radioButtonTest.TabStop = true;
            this.radioButtonTest.Text = "Test";
            this.radioButtonTest.UseVisualStyleBackColor = true;
            // 
            // radioButtonProduzione
            // 
            this.radioButtonProduzione.AutoSize = true;
            this.radioButtonProduzione.Location = new System.Drawing.Point(55, 3);
            this.radioButtonProduzione.Name = "radioButtonProduzione";
            this.radioButtonProduzione.Size = new System.Drawing.Size(78, 17);
            this.radioButtonProduzione.TabIndex = 1;
            this.radioButtonProduzione.Text = "Produzione";
            this.radioButtonProduzione.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Host";
            // 
            // textBoxHost
            // 
            this.textBoxHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxHost, 3);
            this.textBoxHost.Location = new System.Drawing.Point(86, 4);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(710, 20);
            this.textBoxHost.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 3);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonTest);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonProduzione);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(86, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(710, 22);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel2, 3);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonDPM);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonSALMVig);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonSALMPnr);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonSALMPsd);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonSISMRes);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonSISMSemires);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonSISMTer);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonAVN_NSM);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonAVN_NSR);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonAVN_SM);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonAVN_SR);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonDIR);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonDISPOVIG);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonEMURPS);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(86, 143);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(710, 94);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // radioButtonDPM
            // 
            this.radioButtonDPM.AutoSize = true;
            this.radioButtonDPM.Checked = true;
            this.radioButtonDPM.Location = new System.Drawing.Point(3, 3);
            this.radioButtonDPM.Name = "radioButtonDPM";
            this.radioButtonDPM.Size = new System.Drawing.Size(138, 17);
            this.radioButtonDPM.TabIndex = 1;
            this.radioButtonDPM.TabStop = true;
            this.radioButtonDPM.Text = "Donazione Post Mortem";
            this.radioButtonDPM.UseVisualStyleBackColor = true;
            this.radioButtonDPM.CheckedChanged += new System.EventHandler(this.radioButtonDPM_CheckedChanged);
            // 
            // radioButtonSALMVig
            // 
            this.radioButtonSALMVig.AutoSize = true;
            this.radioButtonSALMVig.Location = new System.Drawing.Point(147, 3);
            this.radioButtonSALMVig.Name = "radioButtonSALMVig";
            this.radioButtonSALMVig.Size = new System.Drawing.Size(119, 17);
            this.radioButtonSALMVig.TabIndex = 2;
            this.radioButtonSALMVig.Text = "Vigilanza Alimentare";
            this.radioButtonSALMVig.UseVisualStyleBackColor = true;
            // 
            // radioButtonSALMPnr
            // 
            this.radioButtonSALMPnr.AutoSize = true;
            this.radioButtonSALMPnr.Location = new System.Drawing.Point(272, 3);
            this.radioButtonSALMPnr.Name = "radioButtonSALMPnr";
            this.radioButtonSALMPnr.Size = new System.Drawing.Size(140, 17);
            this.radioButtonSALMPnr.TabIndex = 3;
            this.radioButtonSALMPnr.Text = "Piano Nazionale Residui";
            this.radioButtonSALMPnr.UseVisualStyleBackColor = true;
            // 
            // radioButtonSALMPsd
            // 
            this.radioButtonSALMPsd.AutoSize = true;
            this.radioButtonSALMPsd.Location = new System.Drawing.Point(418, 3);
            this.radioButtonSALMPsd.Name = "radioButtonSALMPsd";
            this.radioButtonSALMPsd.Size = new System.Drawing.Size(64, 17);
            this.radioButtonSALMPsd.TabIndex = 4;
            this.radioButtonSALMPsd.Text = "Pesticidi";
            this.radioButtonSALMPsd.UseVisualStyleBackColor = true;
            // 
            // radioButtonSISMRes
            // 
            this.radioButtonSISMRes.AutoSize = true;
            this.radioButtonSISMRes.Location = new System.Drawing.Point(488, 3);
            this.radioButtonSISMRes.Name = "radioButtonSISMRes";
            this.radioButtonSISMRes.Size = new System.Drawing.Size(120, 17);
            this.radioButtonSISMRes.TabIndex = 5;
            this.radioButtonSISMRes.Text = "Attività Residenziale";
            this.radioButtonSISMRes.UseVisualStyleBackColor = true;
            // 
            // radioButtonSISMSemires
            // 
            this.radioButtonSISMSemires.AutoSize = true;
            this.radioButtonSISMSemires.Location = new System.Drawing.Point(3, 26);
            this.radioButtonSISMSemires.Name = "radioButtonSISMSemires";
            this.radioButtonSISMSemires.Size = new System.Drawing.Size(138, 17);
            this.radioButtonSISMSemires.TabIndex = 6;
            this.radioButtonSISMSemires.Text = "Attività Semiresidenziale";
            this.radioButtonSISMSemires.UseVisualStyleBackColor = true;
            // 
            // radioButtonSISMTer
            // 
            this.radioButtonSISMTer.AutoSize = true;
            this.radioButtonSISMTer.Location = new System.Drawing.Point(147, 26);
            this.radioButtonSISMTer.Name = "radioButtonSISMTer";
            this.radioButtonSISMTer.Size = new System.Drawing.Size(109, 17);
            this.radioButtonSISMTer.TabIndex = 7;
            this.radioButtonSISMTer.Text = "Attività Territoriale";
            this.radioButtonSISMTer.UseVisualStyleBackColor = true;
            // 
            // radioButtonAVN_NSM
            // 
            this.radioButtonAVN_NSM.AutoSize = true;
            this.radioButtonAVN_NSM.Location = new System.Drawing.Point(262, 26);
            this.radioButtonAVN_NSM.Name = "radioButtonAVN_NSM";
            this.radioButtonAVN_NSM.Size = new System.Drawing.Size(215, 17);
            this.radioButtonAVN_NSM.TabIndex = 8;
            this.radioButtonAVN_NSM.Text = "Vaccinazioni Non Somministrate Mobilità";
            this.radioButtonAVN_NSM.UseVisualStyleBackColor = true;
            // 
            // radioButtonAVN_NSR
            // 
            this.radioButtonAVN_NSR.AutoSize = true;
            this.radioButtonAVN_NSR.Location = new System.Drawing.Point(483, 26);
            this.radioButtonAVN_NSR.Name = "radioButtonAVN_NSR";
            this.radioButtonAVN_NSR.Size = new System.Drawing.Size(223, 17);
            this.radioButtonAVN_NSR.TabIndex = 9;
            this.radioButtonAVN_NSR.Text = "Vaccinazioni Non Somministrate Residenti";
            this.radioButtonAVN_NSR.UseVisualStyleBackColor = true;
            // 
            // radioButtonAVN_SM
            // 
            this.radioButtonAVN_SM.AutoSize = true;
            this.radioButtonAVN_SM.Location = new System.Drawing.Point(3, 49);
            this.radioButtonAVN_SM.Name = "radioButtonAVN_SM";
            this.radioButtonAVN_SM.Size = new System.Drawing.Size(192, 17);
            this.radioButtonAVN_SM.TabIndex = 10;
            this.radioButtonAVN_SM.Text = "Vaccinazioni Somministrate Mobilità";
            this.radioButtonAVN_SM.UseVisualStyleBackColor = true;
            // 
            // radioButtonAVN_SR
            // 
            this.radioButtonAVN_SR.AutoSize = true;
            this.radioButtonAVN_SR.Location = new System.Drawing.Point(201, 49);
            this.radioButtonAVN_SR.Name = "radioButtonAVN_SR";
            this.radioButtonAVN_SR.Size = new System.Drawing.Size(200, 17);
            this.radioButtonAVN_SR.TabIndex = 11;
            this.radioButtonAVN_SR.Text = "Vaccinazioni Somministrate Residenti";
            this.radioButtonAVN_SR.UseVisualStyleBackColor = true;
            // 
            // radioButtonDIR
            // 
            this.radioButtonDIR.AutoSize = true;
            this.radioButtonDIR.Location = new System.Drawing.Point(407, 49);
            this.radioButtonDIR.Name = "radioButtonDIR";
            this.radioButtonDIR.Size = new System.Drawing.Size(56, 17);
            this.radioButtonDIR.TabIndex = 0;
            this.radioButtonDIR.Text = "Diretta";
            this.radioButtonDIR.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Modalità";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Flusso";
            // 
            // buttonGetInfo
            // 
            this.buttonGetInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGetInfo.Location = new System.Drawing.Point(819, 105);
            this.buttonGetInfo.Name = "buttonGetInfo";
            this.buttonGetInfo.Size = new System.Drawing.Size(121, 40);
            this.buttonGetInfo.TabIndex = 4;
            this.buttonGetInfo.Text = "Prendi Info";
            this.buttonGetInfo.UseVisualStyleBackColor = true;
            this.buttonGetInfo.Click += new System.EventHandler(this.buttonGetInfo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHost, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxIdClient, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelFile, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFile, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxIdRun, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelJSON, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel1, 5);
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(799, 240);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // linkLabelFile
            // 
            this.linkLabelFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkLabelFile.AutoSize = true;
            this.linkLabelFile.Location = new System.Drawing.Point(57, 63);
            this.linkLabelFile.Name = "linkLabelFile";
            this.linkLabelFile.Size = new System.Drawing.Size(23, 13);
            this.linkLabelFile.TabIndex = 6;
            this.linkLabelFile.TabStop = true;
            this.linkLabelFile.Text = "File";
            this.linkLabelFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFile_LinkClicked);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxFile, 2);
            this.textBoxFile.Location = new System.Drawing.Point(86, 60);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(385, 20);
            this.textBoxFile.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Id Run";
            // 
            // textBoxIdRun
            // 
            this.textBoxIdRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIdRun.Location = new System.Drawing.Point(477, 32);
            this.textBoxIdRun.Name = "textBoxIdRun";
            this.textBoxIdRun.Size = new System.Drawing.Size(319, 20);
            this.textBoxIdRun.TabIndex = 5;
            // 
            // linkLabelJSON
            // 
            this.linkLabelJSON.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabelJSON.AutoSize = true;
            this.linkLabelJSON.Location = new System.Drawing.Point(477, 63);
            this.linkLabelJSON.Name = "linkLabelJSON";
            this.linkLabelJSON.Size = new System.Drawing.Size(135, 13);
            this.linkLabelJSON.TabIndex = 8;
            this.linkLabelJSON.TabStop = true;
            this.linkLabelJSON.Text = "Visualizza / Modifica JSON";
            this.linkLabelJSON.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelJSON_LinkClicked);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Output";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cod.Regione";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxCodReg, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxAnnoRif, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxPeriodoRif, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(83, 112);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(716, 28);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // textBoxCodReg
            // 
            this.textBoxCodReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCodReg.Location = new System.Drawing.Point(3, 4);
            this.textBoxCodReg.Name = "textBoxCodReg";
            this.textBoxCodReg.Size = new System.Drawing.Size(187, 20);
            this.textBoxCodReg.TabIndex = 0;
            // 
            // textBoxAnnoRif
            // 
            this.textBoxAnnoRif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnnoRif.Location = new System.Drawing.Point(258, 4);
            this.textBoxAnnoRif.Name = "textBoxAnnoRif";
            this.textBoxAnnoRif.Size = new System.Drawing.Size(187, 20);
            this.textBoxAnnoRif.TabIndex = 2;
            // 
            // textBoxPeriodoRif
            // 
            this.textBoxPeriodoRif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPeriodoRif.Location = new System.Drawing.Point(525, 4);
            this.textBoxPeriodoRif.Name = "textBoxPeriodoRif";
            this.textBoxPeriodoRif.Size = new System.Drawing.Size(188, 20);
            this.textBoxPeriodoRif.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Anno Rif.";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Periodo Rif.";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.Controls.Add(this.buttonFileFlux, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSingleRecord, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonGetInfo, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.richTextBoxDisplay, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.buttonClearOutput, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonVerificaStato, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(955, 573);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // richTextBoxDisplay
            // 
            this.richTextBoxDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.richTextBoxDisplay, 2);
            this.richTextBoxDisplay.Location = new System.Drawing.Point(3, 249);
            this.richTextBoxDisplay.Name = "richTextBoxDisplay";
            this.richTextBoxDisplay.Size = new System.Drawing.Size(949, 321);
            this.richTextBoxDisplay.TabIndex = 1;
            this.richTextBoxDisplay.Text = "";
            // 
            // buttonClearOutput
            // 
            this.buttonClearOutput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonClearOutput.Location = new System.Drawing.Point(819, 215);
            this.buttonClearOutput.Name = "buttonClearOutput";
            this.buttonClearOutput.Size = new System.Drawing.Size(121, 28);
            this.buttonClearOutput.TabIndex = 5;
            this.buttonClearOutput.Text = "Pulisci Output";
            this.buttonClearOutput.UseVisualStyleBackColor = true;
            this.buttonClearOutput.Click += new System.EventHandler(this.buttonClearOutput_Click);
            // 
            // buttonVerificaStato
            // 
            this.buttonVerificaStato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVerificaStato.Location = new System.Drawing.Point(819, 155);
            this.buttonVerificaStato.Name = "buttonVerificaStato";
            this.buttonVerificaStato.Size = new System.Drawing.Size(121, 40);
            this.buttonVerificaStato.TabIndex = 4;
            this.buttonVerificaStato.Text = "Verifica Stato";
            this.buttonVerificaStato.UseVisualStyleBackColor = true;
            this.buttonVerificaStato.Click += new System.EventHandler(this.buttonVerificaStato_Click);
            // 
            // radioButtonDISPOVIG
            // 
            this.radioButtonDISPOVIG.AutoSize = true;
            this.radioButtonDISPOVIG.Location = new System.Drawing.Point(469, 49);
            this.radioButtonDISPOVIG.Name = "radioButtonDISPOVIG";
            this.radioButtonDISPOVIG.Size = new System.Drawing.Size(76, 17);
            this.radioButtonDISPOVIG.TabIndex = 12;
            this.radioButtonDISPOVIG.Text = "DISPOVIG";
            this.radioButtonDISPOVIG.UseVisualStyleBackColor = true;
            // 
            // radioButtonEMURPS
            // 
            this.radioButtonEMURPS.AutoSize = true;
            this.radioButtonEMURPS.Location = new System.Drawing.Point(551, 49);
            this.radioButtonEMURPS.Name = "radioButtonEMURPS";
            this.radioButtonEMURPS.Size = new System.Drawing.Size(71, 17);
            this.radioButtonEMURPS.TabIndex = 13;
            this.radioButtonEMURPS.Text = "EMURPS";
            this.radioButtonEMURPS.UseVisualStyleBackColor = true;
            // 
            // MainDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 573);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "MainDlg";
            this.Text = "Access Layer MdS";
            this.Load += new System.EventHandler(this.MainDlg_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSingleRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdClient;
        private System.Windows.Forms.Button buttonFileFlux;
        private System.Windows.Forms.RadioButton radioButtonTest;
        private System.Windows.Forms.RadioButton radioButtonProduzione;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButtonDIR;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonGetInfo;
        private System.Windows.Forms.LinkLabel linkLabelFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxDisplay;
        private System.Windows.Forms.Button buttonClearOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIdRun;
        private System.Windows.Forms.RadioButton radioButtonDPM;
        private System.Windows.Forms.LinkLabel linkLabelJSON;
        private System.Windows.Forms.Button buttonVerificaStato;
        private System.Windows.Forms.RadioButton radioButtonSALMVig;
        private System.Windows.Forms.RadioButton radioButtonSALMPnr;
        private System.Windows.Forms.RadioButton radioButtonSALMPsd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBoxCodReg;
        private System.Windows.Forms.TextBox textBoxAnnoRif;
        private System.Windows.Forms.TextBox textBoxPeriodoRif;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonSISMRes;
        private System.Windows.Forms.RadioButton radioButtonSISMSemires;
        private System.Windows.Forms.RadioButton radioButtonSISMTer;
        private System.Windows.Forms.RadioButton radioButtonAVN_NSM;
        private System.Windows.Forms.RadioButton radioButtonAVN_NSR;
        private System.Windows.Forms.RadioButton radioButtonAVN_SM;
        private System.Windows.Forms.RadioButton radioButtonAVN_SR;
        private System.Windows.Forms.RadioButton radioButtonDISPOVIG;
        private System.Windows.Forms.RadioButton radioButtonEMURPS;
    }
}

