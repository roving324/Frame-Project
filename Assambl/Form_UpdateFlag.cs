using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Assambl
{
    public partial class Form_UpdateFlag : Form
    {
        public Form_UpdateFlag()
        {
            InitializeComponent();
        }
        private void Form_UpdateFlag_Load(object sender, EventArgs e)
        {
            SqlConnection Connect = new SqlConnection(common.sConn);
            // 데이터 베이스 오픈.
            Connect.Open();
            // 2. 품목유형 데이터 리스트 조회 SQL

            string sSqlSelect = $" SELECT M_Num              ";
            sSqlSelect += $"             ,M_Num          ";
            sSqlSelect += $"   FROM Table_File ";
            sSqlSelect += $"    GROUP BY M_Num , Date               ";
            sSqlSelect += "    ORDER BY Date desc                          ";
            SqlDataAdapter adapter = new SqlDataAdapter(sSqlSelect, Connect);
            DataTable dtTemp = new DataTable();
            adapter.Fill(dtTemp);
            Connect.Close();
            cboVersion.DataSource = dtTemp;
            cboVersion.ValueMember = "M_Num";
            cboVersion.DisplayMember = "M_Num";
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(common.sOldVersion == Convert.ToString(cboVersion.SelectedValue))
            {
                MessageBox.Show("현재 버전과 일치 합니다.");
                return;
            }
            var dlr = MessageBox.Show(
                    $"{cboVersion.SelectedValue} 버전을 다운로드 받으시겠습니까??", "알림",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == System.Windows.Forms.DialogResult.Yes)
            {
                common.version = Convert.ToString(cboVersion.SelectedValue);
                var myprocess = new Process();
                Form_ProcessBar Bar = new Form_ProcessBar();
                this.Hide();
                Bar.ShowDialog();
                if (Convert.ToString(Bar.Tag) == "Success")
                {
                    MessageBox.Show("업데이트 되었습니다.");
                }
                else
                {
                    MessageBox.Show("업데이트를 실패했습니다.");
                }
                this.Tag = "True";
                this.Close();
                return;
            }
            else
            {
                this.Close();
                return;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

