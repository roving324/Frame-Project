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
    public partial class Form_SqlList : Assambl.Base_Form
    {
        public Form_SqlList()
        {
            InitializeComponent();
        }

        public override void DoInquire()
        {
            SqlConnection Connect = new SqlConnection(common.sConn);
            Connect.Open();
            string sSqlSelect      = $"SELECT B.text FROM sys.sysobjects AS A WITH (NOLOCK) INNER JOIN sys.syscomments AS B WITH (NOLOCK) ON A.id = B.id WHERE	A.name = '{cboSql.SelectedValue.ToString()}'";
            SqlDataAdapter adapter = new SqlDataAdapter(sSqlSelect, Connect);
            DataTable dtTemp       = new DataTable();
            adapter.Fill(dtTemp);
            txtSql.Text = Convert.ToString(dtTemp.Rows[0][0]);
            Connect.Close();
        }

        public override void DoSave()
        {
            if (MessageBox.Show("저장하시겠습니까?", "[저장]수정 및 추가", MessageBoxButtons.YesNo) == DialogResult.No) return;
            SqlConnection Connect = new SqlConnection(common.sConn);
            try
            {
                Connect.Open();
                bool bDelFlag = false;
                string sDel = txtSql.Text.Trim();
                sDel = sDel.ToUpper();
                if (sDel.StartsWith("DROP")) bDelFlag = true;
                SqlDataAdapter adapter = new SqlDataAdapter(txtSql.Text, Connect);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);

                if (bDelFlag)
                {
                    Form_SqlList_Load();
                    cboSql.SelectedIndex = 0;
                }
                else DoInquire();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connect.Close();
            }
            
        }

        public override void DoReset()
        {
            txtSql.Clear();
        }

        private void Form_SqlList_Load(object sender = null, EventArgs e = null)
        {
            SqlConnection Connect = new SqlConnection(common.sConn);
            Connect.Open();
            string sSqlSelect      = "SELECT ROUTINE_NAME FROM INFORMATION_SCHEMA.ROUTINES ORDER BY ROUTINE_NAME";
            SqlDataAdapter adapter = new SqlDataAdapter(sSqlSelect, Connect);
            DataTable dtTemp       = new DataTable();
            adapter.Fill(dtTemp);

            cboSql.DataSource    = dtTemp;
            cboSql.ValueMember   = "ROUTINE_NAME";
            cboSql.DisplayMember = "ROUTINE_NAME";
            Connect.Close();
        }
    }
}
