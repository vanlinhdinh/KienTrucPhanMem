using QuanLyQuanAn.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanAn.DAL.Model;
using QuanLyQuanAn.DAL.ViewModel;

namespace QuanLyQuanAn.DAL.Repository
{
    public class TableFoodRepository : ITableFoodRepository, IDisposable
    {
        private readonly QuanLyQuanAnModel db;
        private bool disposed;

        public TableFoodRepository(QuanLyQuanAnModel _db)
        {
            db = _db;
        }

 
        public IEnumerable<TableFood> GetTableFoods()
        {
            return db.TableFoods.ToList();
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

        //public IEnumerable<TableFoodDetails_Result> TableFoodDetails(int? idTable)
        //{
        //    return db.TableFoodDetails(idTable).ToList();
        //}

        public void SetStatusTable(int? idTable, string status)
        {
            var result = db.TableFoods.SingleOrDefault(m => m.idTable == idTable);
            if (result != null)
            {
                result.statusTable = status;
                db.SaveChanges();
            }
        }

        public string GetStatusTable(int? idTable)
        {
            var result = db.TableFoods.SingleOrDefault(m => m.idTable == idTable);
            string x = result.statusTable;
            return x;
        }

        public bool AddTable(string nameTable)
        {
            var result = db.TableFoods.SingleOrDefault(m => m.nameTable == nameTable);
            if (result != null)
            {
                return false;
            }
            TableFood T = new TableFood();
            T.nameTable = nameTable;
            T.statusTable = "Trống";

            db.TableFoods.Add(T);
            db.SaveChanges();
            return true;
        }

        public bool DeleteTable(int idTable)
        {
            var result = db.TableFoods.SingleOrDefault(m => m.idTable == idTable);
            if (result == null)
            {
                return false;
            }
            db.TableFoods.Remove(result);
            db.SaveChanges();
            return true;
        }

        public bool EditNameTable(int idTable, string newNameTable)
        {
            var result = db.TableFoods.SingleOrDefault(m => m.idTable == idTable);//id read only nên không cần kiểm tra
            var result2 = db.TableFoods.SingleOrDefault(m => m.nameTable == newNameTable);//kiểm tra xem có trùng tên hay không
            if (result2 != null)
            {
                return false;
            }
            result.nameTable = newNameTable;
            db.SaveChanges();
            return true;
        }
    }
}
