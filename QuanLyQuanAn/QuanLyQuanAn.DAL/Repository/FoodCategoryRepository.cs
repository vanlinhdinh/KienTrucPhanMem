using QuanLyQuanAn.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanAn.DAL.Model;

namespace QuanLyQuanAn.DAL.Repository
{
    public class FoodCategoryRepository : IFoodCategoryRepository, IDisposable
    {
        private readonly QuanLyQuanAnModel db;
        private bool disposed;

        public FoodCategoryRepository(QuanLyQuanAnModel _db)
        {
            this.db = _db;
        }

        public IEnumerable<FoodCategory> GetFoodCategories(bool noTracking = false)
        {
           
                return db.FoodCategories.AsNoTracking().ToList();
          
            
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

        public int GetIDCategoryByName(string name)
        {
            return db.FoodCategories.FirstOrDefault(m => m.nameFoodCategory.Equals(name)).idFoodCategory;
        }

        public string GetNameCategoryById(int? id)
        {
            return db.FoodCategories.FirstOrDefault(m => m.idFoodCategory == id).nameFoodCategory;
        }

        public void InsertCategory(string name)
        {
            FoodCategory category = new FoodCategory();
            category.nameFoodCategory = name;

            db.FoodCategories.Add(category);
            db.SaveChanges();
        }

        public void DeleteCategory(int? id)
        {
            var item = db.FoodCategories.FirstOrDefault(m => m.idFoodCategory == id);
            db.FoodCategories.Remove(item);
            db.SaveChanges();
        }

        public void UpdateCategory(int? id, string name)
        {
            var item = db.FoodCategories.FirstOrDefault(m => m.idFoodCategory == id);
            if (item != null)
            {
                item.nameFoodCategory = name;

                db.SaveChanges();
            }
        }
    }
}
