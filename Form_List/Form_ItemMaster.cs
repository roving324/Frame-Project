using Assambl;
using DC00_assm;
using DC00_Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form_List
{
	public partial class Form_ItemMaster : Assambl.Base_Form
	{
		public Form_ItemMaster()
		{
			InitializeComponent();
		}

		private void txtItemCode_ButtonClick(object sender, EventArgs e)
		{
			Form_SubItem Item = new Form_SubItem();
			Item.ShowDialog();
			if (Item.Tag == null) return;
			string[] sTag = Item.Tag.ToString().Split(',');
			txtItemCode.Text = sTag[0];
			txtItemName.Text = sTag[1];
			cboItemType.Text = sTag[2];
		}

		private void Form_ItemMaster_Load(object sender, EventArgs e)
		{
			UltraGridUtil _GridUtil = new UltraGridUtil();

			_GridUtil.InitializeGrid(this.grid);
			_GridUtil.InitColumnUltraGrid(grid, "PLANTCODE", "사업장"      , false, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left   , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "ITEMTYPE" , "품목구분"    , false, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left   , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "ITEMCODE" , "품목"        , false, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left   , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "ITEMNAME" , "품목명"      , false, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Left   , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "BASEUNIT" , "단위"        , false, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Left   , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "UNITCOST" , "단가"        , false, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Right  , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "UNITWGT"  , "단위중량"    , false, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Right  , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "ITEMSPEC" , "규격"        , false, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Left   , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "INSPFLAG" , "수입검사여부", false, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Center , true, false);
			_GridUtil.SetInitUltraGridBind(grid);

			Mysql.Combo(cboUseFlag , "사용여부", "USEFLAG", "[2022_DC_EDU_KDTB]..TB_ItemMaster", "USEFLAG", common.sConn2); // "[2022_DC_EDU_KDTB]..TB_ItemMaster" 다른 데이터베이스 조회
			Mysql.Combo(cboItemType, "품목", "ITEMTYPE", "[2022_DC_EDU_KDTB]..TB_ItemMaster", "ITEMTYPE", common.sConn2);
		}

		public override void DoInquire()
		{
			DBHelper helper = new DBHelper(false, common.sConn2);
			SqlDataAdapter Adapter = new SqlDataAdapter("ITEMMASTER_S2", helper.sCon);

			Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			Adapter.SelectCommand.Parameters.AddWithValue("@PLANTCODE", Convert.ToString(txtPlantCode.Value));
			Adapter.SelectCommand.Parameters.AddWithValue("@ITEMCODE" , Convert.ToString(txtItemCode.Text));
			Adapter.SelectCommand.Parameters.AddWithValue("@ITEMNAME" , Convert.ToString(txtItemName.Text));
			Adapter.SelectCommand.Parameters.AddWithValue("@ITEMTYPE" , Convert.ToString(cboItemType.Value));
			Adapter.SelectCommand.Parameters.AddWithValue("@USEFLAG"  , Convert.ToString(cboUseFlag.Value));

			DataTable dtTemp = new DataTable();
			Adapter.Fill(dtTemp);
			grid.DataSource = dtTemp;
			helper.Close();
		}
	}
}
