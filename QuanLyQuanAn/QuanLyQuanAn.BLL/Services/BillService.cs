using QuanLyQuanAn.BLL.IService;
using QuanLyQuanAn.DAL.IRepository;
using QuanLyQuanAn.DAL.Model;
using QuanLyQuanAn.DAL.Repository;
using System;
using System.Collections.Generic;

namespace QuanLyQuanAn.BLL.Services
{
    public class BillService : IBillService
    {
        private IBillRepository billRepository;
        public BillService()
        {
            this.billRepository = new BillRepository(new QuanLyQuanAnModel());
        }

        public IEnumerable<Bill> GetBillsByDate(DateTime? dateCheckIn, DateTime? dateCheckOut)
        {
            return billRepository.GetBillsByDate(dateCheckIn, dateCheckOut);
        }

        public Bill GetIdBillByTable(int? idTable)
        {
            return billRepository.GetIdBillByTable(idTable);
        }

        public Bill GetIdBillByTableAndStatusBill(int? idTable, bool status)
        {
            return billRepository.GetIdBillByTableAndStatusBill(idTable,status);
        }

        public void InsertBillIntoTable(int? idTable, DateTime? dateCheckIn, DateTime? DateCheckOut, int Discount, bool status)
        {
            billRepository.InsertBillIntoTable(idTable, dateCheckIn, DateCheckOut, Discount, status);
        }

        public void SetIdTableBill(int? idBill, int? idTable)
        {
            billRepository.SetIdTableBill(idBill, idTable);
        }

        public void SetStatusBill(int? idBill, bool status, int? discount, int? totalPrice)
        {
            billRepository.SetStatusBill(idBill, status, discount, totalPrice);
        }
    }
}
