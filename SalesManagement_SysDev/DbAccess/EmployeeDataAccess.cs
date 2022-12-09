using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    class EmployeeDataAccess
    {
        public List<M_Employee> GetEmployeeDspData()
        {
            List<M_Employee> employee = new List<M_Employee>();
            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x => x.EmFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
    }
}
