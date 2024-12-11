using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace POSSystem.Forms.Users
{
    public partial class FrmList : Form
    {
        public FrmList()
        {
            InitializeComponent();
        }

        private void FrmList_Load(object sender, EventArgs e)
        {
            this.tblUsersTableAdapter.Fill(this.dsUsers.TblUsers);
            //this.bdUser.RemoveAt(4);
            //this.tblUsersTableAdapter.Update(this.dsUsers.TblUsers);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.tblUsersTableAdapter.Fill(this.dsUsers.TblUsers);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGVUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String btnAction;
            btnAction = dGVUser.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex.ToString();
            String userID;
            userID = dGVUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (btnAction == "10")
            {
                Forms.Users.FrmEdit frmEdit = new Forms.Users.FrmEdit(UserID: userID);
                frmEdit.ShowDialog();

                //Forms.Users.FrmEdit frmEdit = new Forms.Users.FrmEdit();
                //frmEdit.ShowDialog();
            }
        }





        //private void dGVUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    String userID;
        //    userID = dGVUser.Rows[e.RowIndex].Cells[10].Value.ToString();
        //    MessageBox.Show(userID);

    }


    //private void dGVUser_CellClick(object sender, DataGridViewCellEventArgs e)
    //{
    //    String userID;
    //    //userID = DataGridView1.Columns[cellEvent.ColumnIndex];
    //    MessageBox.Show(e.ColumnIndex.ToString());
    //}

    //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    //{
    //    String userID;
    //    userID = dGVUser.Rows[e.RowIndex].Cells[0].Value.ToString(); 
    //    Forms.Users.FrmEdit frmEdit = new Forms.Users.FrmEdit(UserID: userID);
    //    frmEdit.ShowDialog();
    //}

}

