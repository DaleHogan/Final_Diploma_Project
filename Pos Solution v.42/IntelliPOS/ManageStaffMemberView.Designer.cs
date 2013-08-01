namespace IntelliPOS
{
    partial class ManageStaffMemberView
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
            this.tbxEmail = new System.Windows.Forms.MaskedTextBox();
            this.tbxContactNumber = new System.Windows.Forms.MaskedTextBox();
            this.tbxFirstName = new System.Windows.Forms.MaskedTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnResetSearch = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.dtvStaffMemberDetails = new System.Windows.Forms.DataGridView();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvStaffMemberDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(523, 494);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(171, 20);
            this.tbxEmail.TabIndex = 43;
            this.tbxEmail.Visible = false;
            // 
            // tbxContactNumber
            // 
            this.tbxContactNumber.Location = new System.Drawing.Point(523, 460);
            this.tbxContactNumber.Mask = "00000000000000000000000000000";
            this.tbxContactNumber.Name = "tbxContactNumber";
            this.tbxContactNumber.PromptChar = ' ';
            this.tbxContactNumber.Size = new System.Drawing.Size(171, 20);
            this.tbxContactNumber.TabIndex = 42;
            this.tbxContactNumber.Visible = false;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(523, 386);
            this.tbxFirstName.Mask = ">L<????????????????????????????????";
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.PromptChar = ' ';
            this.tbxFirstName.Size = new System.Drawing.Size(171, 20);
            this.tbxFirstName.TabIndex = 40;
            this.tbxFirstName.Visible = false;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.btnAutomaticSearch);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(950, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(190, 60);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "SEARCH EMPLOYEE";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(299, 460);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(94, 20);
            this.lblPhoneNumber.TabIndex = 37;
            this.lblPhoneNumber.Text = "EDIT PH#:";
            this.lblPhoneNumber.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(299, 494);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(114, 20);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "EDIT EMAIL:";
            this.lblEmail.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(950, 255);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(190, 60);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "EDIT DETAILS";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(951, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 60);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "ADD EMPLOYEE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(951, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(190, 60);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "DELETE EMPLOYEE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.btnResetSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSearch.ForeColor = System.Drawing.Color.White;
            this.btnResetSearch.Location = new System.Drawing.Point(950, 410);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(191, 60);
            this.btnResetSearch.TabIndex = 31;
            this.btnResetSearch.Text = "RESET FIELDS";
            this.btnResetSearch.UseVisualStyleBackColor = false;
            this.btnResetSearch.Click += new System.EventHandler(this.btnResetSearch_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(296, 386);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(200, 20);
            this.lblFirstName.TabIndex = 30;
            this.lblFirstName.Text = "SEARCH FIRST NAME:";
            this.lblFirstName.Visible = false;
            // 
            // dtvStaffMemberDetails
            // 
            this.dtvStaffMemberDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvStaffMemberDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.firstName,
            this.lastName,
            this.StaffContactNumber,
            this.StaffEmail});
            this.dtvStaffMemberDetails.Location = new System.Drawing.Point(306, 104);
            this.dtvStaffMemberDetails.Name = "dtvStaffMemberDetails";
            this.dtvStaffMemberDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtvStaffMemberDetails.RowHeadersVisible = false;
            this.dtvStaffMemberDetails.Size = new System.Drawing.Size(639, 264);
            this.dtvStaffMemberDetails.TabIndex = 29;
            // 
            // StaffID
            // 
            this.StaffID.Frozen = true;
            this.StaffID.HeaderText = "ID";
            this.StaffID.Name = "StaffID";
            // 
            // firstName
            // 
            this.firstName.HeaderText = "FIRST NAME";
            this.firstName.Name = "firstName";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "LAST NAME";
            this.lastName.Name = "lastName";
            // 
            // StaffContactNumber
            // 
            this.StaffContactNumber.HeaderText = "CONTACT NUMBER";
            this.StaffContactNumber.Name = "StaffContactNumber";
            // 
            // StaffEmail
            // 
            this.StaffEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffEmail.HeaderText = "EMAIL";
            this.StaffEmail.Name = "StaffEmail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 26);
            this.label1.TabIndex = 44;
            this.label1.Text = "MANAGE STAFF MEMBER";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(296, 426);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(192, 20);
            this.lblLastName.TabIndex = 38;
            this.lblLastName.Text = "SEARCH LAST NAME:";
            this.lblLastName.Visible = false;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(523, 426);
            this.tbxLastName.Mask = ">L<????????????????????????????????";
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.PromptChar = ' ';
            this.tbxLastName.Size = new System.Drawing.Size(171, 20);
            this.tbxLastName.TabIndex = 41;
            this.tbxLastName.Visible = false;
            this.tbxLastName.TextChanged += new System.EventHandler(this.btnAutomaticSearch);
            // 
            // ManageStaffMemberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1241, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxContactNumber);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnResetSearch);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.dtvStaffMemberDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageStaffMemberView";
            this.Text = "ManageStaffMemberView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtvStaffMemberDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbxEmail;
        private System.Windows.Forms.MaskedTextBox tbxContactNumber;
        private System.Windows.Forms.MaskedTextBox tbxFirstName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnResetSearch;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.DataGridView dtvStaffMemberDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.MaskedTextBox tbxLastName;
    }
}