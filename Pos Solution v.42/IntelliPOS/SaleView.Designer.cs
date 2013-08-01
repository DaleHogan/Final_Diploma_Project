namespace IntelliPOS
{
    partial class SaleView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dtvSaleLineItems = new System.Windows.Forms.DataGridView();
            this.ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMessage = new System.Windows.Forms.Button();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblGST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNoSale = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnVoidSale = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblsub = new System.Windows.Forms.Label();
            this.lblgs = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.btnBeverage = new System.Windows.Forms.Button();
            this.btnSpecial = new System.Windows.Forms.Button();
            this.btnSalad = new System.Windows.Forms.Button();
            this.btnSide = new System.Windows.Forms.Button();
            this.btnBurgers = new System.Windows.Forms.Button();
            this.btnDessert = new System.Windows.Forms.Button();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.btnPasta = new System.Windows.Forms.Button();
            this.btnSteak = new System.Windows.Forms.Button();
            this.btnBreakfast = new System.Windows.Forms.Button();
            this.lblPriceLevel = new System.Windows.Forms.Label();
            this.lblPLevel = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.flpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvSaleLineItems)).BeginInit();
            this.pnlCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMenu
            // 
            this.flpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.flpMenu.Controls.Add(this.crystalReportViewer1);
            this.flpMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpMenu.Location = new System.Drawing.Point(314, 37);
            this.flpMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(364, 600);
            this.flpMenu.TabIndex = 103;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(361, 293);
            this.crystalReportViewer1.TabIndex = 128;
            this.crystalReportViewer1.Visible = false;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvSaleLineItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvSaleLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvSaleLineItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITEM,
            this.QUANTITY,
            this.PRICE,
            this.MenuProduct});
            this.dtvSaleLineItems.Location = new System.Drawing.Point(705, 37);
            this.dtvSaleLineItems.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtvSaleLineItems.MultiSelect = false;
            this.dtvSaleLineItems.Name = "dtvSaleLineItems";
            this.dtvSaleLineItems.ReadOnly = true;
            this.dtvSaleLineItems.RowHeadersVisible = false;
            this.dtvSaleLineItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvSaleLineItems.Size = new System.Drawing.Size(374, 403);
            this.dtvSaleLineItems.TabIndex = 102;
            // 
            // ITEM
            // 
            this.ITEM.FillWeight = 170F;
            this.ITEM.HeaderText = "ITEM";
            this.ITEM.Name = "ITEM";
            this.ITEM.ReadOnly = true;
            // 
            // QUANTITY
            // 
            this.QUANTITY.FillWeight = 30F;
            this.QUANTITY.HeaderText = "QTY";
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.ReadOnly = true;
            // 
            // PRICE
            // 
            this.PRICE.FillWeight = 40F;
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            // 
            // MenuProduct
            // 
            this.MenuProduct.HeaderText = "MenuProduct";
            this.MenuProduct.Name = "MenuProduct";
            this.MenuProduct.ReadOnly = true;
            this.MenuProduct.Visible = false;
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessage.ForeColor = System.Drawing.Color.White;
            this.btnMessage.Location = new System.Drawing.Point(1103, 422);
            this.btnMessage.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(130, 60);
            this.btnMessage.TabIndex = 101;
            this.btnMessage.Text = "MESSAGE";
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(700, 443);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(69, 25);
            this.lblSubTotal.TabIndex = 95;
            this.lblSubTotal.Text = "SUB: ";
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGST.Location = new System.Drawing.Point(699, 472);
            this.lblGST.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(70, 25);
            this.lblGST.TabIndex = 94;
            this.lblGST.Text = "GST: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(699, 499);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(111, 29);
            this.lblTotal.TabIndex = 93;
            this.lblTotal.Text = "TOTAL: ";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(727, 558);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(334, 76);
            this.btnPayment.TabIndex = 92;
            this.btnPayment.Text = "PAYMENT";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1103, 188);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 60);
            this.btnCancel.TabIndex = 91;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNoSale
            // 
            this.btnNoSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnNoSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoSale.ForeColor = System.Drawing.Color.White;
            this.btnNoSale.Location = new System.Drawing.Point(1103, 558);
            this.btnNoSale.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnNoSale.Name = "btnNoSale";
            this.btnNoSale.Size = new System.Drawing.Size(130, 60);
            this.btnNoSale.TabIndex = 89;
            this.btnNoSale.Text = "NO SALE";
            this.btnNoSale.UseVisualStyleBackColor = false;
            this.btnNoSale.Click += new System.EventHandler(this.btnNoSale_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1103, 273);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 60);
            this.btnAdd.TabIndex = 88;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnVoidSale
            // 
            this.btnVoidSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnVoidSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoidSale.ForeColor = System.Drawing.Color.White;
            this.btnVoidSale.Location = new System.Drawing.Point(1103, 490);
            this.btnVoidSale.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnVoidSale.Name = "btnVoidSale";
            this.btnVoidSale.Size = new System.Drawing.Size(130, 60);
            this.btnVoidSale.TabIndex = 87;
            this.btnVoidSale.Text = "VOID SALE";
            this.btnVoidSale.UseVisualStyleBackColor = false;
            this.btnVoidSale.Click += new System.EventHandler(this.btnVoidSale_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Location = new System.Drawing.Point(1103, 341);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(130, 60);
            this.btnMinus.TabIndex = 86;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.Location = new System.Drawing.Point(1103, 101);
            this.btnDown.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(130, 60);
            this.btnDown.TabIndex = 119;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(1103, 37);
            this.btnUp.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(130, 60);
            this.btnUp.TabIndex = 118;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsub.Location = new System.Drawing.Point(801, 443);
            this.lblsub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(0, 25);
            this.lblsub.TabIndex = 120;
            // 
            // lblgs
            // 
            this.lblgs.AutoSize = true;
            this.lblgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgs.Location = new System.Drawing.Point(801, 471);
            this.lblgs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgs.Name = "lblgs";
            this.lblgs.Size = new System.Drawing.Size(0, 25);
            this.lblgs.TabIndex = 121;
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot.Location = new System.Drawing.Point(839, 499);
            this.lblTot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(0, 29);
            this.lblTot.TabIndex = 122;
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.btnBeverage);
            this.pnlCategory.Controls.Add(this.btnSpecial);
            this.pnlCategory.Controls.Add(this.btnSalad);
            this.pnlCategory.Controls.Add(this.btnSide);
            this.pnlCategory.Controls.Add(this.btnBurgers);
            this.pnlCategory.Controls.Add(this.btnDessert);
            this.pnlCategory.Controls.Add(this.btnCoffee);
            this.pnlCategory.Controls.Add(this.btnPasta);
            this.pnlCategory.Controls.Add(this.btnSteak);
            this.pnlCategory.Controls.Add(this.btnBreakfast);
            this.pnlCategory.Location = new System.Drawing.Point(20, 35);
            this.pnlCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(264, 602);
            this.pnlCategory.TabIndex = 124;
            // 
            // btnBeverage
            // 
            this.btnBeverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnBeverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeverage.ForeColor = System.Drawing.Color.White;
            this.btnBeverage.Location = new System.Drawing.Point(6, 494);
            this.btnBeverage.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnBeverage.Name = "btnBeverage";
            this.btnBeverage.Size = new System.Drawing.Size(120, 100);
            this.btnBeverage.TabIndex = 127;
            this.btnBeverage.Text = "Beverage";
            this.btnBeverage.UseVisualStyleBackColor = false;
            // 
            // btnSpecial
            // 
            this.btnSpecial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecial.ForeColor = System.Drawing.Color.White;
            this.btnSpecial.Location = new System.Drawing.Point(138, 494);
            this.btnSpecial.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(120, 100);
            this.btnSpecial.TabIndex = 126;
            this.btnSpecial.Text = "Today\'s Special";
            this.btnSpecial.UseVisualStyleBackColor = false;
            // 
            // btnSalad
            // 
            this.btnSalad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnSalad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalad.ForeColor = System.Drawing.Color.White;
            this.btnSalad.Location = new System.Drawing.Point(138, 247);
            this.btnSalad.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSalad.Name = "btnSalad";
            this.btnSalad.Size = new System.Drawing.Size(120, 100);
            this.btnSalad.TabIndex = 125;
            this.btnSalad.Text = "Salad";
            this.btnSalad.UseVisualStyleBackColor = false;
            // 
            // btnSide
            // 
            this.btnSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSide.ForeColor = System.Drawing.Color.White;
            this.btnSide.Location = new System.Drawing.Point(6, 366);
            this.btnSide.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSide.Name = "btnSide";
            this.btnSide.Size = new System.Drawing.Size(120, 100);
            this.btnSide.TabIndex = 124;
            this.btnSide.Text = "Side";
            this.btnSide.UseVisualStyleBackColor = false;
            // 
            // btnBurgers
            // 
            this.btnBurgers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnBurgers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurgers.ForeColor = System.Drawing.Color.White;
            this.btnBurgers.Location = new System.Drawing.Point(6, 247);
            this.btnBurgers.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnBurgers.Name = "btnBurgers";
            this.btnBurgers.Size = new System.Drawing.Size(120, 100);
            this.btnBurgers.TabIndex = 123;
            this.btnBurgers.Text = "Burgers";
            this.btnBurgers.UseVisualStyleBackColor = false;
            // 
            // btnDessert
            // 
            this.btnDessert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDessert.ForeColor = System.Drawing.Color.White;
            this.btnDessert.Location = new System.Drawing.Point(138, 366);
            this.btnDessert.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(120, 100);
            this.btnDessert.TabIndex = 122;
            this.btnDessert.Text = "Dessert";
            this.btnDessert.UseVisualStyleBackColor = false;
            // 
            // btnCoffee
            // 
            this.btnCoffee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoffee.ForeColor = System.Drawing.Color.White;
            this.btnCoffee.Location = new System.Drawing.Point(138, 0);
            this.btnCoffee.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(120, 100);
            this.btnCoffee.TabIndex = 121;
            this.btnCoffee.Text = "Coffee";
            this.btnCoffee.UseVisualStyleBackColor = false;
            // 
            // btnPasta
            // 
            this.btnPasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasta.ForeColor = System.Drawing.Color.White;
            this.btnPasta.Location = new System.Drawing.Point(6, 123);
            this.btnPasta.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(120, 100);
            this.btnPasta.TabIndex = 120;
            this.btnPasta.Text = "Pasta";
            this.btnPasta.UseVisualStyleBackColor = false;
            // 
            // btnSteak
            // 
            this.btnSteak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnSteak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSteak.ForeColor = System.Drawing.Color.White;
            this.btnSteak.Location = new System.Drawing.Point(138, 123);
            this.btnSteak.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSteak.Name = "btnSteak";
            this.btnSteak.Size = new System.Drawing.Size(120, 100);
            this.btnSteak.TabIndex = 119;
            this.btnSteak.Text = "Steak";
            this.btnSteak.UseVisualStyleBackColor = false;
            // 
            // btnBreakfast
            // 
            this.btnBreakfast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnBreakfast.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBreakfast.FlatAppearance.BorderSize = 3;
            this.btnBreakfast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBreakfast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBreakfast.ForeColor = System.Drawing.Color.White;
            this.btnBreakfast.Location = new System.Drawing.Point(6, 0);
            this.btnBreakfast.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnBreakfast.Name = "btnBreakfast";
            this.btnBreakfast.Size = new System.Drawing.Size(120, 100);
            this.btnBreakfast.TabIndex = 118;
            this.btnBreakfast.Text = "Breakfast";
            this.btnBreakfast.UseVisualStyleBackColor = false;
            // 
            // lblPriceLevel
            // 
            this.lblPriceLevel.AutoSize = true;
            this.lblPriceLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceLevel.ForeColor = System.Drawing.Color.Red;
            this.lblPriceLevel.Location = new System.Drawing.Point(700, 530);
            this.lblPriceLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriceLevel.Name = "lblPriceLevel";
            this.lblPriceLevel.Size = new System.Drawing.Size(132, 25);
            this.lblPriceLevel.TabIndex = 125;
            this.lblPriceLevel.Text = "Price Level :";
            // 
            // lblPLevel
            // 
            this.lblPLevel.AutoSize = true;
            this.lblPLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLevel.ForeColor = System.Drawing.Color.Red;
            this.lblPLevel.Location = new System.Drawing.Point(839, 530);
            this.lblPLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPLevel.Name = "lblPLevel";
            this.lblPLevel.Size = new System.Drawing.Size(0, 25);
            this.lblPLevel.TabIndex = 126;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(727, 641);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(334, 60);
            this.btnPrint.TabIndex = 127;
            this.btnPrint.Text = "PRINT DOCKET";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1271, 696);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblPLevel);
            this.Controls.Add(this.lblPriceLevel);
            this.Controls.Add(this.pnlCategory);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.lblgs);
            this.Controls.Add(this.lblsub);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.dtvSaleLineItems);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblGST);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNoSale);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnVoidSale);
            this.Controls.Add(this.btnMinus);
            this.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaleView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.SaleView_Load);
            this.flpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvSaleLineItems)).EndInit();
            this.pnlCategory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNoSale;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnVoidSale;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.DataGridView dtvSaleLineItems;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.Label lblgs;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Button btnBeverage;
        private System.Windows.Forms.Button btnSpecial;
        private System.Windows.Forms.Button btnSalad;
        private System.Windows.Forms.Button btnSide;
        private System.Windows.Forms.Button btnBurgers;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Button btnPasta;
        private System.Windows.Forms.Button btnSteak;
        private System.Windows.Forms.Button btnBreakfast;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuProduct;
        private System.Windows.Forms.Label lblPriceLevel;
        private System.Windows.Forms.Label lblPLevel;
        private System.Windows.Forms.Button btnPrint;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}