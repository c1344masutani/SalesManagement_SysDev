using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class T_Warehousing
    {
        [Key]
        public int WaID { get; set; }               //入庫ID	
        public int HaID { get; set; }               //発注ID	
        public int EmID { get; set; }               //入庫確認社員ID
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime WaDate { get; set; }        //入庫年月日	
        public int? WaShelfFlag { get; set; }       //入庫済フラグ(棚）
        public String WaHidden { get; set; }	    //非表示理由
        public int WaFlag { get; set; }	//入庫管理フラグ


    }
}
