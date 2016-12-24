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
    public partial class DelProdForm : Form
    {
        SqlConnection sn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dmitry\Documents\Visual Studio 2015\Projects\bd2\bd2\DATABASE.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter adapter;
        

        public DelProdForm()
        {
            InitializeComponent();
        }

        private void DelProdForm_Load(object sender, EventArgs e)
        {
            cmd.Connection = sn;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txb1_form3.Text !="")
            {

                try {
                    sn.Open();
                    cmd.CommandText = "Delete from Product where id='" + txb1_form3.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    MessageBox.Show("Delete!", "Info");
                    sn.Close();

                    txb1_form3.Text = "";
                }


                catch { MessageBox.Show("Error!", "Info"); }
            }
        }

        private void btnDelPos_Click(object sender, EventArgs e)
        {
            if (txb1_form3.Text != "")
            {
                sn.Open();
                cmd.CommandText = "Update Product set amt = amt - 1 where id ='" + txb1_form3.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Позиция удалена", "Info");
                sn.Close();

                txb1_form3.Text = "";
            }
        }
    }
}
