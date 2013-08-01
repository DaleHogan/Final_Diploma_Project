namespace IntelliPOS
{
    partial class PriceLevelView
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
            this.btnLv1 = new System.Windows.Forms.Button();
            this.btnLv2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPLevel = new System.Windows.Forms.Label();
            this.lblPriceLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLv1
            // 
            this.btnLv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnLv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLv1.ForeColor = System.Drawing.Color.White;
            this.btnLv1.Location = new System.Drawing.Point(369, 283);
            this.btnLv1.Name = "btnLv1";
            this.btnLv1.Size = new System.Drawing.Size(186, 117);
            this.btnLv1.TabIndex = 44;
            this.btnLv1.Text = "Nomal Price";
            this.btnLv1.UseVisualStyleBackColor = false;
            this.btnLv1.Click += new System.EventHandler(this.btnLv1_Click);
            // 
            // btnLv2
            // 
            this.btnLv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnLv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLv2.ForeColor = System.Drawing.Color.White;
            this.btnLv2.Location = new System.Drawing.Point(764, 283);
            this.btnLv2.Name = "btnLv2";
            this.btnLv2.Size = new System.Drawing.Size(186, 117);
            this.btnLv2.TabIndex = 43;
            this.btnLv2.Text = "Happy Hour";
            this.btnLv2.UseVisualStyleBackColor = false;
            this.btnLv2.Click += new System.EventHandler(this.btnLv2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(504, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 31);
            this.label1.TabIndex = 47;
            this.label1.Text = "Price Level Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPLevel
            // 
            this.lblPLevel.AutoSize = true;
            this.lblPLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLevel.ForeColor = System.Drawing.Color.Red;
            this.lblPLevel.Location = new System.Drawing.Point(703, 213);
            this.lblPLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPLevel.Name = "lblPLevel";
            this.lblPLevel.Size = new System.Drawing.Size(0, 25);
            this.lblPLevel.TabIndex = 128;
            // 
            // lblPriceLevel
            // 
            this.lblPriceLevel.AutoSize = true;
            this.lblPriceLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceLevel.ForeColor = System.Drawing.Color.Red;
            this.lblPriceLevel.Location = new System.Drawing.Point(567, 213);
            this.lblPriceLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriceLevel.Name = "lblPriceLevel";
            this.lblPriceLevel.Size = new System.Drawing.Size(132, 25);
            this.lblPriceLevel.TabIndex = 129;
            this.lblPriceLevel.Text = "Price Level :";
            // 
            // PriceLevelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1107, 614);
            this.Controls.Add(this.lblPriceLevel);
            this.Controls.Add(this.lblPLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLv1);
            this.Controls.Add(this.btnLv2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PriceLevelView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AreaManagementView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLv1;
        private System.Windows.Forms.Button btnLv2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPLevel;
        private System.Windows.Forms.Label lblPriceLevel;



    }
}