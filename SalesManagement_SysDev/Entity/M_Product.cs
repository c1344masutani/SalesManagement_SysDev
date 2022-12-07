    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

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

    //データグリッドビュー用
    class M_ProductDsp
    {
        public int PrID { get; set; } 
        
        public int MaID { get; set; }

        public String PrName { get; set; }
        
        public int Price { get; set; }

        public int PrSafetyStock { get; set; }
        
        public int ScID { get; set; }

        public String PrModelNumber { get; set; }

        public String PrColor { get; set; }

        public DateTime PrReleaseDate { get; set; }	

        public int PrFlag { get; set; }

        public String PrHidden { get; set; }
    }
}
