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
    public partial class SearchForm : Form
    {
        public void searchProduct()
        {
            if (comboBox1.Text == "Id")
            {
                SqlConnection sn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dmitry\Documents\Visual Studio 2015\Projects\bd2\bd2\DATABASE.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adap = new SqlDataAdapter("select * from Product where Id like '" + txbSearch.Text + "%'", sn);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Наименование")
            {
                SqlConnection sn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dmitry\Documents\Visual Studio 2015\Projects\bd2\bd2\DATABASE.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adap = new SqlDataAdapter("select * from Product where pname like '" + txbSearch.Text + "%'", sn);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        
        public void searchOrders()
        {
            if (comboBox1.Text == "Id")
            {
                SqlConnection sn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dmitry\Documents\Visual Studio 2015\Projects\bd2\bd2\DATABASE.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adap = new SqlDataAdapter("select * from Orders where Id like '" + txbSearch.Text + "%'", sn);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Имя заказчика")
            {
                SqlConnection sn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dmitry\Documents\Visual Studio 2015\Projects\bd2\bd2\DATABASE.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adap = new SqlDataAdapter("select * from Orders where cname like '" + txbSearch.Text + "%'", sn);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text=="Product")
            {
                searchProduct();
            }

            else if(comboBox2.Text=="Orders")
            {
                searchOrders();
            }
        }
    }
}
