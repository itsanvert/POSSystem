using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            DataTable DataUser = new DataTable();
            DS.DsUsersTableAdapters.TblUsersTableAdapter usersTableAdapter = new DS.DsUsersTableAdapters.TblUsersTableAdapter();
            DataUser = usersTableAdapter.GetDataByLoginUser(username, password);

            if (DataUser != null)
            {
                if (DataUser.Rows.Count > 0)
                {
                    foreach (DataRow row in DataUser.Rows)
                    {
                        int active = int.Parse(row["Active"].ToString());
                        if (active == 1)
                        {
                            this.Hide();
                            Forms.FrmMain frmMain = new Forms.FrmMain();
                            frmMain.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sorry this user inactive !!!", "Information", MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect username or password !!!", "Information", MessageBoxButtons.OK,
                                     MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Error Connection", "Information", MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
