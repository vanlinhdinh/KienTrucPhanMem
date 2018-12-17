using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAL.IRepository
{
    public interface IBillInfoRepository
    {
        void InsertFoodIntoBillInfo(int? idBill,int? idFood);
    }
}
