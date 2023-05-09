using Assambl;
using DC00_assm;
using DC00_Component;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Form_List
{
	public partial class Form_Part : Assambl.Base_Form
	{
		UltraGridUtil _GridUtil = new UltraGridUtil();  //그리드 객체 생성
		public Form_Part()
		{
			InitializeComponent();
			_GridUtil.InitializeGrid(this.grid1);
			_GridUtil.InitColumnUltraGrid(grid1, "PART_NO", "품목코드", true, GridColDataType_emu.VarChar, 80, 80, Infragistics.Win.HAlign.Right, true, false);
			_GridUtil.InitColumnUltraGrid(grid1, "PART_NM", "품목명", true, GridColDataType_emu.VarChar, 160, 160, Infragistics.Win.HAlign.Right, true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "OBTAIN_NM2", "MODEL", true, GridColDataType_emu.VarChar, 160, 160, Infragistics.Win.HAlign.Right, true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "QUALITY2", "재질", true, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Right, true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "PART_SPEC", "SPEC", true, GridColDataType_emu.VarChar, 80, 80, Infragistics.Win.HAlign.Center, true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "UNIT", "단위", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Center, true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "MTRL_TYPE2", "자재유형", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Center, true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "MTRL_NO2", "제품유형명", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Center, true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "PMKG", "중량", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Center, true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "REMARK", "비고", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Center, true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "USE_YN", "사용구분", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Center, true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "CREATION_DATE", "생성일시", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Center, true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "CREATION_BY", "생성자", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Center, true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "UPDATE_DATE", "수정일시", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Center, true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "UPDATE_BY", "수정자", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Center, true, true);
			_GridUtil.InitColumnUltraGrid(grid1, "MTRL_NO_NM", "수정자", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Center, false, true);
			_GridUtil.InitColumnUltraGrid(grid1, "QUALITY", "수정자", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Center, false, true);
			_GridUtil.InitColumnUltraGrid(grid1, "OBTAIN_NM", "수정자", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Center, false, true);
			_GridUtil.InitColumnUltraGrid(grid1, "MTRL_TYPE", "수정자", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Center, false, true);
			_GridUtil.SetInitUltraGridBind(grid1);
			

			Mysql.Combo(cboSMtrlTP, "전체", "LWR_CD_NM", "TB_CODE_DTL", "MTRL_TYPE", "UPR_CD", "LWR_CD");
			Mysql.Combo(cboSMtrlNO, "전체", "LWR_CD_NM", "TB_CODE_DTL", "MTRL_NO"  , "UPR_CD", "LWR_CD");
			Mysql.Combo(cboSUseYN, "전체", "LWR_CD_NM", "TB_CODE_DTL" , "USYN"     , "UPR_CD", "LWR_CD");
			Mysql.Combo(cboSUseYN, "전체", "LWR_CD_NM", "TB_CODE_DTL" , "USYN"     , "UPR_CD", "LWR_CD");
			//Mysql.Combo(cboUse, "전체", "USE_YN", "TB_PLANT");
			//Mysql.Combo(cboUse, "전체", "USE_YN", "TB_PLANT");


			UltraGridUtil.SetComboUltraGrid(grid1, "OBTAIN_NM2" , Mysql.NCombo("LWR_CD", "LWR_CD_NM", "TB_CODE_DTL", "OBTAIN", "UPR_CD"));
			UltraGridUtil.SetComboUltraGrid(grid1, "UNIT"      , Mysql.NCombo("LWR_CD", "LWR_CD_NM", "TB_CODE_DTL", "UNIT", "UPR_CD"));
			UltraGridUtil.SetComboUltraGrid(grid1, "MTRL_TYPE2" , Mysql.NCombo("LWR_CD", "LWR_CD_NM", "TB_CODE_DTL", "MTRL_TYPE", "UPR_CD"));
			UltraGridUtil.SetComboUltraGrid(grid1, "MTRL_NO2", Mysql.NCombo("LWR_CD", "LWR_CD_NM", "TB_CODE_DTL", "MTRL_NO", "UPR_CD"));
			UltraGridUtil.SetComboUltraGrid(grid1, "QUALITY2"   , Mysql.NCombo("LWR_CD", "LWR_CD_NM", "TB_CODE_DTL", "QUALITY", "UPR_CD"));
			UltraGridUtil.SetComboUltraGrid(grid1, "USE_YN"    , Mysql.NCombo("USE_YN", "USE_YN", "TB_PLANT"));

		}

		public override void DoInquire()
		{
			DBHelper helper = new DBHelper();
			SqlDataAdapter Adapter = new SqlDataAdapter("PART_S", helper.sCon);

			
			Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			Adapter.SelectCommand.Parameters.AddWithValue("@PART_NO", txtSItemCd.Text);
			Adapter.SelectCommand.Parameters.AddWithValue("@PART_NM", txtSItemNm.Text);
			Adapter.SelectCommand.Parameters.AddWithValue("@LWR_CD_NM", cboSMtrlTP.Value);
			Adapter.SelectCommand.Parameters.AddWithValue("@LWR_CD_NM2", cboSMtrlNO.Value);
			Adapter.SelectCommand.Parameters.AddWithValue("@USE_YN", cboSUseYN.Value);


			DataTable dtTemp = new DataTable();
			Adapter.Fill(dtTemp);
			grid1.DataSource = dtTemp;
			helper.Close();
		}

		private void grid1_ClickCell(object sender, Infragistics.Win.UltraWinGrid.ClickCellEventArgs e)
		{
			//txtSItemCd.Text = grid1.ActiveRow.Cells["PART_NO"].Text;
			//txtSItemNm.Text = grid1.ActiveRow.Cells["PART_NM"].Text;
			//cboSMtrlTP.Value = grid1.ActiveRow.Cells["MTRL_TYPE"].Value;
			//cboSMtrlNO.Value = grid1.ActiveRow.Cells["MTRL_NO_NM"].Value;
			//cboSUseYN.Value = grid1.ActiveRow.Cells["USE_YN"].Value;

		}

		public override void DoNew()
		{
			grid1.DisplayLayout.Bands[0].AddNew();
			grid1.ActiveRow.Cells["PART_NO"].IgnoreRowColActivation = true;
			grid1.ActiveRow.Cells["PART_NO"].Activation = Activation.AllowEdit;

		}

		public override void DoReset()
		{
			cboSMtrlTP.Value = cboSMtrlNO.Value = cboSUseYN.Value = txtSItemCd.Text = txtSItemNm.Text = "";
			DoInquire();
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
				int[] arry = { dr.Table.Columns.IndexOf("PART_NO"), dr.Table.Columns.IndexOf("PART_NM"),
							   dr.Table.Columns.IndexOf("OBTAIN_NM2"), dr.Table.Columns.IndexOf("QUALITY2"),
							   dr.Table.Columns.IndexOf("PART_SPEC"), dr.Table.Columns.IndexOf("UNIT"),
							   dr.Table.Columns.IndexOf("MTRL_TYPE2"), dr.Table.Columns.IndexOf("MTRL_NO2"),
							   dr.Table.Columns.IndexOf("PMKG"), dr.Table.Columns.IndexOf("USE_YN"),
							   dr.Table.Columns.IndexOf("REMARK")};
				foreach (int i in arry)
				{
					if (Convert.ToString(dr[i]) == "")
					{
						MessageBox.Show("값을 입력해 주세요");
						return;
					}
				}


				

				helper.ExecuteNoneQuery("TB_PART_I", "@PART_NO", Convert.ToString(dr["PART_NO"]), "@PART_NM", Convert.ToString(dr["PART_NM"])
										 , "@OBTAIN", Convert.ToString(dr["OBTAIN_NM2"]), "@QUALITY", Convert.ToString(dr["QUALITY2"])
										 , "@PART_SPEC", Convert.ToString(dr["PART_SPEC"]), "@UNIT", Convert.ToString(dr["UNIT"])
										 , "@MTRL_TYPE", Convert.ToString(dr["MTRL_TYPE2"]), "@MTRL_NO", Convert.ToString(dr["MTRL_NO2"])
										 , "@REMARK", Convert.ToString(dr["REMARK"]), "@USE_YN", Convert.ToString(dr["USE_YN"])
										 , "@PMKG", Convert.ToString(dr["PMKG"]));
			}
			helper.Close();
			MessageBox.Show("저장되었습니다.");
			DoReset();
			DoInquire();
		}

		public override void DoDelete()
		{
			if (MessageBox.Show("삭제하시겠습니까?", "데이터 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
			if (grid1.Rows.Count == 0) return;
			if (grid1.ActiveRow == null) return;
			DBHelper helper = new DBHelper();
			helper.ExecuteNoneQuery("TB_PART_D", "@PART_NO", grid1.ActiveRow.Cells["PART_NO"].Text);
			helper.Close();
			DoReset();
			DoInquire();

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
