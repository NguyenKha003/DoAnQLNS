using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Businesslayer.DTO;
using Datalayer;

namespace Businesslayer
{

    public class NHANVIEN
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public tb_NHANVIEN getItem(int id)
        {
            return db.tb_NHANVIEN.FirstOrDefault(x => x.MANV == id);
        }
        public List<tb_NHANVIEN> getList()
        {
            return db.tb_NHANVIEN.ToList();
        }
        public List<NHANVIEN_DTO> getListFull()
        {
            var lstNV = db.tb_NHANVIEN.ToList();
            List<NHANVIEN_DTO> lstNVDTO = new List<NHANVIEN_DTO>();
            NHANVIEN_DTO nvDTO;
            foreach (var item in lstNV)
            {
                nvDTO = new NHANVIEN_DTO();
                nvDTO.MANV = item.MANV;
                nvDTO.HOTEN = item.HOTEN;
                nvDTO.GIOITINH = item.GIOITINH;
                nvDTO.CCCD = item.CCCD;
                nvDTO.NGAYSINH = item.NGAYSINH;
                nvDTO.DIENTHOAI = item.DIENTHOAI;
                nvDTO.DIACHI = item.DIACHI;
                nvDTO.HINHANH = item.HINHANH;

                nvDTO.IDBP = item.IDBP;
                var bp = db.tb_BOPHAN.FirstOrDefault(b => b.IDBP == item.IDBP);
                nvDTO.TENBP = bp.TENBP;

                nvDTO.IDCV = item.IDCV;
                var cv = db.tb_CHUCVU.FirstOrDefault(b => b.IDCV == item.IDCV);
                nvDTO.TENCV = cv.TENCV;

                nvDTO.IDPB = item.IDPB;
                var pb = db.tb_PHONGBAN.FirstOrDefault(p => p.IDPB == item.IDPB);
                nvDTO.TENPB = pb.TENPB;

                nvDTO.IDTD = item.IDTD;
                var td = db.tb_TRINHDO.FirstOrDefault(t => t.IDTD == item.IDTD);
                nvDTO.TENTD = td.TENTD;

                nvDTO.IDDT = item.IDDT;
                var dt = db.tb_DANTOC.FirstOrDefault(d => d.ID == item.IDDT);
                //nvDTO.TENDT = dt.TENDT;
                

                nvDTO.IDTG = item.IDTG;
                var tg = db.tb_TONGIAO.FirstOrDefault(g => g.ID == item.IDTG);
                nvDTO.TENTG = tg.TENTG;

                lstNVDTO.Add(nvDTO);
            } 
                return lstNVDTO;

        }
        public tb_NHANVIEN add(tb_NHANVIEN nv)
        {
            try
            {
                db.tb_NHANVIEN.Add(nv);
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }
        public tb_NHANVIEN update(tb_NHANVIEN nv)
        {
            try
            {
                var _nv = db.tb_NHANVIEN.FirstOrDefault(x => x.MANV == nv.MANV);
                _nv.HOTEN = nv.HOTEN;
                _nv.GIOITINH = nv.GIOITINH;
                _nv.CCCD = nv.CCCD;
                _nv.NGAYSINH = nv.NGAYSINH; 
                _nv.DIACHI = nv.DIACHI;
                _nv.DIENTHOAI = nv.DIENTHOAI;
                _nv.HINHANH = nv.HINHANH;
                _nv.IDBP =  nv.IDBP;
                _nv.IDCV = nv.IDCV;
                _nv.IDPB = _nv.IDPB;
                _nv.IDTD = nv.IDTD;
                _nv.IDDT = nv.IDDT;
                _nv.IDTG = nv.IDTG;
                _nv.MACTY = nv.MACTY;  
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }
        public void Delete(int id)
        {

            try
            {
                var _nv = db.tb_NHANVIEN.FirstOrDefault(x => x.MANV == id);
                db.tb_NHANVIEN.Remove(_nv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }
    }
}
