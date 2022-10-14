using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class T_HattyuDetail
    {
        [Key]
        public int HaDetailID { get; set; } //発注詳細ID
        public int HaID { get; set; }       //発注ID
        public int PrID { get; set; }       //商品ID
        public int HaQuantity { get; set; }	//数量

    }
}
