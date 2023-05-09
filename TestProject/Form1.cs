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

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sConn = "Data Source=222.235.141.8; Initial Catalog=KDTB_2JO; User ID= 2JO ; Password = 1234 ";
        SqlConnection sqlc = new SqlConnection("Data Source=222.235.141.8; Initial Catalog=KDTB_2JO; User ID= 2JO ; Password = 1234 ");
        private void button1_Click(object sender, EventArgs e)
        {


            using (SqlConnection sqlc = new SqlConnection(sConn))
            {
                sqlc.Open();
                string sSqlSelect = " SELECT DB_NAME(dbid) as DBName, COUNT(dbid) as NumberOfConnections,loginame as LoginName, hostname, hostprocess FROM sys.sysprocesses with (nolock) WHERE dbid > 0 GROUP BY dbid, loginame, hostname, hostprocess";
            
                SqlDataAdapter adapter = new SqlDataAdapter(sSqlSelect, sqlc);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);
                dataGridView1.DataSource = dtTemp;
            }

            
            
            //sqlc.Open();
            //string sSqlSelect = " SELECT DB_NAME(dbid) as DBName, COUNT(dbid) as NumberOfConnections,loginame as LoginName, hostname, hostprocess FROM sys.sysprocesses with (nolock) WHERE dbid > 0 GROUP BY dbid, loginame, hostname, hostprocess";
            //
            //SqlDataAdapter adapter = new SqlDataAdapter(sSqlSelect, sqlc);
            //DataTable dtTemp = new DataTable();
            //adapter.Fill(dtTemp);
            //dataGridView1.DataSource = dtTemp;
            
            // 2. 품목유형 데이터 리스트 조회 SQL

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlc = new SqlConnection(sConn);

            sqlc.Open();
            string sSqlSelect = " SELECT DB_NAME(dbid) as DBName, COUNT(dbid) as NumberOfConnections,loginame as LoginName, hostname, hostprocess FROM sys.sysprocesses with (nolock) WHERE dbid > 0 GROUP BY dbid, loginame, hostname, hostprocess";

            SqlDataAdapter adapter = new SqlDataAdapter(sSqlSelect, sqlc);
            DataTable dtTemp = new DataTable();
            adapter.Fill(dtTemp);
            dataGridView1.DataSource = dtTemp;
        }
    }
}
