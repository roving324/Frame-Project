using Assambl;
using DC00_assm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form_List
{
	public partial class Form_SubItem : Form
	{
		public Form_SubItem()
		{
			InitializeComponent();
		}

		private void Form_SubItem_Load(object sender, EventArgs e)
		{
			UltraGridUtil _GridUtil = new UltraGridUtil();

			_GridUtil.InitializeGrid(this.grid);
			_GridUtil.InitColumnUltraGrid(grid, "PLANTCODE", "사업장"  , false, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, false);
			_GridUtil.InitColumnUltraGrid(grid, "ITEMTYPE" , "품목타입", false, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, false);
			_GridUtil.InitColumnUltraGrid(grid, "ITEMCODE" , "품목"    , false, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, false);
			_GridUtil.InitColumnUltraGrid(grid, "ITEMNAME" , "품목명"  , false, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Left, true, false);

			_GridUtil.SetInitUltraGridBind(grid);
			Mysql.Combo(cboPlantCode, "전체", "PLANTCODE", "[2022_DC_EDU_KDTB]..TB_ItemMaster", "PLANTCODE", common.sConn2);
			Mysql.Combo(cboItemType, "전체", "ITEMTYPE", "[2022_DC_EDU_KDTB]..TB_ItemMaster", "ITEMTYPE", common.sConn2);
			btnFind_Click();
		}

		private void btnFind_Click(object sender = null, EventArgs e = null)
		{
			DBHelper helper = new DBHelper(false,common.sConn2);
			SqlDataAdapter Adapter = new SqlDataAdapter("ITEMMASTER_S", helper.sCon);

			Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			Adapter.SelectCommand.Parameters.AddWithValue("@PLANTCODE", Convert.ToString(cboPlantCode.Value));
			Adapter.SelectCommand.Parameters.AddWithValue("@ITEMCODE", Convert.ToString(txtItemCode.Text));
			Adapter.SelectCommand.Parameters.AddWithValue("@ITEMNAME", Convert.ToString(txtItemName.Text));
			Adapter.SelectCommand.Parameters.AddWithValue("@ITEMTYPE", Convert.ToString(cboItemType.Value));

			DataTable dtTemp = new DataTable();
			Adapter.Fill(dtTemp);
			grid.DataSource = dtTemp;
			helper.Close();
		}

		private void grid_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
		{
			this.Tag += Convert.ToString(grid.ActiveRow.Cells["ITEMCODE"].Value) + ",";
			this.Tag += Convert.ToString(grid.ActiveRow.Cells["ITEMNAME"].Value) + ",";
			this.Tag += Convert.ToString(grid.ActiveRow.Cells["ITEMTYPE"].Value) + ",";
			this.Close();
		}
	}
}
