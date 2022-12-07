using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    class ProductDataAccess
    {
        public List<M_ProductDsp> GetProductData(M_ProductDsp selectCondition)
        {
            List<M_ProductDsp> product = new List<M_ProductDsp>();

            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.M_Products
                         join t2 in context.M_Makers
                         on t1.MaID equals t2.MaID
                         where t1.PrID == selectCondition.PrID ||
                               t1.MaID == selectCondition.MaID ||
                               t1.PrName.Contains(selectCondition.PrName) ||
                               t1.Price == selectCondition.Price ||
                               t1.PrSafetyStock == selectCondition.PrSafetyStock ||
                               t1.ScID == selectCondition.ScID ||
                               t1.PrModelNumber.Contains(selectCondition.PrModelNumber) ||
                               t1.PrColor.Contains(selectCondition.PrColor)
                         select new
                         {
                             t1.PrID,
                             t1.MaID,
                             t1.PrName,
                             t1.Price,
                             t1.PrSafetyStock,
                             t1.ScID,
                             t1.PrModelNumber,
                             t1.PrColor,
                             t1.PrReleaseDate,
                             t1.PrFlag,
                             t1.PrHidden
                         };
                foreach(var p in tb)
                {
                    product.Add(new M_ProductDsp()
                    {
                        PrID = p.PrID,
                        MaID = p.MaID,
                        PrName = p.PrName,
                        Price = p.Price,
                        PrSafetyStock = p.PrSafetyStock,
                        ScID = p.ScID,
                        PrModelNumber = p.PrModelNumber,
                        PrColor = p.PrColor,
                        PrReleaseDate = p.PrReleaseDate,
                        PrFlag = p.PrFlag,
                        PrHidden = p.PrHidden
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
    }
}
