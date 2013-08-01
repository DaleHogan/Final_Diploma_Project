namespace IntelliPOS
{
    partial class ManageItemView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnResetSearch = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dtvItemDetails = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExeption = new System.Windows.Forms.Label();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beanSceneDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beanSceneDataSet = new IntelliPOS.BeanSceneDataSet();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKProductCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCategory = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new IntelliPOS.BeanSceneDataSetTableAdapters.CategoryTableAdapter();
            this.productTableAdapter = new IntelliPOS.BeanSceneDataSetTableAdapters.ProductTableAdapter();
            this.tbxDescription = new System.Windows.Forms.MaskedTextBox();
            this.tbxPrice = new System.Windows.Forms.MaskedTextBox();
            this.lblEditPrice = new System.Windows.Forms.Label();
            this.tbxEditPrice = new System.Windows.Forms.MaskedTextBox();
            this.lblManageItemView = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvItemDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beanSceneDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beanSceneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(678, 301);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(187, 34);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "SEARCH ITEM";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(44, 344);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 20);
            this.lblPrice.TabIndex = 37;
            this.lblPrice.Text = "PRICE";
            this.lblPrice.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(679, 401);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(186, 34);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "EDIT DETAIL";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(678, 349);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 34);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "ADD ITEM";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(678, 446);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(186, 34);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "DELETE ITEM";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnResetSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResetSearch.Location = new System.Drawing.Point(678, 495);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(186, 35);
            this.btnResetSearch.TabIndex = 27;
            this.btnResetSearch.Text = "RESET FIELDS";
            this.btnResetSearch.UseVisualStyleBackColor = false;
            this.btnResetSearch.Click += new System.EventHandler(this.btnResetSearch_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(44, 309);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(129, 20);
            this.lblDescription.TabIndex = 26;
            this.lblDescription.Text = "DESCRIPTION";
            this.lblDescription.Visible = false;
            // 
            // dtvItemDetails
            // 
            this.dtvItemDetails.AllowUserToAddRows = false;
            this.dtvItemDetails.AllowUserToDeleteRows = false;
            this.dtvItemDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dtvItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvItemDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvItemDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CategoryId,
            this.Price,
            this.Description});
            this.dtvItemDetails.Location = new System.Drawing.Point(48, 105);
            this.dtvItemDetails.MultiSelect = false;
            this.dtvItemDetails.Name = "dtvItemDetails";
            this.dtvItemDetails.ReadOnly = true;
            this.dtvItemDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtvItemDetails.RowHeadersVisible = false;
            this.dtvItemDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvItemDetails.Size = new System.Drawing.Size(723, 159);
            this.dtvItemDetails.TabIndex = 25;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // CategoryId
            // 
            this.CategoryId.HeaderText = "CATEGORY ID";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.Width = 140;
            // 
            // Price
            // 
            this.Price.HeaderText = "PRICE";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "DESCRIPTION";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, -67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "ADD STAFF MEMBER";
            // 
            // lblExeption
            // 
            this.lblExeption.AutoSize = true;
            this.lblExeption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblExeption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExeption.Location = new System.Drawing.Point(44, 486);
            this.lblExeption.Name = "lblExeption";
            this.lblExeption.Size = new System.Drawing.Size(0, 20);
            this.lblExeption.TabIndex = 41;
            // 
            // cboxCategory
            // 
            this.cboxCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryBindingSource, "Id", true));
            this.cboxCategory.DataSource = this.categoryBindingSource1;
            this.cboxCategory.DisplayMember = "Description";
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Location = new System.Drawing.Point(271, 386);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(376, 21);
            this.cboxCategory.TabIndex = 42;
            this.cboxCategory.ValueMember = "Id";
            this.cboxCategory.Visible = false;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.beanSceneDataSetBindingSource;
            // 
            // beanSceneDataSetBindingSource
            // 
            this.beanSceneDataSetBindingSource.DataSource = this.beanSceneDataSet;
            this.beanSceneDataSetBindingSource.Position = 0;
            // 
            // beanSceneDataSet
            // 
            this.beanSceneDataSet.DataSetName = "BeanSceneDataSet";
            this.beanSceneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.beanSceneDataSetBindingSource;
            // 
            // fKProductCategoryBindingSource
            // 
            this.fKProductCategoryBindingSource.DataMember = "FK_Product_Category";
            this.fKProductCategoryBindingSource.DataSource = this.categoryBindingSource;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(44, 384);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(107, 20);
            this.lblCategory.TabIndex = 43;
            this.lblCategory.Text = "CATEGORY";
            this.lblCategory.Visible = false;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(271, 309);
            this.tbxDescription.Mask = "Aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.PromptChar = ' ';
            this.tbxDescription.Size = new System.Drawing.Size(376, 20);
            this.tbxDescription.TabIndex = 49;
            this.tbxDescription.Visible = false;
            this.tbxDescription.TextChanged += new System.EventHandler(this.btnAutomaticSearch);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(271, 346);
            this.tbxPrice.Mask = "000000000000000000000000000000000000000000";
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.PromptChar = ' ';
            this.tbxPrice.Size = new System.Drawing.Size(376, 20);
            this.tbxPrice.TabIndex = 50;
            this.tbxPrice.Visible = false;
            this.tbxPrice.TextChanged += new System.EventHandler(this.btnAutomaticSearch);
            // 
            // lblEditPrice
            // 
            this.lblEditPrice.AutoSize = true;
            this.lblEditPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPrice.Location = new System.Drawing.Point(44, 418);
            this.lblEditPrice.Name = "lblEditPrice";
            this.lblEditPrice.Size = new System.Drawing.Size(109, 20);
            this.lblEditPrice.TabIndex = 51;
            this.lblEditPrice.Text = "EDIT PRICE";
            this.lblEditPrice.Visible = false;
            // 
            // tbxEditPrice
            // 
            this.tbxEditPrice.Location = new System.Drawing.Point(271, 420);
            this.tbxEditPrice.Mask = "0000000000000000000000000000000";
            this.tbxEditPrice.Name = "tbxEditPrice";
            this.tbxEditPrice.PromptChar = ' ';
            this.tbxEditPrice.Size = new System.Drawing.Size(376, 20);
            this.tbxEditPrice.TabIndex = 52;
            this.tbxEditPrice.Visible = false;
            // 
            // lblManageItemView
            // 
            this.lblManageItemView.AutoSize = true;
            this.lblManageItemView.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageItemView.Location = new System.Drawing.Point(314, 28);
            this.lblManageItemView.Name = "lblManageItemView";
            this.lblManageItemView.Size = new System.Drawing.Size(272, 31);
            this.lblManageItemView.TabIndex = 53;
            this.lblManageItemView.Text = "Manage Item View";
            // 
            // ManageItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1035, 733);
            this.Controls.Add(this.lblManageItemView);
            this.Controls.Add(this.tbxEditPrice);
            this.Controls.Add(this.lblEditPrice);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboxCategory);
            this.Controls.Add(this.lblExeption);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnResetSearch);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dtvItemDetails);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageItemView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Item";
            this.Load += new System.EventHandler(this.ManageItemView_Load);
            this.TextChanged += new System.EventHandler(this.btnAutomaticSearch);
            ((System.ComponentModel.ISupportInitialize)(this.dtvItemDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beanSceneDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beanSceneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnResetSearch;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DataGridView dtvItemDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExeption;
        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.BindingSource beanSceneDataSetBindingSource;
        private BeanSceneDataSet beanSceneDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private BeanSceneDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource fKProductCategoryBindingSource;
        private BeanSceneDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.MaskedTextBox tbxDescription;
        private System.Windows.Forms.MaskedTextBox tbxPrice;
        private System.Windows.Forms.Label lblEditPrice;
        private System.Windows.Forms.MaskedTextBox tbxEditPrice;
        private System.Windows.Forms.Label lblManageItemView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}