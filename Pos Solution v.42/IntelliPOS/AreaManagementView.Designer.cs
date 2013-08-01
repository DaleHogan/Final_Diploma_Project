namespace IntelliPOS
{
    partial class AreaManagementView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvArea = new System.Windows.Forms.DataGridView();
            this.areaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(716, 219);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(279, 61);
            this.btnOpen.TabIndex = 44;
            this.btnOpen.Text = "Open Selected Area";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(716, 299);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(279, 61);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "Close Selected Area";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // dgvArea
            // 
            this.dgvArea.AllowUserToAddRows = false;
            this.dgvArea.AllowUserToDeleteRows = false;
            this.dgvArea.AllowUserToResizeColumns = false;
            this.dgvArea.AllowUserToResizeRows = false;
            this.dgvArea.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.areaName,
            this.areaState,
            this.Area});
            this.dgvArea.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.dgvArea.Location = new System.Drawing.Point(308, 219);
            this.dgvArea.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArea.MultiSelect = false;
            this.dgvArea.Name = "dgvArea";
            this.dgvArea.ReadOnly = true;
            this.dgvArea.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvArea.RowHeadersVisible = false;
            this.dgvArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArea.Size = new System.Drawing.Size(388, 141);
            this.dgvArea.TabIndex = 42;
            this.dgvArea.SelectionChanged += new System.EventHandler(this.dgvArea_SelectionChanged);
            // 
            // areaName
            // 
            this.areaName.Frozen = true;
            this.areaName.HeaderText = "Name";
            this.areaName.Name = "areaName";
            this.areaName.ReadOnly = true;
            this.areaName.Width = 150;
            // 
            // areaState
            // 
            this.areaState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.areaState.HeaderText = "State";
            this.areaState.Name = "areaState";
            this.areaState.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(550, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Area Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(199, 172);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(934, 24);
            this.lblError.TabIndex = 110;
            this.lblError.Text = "Error Label";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AreaManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 651);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvArea);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AreaManagementView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AreaManagementView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.Label lblError;



    }
}