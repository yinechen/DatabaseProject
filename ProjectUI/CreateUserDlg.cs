using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjectModel.DbUser;
using ProjectBLL;
using ProjectModel.Instance;

namespace ProjectUI
{
    public partial class CreateUserDlg : Form
    {
        private DbUser _newUser = new DbUser();

        public CreateUserDlg()
        {
            InitializeComponent();
        }

        public DbUser NewUser
        {
            get
            {
                return _newUser;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            BLLClass myBLL = new BLLClass();
            try
            {
                myBLL.CreateUser(new DbInstance(), new DbUser(), new DbUser());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
