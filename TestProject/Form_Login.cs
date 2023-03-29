using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DC00_assm;
using Assambl;
using System.Data.SqlClient;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace TestProject
{
	public partial class Form_Login : Form
	{
		UltraGridUtil _GridUtil = new UltraGridUtil();  //그리드 객체 생성
		public Form_Login()
		{
			InitializeComponent();

		}

		private void Form_Login_Load(object sender, EventArgs e)
		{
			DBHelper helper = new DBHelper();

			SqlDataAdapter Adapter = new SqlDataAdapter("LoginList_S2", helper.sCon);
			Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			Adapter.SelectCommand.Parameters.AddWithValue("@IP", GetLocalIP());
			DataTable dtTemp = new DataTable();
			Adapter.Fill(dtTemp);
			helper.Close();
			if (dtTemp.Rows.Count > 0)
			{
				common.sID = dtTemp.Rows[0]["ID"].ToString();
				base.Tag = true;    // 로그인 확인 여부
				this.Close();
				MessageBox.Show("로그인 되었습니다.");
				return;
			}
			base.Tag = false;
			ID.Appearance.ForeColor = Color.Gray;
			PW.Appearance.ForeColor = Color.Gray;
		}

		private void BtnCreate_Click(object sender, EventArgs e)
		{
			Form_Create create = new Form_Create();
			base.Hide();
			create.ShowDialog();
			base.Show();
		}

		private string GetLocalIP() // IP 주소 가져오기
		{
			string myIP = "";
			IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

			foreach (IPAddress ip in host.AddressList)
			{
				if (ip.AddressFamily == AddressFamily.InterNetwork)
				{
					myIP = ip.ToString();
				}
			}

			return myIP;
		}

		private void BtnLogin_Click(object sender = null, EventArgs e = null)
		{
			if (ID.Text == "" || PW.Text == "")
			{
				return;
			}
			DBHelper helper = new DBHelper();

			SqlDataAdapter Adapter3 = new SqlDataAdapter("Login_S1", helper.sCon);
			Adapter3.SelectCommand.CommandType = CommandType.StoredProcedure;
			Adapter3.SelectCommand.Parameters.AddWithValue("@ID", ID.Text);
			DataTable dtTemp3 = new DataTable();
			Adapter3.Fill(dtTemp3);
			if (dtTemp3.Rows.Count == 0)
			{
				MessageBox.Show("아이디가 존재하지 않습니다.");
				return;
			}
			if (Convert.ToInt32(dtTemp3.Rows[0]["FCOUNT"]) > 2)
			{
				MessageBox.Show("비밀번호 오류횟수 3회 이상입니다. 관리자에게 문의하세요.");
				return;
			}

			DataTable dtTemp = new DataTable();
			SqlDataAdapter Adapter = new SqlDataAdapter("Login_S", helper.sCon);
			Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			Adapter.SelectCommand.Parameters.AddWithValue("@ID", ID.Text);
			Adapter.SelectCommand.Parameters.AddWithValue("@PW", PW.Text);

			Adapter.Fill(dtTemp);


			if (dtTemp.Rows.Count > 0)
			{
				common.sID = ID.Text;
				string ip = GetLocalIP();
				helper.ExecuteNoneQuery("LoginList_I", ("@IP", ip), ("@ID", ID.Text));
			}
			else
			{
				helper.ExecuteNoneQuery("Login_U", ("@ID", ID.Text));

				PW.Text = "";
				MessageBox.Show("아이디 및 비밀번호 확인 바랍니다.");
				return;
			}
			helper.Close();
			MessageBox.Show("로그인 되었습니다.");
			base.Tag = true;
			base.Close();
		}

		private void PW_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				BtnLogin_Click();
			}
		}


		// HTML 의 Placeholder 기능 구현
		private void BeforeExitEditMode(object sender, Infragistics.Win.BeforeExitEditModeEventArgs e)
		{
			Infragistics.Win.UltraWinEditors.UltraTextEditor TextTitle = (Infragistics.Win.UltraWinEditors.UltraTextEditor)sender; // UltraTextEditor 로 객체화
			if (TextTitle.Text == "")
			{
				if (TextTitle.Name == "ID")
				{
					ID.Text = "ID";
					ID.Appearance.ForeColor = Color.Gray;
				}
				else if (TextTitle.Name == "PW")
				{
					PW.Text = "PW";
					PW.PasswordChar = default(char);        // 패스워드문자 초기화('')
					PW.Appearance.ForeColor = Color.Gray;
				}

			}
		}

		// HTML 의 Placeholder 기능 구현
		private void BeforeEnterEditMode(object sender, CancelEventArgs e)
		{
			Infragistics.Win.UltraWinEditors.UltraTextEditor TextTitle = (Infragistics.Win.UltraWinEditors.UltraTextEditor)sender;

			if (TextTitle.Appearance.ForeColor == Color.Gray)
			{
				if (TextTitle.Text == "ID")
				{
					ID.Text = "";
					ID.Appearance.ForeColor = Color.Black;
				}
				else if (TextTitle.Text == "PW")
				{
					PW.Text = "";
					PW.PasswordChar = '*';
					PW.Appearance.ForeColor = Color.Black;
				}

			}
		}
	}
}
