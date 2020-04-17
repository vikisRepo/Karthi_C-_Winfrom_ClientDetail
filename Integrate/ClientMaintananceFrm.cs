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
    public partial class ClientMaintananceFrm : Form
    {
        dbConnect db = new dbConnect();
        frmClientDetail FC = new frmClientDetail();
        MainPage MP = new MainPage("");
        string btnClicked = null;
        int vClientID = 0;

        public ClientMaintananceFrm(string Action,int ClientID = 0)
        {
            InitializeComponent();
            btnClicked = Action;
            vClientID = ClientID;
        }

        private void ClientMaintananceFrm_Load(object sender, EventArgs e)
        {

        }


        #region Key Press events
        private void KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void tbContactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //if (!EnterKeyPressed)
            //{
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        #endregion


        #region Button click events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Parent = null;
            listShow();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            SqlCommand sc;
            try
            {
                db.sqlConnect.Open();

                if (btnClicked == "btnNew")
                {
                    sc = new SqlCommand(@"Insert into dbo.PClientDetail (ClientName, ClientAddressLine1, 
                                            ClientAddressLine2, ClientState, ClientCity, ClientMobileNumber, ClientGSTNumber) values
                    (@ClientName,@ClientAddressLine1,@ClientAddressLine2,@ClientState,@ClientCity,@ClientMobileNumber,@ClientGSTNumber)", db.sqlConnect);

                    sc.Parameters.AddWithValue("@ClientName", tbName.Text);
                    sc.Parameters.AddWithValue("@ClientAddressLine1", tbAddrLine1.Text);
                    sc.Parameters.AddWithValue("@ClientAddressLine2", tbAddrLine2.Text);
                    sc.Parameters.AddWithValue("@ClientState", tbState.Text);
                    sc.Parameters.AddWithValue("@ClientCity", tbCity.Text);
                    sc.Parameters.AddWithValue("@ClientMobileNumber", tbContactNum.Text);
                    sc.Parameters.AddWithValue("@ClientGSTNumber", tbGSTNo.Text);

                    sc.ExecuteNonQuery();
                }
                else if ((btnClicked == "btnedit" || btnClicked == "gridClick") && (vClientID > 0))
                {

                    //SqlDataAdapter sD = new SqlDataAdapter(@"Update dbo.PClientDetail 
                    //              set ClientName = @ClientName, ClientAddressLine1 = @ClientAddressLine1, ClientGSTNumber = @ClientGSTNumber,
                    //                   ClientMobileNumber = @ClientMobileNumber, ClientAddressLine2 = @ClientAddressLine2, ClientCity = @ClientCity, ClientState = @ClientState
                    //                           WHERE ClientID = @ClientID", db.sqlConnect);

                    //SqlCommandBuilder SCB = new SqlCommandBuilder(sD);
                    sc = new SqlCommand(@"Update dbo.PClientDetail 
                                  set ClientName = @ClientName, ClientAddressLine1 = @ClientAddressLine1, ClientGSTNumber = @ClientGSTNumber,
                                       ClientMobileNumber = @ClientMobileNumber, ClientAddressLine2 = @ClientAddressLine2, ClientCity = @ClientCity, ClientState = @ClientState
                                               WHERE ClientID = @ClientID", db.sqlConnect);


                    sc.Parameters.AddWithValue("@ClientName", tbName.Text);
                    sc.Parameters.AddWithValue("@ClientAddressLine1", tbAddrLine1.Text);
                    sc.Parameters.AddWithValue("@ClientAddressLine2", tbAddrLine2.Text);
                    sc.Parameters.AddWithValue("@ClientState", tbState.Text);
                    sc.Parameters.AddWithValue("@ClientCity", tbCity.Text);
                    sc.Parameters.AddWithValue("@ClientMobileNumber", tbContactNum.Text);
                    sc.Parameters.AddWithValue("@ClientGSTNumber", tbGSTNo.Text);
                    sc.Parameters.AddWithValue("@ClientID", vClientID);

                    //sD.UpdateCommand.Parameters.Add("@ClientName",SqlDbType.VarChar,24, tbName.Text);
                    //sD.UpdateCommand.Parameters.Add("@ClientAddressLine1", SqlDbType.VarChar, 100, tbAddrLine1.Text);
                    //sD.UpdateCommand.Parameters.Add("@ClientAddressLine2", SqlDbType.VarChar, 100, tbAddrLine2.Text);
                    //sD.UpdateCommand.Parameters.Add("@ClientState", SqlDbType.VarChar, 24, tbState.Text);
                    //sD.UpdateCommand.Parameters.Add("@ClientCity", SqlDbType.VarChar, 24, tbCity.Text);
                    //sD.UpdateCommand.Parameters.Add("@ClientMobileNumber", SqlDbType.VarChar, 10, tbContactNum.Text);
                    //sD.UpdateCommand.Parameters.Add("@ClientGSTNumber", SqlDbType.VarChar, 24, tbGSTNo.Text);
                    //sD.UpdateCommand.Parameters.Add("@ClientID", SqlDbType.Int, 4,Convert.ToString(vClientID));

                    sc.ExecuteNonQuery();
                }
                this.Hide();
                this.Parent = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.sqlConnect.Close();

                // FC.gridDisplay();
                //FC.refreshDataGrid();
                listShow();
            }

        }
        #endregion


        private void ClientMaintananceFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }



        public void listShow()
        {
            //FC.MdiParent = MP;
            FC.WindowState = FormWindowState.Minimized;

            FC.Show();
            
            FC.WindowState = FormWindowState.Normal;
        }

    }
}
