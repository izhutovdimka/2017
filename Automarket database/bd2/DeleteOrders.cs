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
    public partial class DeleteOrders : Form
    {
        SqlConnection sn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dmitry\Documents\Visual Studio 2015\Projects\bd2\bd2\DATABASE.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter adapter;

        public DeleteOrders()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txbDelOrd.Text != "")
            {
                sn.Open();
                cmd.CommandText = "Delete from Orders where id='" + txbDelOrd.Text + "' ";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Delete!", "Info");
                sn.Close();

                txbDelOrd.Text = "";
            }
        }

        private void DeleteOrders_Load(object sender, EventArgs e)
        {
            cmd.Connection=sn;
        }

    }
}
