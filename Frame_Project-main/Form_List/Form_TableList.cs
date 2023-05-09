using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Assambl;

namespace Form_List
{
    public partial class Form_TableList : Assambl.Base_Form
    {
        public Form_TableList()
        {
            InitializeComponent();
        }
        public override void DoInquire()
        {
            LoadForm LF = new LoadForm();
            try
            {
                
                SqlConnection Connect = new SqlConnection(common.sConn);
                Connect.Open();
                string sSqlSelect = $"SELECT ORDINAL_POSITION, COLUMN_NAME, IS_NULLABLE, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{cboTableName.SelectedValue.ToString()}'";

                SqlDataAdapter adapter = new SqlDataAdapter(sSqlSelect, Connect);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);
                dgvTableCol.DataSource = dtTemp;

                sSqlSelect = $"SELECT * FROM {cboTableName.SelectedValue.ToString()}";
                adapter = new SqlDataAdapter(sSqlSelect, Connect);
                dtTemp = new DataTable();
                adapter.Fill(dtTemp);
                dgvTableRow.DataSource = dtTemp;
                Connect.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                LF.close();
            }
        }

        private void Form_TableList_Load(object sender, EventArgs e)
        {
            SqlConnection Connect  = new SqlConnection(common.sConn);
            Connect.Open();
            string sSqlSelect      = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES ORDER BY TABLE_NAME";
            SqlDataAdapter adapter = new SqlDataAdapter(sSqlSelect, Connect);
            DataTable dtTemp       = new DataTable();
            adapter.Fill(dtTemp);

            cboTableName.DataSource    = dtTemp;
            cboTableName.ValueMember   = "TABLE_NAME";
            cboTableName.DisplayMember = "TABLE_NAME";
            Connect.Close();
        }
    }
}
