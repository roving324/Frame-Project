using Assambl;
using DC00_assm;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form_List
{
	public partial class Form_Process : Assambl.Base_Form
	{
		UltraGridUtil _GridUtil = new UltraGridUtil();
		public Form_Process()
		{
			InitializeComponent();
		}

		private void Form_Process_Load(object sender, EventArgs e)
		{
			_GridUtil.InitializeGrid(this.grid1);
			_GridUtil.InitColumnUltraGrid(grid1, "PLANT_NM"     , "공장명"      , true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left  , true , false);
			_GridUtil.InitColumnUltraGrid(grid1, "WC_NM"        , "작업장명"    , true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left  , true , false);
			_GridUtil.InitColumnUltraGrid(grid1, "WB_NM"        , "공정명"      , true, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Left  , true , true);
			_GridUtil.InitColumnUltraGrid(grid1, "WB_CD"        , "공정코드"    , true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left  , true , true);
			_GridUtil.InitColumnUltraGrid(grid1, "LINE_TYPE_NM" , "공정구분명"  , true, GridColDataType_emu.VarChar, 160, 160, Infragistics.Win.HAlign.Left  , true , true);
			_GridUtil.InitColumnUltraGrid(grid1, "REMARK"       , "비고"        , true, GridColDataType_emu.VarChar, 80 , 80 , Infragistics.Win.HAlign.Center, true , true);
			_GridUtil.InitColumnUltraGrid(grid1, "USE_YN"       , "사용구분"    , true, GridColDataType_emu.VarChar, 80 , 80 , Infragistics.Win.HAlign.Right , true , true);
			_GridUtil.InitColumnUltraGrid(grid1, "CREATION_DATE", "생성일시"    , true, GridColDataType_emu.VarChar, 90 , 90 , Infragistics.Win.HAlign.Right , true , false);
			_GridUtil.InitColumnUltraGrid(grid1, "CREATION_BY"  , "생성자"      , true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left  , true , false);
			_GridUtil.InitColumnUltraGrid(grid1, "UPDATE_BY"    , "수정자"      , true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left  , true , false);
			_GridUtil.InitColumnUltraGrid(grid1, "PLANT_CD"     , "공장코드"    , true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left  , false, true);
			_GridUtil.InitColumnUltraGrid(grid1, "WC_CD"        , "작업장코드"  , true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left  , false, true);
			_GridUtil.InitColumnUltraGrid(grid1, "LINE_TYPE"    , "공정구분코드", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left  , false, true);
			


			_GridUtil.SetInitUltraGridBind(grid1);

			Mysql.Combo(cboPlantCd, "공장", "PLANT_NM" , "TB_PLANT", "PLANT_CD");
			Mysql.Combo(cboWcCd   , "작업장", "WC_CD"    , "TB_WC");
			Mysql.Combo(cboUse    , "전체", "USE_YN"   , "TB_PLANT");
			Mysql.Combo(cboWB     , "전체", "LWR_CD_NM", "TB_CODE_DTL", "LINE_TYPE", "UPR_CD", "LWR_CD_NM");
			UltraGridUtil.SetComboUltraGrid(grid1, "PLANT_NM"    , Mysql.NCombo("PLANT_CD", "PLANT_NM", "TB_PLANT"));
			UltraGridUtil.SetComboUltraGrid(grid1, "WC_NM"       , Mysql.NCombo("WC_CD", "WC_NM", "TB_WC"));
			UltraGridUtil.SetComboUltraGrid(grid1, "USE_YN"      , Mysql.NCombo("USE_YN", "USE_YN", "TB_PLANT"));
			UltraGridUtil.SetComboUltraGrid(grid1, "LINE_TYPE_NM", Mysql.NCombo("LWR_CD","LWR_CD_NM", "TB_CODE_DTL", "LINE_TYPE", "UPR_CD"));

			this.grid1.DisplayLayout.Override.MergedCellContentArea               = MergedCellContentArea.VisibleRect;
			this.grid1.DisplayLayout.Bands[0].Columns["PLANT_NM"].MergedCellStyle = MergedCellStyle.Always;
			this.grid1.DisplayLayout.Bands[0].Columns["WC_NM"].MergedCellStyle    = MergedCellStyle.Always;
		}

		public override void DoInquire()
		{
			DBHelper helper = new DBHelper();
			SqlDataAdapter Adapter = new SqlDataAdapter("TB_WB_S", helper.sCon);
			Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			Adapter.SelectCommand.Parameters.AddWithValue("@PLANT", cboPlantCd.Value);
			Adapter.SelectCommand.Parameters.AddWithValue("@WORKCODE", cboWcCd.Value);
			Adapter.SelectCommand.Parameters.AddWithValue("@LINE_TYPE", cboWB.Value);
			Adapter.SelectCommand.Parameters.AddWithValue("@USE", cboUse.Value);

			DataTable dtTemp = new DataTable();
			Adapter.Fill(dtTemp);
			grid1.DataSource = dtTemp;
			helper.Close();
		}

		public override void DoNew()
		{
			grid1.DisplayLayout.Bands[0].AddNew();
			grid1.ActiveRow.Cells["PLANT_NM"].IgnoreRowColActivation = true;
			grid1.ActiveRow.Cells["PLANT_NM"].Activation = Activation.AllowEdit;
			grid1.ActiveRow.Cells["WC_NM"].IgnoreRowColActivation = true;
			grid1.ActiveRow.Cells["WC_NM"].Activation = Activation.AllowEdit;
		}

		public override void DoDelete()
		{
			if (MessageBox.Show("삭제하시겠습니까?", "데이터 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
			if (grid1.Rows.Count == 0) return;
			if (grid1.ActiveRow == null) return;	
			DBHelper helper = new DBHelper();
			helper.ExecuteNoneQuery("TB_WB_D", ("@PLANTCODE", Convert.ToString(grid1.ActiveRow.Cells["PLANT_CD"].Value)), ("@WORKCODE", Convert.ToString(grid1.ActiveRow.Cells["WC_CD"].Value))
											 , ("@WOBKCODE", grid1.ActiveRow.Cells["WB_CD"].Text),("@USE", Convert.ToString(grid1.ActiveRow.Cells["USE_YN"].Value)));
			helper.Close();
			DoReset();
			DoInquire();

		}

		private void grid1_ClickCell(object sender, ClickCellEventArgs e)
		{
			
				cboPlantCd.Value = Convert.ToString(grid1.ActiveRow.Cells["PLANT_NM"].Value);
			    cboWcCd.Value    = Convert.ToString(grid1.ActiveRow.Cells["WC_CD"].Value);
			    cboWB.Value      = Convert.ToString(grid1.ActiveRow.Cells["LINE_TYPE_NM"].Value);
				cboUse.Value     = Convert.ToString(grid1.ActiveRow.Cells["USE_YN"].Value);
				txtWB_Cd.Text    = grid1.ActiveRow.Cells["WB_CD"].Text;
				txtWB_Nm.Text    = grid1.ActiveRow.Cells["WB_NM"].Text;
				txtRemark.Value  = grid1.ActiveRow.Cells["REMARK"].Value;
		}

		public override void DoSave()
		{
			DataTable dtTemp = grid1.chkChange();
			string SCODE = "";
			string SWORK = "";
			if (dtTemp == null)
			{
				MessageBox.Show("변경된 내용이 없습니다.");
				return;
			}
			DBHelper helper = new DBHelper();

			foreach (DataRow dr in dtTemp.Rows)
			{
				int[] arry = { dr.Table.Columns.IndexOf("WB_CD"), dr.Table.Columns.IndexOf("PLANT_NM"),
					           dr.Table.Columns.IndexOf("WC_NM"), dr.Table.Columns.IndexOf("WB_NM") };

				foreach (int i in arry)
				{
					if (Convert.ToString(dr[i]) == "")
					{
						MessageBox.Show("값을 입력해 주세요");
						return;
					}
				}
				if (Convert.ToString(dr["PLANT_CD"]) != "")
				{
					SCODE = Convert.ToString(dr["PLANT_CD"]);
				}
				else
				{
					SCODE = Convert.ToString(dr["PLANT_NM"]);
				}

				if (Convert.ToString(dr["WC_CD"]) != "")
				{
					SWORK = Convert.ToString(dr["WC_CD"]);
				}

				else
				{
					SWORK = Convert.ToString(dr["WC_NM"]);
				}
				helper.ExecuteNoneQuery("TB_WB_I", ("@PLANTCODE", SCODE), ("@WORKCODE", SWORK)
										 , ("@WORBNAME", Convert.ToString(dr["WB_NM"])), ("@WORBCODE", Convert.ToString(dr["WB_CD"]))
										 , ("@LINETYPE", Convert.ToString(dr["LINE_TYPE_NM"])), ("@REMARK", Convert.ToString(dr["REMARK"]))
										 , ("@USEYN", Convert.ToString(dr["USE_YN"])));
			}
			helper.Close();
			MessageBox.Show("저장되었습니다.");
			DoReset();
			DoInquire();
		}

		public override void DoReset()
		{
			cboPlantCd.Value = cboWcCd.Value = cboWB.Value = cboUse.Value = txtRemark.Value = txtWB_Cd.Text = txtWB_Nm.Text = "";
		}

		public override void DoExcel()
		{
			try
			{
				//Saving to Excel file. This launches the Save dialog for the user to select the Save Path
				Excel.CreateExcel(Excel.FindSavePath(), grid1);
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
	}
}
