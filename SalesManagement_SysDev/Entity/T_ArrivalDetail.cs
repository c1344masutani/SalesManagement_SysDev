using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class T_ArrivalDetail
    {
        [Key]
        public int ArDetailID { get; set; }     //入荷詳細ID
        public int ArID { get; set; }           //入荷ID
        public int PrID { get; set; }           //商品ID
        public int ArQuantity { get; set; }	    //数量

    }
}
