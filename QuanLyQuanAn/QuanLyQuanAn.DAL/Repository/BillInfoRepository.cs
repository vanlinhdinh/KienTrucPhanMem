using QuanLyQuanAn.DAL.IRepository;
using QuanLyQuanAn.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAL.Repository
{
    public class BillInfoRepository : IBillInfoRepository, IDisposable
    {
        private bool disposed;
        private readonly QuanLyQuanAnModel db;
        public BillInfoRepository(QuanLyQuanAnModel _db)
        {
            this.db = _db;
        }

        public void InsertFoodIntoBillInfo(int? idBill, int? idFood)
        {
            BillInfo x = new BillInfo();
            x.idBill = idBill;
            x.idFood = idFood;
            db.BillInfoes.Add(x);
            db.SaveChanges();
        }
       
         protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
