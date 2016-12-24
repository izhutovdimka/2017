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
    public partial class UpdateProduct : Form
    {

        SqlConnection sn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dmitry\Documents\Visual Studio 2015\Projects\bd2\bd2\DATABASE.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;


        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            cmd.Connection = sn;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbId.Text != "" & txbPname.Text != "" & txbCost.Text != "" & txbAmt.Text != "")
            {

                try {
                    sn.Open();
                    cmd.CommandText = "Update Product set  pname = N'" + txbPname.Text +
                        "', cost = '" + txbCost.Text + "', amt='" + txbCost.Text + "' where id = '" + txbId.Text + "' ";
                    cmd.ExecuteNonQuery();
                    sn.Close();
                    MessageBox.Show("Update!", "Info");
                    txbId.Text = "";
                    txbPname.Text = "";
                    txbCost.Text = "";
                    txbAmt.Text = "";

                    //update твоя_таблица set имя_поля = имя_поля - 1 where id = бла бла

                }

                catch { MessageBox.Show("Error!", "Info"); }
            }
        }
    }
}
