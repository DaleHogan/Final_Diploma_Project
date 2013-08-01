namespace IntelliPOS
{
    partial class POSView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSView));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnOTC = new System.Windows.Forms.ToolStripButton();
            this.btnLogout = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnTable = new System.Windows.Forms.ToolStripButton();
            this.btnSetting = new System.Windows.Forms.ToolStripButton();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblBeanScene = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 544);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1034, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // btnOTC
            // 
            this.btnOTC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOTC.Image = ((System.Drawing.Image)(resources.GetObject("btnOTC.Image")));
            this.btnOTC.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOTC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOTC.Name = "btnOTC";
            this.btnOTC.Size = new System.Drawing.Size(154, 114);
            this.btnOTC.Text = "OTC Sale";
            this.btnOTC.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(154, 114);
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTable,
            this.btnOTC,
            this.btnSetting,
            this.btnLogout});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1034, 117);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // btnTable
            // 
            this.btnTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTable.Image = ((System.Drawing.Image)(resources.GetObject("btnTable.Image")));
            this.btnTable.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(158, 114);
            this.btnTable.Text = "Table";
            this.btnTable.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(154, 114);
            this.btnSetting.Text = "setting";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // lbluser
            // 
            this.lbluser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(156, 38);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(0, 25);
            this.lbluser.TabIndex = 127;
            // 
            // lblBeanScene
            // 
            this.lblBeanScene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBeanScene.AutoSize = true;
            this.lblBeanScene.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeanScene.Location = new System.Drawing.Point(11, 5);
            this.lblBeanScene.Name = "lblBeanScene";
            this.lblBeanScene.Size = new System.Drawing.Size(270, 29);
            this.lblBeanScene.TabIndex = 126;
            this.lblBeanScene.Text = "BEAN SCENE CAFE™";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(23, 74);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 25);
            this.lblDateTime.TabIndex = 125;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(11, 38);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(124, 25);
            this.lblWelcome.TabIndex = 124;
            this.lblWelcome.Text = "WELCOME";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnlLogin.Controls.Add(this.lblWelcome);
            this.pnlLogin.Controls.Add(this.lbluser);
            this.pnlLogin.Controls.Add(this.lblDateTime);
            this.pnlLogin.Controls.Add(this.lblBeanScene);
            this.pnlLogin.Location = new System.Drawing.Point(582, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(288, 113);
            this.pnlLogin.TabIndex = 129;
            // 
            // POSView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 566);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "POSView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bean Scene";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.POSView_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton btnOTC;
        private System.Windows.Forms.ToolStripButton btnLogout;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnSetting;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblBeanScene;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.ToolStripButton btnTable;
    }
}



