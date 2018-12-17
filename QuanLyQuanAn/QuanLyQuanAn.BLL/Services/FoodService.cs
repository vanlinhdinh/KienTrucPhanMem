using QuanLyQuanAn.BLL.IService;
using QuanLyQuanAn.DAL.IRepository;
using QuanLyQuanAn.DAL.Model;
using QuanLyQuanAn.DAL.Repository;
using System;
using System.Collections.Generic;

namespace QuanLyQuanAn.BLL.Services
{
    public class FoodService : IFoodService, IDisposable
    {
        private IFoodRepository foodRepository;
        public FoodService()
        {
            this.foodRepository = new FoodRepository(new QuanLyQuanAnModel());
        }

        public int CountFoodByCategory(int? idCate)
        {
            return foodRepository.CountFoodByCategory(idCate);
        }

        public void DeleteFood(int? idFood)
        {
            foodRepository.DeleteFood(idFood);
        }

        public void Dispose()
        {
            foodRepository.Dispose();
        }

        public IEnumerable<Food> GetFoodByCategory(int? idCategory)
        {
            return foodRepository.GetFoodByCategory(idCategory);
        }

        public IEnumerable<Food> GetFoods(bool noTracking = false)
        {
            return foodRepository.GetFoods(noTracking);
        }

        public void InsertFood(string nameFood, decimal price, int idCategory)
        {
            foodRepository.InsertFood(nameFood, price, idCategory);
        }

        public IEnumerable<Food> SearchNameFood(string name)
        {
            return foodRepository.SearchNameFood(name);
        }

        public void UpdateFood(int? idFood, string nameFood, decimal price, int idCategory)
        {
            foodRepository.UpdateFood(idFood, nameFood, price, idCategory);
        }
    }
}
