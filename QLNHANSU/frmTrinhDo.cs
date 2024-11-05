using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datalayer;
using Businesslayer;

namespace QLNHANSU
{
    public partial class frmTrinhDo : Form
    {
        public frmTrinhDo()
        {
            InitializeComponent();
        }

        TRINHDO _trinhdo;
        bool _them;
        int _id;
        private void frmTrinhDo_Load(object sender, EventArgs e)
        {
            _them = false;
            _trinhdo = new TRINHDO();
            _showMide(true);
            loadData();
        }
        void _showMide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnXoa.Enabled = kt;
            btnSua.Enabled = kt;
            btnDong.Enabled = kt;
            
            txtTen.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _trinhdo.getList();
            gvDanhSach.OptionsBehavior.Editable = false;

        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showMide(false);
            _them = true;
            txtTen.Text = string.Empty;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showMide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _trinhdo.Delete(_id);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            loadData();
            _them = false;
            _showMide(true);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showMide(true);
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void saveData()
        {
            if (_them)
            {
                tb_TRINHDO dt = new tb_TRINHDO();
                dt.TENTD = txtTen.Text;
                _trinhdo.add(dt);
            }
            else
            {
                var dt = _trinhdo.getItem(_id);
                dt.TENTD = txtTen.Text;
                _trinhdo.update(dt);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDTD").ToString());
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENTD").ToString();
            }
        }

        private void txtTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu_ItemClick(this, null);
            }
        }
    }
}
