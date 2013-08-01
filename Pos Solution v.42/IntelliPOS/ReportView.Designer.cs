namespace IntelliPOS
{
    partial class ReportView
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
            this.btnXRead = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnZRead = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXRead
            // 
            this.btnXRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnXRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXRead.ForeColor = System.Drawing.Color.White;
            this.btnXRead.Location = new System.Drawing.Point(124, 124);
            this.btnXRead.Name = "btnXRead";
            this.btnXRead.Size = new System.Drawing.Size(136, 68);
            this.btnXRead.TabIndex = 0;
            this.btnXRead.Text = "X-Read";
            this.btnXRead.UseVisualStyleBackColor = false;
            this.btnXRead.Click += new System.EventHandler(this.btnXRead_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.AutoSize = true;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.crystalReportViewer1.Location = new System.Drawing.Point(278, 98);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowExportButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowPageNavigateButtons = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(933, 281);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelWidth = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.lblHeading.Location = new System.Drawing.Point(322, 35);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(128, 37);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "Reports";
            // 
            // btnZRead
            // 
            this.btnZRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnZRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZRead.ForeColor = System.Drawing.Color.White;
            this.btnZRead.Location = new System.Drawing.Point(124, 218);
            this.btnZRead.Name = "btnZRead";
            this.btnZRead.Size = new System.Drawing.Size(136, 68);
            this.btnZRead.TabIndex = 4;
            this.btnZRead.Text = "Z-Read";
            this.btnZRead.UseVisualStyleBackColor = false;
            this.btnZRead.Click += new System.EventHandler(this.btnZRead_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(124, 310);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(136, 68);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1247, 449);
            this.ControlBox = false;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnZRead);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnXRead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportView";
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXRead;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnZRead;
        private System.Windows.Forms.Button btnPrint;

    }
}