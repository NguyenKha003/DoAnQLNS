using Datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public class TRINHDO
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public tb_TRINHDO getItem(int IDTD)
        {
            return db.tb_TRINHDO.FirstOrDefault(x => x.IDTD == IDTD);
        }
        public List<tb_TRINHDO> getList()
        {
            return db.tb_TRINHDO.ToList();
        }
        public tb_TRINHDO add(tb_TRINHDO td)
        {
            try
            {
                db.tb_TRINHDO.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }
        public tb_TRINHDO update(tb_TRINHDO td)
        {
            try
            {
                var _db = db.tb_TRINHDO.FirstOrDefault(x => x.IDTD == td.IDTD);
                _db.TENTD = td.TENTD;
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }
        public void Delete(int IDTD)
        {

            try
            {
                var _td = db.tb_TRINHDO.FirstOrDefault(x => x.IDTD == IDTD);
                db.tb_TRINHDO.Remove(_td);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }
    }
}
