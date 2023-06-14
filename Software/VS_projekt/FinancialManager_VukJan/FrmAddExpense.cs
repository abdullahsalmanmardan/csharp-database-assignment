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

namespace FinancialManager_VukJan
{
    public partial class FrmAddExpense : Form
    {
        db fn = new db();
        Random rnd = new Random();
        public FrmAddExpense()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddExpense_Load(object sender, EventArgs e)
        {
            cbmNeeded.Items.Add("Yes");
            cbmNeeded.Items.Add("No");

            cbmNeeded.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int value = rnd.Next(1, 20000);
            // checking if the value is avalible in the db
            string query1 = "select * from PayCheck where ID_Paycheck='" + value + "'";
            DataSet ds = fn.getData(query1);

            while (ds.Tables.Count < 0)
            {
                value = rnd.Next(1, 20000);

                query1 = "select * from PayCheck where ID_Paycheck='" + value + "'";
                ds = fn.getData(query1);
            }
            bool flag=false;
            if (cbmNeeded.SelectedIndex.ToString() == "Yes")
            {
                flag = true;   
            }
            Expense ec = new Expense
            {
                ID = value,
                Name = txtExpenseName.Text,
                Description = txtExpenseDescription.Text,
                DateTime = Convert.ToDateTime(txtExpenseDate.Text),
                Price = Convert.ToDecimal(txtExpenseAmount.Text),
                Needed = flag
            };

            string query = "insert into Expenses (ID_Expense,Name,Amount,Description,Date,Needed) values('" + ec.ID + "','" + ec.Name + "','" + ec.Price + "','" + ec.Description + "','" + ec.DateTime + "','" + ec.Needed + "') ";

            fn.setData(query, "Record in expense inserted");
        }

        private void lblExpenseAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
