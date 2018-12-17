using QuanLyQuanAn.BLL.IService;
using QuanLyQuanAn.DAL.IRepository;
using QuanLyQuanAn.DAL.Model;
using QuanLyQuanAn.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.BLL.Services
{
    public class BillInfoService : IBillInfoService
    {
        private IBillInfoRepository billInfo;
        public BillInfoService()
        {
            this.billInfo = new BillInfoRepository(new QuanLyQuanAnModel());
        }
        public void InsertFoodIntoBillInfo(int? idBill, int? idFood)
        {
            billInfo.InsertFoodIntoBillInfo(idBill, idFood);
        }
    }
}
