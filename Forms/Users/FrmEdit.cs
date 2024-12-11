using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POSSystem.Forms.Users
{
    public partial class FrmEdit : Form
    {
        public FrmEdit(System.String UserID)
        {
            InitializeComponent();
            txtID.Text = UserID;
        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {
            int userID = int.Parse(txtID.Text);
            DataTable DataUser = new DataTable();
            DS.DsUsersTableAdapters.TblUsersTableAdapter usersTableAdapter = new DS.DsUsersTableAdapters.TblUsersTableAdapter();
            DataUser = usersTableAdapter.GetDataByID(userID);
            foreach (DataRow row in DataUser.Rows)
            {
                txtLastName.Text = row["LastName"].ToString();
                txtFirstName.Text = row["FirstName"].ToString();
                cmbGender.Text = row["Gender"].ToString().Trim();
                txtUsername.Text = row["Username"].ToString();
                txtPassword.Text = row["Password"].ToString();
                cmdActive.Text = row["Active"].ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(txtID.Text);
            System.String lastName = txtLastName.Text;
            System.String firtName = txtFirstName.Text;
            System.String gender = cmbGender.Text;
            System.String username = txtUsername.Text;
            System.String password = txtPassword.Text;
            System.String activeText = cmdActive.Text;
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
            DateTime updatedAt = DateTime.Now;
            this.tblUsersTableAdapter2.UpdateUser(lastName, firtName, gender, username, password, active, UserId, updatedAt, userID);
            MessageBox.Show("Your record has been updated", "Invoice Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
