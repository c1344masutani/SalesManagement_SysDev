using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    class M_Maker
    {
        [Key]
        public int MaID { get; set; }           //メーカID
        [MaxLength(50)]
        [Required]
        public String MaName { get; set; }      //メーカ名	 
        [MaxLength(50)]
        [Required]
        public String MaAdress { get; set; }    //住所
        [MaxLength(13)]
        [Required]
        public String MaPhone { get; set; }     //電話番号
        [MaxLength(7)]
        [Required]
        public String MaPostal { get; set; }    //郵便番号
        [MaxLength(13)]
        [Required]
        public String MaFAX { get; set; }       //FAX		
        public int MaFlag { get; set; }         //メーカ管理フラグ
        public String MaHidden { get; set; }	//非表示理由		

    }
}
