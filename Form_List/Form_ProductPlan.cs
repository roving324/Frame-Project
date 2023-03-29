using Assambl;
using DC00_assm;
using DC00_Component;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form_List
{
	public partial class Form_ProductPlan : Assambl.Base_Form
	{
		public Form_ProductPlan()
		{
			InitializeComponent();
		}

		private void Form_ProductPlan_Load(object sender, EventArgs e)
		{
			UltraGridUtil _GridUtil = new UltraGridUtil();
			_GridUtil.InitializeGrid(grid);
			_GridUtil.InitColumnUltraGrid(grid, "PLANTCODE"     , "공장"        , GridColDataType_emu.VarChar   , 100, HAlign.Left  , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "PLANNO"        , "생산계획번호", GridColDataType_emu.VarChar   , 130, HAlign.Center, true, false);
			_GridUtil.InitColumnUltraGrid(grid, "ITEMCODE"      , "생산품목"    , GridColDataType_emu.VarChar   , 150, HAlign.Left  , true, true);
			_GridUtil.InitColumnUltraGrid(grid, "PLANQTY"       , "게획수량"    , GridColDataType_emu.Double    ,  80, HAlign.Right , true, true);
			_GridUtil.InitColumnUltraGrid(grid, "UNITCODE"      , "단위"        , GridColDataType_emu.VarChar   ,  80, HAlign.Left  , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "CHK"           , "확정"        , GridColDataType_emu.CheckBox  ,  80, HAlign.Center, true, true);
			_GridUtil.InitColumnUltraGrid(grid, "WORKCENTERCODE", "작업장"      , GridColDataType_emu.VarChar   , 150, HAlign.Left  , true, true);
			_GridUtil.InitColumnUltraGrid(grid, "ORDERNO"       , "작업지시번호", GridColDataType_emu.VarChar   , 130, HAlign.Center, true, false);
			_GridUtil.InitColumnUltraGrid(grid, "ORDERTEMP"     , "확정일시"    , GridColDataType_emu.DateTime24, 150, HAlign.Left  , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "ORDERWORKER"   , "확정자"      , GridColDataType_emu.VarChar   , 100, HAlign.Left  , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "ORDERCLOSEFLAG", "지시종료여부", GridColDataType_emu.VarChar   , 100, HAlign.Left  , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "ORDERCLOSEDATE", "지시종료일시", GridColDataType_emu.DateTime24, 150, HAlign.Left  , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "MAKEDATE"      , "등록일시"    , GridColDataType_emu.DateTime24, 150, HAlign.Left  , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "MAKER"         , "등록자"      , GridColDataType_emu.VarChar   , 100, HAlign.Left  , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "EDITDATE"      , "수정일시"    , GridColDataType_emu.DateTime24, 150, HAlign.Left  , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "EDITOR"        , "수정자"      , GridColDataType_emu.VarChar   , 100, HAlign.Left  , true, false);
			_GridUtil.SetInitUltraGridBind(grid);
		}

		public override void DoNew()
		{
			grid.DisplayLayout.Bands[0].AddNew();
			grid.ActiveRow.Cells["PLANTCODE"].IgnoreRowColActivation = true;
			grid.ActiveRow.Cells["PLANTCODE"].Activation = Activation.AllowEdit;
		}

		public override void DoInquire()
		{
			DBHelper helper = new DBHelper();
			helper.ExecuteNoneQuery("PRODUCT_PLAN_S", ("@PLANTCODE", Convert.ToString(cboPlantCode.Value)), ("@ORDERNO", Convert.ToString(txtProductNum.Text)), ("@WORKCENTERCODE", Convert.ToString(cboWCC.Value)), ("@ITEMCODE", Convert.ToString(cboItemCode.Value)), ("@ORDERCLOSEFLAG", Convert.ToString(cboUseFlag.Value)));
		}

		public override void DoSave()
		{
			
		}

	}
}
