using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class T_ChumonDetail
    {
        [Key]
        public int ChDetailID { get; set; }     //注文詳細ID
        public int ChID { get; set; }           //注文ID
        public int PrID { get; set; }           //商品ID
        public int ChQuantity { get; set; }	    //数量

    }
}
