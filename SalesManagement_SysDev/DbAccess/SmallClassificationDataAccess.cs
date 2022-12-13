using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SalesManagement_SysDev
{
    class SmallClassificationDataAccess
    {
        public List<M_SmallClassification> GetSmallClassificationDspData()
        {
            List<M_SmallClassification> smallClassification = new List<M_SmallClassification>();
            try
            {
                var context = new SalesManagement_DevContext();
                smallClassification = context.M_SmallClassifications.Where(x => x.ScFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return smallClassification;

        }
    }
}
