    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    class M_Product
    {
        [Key]
        public int PrID { get; set; }               //商品ID		
        public int MaID { get; set; }               //メーカID	
        [MaxLength(50)]
        [Required]
        public String PrName { get; set; }           //商品名		
        public int Price { get; set; }              //価格	
        [MaxLength(13)]
        public String PrJCode { get; set; }         //JANコード		
        public int PrSafetyStock { get; set; }      //安全在庫数		
        public int ScID { get; set; }               //小分類ID	                                                
        [MaxLength(20)]
        [Required]
        public String PrModelNumber { get; set; }      //型番
        [MaxLength(20)]
        [Required]
        public String PrColor { get; set; }         //色		
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime PrReleaseDate { get; set; } //発売日		
        public int PrFlag { get; set; }             //商品管理フラグ
        public String PrHidden { get; set; }	    //非表示理由		
    }
}
