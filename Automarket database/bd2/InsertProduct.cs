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
    public partial class InsProdForm : Form
    {
        SqlConnection sn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dmitry\Documents\Visual Studio 2015\Projects\bd2\bd2\DATABASE.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public InsProdForm()
        {
            InitializeComponent();
        }
        private void insProdForm_Load(object sender, EventArgs e)
        {
            cmd.Connection = sn;
            //loadlist();
        }

        public void loadlist()
        {
            
            sn.Open();
            cmd.CommandText = "select * from Product";
            dr = cmd.ExecuteReader();
            sn.Close();
        }

       

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (textBoxPName.Text != "" & textBoxCost.Text != "" & textBoxAmt.Text != "")
            {
                try
                {
                    sn.Open();

                    cmd.CommandText = "Insert into Product (pname, cost, amt) values (N'" +
                        textBoxPName.Text + "', '" + textBoxCost.Text + "', '" + textBoxAmt.Text + "')";

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Добавлено", "Info");
                    sn.Close();

                    textBoxPName.Text = "";
                    textBoxCost.Text = "";
                    textBoxAmt.Text = "";
                    //loadlist();
                }

                catch { MessageBox.Show("Error!", "Info"); }
            }
        }



        
    }
}
