using QuanLyQuanAn.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAL.IRepository
{
    public interface IBillRepository
    {
        IEnumerable<Bill> GetBillsByDate(DateTime? dateCheckIn, DateTime? dateCheckOut);

        Bill GetIdBillByTable(int? idTable);
        Bill GetIdBillByTableAndStatusBill(int? idTable, bool status);//trien
        void InsertBillIntoTable(int? idTable, DateTime? dateCheckIn, DateTime? DateCheckOut, int Discount, bool status);
        void SetStatusBill(int? idBill, bool status, int? discount, int? totalPrice);
        void SetIdTableBill(int? idBill, int? idTable);     
    }
}
