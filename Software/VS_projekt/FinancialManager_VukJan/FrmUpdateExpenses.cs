using System;
using System.Collections;
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
    public partial class FrmUpdateExpenses : Form
    {
        db fn=new db(); 
        public FrmUpdateExpenses()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmUpdateExpenses_Load(object sender, EventArgs e)
        {
            string query1 = "select Name from Expenses";
            DataSet ds = fn.getData(query1);
           
            string[] name = new string[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //MessageBox.Show(ds.Tables[0].Rows[i]["Name"].ToString());
                name[i] = Convert.ToString(ds.Tables[0].Rows[i]["Name"].ToString());
            }
            cbmExpenseName.DataSource = name;
        }
        // this button is for to udpate the record
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string nameValue= cbmExpenseName.SelectedItem.ToString();  
            DateTime dateValue = Convert.ToDateTime(txtUpdateDate.Text);
            MessageBox.Show(nameValue);
            MessageBox.Show(dateValue.ToString());  
            string query1 = "update Expenses set Date='" + dateValue + "'  where name='" + nameValue + "'";
            fn.setData(query1,"Expense Record updated successfully");
        }
    }
}
