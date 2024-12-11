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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void listsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Users.FrmList frmList = new Forms.Users.FrmList() { TopLevel = false };
            pnMain.Controls.Add(frmList);
            frmList.Show();
            //frmList.ShowDialog();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Users.FrmCreate frmCreate = new Forms.Users.FrmCreate();
            frmCreate.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.FrmLogin frmLogin = new Forms.FrmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
