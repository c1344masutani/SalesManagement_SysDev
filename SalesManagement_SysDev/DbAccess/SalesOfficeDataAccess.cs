using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.DbAccess
{
    class SalesOfficeDataAccess
    {
        public List<M_SalesOffice> GetSalesOfficeDspData()
        {
            List<M_SalesOffice> salesoffice = new List<M_SalesOffice>();
            try
            {
                var context = new SalesManagement_DevContext();
                salesoffice = context.M_SalesOffices.Where(x => x.SoFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salesoffice;
        }
    }
}
