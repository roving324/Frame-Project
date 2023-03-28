using Assambl;
using DC00_assm;
using DC00_Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Form_List
{
	public partial class Form_Userlist : Assambl.Base_Form
	{
		UltraGridUtil _GridUtil = new UltraGridUtil();  //그리드 객체 생성
		public Form_Userlist()
		{
			InitializeComponent();
		}

		private void Form_Userlist_Load(object sender, EventArgs e)
		{
			_GridUtil.InitializeGrid(this.grid1);
			_GridUtil.InitColumnUltraGrid(grid1, "ID"    , "아이디"           , true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left  , true, false);
			_GridUtil.InitColumnUltraGrid(grid1, "PW"    , "패스워드"         , true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left  , true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "NAME"  , "이름"             , true, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Left  , true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "PHONE" , "휴대폰번호"       , true, GridColDataType_emu.VarChar, 160, 160, Infragistics.Win.HAlign.Left  , true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "SEX"   , "성별"             , true, GridColDataType_emu.VarChar, 80 , 80 , Infragistics.Win.HAlign.Center, true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "PART"  , "부서"             , true, GridColDataType_emu.VarChar, 80 , 80 , Infragistics.Win.HAlign.Right , true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "RANK"  , "직급"             , true, GridColDataType_emu.VarChar, 90 , 90 , Infragistics.Win.HAlign.Right , true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "FCOUNT", "비밀번호 오류횟수", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left  , true, true);


			_GridUtil.SetInitUltraGridBind(grid1);

			Mysql.Combo(cbopart, "부서", "PART", "TB_USER_R");
			Mysql.Combo(cborank, "직급", "RANK", "TB_USER_R");

		}

		public override void DoInquire()
		{
			DBHelper helper = new DBHelper();
			SqlDataAdapter Adapter = new SqlDataAdapter("USERLIST_S", helper.sCon);
			Adapter.SelectCommand.Parameters.AddWithValue("@NAME", name.Text);
			Adapter.SelectCommand.Parameters.AddWithValue("@PART", cbopart.SelectedItem.DataValue);
			Adapter.SelectCommand.Parameters.AddWithValue("@RANK", cborank.SelectedItem.DataValue);

			Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

			DataTable dtTemp = new DataTable();
			Adapter.Fill(dtTemp);
			grid1.DataSource = dtTemp;
			helper.Close();
		}

		public override void DoSave()
		{
			DataTable dtTemp = grid1.chkChange();
			if (dtTemp == null)
			{
				MessageBox.Show("변경된 내용이 없습니다.");
				return;
			}
			DBHelper helper = new DBHelper();

			foreach (DataRow dr in dtTemp.Rows)
			{
				SqlDataAdapter Adapter = new SqlDataAdapter("USERLIST_I", helper.sCon);
				Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				Adapter.SelectCommand.Parameters.AddWithValue("@ID", Convert.ToString(dr["ID"]));
				Adapter.SelectCommand.Parameters.AddWithValue("@PW", Convert.ToString(dr["PW"]));
				Adapter.SelectCommand.Parameters.AddWithValue("@NAME", Convert.ToString(dr["NAME"]));
				Adapter.SelectCommand.Parameters.AddWithValue("@PHONE", Convert.ToString(dr["PHONE"]));
				Adapter.SelectCommand.Parameters.AddWithValue("@SEX", Convert.ToString(dr["SEX"]));
				Adapter.SelectCommand.Parameters.AddWithValue("@PART", Convert.ToString(dr["PART"]));
				Adapter.SelectCommand.Parameters.AddWithValue("@RANK", Convert.ToString(dr["RANK"]));
				Adapter.SelectCommand.Parameters.AddWithValue("@FCOUNT", Convert.ToString(dr["FCOUNT"]));

				Adapter.Fill(dtTemp);
			}
			helper.Close();
			MessageBox.Show("저장되었습니다.");
			DoInquire();
		}

		public override void DoDelete()
		{
			if (grid1.ActiveRow == null) return;
			string sId = grid1.ActiveRow.Cells["ID"].Value.ToString();

			if (MessageBox.Show("선택한 정보를 삭제 하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				DBHelper helper = new DBHelper();
				helper.ExecuteNoneQuery("USERLIST_D", ("@ID", sId));
				helper.Close();
				DoInquire();
			}

			else return;
		}
	}
}
