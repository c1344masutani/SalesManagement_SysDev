using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class T_Syukko
    {
        [Key]
        public int SyID { get; set; }               //出庫ID	
        public int EmID { get; set; }               //社員ID	
        public int ClID { get; set; }               //顧客ID	
        public int SoID { get; set; }               //営業所ID	
        public int OrID { get; set; }               //受注ID
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? SyDate { get; set; }       //出庫年月日	
        public int? SyStateFlag { get; set; }    //出庫状態フラグ
        public int SyFlag { get; set; }	//出庫管理フラグ
        public String SyHidden { get; set; }	    //非表示理由	

    }
}
