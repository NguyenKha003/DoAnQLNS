﻿using Businesslayer.DTO;
using DevExpress.Office.Utils;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;

namespace QLNHANSU.Reports
{
    public partial class rptDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachNhanVien()
        {
            InitializeComponent();
        }
        List<NHANVIEN_DTO> _lstNV;
        public rptDanhSachNhanVien(List<NHANVIEN_DTO> lstNV)
        {
            InitializeComponent();
            this._lstNV = lstNV;
            this.DataSource = lstNV;
            loadData();
        }
        void loadData()
        {
           
            lblHoTen.DataBindings.Add("Text", _lstNV, "HOTEN");
            lblGioiTinh.DataBindings.Add("Text", _lstNV, "GIOITINH");
            lblNgaySinh.DataBindings.Add("Text", _lstNV, "NGAYSINH");
            lblCCCD.DataBindings.Add("Text", _lstNV, "CCCD");
            lblDienThoai.DataBindings.Add("Text", _lstNV, "DIENTHOAI");
            lblPhongBan.DataBindings.Add("Text", _lstNV, "TENPB");
            lblChucVu.DataBindings.Add("Text", _lstNV, "TENCV");
            lblTrinhDo.DataBindings.Add("Text", _lstNV, "TENTD");
            lblDanToc.DataBindings.Add("Text", _lstNV, "TENDT");
            lblTonGiao.DataBindings.Add("Text", _lstNV, "TENTG");
            lblDiaChi.DataBindings.Add("Text", _lstNV, "DIACHI");
        }

    }
}
