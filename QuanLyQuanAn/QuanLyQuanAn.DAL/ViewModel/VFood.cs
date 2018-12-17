using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAL.ViewModel
{
    public class VFood
    {
        public int? idFood { get; set; }
        public string nameFood { get; set; }
        public decimal price { get; set; }
        public int? idFoodCategory { get; set; }
    }
}
