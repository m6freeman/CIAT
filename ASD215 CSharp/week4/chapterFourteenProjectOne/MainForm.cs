using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapterFourteenProjectOne
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string connectionString = "server=127.0.0.1; Initial Catalog=BankAccount;Integrated Security=false;User ID=SA;Password=********";
        private SqlConnection sqlConnection;
        private SqlDataAdapter dataAdapter;
        //private SqlCommand sqlCommand;
        private DataSet dataSet;
        private void GetList()
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT " +
                                "account_number AS \"Account #\", " +
                                "first_name as \"First Name\", " +
                                "last_name as \"Last Name\", " +
                                "current_balance as Balance " +
                                "FROM Account";
                using (dataAdapter = new SqlDataAdapter(query, sqlConnection))
                {
                    dataSet = new DataSet();
                    if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
                    dataAdapter.Fill(dataSet, "Account");
                    DisplayFullAccountTable_DataGridView.DataSource = dataSet.Tables["Account"];
                }

                sqlConnection.Close();
            }
        }

        private void GetInfo()
        {
            if (this.AccountNumberInput_TextBox.Text.Length > 0)
            {
                try
                {
                    DataTable accountInfo = dataSet.Tables["Account"].Copy()
                                                                 .AsEnumerable()
                                                                 .Where(row => row.Field<int>("Account #") == Int32.Parse(this.AccountNumberInput_TextBox.Text))
                                                                 .CopyToDataTable();
                    Account info = new Account(
                        Int32.Parse(accountInfo.Rows[0][0].ToString()),
                        accountInfo.Rows[0][1].ToString(),
                        accountInfo.Rows[0][2].ToString(),
                        Double.Parse(accountInfo.Rows[0][3].ToString())
                    );
                    this.AccountInformationDisplay_Label.Text = "Hello, " +
                                                                info.FirstName + " " + info.LastName + "\n" +
                                                                "Your current balance is: " +
                                                                Math.Round(info.CurrentBalance, 2).ToString();
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex);
                    this.AccountInformationDisplay_Label.Text = "Invalid Entry";
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void GetAccountInformation_Button_Click(object sender, EventArgs e)
        {
            GetInfo();
        }

    }
}
