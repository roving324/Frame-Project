using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//sql Server 접속 캘래스 라이브러리
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assambl;
using DC00_assm;
using DC00_Component;
using Telerik.WinControls.UI;
using TestProject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestProject
{
	public partial class Form_Create : Form
	{

		UltraGridUtil GridUtil = new UltraGridUtil(); // 그리드 객체 생성								

		public Form_Create()
		{
			InitializeComponent();
		}
		
		//가입하기
		private void btnForm_Create_Click(object sender, EventArgs e)
		{
			string ID   = txtId.Text;
			string PW   = txtPw.Text;
			string PW1  = txtPw1.Text;
			string Name = txtName.Text;
			string SEX  = ComboSex.Text;
			string PART = ComboPart.Text;
			string RANK = ComboLevel.Text;
			string MS   = "";




			if (ID == "")   MS += "아이디 " ;
			if (PW == "")   MS += "비밀번호 ";
			if (PW1 == "")  MS += "비밀번호 확인 ";
			if (Name == "") MS += "이름 ";
			if (SEX == "")  MS += "성별 ";
			if (PART == "") MS += "부서 ";
			if (RANK == "") MS += "직급 ";
			if (PW != PW1)
			{
				MessageBox.Show("비밀번호와 비밀번호 확인이 다릅니다.");
				return;
			}
			if (MS != "")
			{
				MessageBox.Show($"{MS} 를 입력해 주세요.");
				return;
			}
			if (PW.Length < 6 && PW.Length > 10)
			{
				MessageBox.Show("비밀번호는 6자리 이상 10자리 이하입니다.");
				return;
			}

			string PH = PH1.Text + "-" + PH2.Text + "-" + PH3.Text;

			DBHelper helper = new DBHelper();
			SqlDataAdapter Adapter = new SqlDataAdapter("Create_S1", helper.sCon);
			Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			Adapter.SelectCommand.Parameters.AddWithValue("@ID", ID);
			DataTable dtTemp = new DataTable();
			Adapter.Fill(dtTemp);

			if (dtTemp.Rows.Count > 0)
			{
				helper.Close();
				MessageBox.Show("아이디 중복 입니다.");
				return;
			}
			else
			{
				helper.ExecuteNoneQuery("Create_I1", ("@ID", ID), ("@PW", PW), ("@Name", Name), ("@SEX", SEX)
												   , ("@PHONE", PH), ("@PART", PART), ("@RANK", RANK));
				helper.Close();
				MessageBox.Show(" 가입을 축하합니다.");
				base.Close();
			}




		}

		//취소
		private void btnCancle_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
			{
				e.Handled = true;
				MessageBox.Show("숫자만 입력하세요");
			}
		}

		private void PH_TextChanged(object sender, EventArgs e)
		{
			Infragistics.Win.UltraWinEditors.UltraTextEditor Text = (Infragistics.Win.UltraWinEditors.UltraTextEditor)sender;
			if (Text.Text.Length > 4)
			{
				Text.Text = Text.Text.Substring(0, 4);
				return;
			}
		}

		private void PH1_ValueChanged(object sender, EventArgs e)
		{
			if (PH1.Text.Length > 3)
			{
				PH1.Text = PH1.Text.Substring(0, 3);
				return;
			}
		}
	}
}
