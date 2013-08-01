namespace IntelliPOS
{
    partial class PaymentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEftpos = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.dtvSaleLineItems = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCh = new System.Windows.Forms.Label();
            this.lblpa = new System.Windows.Forms.Label();
            this.lbltot = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtpay = new System.Windows.Forms.TextBox();
            this.btnM10 = new System.Windows.Forms.Button();
            this.btnM20 = new System.Windows.Forms.Button();
            this.btnM50 = new System.Windows.Forms.Button();
            this.btnM100 = new System.Windows.Forms.Button();
            this.btnM5 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dtvSaleLineItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEftpos
            // 
            this.btnEftpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEftpos.Image = ((System.Drawing.Image)(resources.GetObject("btnEftpos.Image")));
            this.btnEftpos.Location = new System.Drawing.Point(853, 243);
            this.btnEftpos.Name = "btnEftpos";
            this.btnEftpos.Size = new System.Drawing.Size(170, 90);
            this.btnEftpos.TabIndex = 45;
            this.btnEftpos.UseVisualStyleBackColor = true;
            this.btnEftpos.Click += new System.EventHandler(this.btnEftpos_Click);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Image = ((System.Drawing.Image)(resources.GetObject("btnCash.Image")));
            this.btnCash.Location = new System.Drawing.Point(853, 339);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(170, 89);
            this.btnCash.TabIndex = 44;
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // dtvSaleLineItems
            // 
            this.dtvSaleLineItems.AllowUserToAddRows = false;
            this.dtvSaleLineItems.AllowUserToDeleteRows = false;
            this.dtvSaleLineItems.AllowUserToResizeColumns = false;
            this.dtvSaleLineItems.AllowUserToResizeRows = false;
            this.dtvSaleLineItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvSaleLineItems.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtvSaleLineItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvSaleLineItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvSaleLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvSaleLineItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price});
            this.dtvSaleLineItems.Location = new System.Drawing.Point(147, 88);
            this.dtvSaleLineItems.MultiSelect = false;
            this.dtvSaleLineItems.Name = "dtvSaleLineItems";
            this.dtvSaleLineItems.ReadOnly = true;
            this.dtvSaleLineItems.RowHeadersVisible = false;
            this.dtvSaleLineItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvSaleLineItems.Size = new System.Drawing.Size(405, 435);
            this.dtvSaleLineItems.TabIndex = 103;
            // 
            // Item
            // 
            this.Item.FillWeight = 159.5428F;
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 53.29949F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.FillWeight = 87.15774F;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // lblCh
            // 
            this.lblCh.AutoSize = true;
            this.lblCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCh.Location = new System.Drawing.Point(259, 643);
            this.lblCh.Name = "lblCh";
            this.lblCh.Size = new System.Drawing.Size(0, 25);
            this.lblCh.TabIndex = 128;
            // 
            // lblpa
            // 
            this.lblpa.AutoSize = true;
            this.lblpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpa.Location = new System.Drawing.Point(259, 606);
            this.lblpa.Name = "lblpa";
            this.lblpa.Size = new System.Drawing.Size(0, 25);
            this.lblpa.TabIndex = 127;
            // 
            // lbltot
            // 
            this.lbltot.AutoSize = true;
            this.lbltot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltot.Location = new System.Drawing.Point(259, 565);
            this.lbltot.Name = "lbltot";
            this.lbltot.Size = new System.Drawing.Size(0, 25);
            this.lbltot.TabIndex = 126;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(156, 643);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(116, 25);
            this.lblChange.TabIndex = 125;
            this.lblChange.Text = "CHANGE: ";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(156, 606);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(75, 25);
            this.lblPaid.TabIndex = 124;
            this.lblPaid.Text = "PAID: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(156, 565);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(97, 25);
            this.lblTotal.TabIndex = 123;
            this.lblTotal.Text = "TOTAL: ";
            // 
            // txtpay
            // 
            this.txtpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpay.Location = new System.Drawing.Point(679, 88);
            this.txtpay.Name = "txtpay";
            this.txtpay.ReadOnly = true;
            this.txtpay.Size = new System.Drawing.Size(266, 38);
            this.txtpay.TabIndex = 129;
            this.txtpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnM10
            // 
            this.btnM10.BackColor = System.Drawing.Color.Transparent;
            this.btnM10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnM10.BackgroundImage")));
            this.btnM10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM10.ForeColor = System.Drawing.Color.White;
            this.btnM10.Location = new System.Drawing.Point(815, 505);
            this.btnM10.Name = "btnM10";
            this.btnM10.Size = new System.Drawing.Size(120, 85);
            this.btnM10.TabIndex = 57;
            this.btnM10.Tag = "10";
            this.btnM10.UseVisualStyleBackColor = false;
            this.btnM10.Click += new System.EventHandler(this.btnM5_Click);
            // 
            // btnM20
            // 
            this.btnM20.BackColor = System.Drawing.Color.Transparent;
            this.btnM20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnM20.BackgroundImage")));
            this.btnM20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM20.ForeColor = System.Drawing.Color.White;
            this.btnM20.Location = new System.Drawing.Point(618, 596);
            this.btnM20.Name = "btnM20";
            this.btnM20.Size = new System.Drawing.Size(120, 85);
            this.btnM20.TabIndex = 56;
            this.btnM20.Tag = "20";
            this.btnM20.UseVisualStyleBackColor = false;
            this.btnM20.Click += new System.EventHandler(this.btnM5_Click);
            // 
            // btnM50
            // 
            this.btnM50.BackColor = System.Drawing.Color.Transparent;
            this.btnM50.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnM50.BackgroundImage")));
            this.btnM50.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM50.ForeColor = System.Drawing.Color.White;
            this.btnM50.Location = new System.Drawing.Point(744, 596);
            this.btnM50.Name = "btnM50";
            this.btnM50.Size = new System.Drawing.Size(120, 85);
            this.btnM50.TabIndex = 55;
            this.btnM50.Tag = "50";
            this.btnM50.UseVisualStyleBackColor = false;
            this.btnM50.Click += new System.EventHandler(this.btnM5_Click);
            // 
            // btnM100
            // 
            this.btnM100.BackColor = System.Drawing.Color.Transparent;
            this.btnM100.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnM100.BackgroundImage")));
            this.btnM100.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM100.ForeColor = System.Drawing.Color.White;
            this.btnM100.Location = new System.Drawing.Point(870, 596);
            this.btnM100.Name = "btnM100";
            this.btnM100.Size = new System.Drawing.Size(120, 85);
            this.btnM100.TabIndex = 54;
            this.btnM100.Tag = "100";
            this.btnM100.UseVisualStyleBackColor = false;
            this.btnM100.Click += new System.EventHandler(this.btnM5_Click);
            // 
            // btnM5
            // 
            this.btnM5.BackColor = System.Drawing.Color.Transparent;
            this.btnM5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnM5.BackgroundImage")));
            this.btnM5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM5.ForeColor = System.Drawing.Color.White;
            this.btnM5.Location = new System.Drawing.Point(689, 505);
            this.btnM5.Name = "btnM5";
            this.btnM5.Size = new System.Drawing.Size(120, 85);
            this.btnM5.TabIndex = 53;
            this.btnM5.Tag = "5";
            this.btnM5.UseVisualStyleBackColor = false;
            this.btnM5.Click += new System.EventHandler(this.btnM5_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(783, 370);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 60);
            this.btnClear.TabIndex = 141;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(783, 304);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 60);
            this.btn9.TabIndex = 140;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(783, 238);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 60);
            this.btn6.TabIndex = 139;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(783, 172);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 60);
            this.btn3.TabIndex = 138;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(717, 370);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 60);
            this.btn0.TabIndex = 137;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(717, 304);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 60);
            this.btn8.TabIndex = 136;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(717, 238);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 60);
            this.btn5.TabIndex = 135;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(717, 170);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 60);
            this.btn2.TabIndex = 134;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.Color.White;
            this.btnDot.Location = new System.Drawing.Point(651, 368);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(60, 60);
            this.btnDot.TabIndex = 133;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(651, 302);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 60);
            this.btn7.TabIndex = 132;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(651, 236);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 60);
            this.btn4.TabIndex = 131;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(651, 170);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 60);
            this.btn1.TabIndex = 130;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(853, 172);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(170, 65);
            this.btnBack.TabIndex = 142;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(53, 668);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowExportButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowPageNavigateButtons = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowPrintButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.ShowZoomButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(34, 49);
            this.crystalReportViewer1.TabIndex = 143;
            this.crystalReportViewer1.Visible = false;
            // 
            // PaymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1065, 729);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnM10);
            this.Controls.Add(this.btnM20);
            this.Controls.Add(this.txtpay);
            this.Controls.Add(this.btnM50);
            this.Controls.Add(this.lblCh);
            this.Controls.Add(this.btnM100);
            this.Controls.Add(this.lblpa);
            this.Controls.Add(this.btnM5);
            this.Controls.Add(this.lbltot);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dtvSaleLineItems);
            this.Controls.Add(this.btnEftpos);
            this.Controls.Add(this.btnCash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment View";
            ((System.ComponentModel.ISupportInitialize)(this.dtvSaleLineItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEftpos;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.DataGridView dtvSaleLineItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label lblCh;
        private System.Windows.Forms.Label lblpa;
        private System.Windows.Forms.Label lbltot;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtpay;
        private System.Windows.Forms.Button btnM10;
        private System.Windows.Forms.Button btnM20;
        private System.Windows.Forms.Button btnM50;
        private System.Windows.Forms.Button btnM100;
        private System.Windows.Forms.Button btnM5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnBack;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

    }
}