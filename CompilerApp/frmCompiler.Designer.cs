namespace CompilerApp
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnalyze = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShowCode = new System.Windows.Forms.TextBox();
            this.dataGridMain = new System.Windows.Forms.DataGridView();
            this.Row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAbout = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.l9 = new System.Windows.Forms.Label();
            this.lblLiterals = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.lblOperators = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.lblIdentifier = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.lblKeywords = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.lblBlocks = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.l8 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Panel();
            this.p2 = new System.Windows.Forms.Panel();
            this.p3 = new System.Windows.Forms.Panel();
            this.p4 = new System.Windows.Forms.Panel();
            this.p5 = new System.Windows.Forms.Panel();
            this.p6 = new System.Windows.Forms.Panel();
            this.p7 = new System.Windows.Forms.Panel();
            this.p8 = new System.Windows.Forms.Panel();
            this.p9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(12, 306);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 65);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exit";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(12, 164);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 65);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clear";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(12, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 65);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(83, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Add file";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.Transparent;
            this.btnAnalyze.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnalyze.BackgroundImage")));
            this.btnAnalyze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnalyze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalyze.Location = new System.Drawing.Point(12, 93);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(65, 65);
            this.btnAnalyze.TabIndex = 0;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(83, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Analyze Code";
            // 
            // txtShowCode
            // 
            this.txtShowCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(82)))), ((int)(((byte)(169)))));
            this.txtShowCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShowCode.Font = new System.Drawing.Font("Monospace", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowCode.ForeColor = System.Drawing.SystemColors.Control;
            this.txtShowCode.Location = new System.Drawing.Point(266, 22);
            this.txtShowCode.Multiline = true;
            this.txtShowCode.Name = "txtShowCode";
            this.txtShowCode.ReadOnly = true;
            this.txtShowCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtShowCode.Size = new System.Drawing.Size(783, 1011);
            this.txtShowCode.TabIndex = 2;
            // 
            // dataGridMain
            // 
            this.dataGridMain.AllowUserToAddRows = false;
            this.dataGridMain.AllowUserToDeleteRows = false;
            this.dataGridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(82)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Row,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column1});
            this.dataGridMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridMain.Location = new System.Drawing.Point(1075, 22);
            this.dataGridMain.Name = "dataGridMain";
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridMain.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridMain.RowTemplate.Height = 24;
            this.dataGridMain.Size = new System.Drawing.Size(816, 1011);
            this.dataGridMain.TabIndex = 3;
            // 
            // Row
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Row.DefaultCellStyle = dataGridViewCellStyle16;
            this.Row.HeaderText = "Row";
            this.Row.Name = "Row";
            this.Row.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column2.HeaderText = "Column";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column3.HeaderText = "Block";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle19;
            this.Column4.HeaderText = "Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle20;
            this.Column1.HeaderText = "Type";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.BackgroundImage")));
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Location = new System.Drawing.Point(12, 240);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(65, 65);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(83, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "About";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.Transparent;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(204, 1008);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(21, 29);
            this.lbltotal.TabIndex = 1;
            this.lbltotal.Text = "-";
            // 
            // l9
            // 
            this.l9.AutoSize = true;
            this.l9.BackColor = System.Drawing.Color.Transparent;
            this.l9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l9.ForeColor = System.Drawing.Color.White;
            this.l9.Location = new System.Drawing.Point(60, 1008);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(80, 29);
            this.l9.TabIndex = 1;
            this.l9.Text = "Total :";
            // 
            // lblLiterals
            // 
            this.lblLiterals.AutoSize = true;
            this.lblLiterals.BackColor = System.Drawing.Color.Transparent;
            this.lblLiterals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiterals.ForeColor = System.Drawing.Color.White;
            this.lblLiterals.Location = new System.Drawing.Point(204, 776);
            this.lblLiterals.Name = "lblLiterals";
            this.lblLiterals.Size = new System.Drawing.Size(21, 29);
            this.lblLiterals.TabIndex = 1;
            this.lblLiterals.Text = "-";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.BackColor = System.Drawing.Color.Transparent;
            this.l5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5.ForeColor = System.Drawing.Color.White;
            this.l5.Location = new System.Drawing.Point(60, 776);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(103, 29);
            this.l5.TabIndex = 1;
            this.l5.Text = "Literals :";
            // 
            // lblOperators
            // 
            this.lblOperators.AutoSize = true;
            this.lblOperators.BackColor = System.Drawing.Color.Transparent;
            this.lblOperators.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperators.ForeColor = System.Drawing.Color.White;
            this.lblOperators.Location = new System.Drawing.Point(204, 718);
            this.lblOperators.Name = "lblOperators";
            this.lblOperators.Size = new System.Drawing.Size(21, 29);
            this.lblOperators.TabIndex = 1;
            this.lblOperators.Text = "-";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.BackColor = System.Drawing.Color.Transparent;
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.ForeColor = System.Drawing.Color.White;
            this.l4.Location = new System.Drawing.Point(60, 718);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(133, 29);
            this.l4.TabIndex = 1;
            this.l4.Text = "Operators :";
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.BackColor = System.Drawing.Color.Transparent;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.ForeColor = System.Drawing.Color.White;
            this.lblNumbers.Location = new System.Drawing.Point(204, 660);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(21, 29);
            this.lblNumbers.TabIndex = 1;
            this.lblNumbers.Text = "-";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BackColor = System.Drawing.Color.Transparent;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.ForeColor = System.Drawing.Color.White;
            this.l3.Location = new System.Drawing.Point(60, 660);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(124, 29);
            this.l3.TabIndex = 1;
            this.l3.Text = "Numbers :";
            // 
            // lblIdentifier
            // 
            this.lblIdentifier.AutoSize = true;
            this.lblIdentifier.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifier.ForeColor = System.Drawing.Color.White;
            this.lblIdentifier.Location = new System.Drawing.Point(204, 602);
            this.lblIdentifier.Name = "lblIdentifier";
            this.lblIdentifier.Size = new System.Drawing.Size(21, 29);
            this.lblIdentifier.TabIndex = 1;
            this.lblIdentifier.Text = "-";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.Color.Transparent;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.ForeColor = System.Drawing.Color.White;
            this.l2.Location = new System.Drawing.Point(60, 602);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(130, 29);
            this.l2.TabIndex = 1;
            this.l2.Text = "Identifiers :";
            // 
            // lblKeywords
            // 
            this.lblKeywords.AutoSize = true;
            this.lblKeywords.BackColor = System.Drawing.Color.Transparent;
            this.lblKeywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeywords.ForeColor = System.Drawing.Color.White;
            this.lblKeywords.Location = new System.Drawing.Point(204, 544);
            this.lblKeywords.Name = "lblKeywords";
            this.lblKeywords.Size = new System.Drawing.Size(21, 29);
            this.lblKeywords.TabIndex = 1;
            this.lblKeywords.Text = "-";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.Transparent;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.ForeColor = System.Drawing.Color.White;
            this.l1.Location = new System.Drawing.Point(60, 544);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(132, 29);
            this.l1.TabIndex = 1;
            this.l1.Text = "Keywords :";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.BackColor = System.Drawing.Color.Transparent;
            this.lblComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.ForeColor = System.Drawing.Color.White;
            this.lblComments.Location = new System.Drawing.Point(204, 834);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(21, 29);
            this.lblComments.TabIndex = 1;
            this.lblComments.Text = "-";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.BackColor = System.Drawing.Color.Transparent;
            this.l6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l6.ForeColor = System.Drawing.Color.White;
            this.l6.Location = new System.Drawing.Point(60, 834);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(141, 29);
            this.l6.TabIndex = 1;
            this.l6.Text = "Comments :";
            // 
            // lblBlocks
            // 
            this.lblBlocks.AutoSize = true;
            this.lblBlocks.BackColor = System.Drawing.Color.Transparent;
            this.lblBlocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlocks.ForeColor = System.Drawing.Color.White;
            this.lblBlocks.Location = new System.Drawing.Point(204, 892);
            this.lblBlocks.Name = "lblBlocks";
            this.lblBlocks.Size = new System.Drawing.Size(21, 29);
            this.lblBlocks.TabIndex = 1;
            this.lblBlocks.Text = "-";
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.BackColor = System.Drawing.Color.Transparent;
            this.l7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l7.ForeColor = System.Drawing.Color.White;
            this.l7.Location = new System.Drawing.Point(60, 892);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(97, 29);
            this.l7.TabIndex = 1;
            this.l7.Text = "Blocks :";
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.BackColor = System.Drawing.Color.Transparent;
            this.lblErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrors.ForeColor = System.Drawing.Color.White;
            this.lblErrors.Location = new System.Drawing.Point(204, 950);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(21, 29);
            this.lblErrors.TabIndex = 1;
            this.lblErrors.Text = "-";
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.BackColor = System.Drawing.Color.Transparent;
            this.l8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l8.ForeColor = System.Drawing.Color.White;
            this.l8.Location = new System.Drawing.Point(60, 950);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(91, 29);
            this.l8.TabIndex = 1;
            this.l8.Text = "Errors :";
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Transparent;
            this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p1.BackgroundImage")));
            this.p1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p1.Location = new System.Drawing.Point(12, 535);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(42, 38);
            this.p1.TabIndex = 0;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Transparent;
            this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p2.BackgroundImage")));
            this.p2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p2.Location = new System.Drawing.Point(12, 593);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(42, 38);
            this.p2.TabIndex = 0;
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.Transparent;
            this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p3.BackgroundImage")));
            this.p3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p3.Location = new System.Drawing.Point(12, 651);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(42, 38);
            this.p3.TabIndex = 0;
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.Color.Transparent;
            this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p4.BackgroundImage")));
            this.p4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p4.Location = new System.Drawing.Point(12, 709);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(42, 38);
            this.p4.TabIndex = 0;
            // 
            // p5
            // 
            this.p5.BackColor = System.Drawing.Color.Transparent;
            this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p5.BackgroundImage")));
            this.p5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p5.Location = new System.Drawing.Point(12, 767);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(42, 38);
            this.p5.TabIndex = 0;
            // 
            // p6
            // 
            this.p6.BackColor = System.Drawing.Color.Transparent;
            this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p6.BackgroundImage")));
            this.p6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p6.Location = new System.Drawing.Point(12, 825);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(42, 38);
            this.p6.TabIndex = 0;
            // 
            // p7
            // 
            this.p7.BackColor = System.Drawing.Color.Transparent;
            this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p7.BackgroundImage")));
            this.p7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p7.Location = new System.Drawing.Point(12, 883);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(42, 38);
            this.p7.TabIndex = 0;
            // 
            // p8
            // 
            this.p8.BackColor = System.Drawing.Color.Transparent;
            this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p8.BackgroundImage")));
            this.p8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p8.Location = new System.Drawing.Point(12, 941);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(42, 38);
            this.p8.TabIndex = 0;
            // 
            // p9
            // 
            this.p9.BackColor = System.Drawing.Color.Transparent;
            this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p9.BackgroundImage")));
            this.p9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p9.Location = new System.Drawing.Point(12, 999);
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(42, 38);
            this.p9.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1903, 1079);
            this.Controls.Add(this.dataGridMain);
            this.Controls.Add(this.txtShowCode);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.lblKeywords);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.lblIdentifier);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.lblOperators);
            this.Controls.Add(this.l8);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.l7);
            this.Controls.Add(this.lblBlocks);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.lblLiterals);
            this.Controls.Add(this.l9);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.p9);
            this.Controls.Add(this.p8);
            this.Controls.Add(this.p7);
            this.Controls.Add(this.p6);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compiler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel btnAnalyze;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtShowCode;
        private System.Windows.Forms.DataGridView dataGridMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Row;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel btnAbout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label l9;
        private System.Windows.Forms.Label lblLiterals;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label lblOperators;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label lblIdentifier;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label lblKeywords;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label lblBlocks;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.Panel p5;
        private System.Windows.Forms.Panel p6;
        private System.Windows.Forms.Panel p7;
        private System.Windows.Forms.Panel p8;
        private System.Windows.Forms.Panel p9;
    }
}

