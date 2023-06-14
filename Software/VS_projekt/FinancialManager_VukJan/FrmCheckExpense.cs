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
    public partial class FrmCheckExpense : Form
    {
        db fn=new db(); 
        public FrmCheckExpense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCheckExpense_Load(object sender, EventArgs e)
        {
            string query1 = "select * from Expenses";
            DataSet ds = fn.getData(query1);
            dgvCheckExpense.DataSource = ds.Tables[0];
        }
    }
}
