using Assambl;
using DC00_assm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infragistics.Win;
using System.Xml.Linq;
using Infragistics.Documents.Excel;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using System.IO;

namespace Form_List
{
	public partial class Form_LoginList : Assambl.Base_Form
	{
		UltraGridUtil _GridUtil = new UltraGridUtil();  //그리드 객체 생성
		public Form_LoginList()
		{
			InitializeComponent();
		}

		private void Form_LoginList_Load(object sender, EventArgs e)
		{
			_GridUtil.InitializeGrid(this.grid1);
			_GridUtil.InitColumnUltraGrid(grid1, "IP"        , "주소"  , false, GridColDataType_emu.VarChar   , 130, 130, Infragistics.Win.HAlign.Left , true, false);
			_GridUtil.InitColumnUltraGrid(grid1, "ID"        , "아이디", false, GridColDataType_emu.VarChar   , 130, 130, Infragistics.Win.HAlign.Left , true, false);
			_GridUtil.InitColumnUltraGrid(grid1, "NAME"      , "이름"  , false, GridColDataType_emu.VarChar   , 120, 120, Infragistics.Win.HAlign.Left , true, false);
			_GridUtil.InitColumnUltraGrid(grid1, "LOGINTIME" , "출근"  , false, GridColDataType_emu.DateTime24, 160, 160, Infragistics.Win.HAlign.Right, true, false);
			_GridUtil.InitColumnUltraGrid(grid1, "LOGOUTTIME", "퇴근"  , false, GridColDataType_emu.DateTime24, 160, 160, Infragistics.Win.HAlign.Right, true, false);


			_GridUtil.SetInitUltraGridBind(grid1);

		}

		public override void DoInquire()
		{
			DBHelper helper = new DBHelper();
			SqlDataAdapter Adapter = new SqlDataAdapter("LoginList_S", helper.sCon);

			Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			Adapter.SelectCommand.Parameters.AddWithValue("@ID", txtId.Text);
			Adapter.SelectCommand.Parameters.AddWithValue("@NAME", txtName.Text);
			Adapter.SelectCommand.Parameters.AddWithValue("@START", string.Format("{0:yyy-MM-dd}", dtStart.Value));
			Adapter.SelectCommand.Parameters.AddWithValue("@END", string.Format("{0:yyy-MM-dd}", dtEnd.Value));


			System.Data.DataTable dtTemp = new System.Data.DataTable();
			Adapter.Fill(dtTemp);
			grid1.DataSource = dtTemp;
			helper.Close();
		}

		public override void DoExcel()
		{
			try
			{
				//Saving to Excel file. This launches the Save dialog for the user to select the Save Path
				Excel.CreateExcel(Excel.FindSavePath(),grid1,ultraGridExcelExporter2);
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