using QuanLyQuanAn.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanAn.DAL.Model;
using System.Data.Entity;

namespace QuanLyQuanAn.DAL.Repository
{
    public class FoodRepository : IFoodRepository, IDisposable
    {
        private bool disposed;
        private readonly QuanLyQuanAnModel db;
        public FoodRepository(QuanLyQuanAnModel _db)
        {
            this.db = _db;
        }

        public IEnumerable<Food> GetFoodByCategory(int? idCategory)
        {
            return db.Foods.Where(m => m.idFoodCategory == idCategory).ToList();
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

        public IEnumerable<Food> GetFoods(bool noTracking = false)
        {
            var list = new List<Food>();
            if (noTracking)
            {
                list = db.Foods.AsNoTracking().ToList();
            }
            else
            {
                list = db.Foods.ToList();
            }

            return list;
        }

        public void InsertFood(string nameFood, decimal price, int idCategory)
        {
            Food f = new Food();
            f.nameFood = nameFood;
            f.price = price;
            f.idFoodCategory = idCategory;

            db.Foods.Add(f);
            db.SaveChanges();
        }

        public void DeleteFood(int? idFood)
        {
            Food food = db.Foods.FirstOrDefault(m => m.idFood == idFood);
            db.Foods.Remove(food);

            db.SaveChanges();
        }

        public void UpdateFood(int? idFood, string nameFood, decimal price, int idCategory)
        {
            var result = db.Foods.FirstOrDefault(m => m.idFood == idFood);
            if (result != null)
            {
                result.nameFood = nameFood;
                result.price = price;
                result.idFoodCategory = idCategory;

                db.SaveChanges();
            }
        }

        public IEnumerable<Food> SearchNameFood(string name)
        {
            return db.Foods.Where(m => m.nameFood.Contains(name));
        }

        public int CountFoodByCategory(int? idCate)
        {
            return db.Foods.Count(m => m.idFoodCategory == idCate);
        }
    }
}
