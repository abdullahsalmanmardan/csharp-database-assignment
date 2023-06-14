using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManager_VukJan
{
    public partial class FrmViewIncome : Form
    {
        db fn = new db();
        public FrmViewIncome()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnViewIncome_Click(object sender, EventArgs e)
        {

        }

        private void FrmViewIncome_Load(object sender, EventArgs e)
        {
            string query1 = "select * from PayCheck";
            DataSet ds = fn.getData(query1);
            dgvViewIncome.DataSource = ds.Tables[0];
        }
    }
}
