using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class M_Client
    {
        [Key]
        public int ClID { get; set; }           //顧客ID		
        public int SoID { get; set; }           //営業所ID
        [MaxLength(50)]
        [Required]
        public String ClName { get; set; }      //顧客名
        [MaxLength(50)]
        [Required]
        public String ClAddress { get; set; }   //住所	 
        [MaxLength(13)]
        [Required]
        public String ClPhone { get; set; }     //電話番号	
        [MaxLength(7)]
        [Required]                                        
        public String ClPostal { get; set; }       //郵便番号
        [MaxLength(13)]
        [Required]
        public String ClFAX { get; set; }       //FAX		
        public int ClFlag { get; set; }         //顧客管理フラグ	
        public String ClHidden { get; set; }	//非表示理由		

    }
}
