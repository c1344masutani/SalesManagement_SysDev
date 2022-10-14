using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class M_MajorCassification
    {
        [Key]
        public int McID { get; set; }           //大分類ID
        [MaxLength(50)]
        [Required]
        public String McName { get; set; }      //大分類名		
        public int McFlag { get; set; }         //大分類管理フラグ
        public String McHidden { get; set; }	//非表示理由		

    }
}
