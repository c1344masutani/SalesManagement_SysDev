using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class T_OrderDetail
    {
        [Key]
        public int OrDetailID { get; set; }     //受注詳細ID
        public int OrID { get; set; }           //受注ID
        public int PrID { get; set; }           //商品ID
        public int OrQuantity { get; set; }	    //数量
        public int OrTotalPrice { get; set; }	//合計金額

    }
}
