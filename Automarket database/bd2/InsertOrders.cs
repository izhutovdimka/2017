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
    public partial class InsertOrders : Form
    {

        SqlConnection sn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dmitry\Documents\Visual Studio 2015\Projects\bd2\bd2\DATABASE.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        

        public InsertOrders()
        {
            InitializeComponent();
        }

        private void InsertOrders_Load(object sender, EventArgs e)
        {
            cmd.Connection = sn;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if ( txbCname.Text != "" & txbAddress.Text != "" & txbAmt.Text != "" & txbCost.Text != "" & txbDateOrd.Text != "" &
                txbIdProd.Text != "" & txbPhone.Text != "")
            {

                try {
                    sn.Open();
                    cmd.CommandText = "Insert into Orders (cname, phonenumber , address, dateORD, productID, amt, cost) values (N'" +
                        txbCname.Text + "', '" + txbPhone.Text + "', N'" + txbAddress.Text +
                        "', '" + txbDateOrd.Text + "', '" + txbIdProd.Text + "', '" + txbAmt.Text + "', '" + txbCost.Text + "')";

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Добавлено", "Info");
                    sn.Close();


                    txbCname.Text = "";
                    txbPhone.Text = "";
                    txbAddress.Text = "";
                    txbDateOrd.Text = "";
                    txbIdProd.Text = "";
                    txbAmt.Text = "";
                    txbCost.Text = "";
                }

                catch { MessageBox.Show("Error!", "Info"); }
            }
        }
    }
}
