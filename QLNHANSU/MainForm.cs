using Datalayer;
using DevExpress.XtraBars;
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
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private frmDANGNHAP loginForm;
        void openFoem(Type typeForm)
        {
            foreach (var frm in MdiChildren)

            {
                if (frm.GetType()==typeForm)
                {
                    frm.Activate();
                    return;
                }    
            }    
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();

        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            ribbon.SelectedPage = ribbonPage2;
            
        }
      

        

        private void btnDanTocN_ItemClick(object sender, ItemClickEventArgs e)
        {
           openFoem(typeof(frmDanToc)); 
        }

        private void btnTonGiao_ItemClick(object sender, ItemClickEventArgs e)
        {
            openFoem(typeof(frmTonGiao));
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            openFoem(typeof(frmTrinhDo));
        }

        private void btnPhongBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            openFoem(typeof (frmPhongBan));
        }

        private void btnCongTy_ItemClick(object sender, ItemClickEventArgs e)
        {
            openFoem (typeof (frmCongTy));
        }

        private void btnBoPhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            openFoem (typeof(frmBoPhan));
        }

        private void btnChucVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            openFoem (typeof(frmChucVu));
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            openFoem (typeof( frmNhanVien));
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                // Ẩn form hiện tại

                // Kiểm tra xem form đăng nhập đã tồn tại chưa
                if (loginForm == null)
                {
                    loginForm = new frmDANGNHAP();
                }
                loginForm.Show();
            }
        }

        private void btnThoiviec_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}