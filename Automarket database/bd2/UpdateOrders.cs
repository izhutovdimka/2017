using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bd2
{
    public partial class UpdateOrders : Form
    {

        SqlConnection sn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dmitry\Documents\Visual Studio 2015\Projects\bd2\bd2\DATABASE.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter adapter;

        public UpdateOrders()
        {
            InitializeComponent();
        }

        private void UpdateOrders_Load(object sender, EventArgs e)
        {
            cmd.Connection = sn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbId.Text != "" & txbCname.Text != "" & txbAddress.Text != "" & txbPhone.Text != "" &
                txbDateOrd.Text !="" & txbProdId.Text !="" & txbAmt.Text !="" &txbCost.Text !="")
            {


                try {

                    sn.Open();
                    cmd.CommandText = string.Format("Update Orders set  cname = N'{0}', phonenumber = '{1}', address=N'{2}', dateORD='{3}', productID='{4}', amt='{5}', cost='{6}' where id={7}",
                        txbCname.Text, txbPhone.Text, txbAddress.Text, txbDateOrd.Text, txbProdId.Text, txbAmt.Text,
                        txbCost.Text, txbId.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Update!", "Info");
                    sn.Close();

                    txbId.Text = ""; txbAddress.Text = ""; txbAmt.Text = ""; txbCname.Text = "";
                    txbCost.Text = ""; txbDateOrd.Text = ""; txbPhone.Text = ""; txbProdId.Text = "";
                }

                catch { MessageBox.Show("Error!", "Info"); }
            }
        }
    }
}
