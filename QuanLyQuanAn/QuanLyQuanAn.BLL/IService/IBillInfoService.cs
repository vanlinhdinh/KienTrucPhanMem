using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.BLL.IService
{
    public interface IBillInfoService
    {
        void InsertFoodIntoBillInfo(int? idBill, int? idFood);
    }
}
