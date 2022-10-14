using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SalesManagement_SysDev
{
    class T_Chumon
    {
        [Key]
        public int ChID { get; set; }               //注文ID	
        public int SoID { get; set; }               //営業所ID	
        public int EmID { get; set; }               //社員ID	
        public int ClID { get; set; }               //顧客ID	
        public int OrID { get; set; }               //受注ID
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? ChDate { get; set; }       //注文年月日
        public int? ChStateFlag { get; set; }    //注文状態フラグ
        public int ChFlag { get; set; }	//注文管理フラグ
        public String ChHidden { get; set; }	    //非表示理由	

 
    }
}
