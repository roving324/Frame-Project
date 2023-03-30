using System;
using Assambl;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DC00_assm;
using DC00_Component;
using DC00_Component.Properties;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinDock;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Documents.Excel;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Assambl
{
	public static class common
	{
		public const string sConn = "Data Source=222.235.141.8; Initial Catalog=KDTB_2JO; User ID= 2JO ; Password = 1234 ";
		public const string sConn2 = "Data Source=222.235.141.8; Initial Catalog=KDTB_1JO; User ID= 1JO ; Password = 1234 ";
		public static string sID = "";
	}


	// Transaction 사용법
	// 테이블 첫 번째 컬럼은 int, 증가 컬럼 사용
	// 아래에 있는 모든 주석 풀기
	// DBHelper helper = new DBHelper(true)
	// helper.open()
	// helper.Transaction()
	// helper.commit()
	// helper.Rollback()

	public class DBHelper
	{
		DataTable odtTemp = new DataTable();
		//string oTable = "";
		public SqlConnection sCon = null;
		SqlTransaction sTran = null;
		SqlCommand cmd = new SqlCommand();

		public DBHelper(bool flag = false,string SCon = common.sConn)
		{
			// 데이터 베이스 오픈.
			sCon = new SqlConnection(SCon);
			sCon.Open();
			if (flag)
			{
				sTran = sCon.BeginTransaction();
				cmd.Transaction = sTran;
			}
		}

		// Insert,Update,Delete 만 사용
		public void ExecuteNoneQuery(string query, params object[] parameters)
		{
			try
			{
				cmd.Connection = sCon;
				cmd.CommandText = query;                       // StoredProcedure 이름
				cmd.CommandType = CommandType.StoredProcedure; // StoredProcedure 사용
				cmd.Parameters.Clear();                        // 기존 파라메터 초기화
				if (parameters != null)
				{
					string[] arry = Array.ConvertAll(parameters, p => (p ?? string.Empty).ToString()); // object[] => string[]로 변환 ,  p => (p ?? string.Empty).ToString() : 람다식
					string[] sKey = new string[2];
					for (int i = 0; i < arry.Length; i++)
					{
						sKey = arry[i].Split(',');  // ("@ex", Value) 으로 나누기
						cmd.Parameters.Add(new SqlParameter(sKey[0].Substring(1), sKey[1].Substring(1, sKey[1].Length - 2))); // sKey[0] : @ex, sKey[1] : Value
					}
				}
				cmd.ExecuteNonQuery();
			}
			catch
			{
				throw new Exception("Error");
			}
		}

		public void Close()
		{
			// 데이터 베이스 종료
			if (sCon.State == ConnectionState.Open) sCon.Close();  // 데이터 베이스 연결중 이면 닫기
		}

		public void Commit()
		{
			if (sTran != null)
			{
				sTran.Commit();
				//odtTemp = null;
				//oTable = "";
				sTran = null;
			}
		}

		public void Rollback()
		{
			if (sTran != null)
			{
				sTran.Rollback();
				sTran = null;
			}

			// Rollback 기능 구현

			//if (odtTemp != null && sTran)
			//{
			//	SqlConnection Connect = new SqlConnection(common.sConn);
			//	// 데이터 베이스 오픈.
			//	Connect.Open();
			//	// 2. 품목유형 데이터 리스트 조회 SQL
			//	string sSqlSelect = $"DELETE FROM {oTable}";
			//	string value = "";
			//	SqlDataAdapter adapter = new SqlDataAdapter(sSqlSelect, Connect);
			//	DataTable dtTemp = new DataTable();
			//	adapter.Fill(dtTemp);
			//
			//	SqlDataAdapter Adapter = new SqlDataAdapter("Rollback", sCon);
			//	Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			//	foreach (DataRow rows in odtTemp.Rows)
			//	{
			//      // 타입에 따라 형변환 후 update 및 insert
			//		for (int i = 0; i < rows.ItemArray.Length; i++)
			//		{
			//			if (rows[i].GetType() == value.GetType())
			//			{
			//				sSqlSelect = $"UPDATE {oTable} SET {odtTemp.Columns[i].ToString()} = '{Convert.ToString(rows[odtTemp.Columns[i].ToString()])}' WHERE {odtTemp.Columns[0].ToString()} = '{Convert.ToString(rows[odtTemp.Columns[0].ToString()])}' ";
			//			}
			//			else if (rows[i].GetType() == i.GetType())
			//			{
			//				if (i == 0)
			//				{
			//					sSqlSelect = $"SET IDENTITY_INSERT {oTable} ON INSERT INTO {oTable}({odtTemp.Columns[i].ToString()}) VALUES(Convert(int,{Convert.ToString(rows[odtTemp.Columns[i].ToString()])})) SET IDENTITY_INSERT {oTable} OFF ";
			//				}
			//				else
			//				{
			//					sSqlSelect = $"UPDATE {oTable} SET {odtTemp.Columns[i].ToString()} = Convert(int,{Convert.ToString(rows[odtTemp.Columns[i].ToString()])}) WHERE {odtTemp.Columns[0].ToString()} = '{Convert.ToString(rows[odtTemp.Columns[0].ToString()])}' ";
			//				}
			//			}
			//			else
			//			{
			//				string date = string.Format("{0:yyyy-MM-dd HH:mm:ss}", rows[odtTemp.Columns[i].ToString()]);
			//
			//				sSqlSelect = $"UPDATE {oTable} SET {odtTemp.Columns[i].ToString()} = Convert(VARCHAR(50),'{date}') WHERE {odtTemp.Columns[0].ToString()} = '{Convert.ToString(rows[odtTemp.Columns[0].ToString()])}'";
			//			}
			//			adapter = new SqlDataAdapter(sSqlSelect, Connect);
			//			dtTemp = new DataTable();
			//			adapter.Fill(dtTemp);
			//		}
			//	}
			//	sTran = false;
			//}
		}

		// Transaction : 기존 테이블 조회 후 datatable에 담아 저장해놓기, Rollback 시 저장 해놓은 데이터를 Insert 및 Update

		//public void Transaction(string Table, string Columns)
		//{
		//	if (false)
		//	{
		//		// 키 값:() int,  증가 값 설정
		//		SqlConnection Connect = new SqlConnection(common.sConn);
		//		Connect.Open();
		//		SqlDataAdapter adapter = null;
		//		string sSqlSelect = "";
		//		try
		//		{
		//			sSqlSelect = $"SELECT {Columns}  FROM {Table} ";
		//			adapter = new SqlDataAdapter(sSqlSelect, Connect);
		//			adapter = new SqlDataAdapter(sSqlSelect, Connect);
		//			DataTable dtTemp = new DataTable();
		//			adapter.Fill(dtTemp);
		//			if (dtTemp.Rows.Count == 0)
		//			{
		//				MessageBox.Show("테이블 설정이 잘못되었습니다.");
		//				return;
		//			}
		//		}
		//		catch
		//		{
		//			MessageBox.Show("테이블 설정이 잘못되었습니다.");
		//			return;
		//		}
		//	
		//	
		//		oTable = Table;
		//		sSqlSelect = $"SELECT * FROM {Table} ";
		//		adapter = new SqlDataAdapter(sSqlSelect, Connect);
		//		adapter.Fill(odtTemp);
		//	}
		//	else
		//	{
		//		MessageBox.Show("DBhelper 설정이 잘못되었습니다.");
		//	}
		//}

	}

	public class Mysql
	{
		// Dosave 미완성 : 아무 기능 없음
		public void Dosave(Grid dgvGrid)
		{
			DBHelper helper = new DBHelper();
			DataTable dtTemp = ((DataTable)dgvGrid.DataSource).GetChanges();

			foreach (DataRow dr in dtTemp.Rows)
			{
				switch (dr.RowState)
				{
					case DataRowState.Added:
						break;

					case DataRowState.Modified:
						break;

					case DataRowState.Deleted:
						dr.RejectChanges(); // 삭제된 데이터 원상 복귀.
						break;
				}
			}
		}

		// 콤보 박스 데이터 넣기
		public static void Combo(UltraComboEditor Combobox, string KName, string DName, string Table, string VName = null ,string SCon = common.sConn)
		{
			SqlConnection Connect = new SqlConnection(SCon);
			// 데이터 베이스 오픈.
			Connect.Open();
			// 2. 품목유형 데이터 리스트 조회 SQL
			if (VName == null) VName = DName;
			string sSqlSelect = "SELECT * FROM( SELECT ''          AS VALUE   ";
			sSqlSelect += $"                          ,'{KName}'   AS DISPLAY ";
			sSqlSelect += " UNION ALL                                         ";
			sSqlSelect += $" SELECT {VName}                        AS VALUE   ";
			sSqlSelect += $"       ,{DName}                        AS DISPLAY ";
			sSqlSelect += $"   FROM {Table}  ) A                              ";
			sSqlSelect += $"  WHERE A.VALUE IS NOT NULL                     ";
			sSqlSelect += "    GROUP BY A.VALUE,A.DISPLAY                     ";
			SqlDataAdapter adapter = new SqlDataAdapter(sSqlSelect, Connect);
			DataTable dtTemp = new DataTable();
			adapter.Fill(dtTemp);
			Combobox.DataSource = dtTemp;
			Combobox.ValueMember = "VAL";
			Combobox.DisplayMember = "DISPLAY";
			Combobox.SelectedIndex = 0;
			Connect.Close();
		}

		public static void Combo(UltraComboEditor Combobox, string KName, string EName, string Table, string Where, string Where2, string DName)
		{
			SqlConnection Connect = new SqlConnection(common.sConn);
			// 데이터 베이스 오픈.
			Connect.Open();
			// 2. 품목유형 데이터 리스트 조회 SQL
			string sSqlSelect = $"SELECT * FROM( SELECT ''         AS VALUE   ";
			sSqlSelect += $"                           ,'{KName}'  AS DISPLAY ";
			sSqlSelect += " UNION ALL                                         ";
			sSqlSelect += $" SELECT {DName}                        AS VALUE   ";
			sSqlSelect += $"       ,{EName}                        AS DISPLAY ";
			sSqlSelect += $"   FROM {Table} WHERE {Where2} = '{Where}' ) A    ";
			sSqlSelect += "    GROUP BY A.VALUE,A.DISPLAY                     ";
			SqlDataAdapter adapter = new SqlDataAdapter(sSqlSelect, Connect);
			DataTable dtTemp = new DataTable();
			adapter.Fill(dtTemp);
			Combobox.DataSource = dtTemp;
			Combobox.ValueMember = "VAL";
			Combobox.DisplayMember = "DISPLAY";
			Combobox.SelectedIndex = 0;
			Connect.Close();
		}

		public static DataTable NCombo(string Name, string EName, string Table, string Scon = common.sConn)
		{
			SqlConnection Connect = new SqlConnection(Scon);
			// 데이터 베이스 오픈.
			Connect.Open();
			// 2. 품목유형 데이터 리스트 조회 SQL

			string sSqlSelect = $" SELECT {Name} AS CODE_ID    ";
			sSqlSelect += $"             ,{EName} AS CODE_NAME ";
			sSqlSelect += $"         FROM {Table}              ";
			sSqlSelect += $"          GROUP BY {Name},{EName}  ";
			sSqlSelect += "          ORDER BY CODE_ID          ";
			SqlDataAdapter adapter = new SqlDataAdapter(sSqlSelect, Connect);
			DataTable dtTemp = new DataTable();
			adapter.Fill(dtTemp);
			Connect.Close();
			return dtTemp;
		}


		public static DataTable NCombo(string Name, string EName, string Table, string Where, string Where2)
		{
			SqlConnection Connect = new SqlConnection(common.sConn);
			// 데이터 베이스 오픈.
			Connect.Open();
			// 2. 품목유형 데이터 리스트 조회 SQL

			string sSqlSelect = $" SELECT {Name} AS CODE_ID              ";
			sSqlSelect += $"             ,{EName} AS CODE_NAME           ";
			sSqlSelect += $"   FROM {Table}   WHERE {Where2} = '{Where}' ";
			sSqlSelect += $"    GROUP BY {Name},{EName}                  ";
			sSqlSelect += "    ORDER BY CODE_ID                          ";
			SqlDataAdapter adapter = new SqlDataAdapter(sSqlSelect, Connect);
			DataTable dtTemp = new DataTable();
			adapter.Fill(dtTemp);
			Connect.Close();
			return dtTemp;
		}
	}

	public class Btn
	{
		public static void btnHide(params object[] ObBtn)
		{
			for (int i = 0; i < ObBtn.Length; i++)
			{
				UltraButton btn = (UltraButton)ObBtn[i];
				btn.Hide();
			}
		}

		// 버튼 여부에 따라 메인화면에 출력
		public static void btnShow(object[] oBtn,string title)
		{
			DBHelper helper = new DBHelper();
			SqlDataAdapter Adapter = new SqlDataAdapter("FORM_S", helper.sCon);
			Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			Adapter.SelectCommand.Parameters.AddWithValue("@TITLE", title);
			DataTable dTtemp = new DataTable();
			Adapter.Fill(dTtemp);
			string[] btnNm = { "FIND", "NEW", "DLT", "SV", "RT", "EX" };
			Dictionary<string, string> Mydic = new Dictionary<string, string>() { { "FIND", "조회" }, { "NEW", "추가" }, { "DLT", "삭제" }, { "SV", "저장" }, { "RT", "초기화" },{ "EX","엑셀"} };
			int iShow = 0;
			int iHide = 5;
			for (int i = 0; i < Mydic.Count(); i++)
			{

				if (Convert.ToInt32(dTtemp.Rows[0][btnNm[i]]) == 1)
				{
					((UltraButton)oBtn[iShow]).Show();
					((UltraButton)oBtn[iShow]).Text = Mydic[btnNm[i]].ToString(); // 버튼 텍스트 변경
					iShow++;
				}
				else
				{
					// 미출력에 따라 뒤에서부터 숨기기
					((UltraButton)oBtn[iHide]).Hide();
					iHide--;
				}
			}
		}
	}

	public class Excel
	{
		/// <summary>
		/// Creates an Excel from the UltraGrid and saves it to the user mentioned Save Path
		/// </summary>
		/// <param name="myFilepath"></param>
		public static void CreateExcel(String myFilepath, DC00_Component.Grid grid)
		{
			try
			{
				if (myFilepath != null)
				{
					//You need to Create the ExcelExporter component in the design view
					//ultraGridExcelExporter.Export(grid, myFilepath);
					//위와 같이 컨트롤을 넣어도 됩니다. 저는 컨트롤을 붙이기 보다는  아래와 같이 선언을 해서 썼습니다. (동일)
					//using Infragistics.Win.UltraWinGrid.ExcelExport;
					UltraGridExcelExporter UltraGridExcelExporter1 = new UltraGridExcelExporter();
					UltraGridExcelExporter1.Export(grid, myFilepath);

					MessageBox.Show("Grid data successfully downloaded to " + myFilepath);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Finding path for saving excel sheet.
		/// </summary>
		/// <returns>full path</returns>
		public static String FindSavePath()
		{
			Stream myStream;
			string myFilepath = null;
			try
			{
				SaveFileDialog saveFileDialog1 = new SaveFileDialog();
				saveFileDialog1.Filter = "excel files (*.xls)|*.xls";
				saveFileDialog1.FilterIndex = 2;
				saveFileDialog1.RestoreDirectory = true;
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					if ((myStream = saveFileDialog1.OpenFile()) != null)
					{
						myFilepath = saveFileDialog1.FileName;
						myStream.Close();
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return myFilepath;
		}
	}

}
