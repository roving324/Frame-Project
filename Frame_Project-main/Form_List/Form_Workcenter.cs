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
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Form_List
{
	public partial class Form_Workcenter : Assambl.Base_Form
	{
		UltraGridUtil _GridUtil = new UltraGridUtil();  //그리드 객체 생성
		public Form_Workcenter()
		{
			InitializeComponent();
		}

		private void Form_Workcenter_Load(object sender, EventArgs e)
		{
			_GridUtil.InitializeGrid(this.grid1);
			_GridUtil.InitColumnUltraGrid(grid1, "PLANT_CD"   , "공장코드"  , true, GridColDataType_emu.VarChar,  80 , 80 , Infragistics.Win.HAlign.Right , false, false);
			_GridUtil.InitColumnUltraGrid(grid1, "PLANT_NM"   , "공장이름"  , true, GridColDataType_emu.VarChar, 160, 160, Infragistics.Win.HAlign.Right , true , false);
			_GridUtil.InitColumnUltraGrid(grid1, "WC_NM"      , "작업장명"  , true, GridColDataType_emu.VarChar, 160, 160, Infragistics.Win.HAlign.Right , true , true);
			_GridUtil.InitColumnUltraGrid(grid1, "WC_CD"      , "작업장코드", true, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Right , true , true);
			_GridUtil.InitColumnUltraGrid(grid1, "USE_YN"     , "사용구분"  , true, GridColDataType_emu.VarChar,  80 , 80 , Infragistics.Win.HAlign.Center, true , true);
			_GridUtil.InitColumnUltraGrid(grid1, "CREATION_BY", "생성자"    , true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Center, true , false);
			_GridUtil.InitColumnUltraGrid(grid1, "UPDATE_BY"  , "수정자"    , true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Center, true , false);
			_GridUtil.SetInitUltraGridBind(grid1);
			

			Mysql.Combo(cboPlantCd, "공장", "PLANT_NM", "TB_PLANT");
			Mysql.Combo(cboUse    , "전체", "USE_YN"  , "TB_PLANT");
			UltraGridUtil.SetComboUltraGrid(grid1, "PLANT_NM", Mysql.NCombo("PLANT_CD","PLANT_NM", "TB_PLANT"));
			UltraGridUtil.SetComboUltraGrid(grid1, "USE_YN"  , Mysql.NCombo("USE_YN","USE_YN", "TB_PLANT"));

			this.grid1.DisplayLayout.Override.MergedCellContentArea               = MergedCellContentArea.VisibleRect;
			this.grid1.DisplayLayout.Bands[0].Columns["PLANT_NM"].MergedCellStyle = MergedCellStyle.Always;
			this.grid1.DisplayLayout.Bands[0].Columns["PLANT_CD"].MergedCellStyle = MergedCellStyle.Always;
		}

		public override void DoInquire()
		{
			try
			{
				DBHelper helper = new DBHelper();
				SqlDataAdapter Adapter = new SqlDataAdapter("PLANT_S", helper.sCon);



				Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				Adapter.SelectCommand.Parameters.AddWithValue("@PLANT", cboPlantCd.Value);
				Adapter.SelectCommand.Parameters.AddWithValue("@WORKCODE", txtWcCd.Text);
				Adapter.SelectCommand.Parameters.AddWithValue("@WORKNAME", txtWcCdNm.Text);
				Adapter.SelectCommand.Parameters.AddWithValue("@USE", cboUse.Value);


				DataTable dtTemp = new DataTable();
				Adapter.Fill(dtTemp);
				grid1.DataSource = dtTemp;
				helper.Close();
			}
			catch
			{
				MessageBox.Show("데이터가 존재하지 않습니다.");
			}
		}

		private void grid1_ClickCell(object sender, Infragistics.Win.UltraWinGrid.ClickCellEventArgs e)
		{
			cboPlantCd.Value = Convert.ToString(grid1.ActiveRow.Cells["PLANT_NM"].Value);
			txtWcCd.Text     = grid1.ActiveRow.Cells["WC_CD"].Text;
			txtWcCdNm.Text   = grid1.ActiveRow.Cells["WC_NM"].Text;
			cboUse.Value     = grid1.ActiveRow.Cells["USE_YN"].Value;
		}

		public override void DoNew()
		{
			grid1.DisplayLayout.Bands[0].AddNew();
			grid1.ActiveRow.Cells["PLANT_NM"].IgnoreRowColActivation = true;
			grid1.ActiveRow.Cells["PLANT_NM"].Activation = Activation.AllowEdit;

		}
		public override void DoDelete()
		{
			if (MessageBox.Show("삭제하시겠습니까?", "데이터 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
			if (grid1.Rows.Count == 0)   return;
			if (grid1.ActiveRow == null) return;
			DBHelper helper = new DBHelper();
			helper.ExecuteNoneQuery("TB_WC_D", "@PLANTCODE", grid1.ActiveRow.Cells["PLANT_CD"].Text, "@WORKCODE", grid1.ActiveRow.Cells["WC_CD"].Text);
			helper.Close();
			DoReset();
			DoInquire();

		}

		public override void DoSave()
		{
			string SCODE = "";
			DataTable dtTemp = grid1.chkChange();


			if (dtTemp == null)
			{
				MessageBox.Show("변경된 내용이 없습니다.");
				return;
			}
			DBHelper helper = new DBHelper();

			foreach (DataRow dr in dtTemp.Rows)
			{
				int[] arry = { dr.Table.Columns.IndexOf("WC_NM"), dr.Table.Columns.IndexOf("USE_YN"),
							   dr.Table.Columns.IndexOf("WC_CD"), dr.Table.Columns.IndexOf("PLANT_NM") };
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

				helper.ExecuteNoneQuery("TB_WC_I", "@PLANTCODE", SCODE, "@WORKCODE", Convert.ToString(dr["WC_CD"])
										 , "@WORKNAME", Convert.ToString(dr["WC_NM"]), "@USE_YN", Convert.ToString(dr["USE_YN"]));
			}
			helper.Close();
			MessageBox.Show("저장되었습니다.");
			DoReset();
			DoInquire();
		}

		public override void DoReset()
		{
			cboPlantCd.Value = cboUse.Value = txtWcCd.Text = txtWcCdNm.Text = "";
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
