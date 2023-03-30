using Assambl;
using DC00_assm;
using DC00_Component;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
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
			_GridUtil.InitColumnUltraGrid(grid, "ORDERCLOSEFLAG", "지시종료여부", GridColDataType_emu.CheckBox  , 100, HAlign.Left  , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "ORDERCLOSEDATE", "지시종료일시", GridColDataType_emu.YearMonthDay, 150, HAlign.Center, true, false);
			_GridUtil.InitColumnUltraGrid(grid, "MAKEDATE"      , "등록일시"    , GridColDataType_emu.YearMonthDay, 150, HAlign.Center, true, false);
			_GridUtil.InitColumnUltraGrid(grid, "MAKER"         , "등록자"      , GridColDataType_emu.VarChar   , 100, HAlign.Left  , true, false);
			_GridUtil.InitColumnUltraGrid(grid, "EDITDATE"      , "수정일시"    , GridColDataType_emu.YearMonthDay, 150, HAlign.Center, true, false);
			_GridUtil.InitColumnUltraGrid(grid, "EDITOR"        , "수정자"      , GridColDataType_emu.VarChar   , 100, HAlign.Left  , true, false);
			_GridUtil.SetInitUltraGridBind(grid);

			Mysql.Combo(cboPlantCode, "공장"    , "PLANTCODE"     , "TB_PRODUCT_PLAN");
			Mysql.Combo(cboWCC      , "작업장"  , "WORKCENTERCODE", "TB_PRODUCT_PLAN");
			Mysql.Combo(cboCHK      , "확정여부", "CHK"           , "TB_PRODUCT_PLAN");
			Mysql.Combo(cboItemCode , "품목"    , "ITEMCODE"      , "TB_PRODUCT_PLAN");

			UltraGridUtil.SetComboUltraGrid(grid, "PLANTCODE", Mysql.NCombo("PLANTCODE", "PLANTCODE", "[2022_DC_EDU_KDTB]..TB_ItemMaster",common.sConn2));
			UltraGridUtil.SetComboUltraGrid(grid, "ITEMCODE", Mysql.NCombo("ITEMCODE", "ITEMCODE", "[2022_DC_EDU_KDTB]..TB_ItemMaster", common.sConn2));
			UltraGridUtil.SetComboUltraGrid(grid, "WORKCENTERCODE", Mysql.NCombo("WORKCENTERCODE", "WORKCENTERCODE", "TB_PRODUCT_PLAN"));
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
			SqlDataAdapter Adapter = new SqlDataAdapter("PRODUCT_PLAN_S", helper.sCon);

			Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			Adapter.SelectCommand.Parameters.AddWithValue("@PLANTCODE", Convert.ToString(cboPlantCode.Value));
			Adapter.SelectCommand.Parameters.AddWithValue("@ORDERNO", Convert.ToString(txtProductNum.Text));
			Adapter.SelectCommand.Parameters.AddWithValue("@ITEMCODE", Convert.ToString(cboItemCode.Value));
			Adapter.SelectCommand.Parameters.AddWithValue("@WORKCENTERCODE", Convert.ToString(cboWCC.Value));
			Adapter.SelectCommand.Parameters.AddWithValue("@ORDERCLOSEFLAG", Convert.ToString(cboCHK.Value));

			DataTable dtTemp = new DataTable();
			Adapter.Fill(dtTemp);
			grid.DataSource = dtTemp;
			helper.Close();
		}

		public override void DoSave()
		{
			string i = "";
			DBHelper helper = new DBHelper(true);

			DataTable dtTemp = ((DataTable)grid.DataSource).GetChanges();


			if (dtTemp == null)
			{
				MessageBox.Show("저장할 내역이 없습니다.");
				return;
			}

			try
			{
				foreach (DataRow drRow in dtTemp.Rows)
				{
					switch (drRow.RowState)
					{
						case DataRowState.Deleted:
							drRow.RejectChanges();
							helper.ExecuteNoneQuery("PRODUCT_PLAN_D", ("@PLANTCODE", drRow["PLANTCODE"].ToString()), ("@PLANNO", drRow["PLANNO"].ToString()));
							break;
						case DataRowState.Added:
							if (Convert.ToString(drRow["PLANTCODE"]) == "") throw new Exception("공장 코드를 입력하지 않았습니다.");
							if (Convert.ToString(drRow["ORDERNO"]) != "") throw new Exception("삭제 후 진행하시기 바랍니다.");
							
							
							helper.ExecuteNoneQuery("PRODUCT_PLAN_I", ("@PLANTCODE", drRow["PLANTCODE"].ToString()), ("@ITEMCODE", drRow["ITEMCODE"].ToString()), ("@WORKCENTERCODE", drRow["WORKCENTERCODE"].ToString()), ("@ID", common.sID), ("@CHK","True"), ("@ORDERCLOSEFLAG", ""), ("@PLANNO", "")); 
							break;
						case DataRowState.Modified:
							if (Convert.ToString(drRow["CHK"]) == "") i = "False";
							else
							{
								if (Convert.ToBoolean(drRow["CHK"])) i = "True";
								else i = "False";
							}
							helper.ExecuteNoneQuery("PRODUCT_PLAN_I", ("@PLANTCODE", drRow["PLANTCODE"].ToString()), ("@ITEMCODE", drRow["ITEMCODE"].ToString()), ("@WORKCENTERCODE", drRow["WORKCENTERCODE"].ToString()), ("@ID", common.sID), ("@CHK", i), ("@ORDERCLOSEFLAG", drRow["ORDERCLOSEFLAG"].ToString()), ("@PLANNO", drRow["PLANNO"].ToString()));
							break;
					}
				}
				helper.Commit();
				MessageBox.Show("정상적으로 등록을 완료 하였습니다.");

			}
			catch (Exception ex)
			{
				helper.Rollback();
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				helper.Close();
				DoInquire();
			}
		}

		public override void DoExcel()
		{
			try
			{
				//Saving to Excel file. This launches the Save dialog for the user to select the Save Path
				Excel.CreateExcel(Excel.FindSavePath(), grid);
			}
			catch (Exception ex)
			{
				//Handle Exception
				MessageBox.Show(ex.Message);
			}
			finally
			{
				//Any cleanup code
				this.Cursor = Cursors.Default;

			}
		}

		public override void DoDelete()
		{
			if (Convert.ToString(grid.ActiveRow.Cells["CHK"]) == "True")
			{ 
				MessageBox.Show("확정된 계획이므로 삭제할 수 없습니다.");
				return;
			}
			grid.ActiveRow.Delete();
		}

	}
}
