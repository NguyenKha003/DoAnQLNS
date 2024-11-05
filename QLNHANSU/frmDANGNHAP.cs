using Businesslayer;
using Datalayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANSU
{
    public partial class frmDANGNHAP : Form
    {
        public frmDANGNHAP()
        {
            InitializeComponent();
            
        }



        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userInput = txtUsername.Text;
            string password = txtPassword.Text;

            using (QuanlynhansuEntities db = new QuanlynhansuEntities())
            {
                var user = db.tb_TAIKHOAN.FirstOrDefault(u => (u.TAIKHOAN == userInput || u.EMAIL == userInput));

                if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                {
                   
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void ckbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbHienMatKhau.Checked)
                txtPassword.UseSystemPasswordChar = false;

            if(!ckbHienMatKhau.Checked )
                txtPassword.UseSystemPasswordChar = true;

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(this,null);
            }
        }
    }
}
