using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrate
{
    public partial class listView : Form
    {
        DataTable dataTable;
        SqlCommandBuilder sqlCommandBuilder;
        SqlDataAdapter sqlDataAdapter;
        BindingSource bindingSource;
        string qry;

        dbConnect db = new dbConnect();

        public listView()
        {
            InitializeComponent();
        }

        private void listView_Load(object sender, EventArgs e)
        {
            sqlDataAdapter = db.GridView(qry);

            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dgGrid.DataSource = bindingSource;
        }
    }


}
