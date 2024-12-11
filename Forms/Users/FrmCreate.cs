using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem.Forms.Users
{
    public partial class FrmCreate : Form
    {
        public FrmCreate()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String lastName = txtLastName.Text;
            String firtName = txtFirstName.Text;
            String gender = cmbGender.Text;
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            String activeText = cmdActive.Text;
            int active;
            if (activeText == "True")
            {
                active = 1;
            }
            else
            {
                active = 0;
            }
            int UserId = 1;
            DateTime createdAt = DateTime.Now;
            DateTime updatedAt = DateTime.Now;
            this.tblUsersTableAdapter.InsertUser(lastName, firtName, gender, username, password, active, UserId, createdAt, updatedAt);
            MessageBox.Show("You have been create  1 user", "Invoice Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmCreate_Load(object sender, EventArgs e)
        {

        }
    }
}
