using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    class PositionDataAccess
    {
        public List<M_Position> GetPositionDspData()
        {
            List<M_Position> position = new List<M_Position>();
            try
            {
                var context = new SalesManagement_DevContext();
                position = context.M_Positions.Where(x => x.PoFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return position;
        }

    }
}
