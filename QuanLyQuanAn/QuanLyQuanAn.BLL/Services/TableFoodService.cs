using QuanLyQuanAn.DAL.Model;
using QuanLyQuanAn.DAL.Repository;
using QuanLyQuanAn.BLL.IService;
using System.Collections.Generic;
using QuanLyQuanAn.DAL.IRepository;

namespace QuanLyQuanAn.BLL.Services
{
    public class TableFoodService : ITableFoodService
    {
        private ITableFoodRepository tableRepository;
        public TableFoodService()
        {
            this.tableRepository = new TableFoodRepository(new QuanLyQuanAnModel());
        }

        public bool AddTable(string nameTable)
        {
            return tableRepository.AddTable(nameTable);
        }

        public bool DeleteTable(int idTable)
        {
            return tableRepository.DeleteTable(idTable);
        }

        public bool EditNameTable(int idTable, string newNameTable)
        {
            return tableRepository.EditNameTable(idTable, newNameTable);
        }

        public string GetStatusTable(int? idTable)
        {
            return tableRepository.GetStatusTable(idTable);
        }

        public IEnumerable<TableFood> GetTableFoods()
        {
            return tableRepository.GetTableFoods();
        }

        public void SetStatusTable(int? idTable, string status)
        {
            tableRepository.SetStatusTable(idTable, status);
        }

        //public IEnumerable<TableFoodDetails_Result> TableFoodDetails(int? idTable)
        //{
        //    return tableRepository.TableFoodDetails(idTable);
        //}
    }
}
