using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrate
{
    public partial class companyDetail : Form
    {
        #region SQL_initialization
        dbConnect db = new dbConnect();
        SqlDataAdapter sd;
        DataTable dt;
        #endregion

        private string CompName = "", CompaAddr1 = "", CompaAddr2 = "",City = "",State= "", 
                        GSTNo = "", ContactNo = "", Logo = "";
       // private bool EnterKeyPressed = false;

        public companyDetail()
        {
            InitializeComponent();
        }


        #region Button click events
        private void btnLogoEllipse_Click(object sender, EventArgs e)
        {
            string sourcePath = "", destPath = "";
            OpenFileDialog op = new OpenFileDialog();

            destPath = Application.StartupPath;

            if (op.ShowDialog() == DialogResult.OK)
            {
                //sourcePath = op.FileName; //= tbLogo.Text =
                sourcePath = Path.GetDirectoryName(op.FileName);
                string fileName = op.FileName.Substring(op.FileName.LastIndexOf(@"\") + 1);

                string sourceFile = Path.Combine(sourcePath, fileName);
                string destFile = Path.Combine(destPath, fileName);
                File.Copy(sourceFile, destFile, true);

                tbLogo.Text = destFile;
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            sqlCommandline();
            SqlCommand sc;

            try
            {
                db.sqlConnect.Open();
                if (dt.Rows.Count == 0)
                {
                    sc = new SqlCommand(@"Insert into dbo.PCompanyDetail (Company_Name , Company_Addr1, Company_Addr2, City, State, GST_NO, Contact_No, Logo) values
                    (@CompName,@CompAddr,@CompAddr2,@GSTNo,@City,@State,@ContactNo,@Logo)", db.sqlConnect);

                    sc.Parameters.AddWithValue("@CompName", tbCompName.Text);
                    sc.Parameters.AddWithValue("@CompAddr", tbAddrLine1.Text);
                    sc.Parameters.AddWithValue("@CompAddr2", tbAddrLine2.Text);
                    sc.Parameters.AddWithValue("@City", tbCity.Text);
                    sc.Parameters.AddWithValue("@State", tbState.Text);
                    sc.Parameters.AddWithValue("@GSTNo", tbGSTNo.Text);
                    sc.Parameters.AddWithValue("@ContactNo", tbContactNo.Text);
                    sc.Parameters.AddWithValue("@Logo", tbLogo.Text);

                    sc.ExecuteNonQuery();
                }
                else if ((string.Compare(CompName, tbCompName.Text) != 0)
                        || (string.Compare(CompaAddr1, tbAddrLine1.Text) != 0)
                        || (string.Compare(GSTNo, tbGSTNo.Text) != 0)
                        || (string.Compare(ContactNo, tbContactNo.Text) != 0)
                        || (string.Compare(CompaAddr2, tbAddrLine2.Text) != 0)
                        || (string.Compare(City, tbCity.Text) != 0)
                        || (string.Compare(State, tbState.Text) != 0)
                        || (string.Compare(Logo, tbLogo.Text) != 0)
                         && (dt.Rows.Count > 0))
                {
                    sc = new SqlCommand(@"Update dbo.PCompanyDetail 
                                  set Company_Name = @CompName, Company_Addr1 = @CompAddr, GST_NO = @GSTNo, Contact_No = @ContactNo,
                                       Company_Addr2 = @CompAddr2, City = @City, State = @State, Logo= @Logo", db.sqlConnect);


                    sc.Parameters.AddWithValue("@CompName", tbCompName.Text);
                    sc.Parameters.AddWithValue("@CompAddr", tbAddrLine1.Text);
                    sc.Parameters.AddWithValue("@CompAddr2", tbAddrLine2.Text);
                    sc.Parameters.AddWithValue("@City", tbCity.Text);
                    sc.Parameters.AddWithValue("@State", tbState.Text);
                    sc.Parameters.AddWithValue("@GSTNo", tbGSTNo.Text);
                    sc.Parameters.AddWithValue("@ContactNo", tbContactNo.Text);
                    sc.Parameters.AddWithValue("@Logo", tbLogo.Text);

                    sc.ExecuteNonQuery();
                }
                closing();
                // this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.sqlConnect.Close();
            }
            //this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            closing();
        }

        #endregion

        private void companyDetail_KeyDown(object sender, KeyEventArgs e)
        
        {
            //if (e.KeyCode == Keys.Escape)
            //    closing();
        }

        #region Key Press events
        private void KeyPress(object sender, KeyEventArgs e)
        {
            // EnterKeyPressed = false;
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                // EnterKeyPressed = true;
            }
        }

        private void tbContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //if (!EnterKeyPressed)
            //{
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            //}
        }
        #endregion


        private void companyDetail_Load(object sender, EventArgs e)
        {
            sqlCommandline();

            if (dt.Rows.Count > 0)
            {
                CompName = tbCompName.Text = dt.Rows[0][1].ToString();
                CompaAddr1 = tbAddrLine1.Text = dt.Rows[0][2].ToString().Trim();
                CompaAddr2 = tbAddrLine2.Text = dt.Rows[0][3].ToString();
                City = tbCity.Text = dt.Rows[0][4].ToString();
                State = tbState.Text = dt.Rows[0][5].ToString(); 
                GSTNo = tbGSTNo.Text = dt.Rows[0][6].ToString();
                ContactNo = tbContactNo.Text = dt.Rows[0][7].ToString();
                Logo = tbLogo.Text = dt.Rows[0][8].ToString();
            }
        }

        private void companyDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            closing();
        }


        public void closing()
        {
            this.Hide();
            this.Parent = null;
            //e.cancel = true;
            
        }

        public void sqlCommandline()
        {
            try
            {
                db.sqlConnect.Open();
                sd = new SqlDataAdapter(@"Select * from dbo.PCompanyDetail", db.sqlConnect);
                dt = new DataTable();
                sd.Fill(dt);
            }
            finally
            {
                db.sqlConnect.Close();
            }
        }
    }
}
