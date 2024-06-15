using DevExpress.Utils.Behaviors;
using GUI.system;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng ứng dụng?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().ToString() != String.Empty && txtPassword.Text.Trim().ToString() != String.Empty)
            {
                this.Hide();
                frmMain _frmMain = new frmMain();
                _frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!", "Lỗi");
            }
        }
    }
}
