using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    class ClientDataAccess
    {
        public List<M_Client> GetClientDspData()
        {
            List<M_Client> client = new List<M_Client>();
            try
            {
                var context = new SalesManagement_DevContext();
                client = context.M_Clients.Where(x => x.ClFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return client;

        }
    }
}
