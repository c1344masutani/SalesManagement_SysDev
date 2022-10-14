using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class T_SaleDetail
    {
        [Key]
        public int SaDetailID { get; set; }         //売上明細ID
        public int SaID { get; set; }               //売上ID
        public int PrID { get; set; }               //商品ID
        public int SaQuantity { get; set; }         //個数
        public int SaPrTotalPrice { get; set; }	    //合計金額

    }
}
