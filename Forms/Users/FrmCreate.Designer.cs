namespace POSSystem.Forms.Users
{
    partial class FrmCreate
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
            label1 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            cmbGender = new ComboBox();
            label4 = new Label();
            txtUsername = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            cmdActive = new ComboBox();
            btnCreate = new Button();
            label7 = new Label();
            dsUsers = new DS.DsUsers();
            tblUsersTableAdapter = new DS.DsUsersTableAdapters.TblUsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)dsUsers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 99);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(340, 96);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(230, 31);
            txtLastName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 165);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 0;
            label2.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(340, 162);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(230, 31);
            txtFirstName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 233);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 0;
            label3.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "M", "F" });
            cmbGender.Location = new Point(340, 225);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(111, 33);
            cmbGender.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 291);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 0;
            label4.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(340, 288);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(230, 31);
            txtUsername.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(159, 351);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 0;
            label5.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(340, 348);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(230, 31);
            txtPassword.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(159, 415);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 0;
            label6.Text = "Active";
            // 
            // cmdActive
            // 
            cmdActive.FormattingEnabled = true;
            cmdActive.Items.AddRange(new object[] { "True", "False" });
            cmdActive.Location = new Point(340, 407);
            cmdActive.Name = "cmdActive";
            cmdActive.Size = new Size(111, 33);
            cmdActive.TabIndex = 6;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(340, 480);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(230, 44);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(308, 28);
            label7.Name = "label7";
            label7.Size = new Size(199, 32);
            label7.TabIndex = 0;
            label7.Text = "Create User Form";
            // 
            // dsUsers
            // 
            dsUsers.DataSetName = "DsUsers";
            dsUsers.Namespace = "http://tempuri.org/DsUsers.xsd";
            dsUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersTableAdapter
            // 
            tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCreate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 575);
            Controls.Add(btnCreate);
            Controls.Add(cmdActive);
            Controls.Add(cmbGender);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create";
            Load += FrmCreate_Load;
            ((System.ComponentModel.ISupportInitialize)dsUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtFirstName;
        private Label label3;
        private ComboBox cmbGender;
        private Label label4;
        private TextBox txtUsername;
        private Label label5;
        private TextBox txtPassword;
        private Label label6;
        private ComboBox cmdActive;
        private Button btnCreate;
        private Label label7;
        private DS.DsUsers dsUsers;
        private DS.DsUsersTableAdapters.TblUsersTableAdapter tblUsersTableAdapter;
    }
}