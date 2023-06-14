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
    public partial class FrmDeleteIncome : Form
    {
        db fn=new db();
        public FrmDeleteIncome()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteIncome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Izbrisati Prihod", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(cbmIncomeID.SelectedItem.ToString());
                string query= "delete from PayCheck where ID_Paycheck='"+id+"'";
                fn.setData(query, "record deleted succesfully");
            }
            else
            {
                MessageBox.Show("Prihod nije izbrisan!", "Izbrisati Prihod?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmDeleteIncome_Load(object sender, EventArgs e)
        {
            string query1 = "select ID_Paycheck from PayCheck";
            

            DataSet ds = fn.getData(query1);
           int[] Ids = new int[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Ids[i] = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_Paycheck"]);
                

            }
            query1 = "select Name from PayCheck";


            ds = fn.getData(query1);
            string[] name = new string[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //MessageBox.Show(ds.Tables[0].Rows[i]["Name"].ToString());
                name[i] = Convert.ToString(ds.Tables[0].Rows[i]["Name"].ToString());
            }
            query1 = "select Amount from PayCheck";


             ds = fn.getData(query1);
            decimal[] price = new decimal[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                price[i] = Convert.ToDecimal(ds.Tables[0].Rows[i]["Amount"].ToString());
            }
            cbmIncomeID.DataSource= Ids;
            cbmIncomeName.DataSource= name;
            cbmIncomePrice.DataSource= price;
        }
    }
}
