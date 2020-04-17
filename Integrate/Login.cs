using Microsoft.SqlServer.Management.Smo;
using Microsoft.Win32;
using System;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrate
{
    public partial class frmLogin : Form
    {
       

        public string user = string.Empty;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void KeyUpPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        #region Login Button clicks


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string adres = System.Reflection.Assembly.GetExecutingAssembly().Location;//GetName().CodeBase;
            //MessageBox.Show(adres);
            dbConnect db = new dbConnect();

            if (string.IsNullOrWhiteSpace(tbUserName.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                if (string.IsNullOrWhiteSpace(tbUserName.Text))
                {
                    MessageBox.Show("Please enter User Name");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(tbPassword.Text))
                {
                    MessageBox.Show("Please enter Password");
                    return;
                }
            }

            SqlDataReader reader ;
            bool hasRow = false;

            try
            {
                using (SqlCommand sCmd = new SqlCommand())
                {
                    
                    string sql = @"SELECT 1 FROM dbo.PUserLogin WHERE userName = @User AND Password = @Password";
                    sCmd.Connection = db.sqlConnect;
                    db.sqlConnect.Open();
                    sCmd.CommandText = sql;
                    sCmd.Parameters.AddWithValue("@User", tbUserName.Text.Trim().ToUpper());
                    sCmd.Parameters.AddWithValue("@Password", tbPassword.Text.Trim().ToUpper());
                    reader = sCmd.ExecuteReader();//sCmd.ExecuteNonQuery();

                    if (reader.HasRows)
                        hasRow = true;
                    else
                        hasRow = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.sqlConnect.Close();
            }

            #region commented code
            //SqlDataAdapter sdt = new SqlDataAdapter(cmd);

            //DataTable dt = new DataTable();

            //sdt.Fill(dt);

            //sqlCon.Open();
            //var i = cmd.ExecuteNonQuery();
            //sqlCon.Close();
            #endregion

            if (hasRow)
            {
                user = tbUserName.Text.Trim();
                this.Hide();
                MainPage MP = new MainPage(user);
               
                //MP.Show();

                MP.WindowState = FormWindowState.Minimized;
                MP.Show(); 
                MP.WindowState = FormWindowState.Maximized;
                // MP.BringToFront();
            }
            else
            {
                MessageBox.Show("Please check the User Name and password");
                tbUserName.Clear();
                tbPassword.Clear();
                return;
            }
        }
        #endregion

        #region First time server feed

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string Conn = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString.ToString();

            Conn = Conn.Split('\\')[0];

            Conn = Conn.Substring((Conn.IndexOf("=", 1) + 1));

            if ((Conn.CompareTo(Environment.MachineName.Trim())) != 0)
            {
                RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
                using (RegistryKey registrtKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
                {
                    RegistryKey instanceKey = registrtKey.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                    if (instanceKey != null)
                    {
                        foreach (var instanceName in instanceKey.GetValueNames())
                        {
                            cbDataSource.Items.Add(Environment.MachineName + "\\" + instanceName);
                        }
                    }
                }
            }
            else
            {
                pnlDataSourceFetch.Visible = false;
                pnlLogMain.Visible = true;
            }
        }


        private void btnServerCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnServerOk_Click(object sender, EventArgs e)
        {
            try

            {

                if (cbDataSource.Text == "")
                {
                    MessageBox.Show("Please enter Server Name.");
                    cbDataSource.Focus();
                    return;
                }

                if (tbInitialCatalog.Text == "")
                {
                    MessageBox.Show("Please enter Database.");
                    tbInitialCatalog.Focus();
                    return;
                }

                if (tbServerUser.Text == "")
                {
                    MessageBox.Show("Please enter Username.");
                    tbServerUser.Focus();
                    return;
                }

                if (tbServerPassword.Text == "")
                {
                    MessageBox.Show("Please enter Password.");
                    tbServerPassword.Focus();
                    return;
                }

                string DBConn = "Data Source={0};Initial Catalog={1};User ID={2};Password={3}";
                DBConn = string.Format(DBConn, cbDataSource.Text, tbInitialCatalog.Text, tbServerUser.Text, tbServerPassword.Text);
 
                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                ConnectionStringsSection connSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connSection.ConnectionStrings["DBConn"].ConnectionString = DBConn;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("AppSettings");

                pnlDataSourceFetch.Visible = false;
                pnlLogMain.Visible = true;
            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion


    }
}


