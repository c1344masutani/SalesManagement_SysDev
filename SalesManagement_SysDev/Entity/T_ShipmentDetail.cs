using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class T_ShipmentDetail
    {
        [Key]
        public int ShDetailID { get; set; }     //出荷詳細ID
        public int ShID { get; set; }           //出荷ID
        public int PrID { get; set; }           //商品ID
        public int ShDquantity { get; set; }	//数量

    }
}
