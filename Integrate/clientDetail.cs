using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrate
{
    public partial class frmClientDetail : Form
    {
        //frmClientDetail CD = new frmClientDetail();
        ClientMaintananceFrm CM;
        dbConnect Db = new dbConnect();
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        public string VClientName = "", VClientAddr1 = "", VClientAddr2 = "", VCity = "", VState = "",
                VGSTNo = "", VContactNo = "";
        public int VClientID = 0;

        SqlDataAdapter sd;
        DataTable dt;

        public frmClientDetail()
        {
            InitializeComponent();
        }

        private void frmClientDetail_Load(object sender, EventArgs e)
        {
            try
            {
                #region SQLCommented
                //using (SqlConnection sql = new SqlConnection())
                //{
                //    Db.sqlConnect.Open();
                //    sd = new SqlDataAdapter(@"Select * from dbo.PClientDetail", Db.sqlConnect);
                //    dt = new DataTable();
                //    sd.Fill(dt);

                //    dgClientGrid.AutoGenerateColumns = false;
                //    dgClientGrid.DataSource = dt;
                //    dgClientGrid.AutoResizeColumns();
                //}
                //connectionString = Db.sqlConnect.ConnectionString;//ConfigurationManager.AppSettings["connectionString"];
                //sqlConnection = new SqlConnection(connectionString);
                //selectQueryString = "Select * from dbo.PClientDetail";

                //sqlConnection.Open();

                //sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                #endregion
                gridDisplay();

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                Db.sqlConnect.Close();
            }

        }

        #region Grid essentials

        public void LoadDataFromGrid(DataGridViewRow Row,string action)
        {
            VClientID = Convert.ToInt32(Row.Cells["ClientID"].Value);

            CM = new ClientMaintananceFrm(action, VClientID);
            CM.MdiParent = this.MdiParent;

            VClientName = CM.tbName.Text = Row.Cells["ClientName"].Value.ToString();
            VClientAddr1 = CM.tbAddrLine1.Text = Row.Cells["ClientAddressLine1"].Value.ToString();
            VClientAddr2 = CM.tbAddrLine2.Text = Row.Cells["ClientAddressLine2"].Value.ToString();
            VState = CM.tbState.Text = Row.Cells["ClientState"].Value.ToString();
            VCity = CM.tbCity.Text = Row.Cells["ClientCity"].Value.ToString();
            VContactNo = CM.tbContactNum.Text = Row.Cells["ClientMobileNumber"].Value.ToString();
            VGSTNo = CM.tbGSTNo.Text = Row.Cells["ClientGSTNumber"].Value.ToString();

            closing();
            CM.MdiParent = this.MdiParent;
            CM.WindowState = FormWindowState.Minimized;
            CM.Show();
            CM.WindowState = FormWindowState.Normal;
        }

        public void gridDisplay()
        {
            sqlDataAdapter = new SqlDataAdapter(@"Select * from dbo.PClientDetail", Db.sqlConnect);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dgClientGrid.DataSource = bindingSource;

            dgClientGrid.Columns[0].Visible = false;
        }

        #endregion
        private void dgClientGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow CurRow = this.dgClientGrid.Rows[e.RowIndex];
            //    LoadDataFromGrid(CurRow, "gridClick");
            //}
        }

        private void dgClientGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow CurRow = this.dgClientGrid.Rows[e.RowIndex];
                LoadDataFromGrid(CurRow, "gridClick");
            }
        }

        #region Button click events
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dgClientGrid.Rows.RemoveAt(dgClientGrid.CurrentRow.Index);
                sqlDataAdapter.Update(dataTable);
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            CM = new ClientMaintananceFrm("btnNew");
            CM.MdiParent = this.MdiParent;
            closing();
            CM.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgClientGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow CurRow = this.dgClientGrid.CurrentRow;
                LoadDataFromGrid(CurRow, "btnEdit");
            }
        }
        #endregion


       

        public void closing()
        {
            this.Close();

        }
    }
}
