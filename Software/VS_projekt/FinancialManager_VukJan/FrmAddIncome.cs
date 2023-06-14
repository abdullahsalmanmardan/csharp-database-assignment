using FinancialManager_VukJan.Models___Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FinancialManager_VukJan
{
    public partial class FrmAddIncome : Form
    {
        db fn=new db();
        Random rnd = new Random();
        public FrmAddIncome()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            int value = rnd.Next(1, 20000);
            // checking if the value is avalible in the db
            string query1 = "select * from PayCheck where ID_Paycheck='" + value + "'";
            DataSet ds=fn.getData(query1);
            
            while (ds.Tables.Count < 0)
            {
                value = rnd.Next(1, 20000);
               
                query1 = "select * from PayCheck where ID_Paycheck='" + value + "'";
                ds = fn.getData(query1);
            }
          
            Income ic = new Income {
                ID= value,
                Name = txtIncomeName.Text,
                Description = txtIncomeDescription.Text,
                DateTime = Convert.ToDateTime(txtIncomeDate.Text),
                Amount = Convert.ToDecimal(txtIncomeAmount.Text),
            };

            string query = "insert into Paycheck (ID_Paycheck,Name,Amount,Description,Date) values('" + ic.ID + "','" + ic.Name + "','" + ic.Amount + "','" + ic.Description + "','" + ic.DateTime + "') ";

            fn.setData(query, "Record in pay check inserted");

        }
    }
}
