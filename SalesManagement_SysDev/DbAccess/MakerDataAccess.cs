using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    class MakerDataAccess
    {
        public List<M_Maker> GetMakerDspData()
        {
            List<M_Maker> maker = new List<M_Maker>();
            try
            {
                var context = new SalesManagement_DevContext();
                maker = context.M_Makers.Where(x => x.MaFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return maker;

        }
    }
}
