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
    public partial class StartForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dmitry\Documents\Visual Studio 2015\Projects\bd2\bd2\DATABASE.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public static System.Data.DataSet ds = new DataSet();

       public InsProdForm obj = new InsProdForm();
        public DelProdForm obj3 = new DelProdForm();
        public UpdateProduct obj4 = new UpdateProduct();
        public InsertOrders obj5 = new InsertOrders();
        public DeleteOrders obj6 = new DeleteOrders();
        public UpdateOrders obj7 = new UpdateOrders();
        public SearchForm obS = new SearchForm();

        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            LoadDataFromDB();
        }

        void LoadDataFromDB()
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dATABASEDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.dATABASEDataSet.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dATABASEDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.dATABASEDataSet.Product);
        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dATABASEDataSet);

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.ShowDialog();
            
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
                base_load();
          
        }

        public void base_load()
        {
            sqlConnection.Open();
           
            SqlCommand cmd = new SqlCommand("select * from Product", sqlConnection);
            dATABASEDataSet.Load(cmd.ExecuteReader(),LoadOption.OverwriteChanges, dATABASEDataSet.Product);

            cmd = new SqlCommand("select * from Orders", sqlConnection);
            dATABASEDataSet.Load(cmd.ExecuteReader(), LoadOption.OverwriteChanges, dATABASEDataSet.Orders);
            
            
            sqlConnection.Close();
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            obj3.ShowDialog();
            
        }

        private void productToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            obj4.ShowDialog();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj5.ShowDialog();
        }

        private void ordersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            obj6.ShowDialog();
        }

        private void ordersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            obj7.ShowDialog();
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obS.ShowDialog();
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
