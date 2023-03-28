using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Assambl
{
	public static class common
	{
		public const string sConn = "Data Source=222.235.141.8; Initial Catalog=KDTB_2JO; User ID= 2JO ; Password = 1234 ";
		public static string sID = "";
	}


	public class DBHelper
	{
		DataTable odtTemp = new DataTable();
		//string oTable = "";
		public SqlConnection sCon = null;
		SqlTransaction sTran = null;
		SqlCommand cmd = new SqlCommand();

		public DBHelper(bool flag = false)
		{
			// 데이터 베이스 오픈.
			sCon = new SqlConnection(common.sConn);
			sCon.Open();
			if (flag)
			{
				sTran = sCon.BeginTransaction();
				cmd.Transaction = sTran;
			}
		}

		public void ExecuteNoneQuery(string query, params object[] parameters)
		{
			try
			{
				cmd.Connection = sCon;
				cmd.CommandText = query;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Clear();
				if (parameters != null)
				{
					string[] arry = Array.ConvertAll(parameters, p => (p ?? string.Empty).ToString());
					string[] sKey = new string[2];
					for (int i = 0; i < arry.Length; i++)
					{
						sKey = arry[i].Split(',');
						cmd.Parameters.Add(new SqlParameter(sKey[0].Substring(1), sKey[1].Substring(1, sKey[1].Length - 2)));
					}
				}
				cmd.ExecuteNonQuery();
			}
			catch
			{
				MessageBox.Show("Error");
			}
		}
		 
		public void Close()
		{
			// 데이터 베이스 종료
			if (sCon.State == ConnectionState.Open) sCon.Close();
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

	public class Mysql // 미완성
	{
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

		public static void Combo(UltraComboEditor Combobox, string KName, string DName, string Table, string VName = null )
		{
			SqlConnection Connect = new SqlConnection(common.sConn);
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

		public static void Combo(UltraComboEditor Combobox, string KName, string EName, string Table, string Where, string Where2)
		{
			SqlConnection Connect = new SqlConnection(common.sConn);
			// 데이터 베이스 오픈.
			Connect.Open();
			// 2. 품목유형 데이터 리스트 조회 SQL
			string sSqlSelect = $"SELECT * FROM( SELECT ''         AS VALUE   ";
			sSqlSelect += $"                           ,'{KName}'  AS DISPLAY ";
			sSqlSelect += " UNION ALL                                         ";
			sSqlSelect += $" SELECT {EName}                        AS VALUE   ";
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

		public static DataTable Combo(string Name, string EName, string Table)
		{
			SqlConnection Connect = new SqlConnection(common.sConn);
			// 데이터 베이스 오픈.
			Connect.Open();
			// 2. 품목유형 데이터 리스트 조회 SQL

			string sSqlSelect = $" SELECT {Name} AS CODE_ID       ";
			sSqlSelect += $"             ,{EName} AS CODE_NAME    ";
			sSqlSelect += $"         FROM {Table}                    ";
			sSqlSelect += $"          GROUP BY {Name},{EName}                 ";
			sSqlSelect += "          ORDER BY CODE_ID                     ";
			SqlDataAdapter adapter = new SqlDataAdapter(sSqlSelect, Connect);
			DataTable dtTemp = new DataTable();
			adapter.Fill(dtTemp);
			Connect.Close();
			return dtTemp;
		}


		public static DataTable Combo(string Name, string EName, string Table, string Where, string Where2)
		{
			SqlConnection Connect = new SqlConnection(common.sConn);
			// 데이터 베이스 오픈.
			Connect.Open();
			// 2. 품목유형 데이터 리스트 조회 SQL

			string sSqlSelect = $" SELECT {Name} AS CODE_ID";
			sSqlSelect += $"             ,{EName} AS CODE_NAME";
			sSqlSelect += $"   FROM {Table}   WHERE {Where2} = '{Where}'     ";
			sSqlSelect += $"    GROUP BY {Name},{EName}                 ";
			sSqlSelect += "    ORDER BY CODE_ID                     ";
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
	}

}
