using QuanLyQuanAn.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAL.IRepository
{
    public interface IFoodCategoryRepository
    {
        IEnumerable<FoodCategory> GetFoodCategories(bool noTracking = false);
        int GetIDCategoryByName(string name);
        string GetNameCategoryById(int? id);
        void InsertCategory(string name);
        void DeleteCategory(int? id);
        void UpdateCategory(int? id ,string name);
    }
}
