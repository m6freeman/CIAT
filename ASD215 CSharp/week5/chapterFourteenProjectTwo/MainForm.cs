using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace chapterFourteenProjectTwo
{
    public partial class MainForm : Form
    {
        private string connectionString = "server=127.0.0.1; Initial Catalog=Family;Integrated Security=false;User ID=SA;Password={C#}90manjaro";
        private SqlConnection sqlConnection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        public MainForm()
        {
            InitializeComponent();
        }

        public void MainForm_Load(object sender, EventArgs e) => GetFamilyTable();

        private void GetFamilyTable()
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT " +
                                "memberId AS \"Member ID\", " +
                                "firstName as \"First Name\", " +
                                "lastName as \"Last Name\", " +
                                "relationship as Relationship, " +
                                "hometown as Hometown, " +
                                "age as Age " +
                                "FROM Members";

                using (dataAdapter = new SqlDataAdapter(query, sqlConnection))
                {
                    dataSet = new DataSet();
                    if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
                    dataAdapter.Fill(dataSet, "Members");
                    this.displayFullFamilyTable_DataGridView.DataSource = dataSet.Tables["Members"];
                }

                sqlConnection.Close();
            }
        }

    }
}
