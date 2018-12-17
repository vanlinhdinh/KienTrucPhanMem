using QuanLyQuanAn.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.BLL.IService
{
    public interface ITableFoodService
    {
        IEnumerable<TableFood> GetTableFoods();
       // IEnumerable<TableFoodDetails_Result> TableFoodDetails(int? idTable);
        void SetStatusTable(int? idTable, string status);
        string GetStatusTable(int? idTable);
        bool AddTable(string nameTable);
        bool DeleteTable(int idTable);
        bool EditNameTable(int idTable, string newNameTable);
    }
}
