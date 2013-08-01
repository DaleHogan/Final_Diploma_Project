namespace IntelliPOS
{
    partial class TableManagementView
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
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaOb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbArea = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTables
            // 
            this.dgvTables.AllowUserToAddRows = false;
            this.dgvTables.AllowUserToDeleteRows = false;
            this.dgvTables.AllowUserToResizeColumns = false;
            this.dgvTables.AllowUserToResizeRows = false;
            this.dgvTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTables.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvTables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AREA,
            this.TableNumber,
            this.STATE,
            this.areaOb});
            this.dgvTables.Location = new System.Drawing.Point(417, 176);
            this.dgvTables.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTables.MultiSelect = false;
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.ReadOnly = true;
            this.dgvTables.RowHeadersVisible = false;
            this.dgvTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTables.Size = new System.Drawing.Size(478, 459);
            this.dgvTables.TabIndex = 103;
            this.dgvTables.SelectionChanged += new System.EventHandler(this.dgvTables_SelectionChanged);
            // 
            // AREA
            // 
            this.AREA.FillWeight = 56.66084F;
            this.AREA.HeaderText = "AREA";
            this.AREA.Name = "AREA";
            this.AREA.ReadOnly = true;
            // 
            // TableNumber
            // 
            this.TableNumber.HeaderText = "TABLE NUMBER";
            this.TableNumber.Name = "TableNumber";
            this.TableNumber.ReadOnly = true;
            // 
            // STATE
            // 
            this.STATE.FillWeight = 32.43615F;
            this.STATE.HeaderText = "STATE";
            this.STATE.Name = "STATE";
            this.STATE.ReadOnly = true;
            // 
            // areaOb
            // 
            this.areaOb.FillWeight = 87.15774F;
            this.areaOb.HeaderText = "object";
            this.areaOb.Name = "areaOb";
            this.areaOb.ReadOnly = true;
            this.areaOb.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(516, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 33);
            this.label1.TabIndex = 104;
            this.label1.Text = "Table Management";
            // 
            // cbbArea
            // 
            this.cbbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbArea.FormattingEnabled = true;
            this.cbbArea.Location = new System.Drawing.Point(545, 145);
            this.cbbArea.Name = "cbbArea";
            this.cbbArea.Size = new System.Drawing.Size(350, 28);
            this.cbbArea.TabIndex = 105;
            this.cbbArea.DropDownClosed += new System.EventHandler(this.cbbArea_DropDownClosed);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(902, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 80);
            this.btnAdd.TabIndex = 106;
            this.btnAdd.Text = "Add Table";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(902, 288);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 80);
            this.btnEdit.TabIndex = 107;
            this.btnEdit.Text = "Edit Selected Table";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(902, 552);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 80);
            this.btnDelete.TabIndex = 108;
            this.btnDelete.Text = "Delete Selected Table";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(165, 99);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(983, 24);
            this.lblError.TabIndex = 109;
            this.lblError.Text = "Error Label";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(902, 376);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 80);
            this.btnClose.TabIndex = 111;
            this.btnClose.Text = "Close Selected Table";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(413, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 112;
            this.label2.Text = "Selected Area:";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(902, 464);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(115, 80);
            this.btnOpen.TabIndex = 113;
            this.btnOpen.Text = "Open Selected Table";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // TableManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 663);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTables);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TableManagementView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableManagementView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbArea;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaOb;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpen;
    }
}