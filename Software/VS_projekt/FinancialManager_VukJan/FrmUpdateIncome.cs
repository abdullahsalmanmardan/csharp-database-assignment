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
    public partial class FrmUpdateIncome : Form
    {db fn=new db();    
        public FrmUpdateIncome()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUpdateIncome_Load(object sender, EventArgs e)
        {
            string query1 = "select * from PayCheck";
            DataSet ds = fn.getData(query1);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
