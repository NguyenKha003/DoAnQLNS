﻿using Datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Businesslayer
{
    public class TONGIAO
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public tb_TONGIAO getItem(int id)
        {
            return db.tb_TONGIAO.FirstOrDefault(x => x.ID == id);
        }
        public List<tb_TONGIAO> getList()
        {
            return db.tb_TONGIAO.ToList();
        }
        public tb_TONGIAO add(tb_TONGIAO tg)
        {
            try
            {
                db.tb_TONGIAO.Add(tg);
                db.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }
        public tb_TONGIAO update(tb_TONGIAO tg)
        {
            try
            {
                var _db = db.tb_TONGIAO.FirstOrDefault(x => x.ID == tg.ID);
                _db.TENTG = tg.TENTG;
                db.SaveChanges();
                return tg;
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
                var _tg = db.tb_TONGIAO.FirstOrDefault(x => x.ID == id);
                db.tb_TONGIAO.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }
    }
}
