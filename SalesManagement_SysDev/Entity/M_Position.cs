using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class M_Position
    { 

        [Key]
        public int PoID { get; set; }           //役職ID
        [MaxLength(50)]
        [Required]
        public String PoName { get; set; }      //役職名		
        public int PoFlag { get; set; }         //役職管理フラグ
        public String PoHidden { get; set; }    //非表示理由		
 
    }
}
