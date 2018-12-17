using QuanLyQuanAn.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.BLL.IService
{
    public interface IFoodService : IDisposable
    {
        IEnumerable<Food> GetFoodByCategory(int? idCategory);
        IEnumerable<Food> GetFoods(bool noTracking = false);
        void InsertFood(string nameFood, decimal price, int idCategory);
        void DeleteFood(int? idFood);
        void UpdateFood(int? idFood, string nameFood, decimal price, int idCategory);
        IEnumerable<Food> SearchNameFood(string name);
        int CountFoodByCategory(int? idCate);
    }
}
