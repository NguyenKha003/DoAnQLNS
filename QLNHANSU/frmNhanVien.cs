﻿using Businesslayer;
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
using System.IO;
using QLNHANSU.Reports;
using Businesslayer.DTO;

using DevExpress.XtraReports.UI;
namespace QLNHANSU
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            
        }
        
        NHANVIEN _nhanvien;
        DANTOC _dantoc;
        TONGIAO _tongiao;
        CHUCVU _chucvu;
        TRINHDO _trinhdo;
        PHONGBAN _phongban;
        BOPHAN _bophan;
        bool _them;
        int _id;
        private Image _hinh;
        List<NHANVIEN_DTO> _lstNVDTO; 
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            _them = false;
            _nhanvien = new NHANVIEN();
            _dantoc = new DANTOC();
            _tongiao = new TONGIAO();
            _chucvu = new CHUCVU();
            _trinhdo = new TRINHDO();
            _phongban = new PHONGBAN();
            _bophan = new BOPHAN();
            _showMide(true);
            loadData();
            loadCombo();
            splitContainer1.Panel1Collapsed = true;
            gcDanhSach.Enabled = true;
            btnSua.Enabled = true;

        }
        void loadCombo()
        {
            cboBoPhan.DataSource = _bophan.getList();
            cboBoPhan.DisplayMember = "TENBP";
            cboBoPhan.ValueMember = "IDBP";

            cboPhongBan.DataSource = _phongban.getList();
            cboPhongBan.DisplayMember = "TENPB";
            cboPhongBan.ValueMember = "IDPB";

            cboTrinhDo.DataSource = _trinhdo.getList();
            cboTrinhDo.DisplayMember = "TENTD";
            cboTrinhDo.ValueMember = "IDTD";

            cboChucVu.DataSource = _chucvu.getList();
            cboChucVu.DisplayMember = "TENCV";
            cboChucVu.ValueMember = "IDCV";

            cboDanToc.DataSource = _dantoc.getList();
            cboDanToc.DisplayMember = "TENDT";
            cboDanToc.ValueMember = "ID";

            cboTonGiao.DataSource = _tongiao.getList();
            cboTonGiao.DisplayMember = "TENTG";
            cboTonGiao.ValueMember = "ID";

        }
        void _showMide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnPrint.Enabled = kt;
            txtHoTen.Enabled = !kt;
            txtHoTen.Enabled = !kt;
            txtCCCD.Enabled = !kt;
            txtDienThoai.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            chkGioiTinh.Enabled = !kt;
            //picHinhAnh.Enabled = !kt;
            cboBoPhan.Enabled = !kt;
            cboPhongBan.Enabled = !kt;
            cboTrinhDo.Enabled = !kt;
            cboChucVu.Enabled = !kt;
            cboDanToc.Enabled = !kt;
            cboTonGiao.Enabled = !kt;
            btnHinhAnh.Enabled = !kt;
            picHinhAnh.Enabled = kt;
            dtnNgaySinh.Enabled = !kt;
            gcDanhSach.Enabled = kt;
        }
        void _reset()
        {
            txtHoTen.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            chkGioiTinh.Checked = false;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _nhanvien.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstNVDTO = _nhanvien.getListFull();

        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showMide(false);
            _them = true;
            _reset();
            btnThem.Enabled = false;
            splitContainer1.Panel1Collapsed = false;
            btnSua.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showMide(false);
            picHinhAnh.Image = _hinh;
         
            splitContainer1.Panel1Collapsed = false;
            gcDanhSach.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _nhanvien.Delete(_id);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            loadData();
            _them = false;
            _showMide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showMide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptDanhSachNhanVien rpt = new rptDanhSachNhanVien(_lstNVDTO);
            rpt.ShowPreview();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void saveData()
        {
            if (_them)
            {
                tb_NHANVIEN nv = new tb_NHANVIEN();
                nv.HOTEN = txtHoTen.Text;
                nv.GIOITINH  = chkGioiTinh.Checked;
                nv.NGAYSINH  = dtnNgaySinh.Value;
                nv.DIENTHOAI = txtDienThoai.Text;
                nv.CCCD = txtCCCD.Text;
                nv.DIACHI = txtDiaChi.Text;
                nv.HINHANH = ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
                nv.IDBP = int.Parse(cboBoPhan.SelectedValue.ToString());
                nv.IDPB = int.Parse(cboPhongBan.SelectedValue.ToString());
                nv.IDTD = int.Parse(cboTrinhDo.SelectedValue.ToString());
                nv.IDCV = int.Parse(cboChucVu.SelectedValue.ToString());
                nv.IDDT = int.Parse(cboDanToc.SelectedValue.ToString());
                nv.IDTG = int.Parse(cboTonGiao.SelectedValue.ToString());
                nv.MACTY = 1;
                _nhanvien.add(nv);
            }
            else
            {
                var nv = _nhanvien.getItem(_id);
                nv.HOTEN = txtHoTen.Text;
                nv.GIOITINH = chkGioiTinh.Checked;
                nv.NGAYSINH = dtnNgaySinh.Value;
                nv.DIENTHOAI = txtDienThoai.Text;
                nv.CCCD = txtCCCD.Text;
                nv.DIACHI = txtDiaChi.Text;
                nv.HINHANH = ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
                nv.IDBP = int.Parse(cboBoPhan.SelectedValue.ToString());
                nv.IDPB = int.Parse(cboPhongBan.SelectedValue.ToString());
                nv.IDTD = int.Parse(cboTrinhDo.SelectedValue.ToString());
                nv.IDCV = int.Parse(cboChucVu.SelectedValue.ToString());
                nv.IDDT = int.Parse(cboDanToc.SelectedValue.ToString());
                nv.IDTG = int.Parse(cboTonGiao.SelectedValue.ToString());
                nv.MACTY = 1;
                _nhanvien.update(nv);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MANV").ToString());
                var nv = _nhanvien.getItem(_id);
                txtHoTen.Text = nv.HOTEN;
                chkGioiTinh.Checked = nv.GIOITINH.Value;
                dtnNgaySinh.Value = nv.NGAYSINH.Value;
                txtDienThoai.Text = nv.DIENTHOAI;
                txtCCCD.Text = nv.CCCD;
                txtDiaChi.Text = nv.DIACHI;
                picHinhAnh.Image = Base64ToImage(nv.HINHANH);
                cboBoPhan.SelectedValue =nv.IDBP;
                cboPhongBan.SelectedValue = nv.IDPB;
                cboTrinhDo.SelectedValue= nv.IDTD;
                cboChucVu.SelectedValue = nv.IDCV;
                cboDanToc.SelectedValue = nv.IDDT;
                cboTonGiao.SelectedValue = nv.IDTG;
                //nv.MACTY = 1;
            }
        }
        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file9 (.png, .jpg)|*.png;*jpg";
            openFile.Title = "Chọn hình ảnh";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(openFile.FileName);
                picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }    
        }

        private void txtHoTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtnNgaySinh.Focus();
            }
        }

        private void dtnNgaySinh_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void txtCCCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDienThoai.Focus();
            }
        }

        private void txtDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboPhongBan.Focus();
            }
        }

        private void txtDienThoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDiaChi.Focus();
            }
        }
    }
}
