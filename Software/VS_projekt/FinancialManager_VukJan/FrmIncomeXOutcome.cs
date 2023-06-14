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
    public partial class FrmIncomeXOutcome : Form
    {
        db fn=new db();
        public FrmIncomeXOutcome()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmIncomeXOutcome_Load(object sender, EventArgs e)
        {
            string query1 = "select * from Expenses";
            DataSet ds = fn.getData(query1);
            dgvOutcome.DataSource = ds.Tables[0];


            query1 = "select Amount from Expenses";

            ds = fn.getData(query1);
            decimal ExpenseSum = 0;
            decimal[] priceE = new decimal[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                priceE[i] = Convert.ToDecimal(ds.Tables[0].Rows[i]["Amount"].ToString());
                ExpenseSum += priceE[i];
            }
            txtOutcome.Text= ExpenseSum.ToString();





            query1 = "select * from PayCheck";
            ds = fn.getData(query1);
            dgvIncome.DataSource = ds.Tables[0];
            query1 = "select Amount from PayCheck";
            ds = fn.getData(query1);
            decimal[] price = new decimal[ds.Tables[0].Rows.Count];
            decimal priceSum = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                price[i] = Convert.ToDecimal(ds.Tables[0].Rows[i]["Amount"].ToString());
                priceSum += price[i];
            }
            txtIncome.Text=priceSum.ToString();

            decimal diff = priceSum - ExpenseSum;
            txtTotal.Text=diff.ToString();

        }

        private void dgvOutcome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
