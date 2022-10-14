using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class T_Hattyu
    {
        [Key]
        public int HaID { get; set; }                   //発注ID	
        public int MaID { get; set; }                   //メーカID	
        public int EmID { get; set; }                   //発注社員ID
        public DateTime HaDate { get; set; }            //発注年月日	
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public int? WaWarehouseFlag { get; set; }	//入庫済フラグ（倉庫）
        public int HaFlag { get; set; }	            //発注管理フラグ
        public String HaHidden { get; set; }            //非表示理由	
  	
    }
}
