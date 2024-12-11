namespace POSSystem.Forms.Users
{
    partial class FrmEdit
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
            components = new System.ComponentModel.Container();
            btnUpdate = new Button();
            cmdActive = new ComboBox();
            tblUsersBindingSource = new BindingSource(components);
            cmbGender = new ComboBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label1 = new Label();
            label8 = new Label();
            txtID = new TextBox();
            tblUsersTableAdapter2 = new DS.DsUsersTableAdapters.TblUsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)tblUsersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(478, 547);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(173, 44);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmdActive
            // 
            cmdActive.FormattingEnabled = true;
            cmdActive.Items.AddRange(new object[] { "True", "False" });
            cmdActive.Location = new Point(402, 472);
            cmdActive.Name = "cmdActive";
            cmdActive.Size = new Size(111, 33);
            cmdActive.TabIndex = 15;
            // 
            // tblUsersBindingSource
            // 
            tblUsersBindingSource.DataMember = "TblUsers";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "M", "F" });
            cmbGender.Location = new Point(402, 290);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(111, 33);
            cmbGender.TabIndex = 16;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(402, 413);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(230, 31);
            txtPassword.TabIndex = 11;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(402, 353);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(230, 31);
            txtUsername.TabIndex = 12;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(402, 227);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(230, 31);
            txtFirstName.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(402, 161);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(230, 31);
            txtLastName.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 416);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(221, 480);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 5;
            label6.Text = "Active";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 356);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 6;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 298);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 7;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 230);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 8;
            label2.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(370, 39);
            label7.Name = "label7";
            label7.Size = new Size(170, 32);
            label7.TabIndex = 9;
            label7.Text = "Edit User Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 164);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 10;
            label1.Text = "Last Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(221, 104);
            label8.Name = "label8";
            label8.Size = new Size(30, 25);
            label8.TabIndex = 10;
            label8.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(402, 101);
            txtID.Name = "txtID";
            txtID.Size = new Size(230, 31);
            txtID.TabIndex = 14;
            // 
            // tblUsersTableAdapter2
            // 
            tblUsersTableAdapter2.ClearBeforeFill = true;
            // 
            // FrmEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 642);
            Controls.Add(btnUpdate);
            Controls.Add(cmdActive);
            Controls.Add(cmbGender);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtFirstName);
            Controls.Add(txtID);
            Controls.Add(txtLastName);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "FrmEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEdit";
            Load += FrmEdit_Load;
            ((System.ComponentModel.ISupportInitialize)tblUsersBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private ComboBox cmdActive;
        private ComboBox cmbGender;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label1;
        private DS.DsUsers dsUsers;
        private DS.DsUsersTableAdapters.TblUsersTableAdapter tblUsersTableAdapter;
        private Label label8;
        private TextBox txtID;
        private BindingSource tblUsersBindingSource;
        private DS.DsUsers dsUsers1;
        private DS.DsUsersTableAdapters.TblUsersTableAdapter tblUsersTableAdapter1;
        private DS.DsUsersTableAdapters.TblUsersTableAdapter tblUsersTableAdapter2;
    }
}