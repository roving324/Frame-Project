using Assambl;
using DC00_assm;
using DC00_Component;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form_List
{
	public partial class Form_PCList : Assambl.Base_Form
	{
		UltraGridUtil _GridUtil = new UltraGridUtil();
		int num = 0;
		public Form_PCList()
		{
			InitializeComponent();
		}

		private void Form_PCList_Load(object sender, EventArgs e)
		{
			_GridUtil.InitializeGrid(this.MENU);
			_GridUtil.InitColumnUltraGrid(MENU, "NUM"  , "순서"    , false, GridColDataType_emu.Integer , 130, 130, Infragistics.Win.HAlign.Left, false, false);
			_GridUtil.InitColumnUltraGrid(MENU, "PART" , "부서"    , false, GridColDataType_emu.VarChar , 130, 130, Infragistics.Win.HAlign.Left, true, false);
			_GridUtil.InitColumnUltraGrid(MENU, "MENU" , "메뉴"    , false, GridColDataType_emu.VarChar , 130, 130, Infragistics.Win.HAlign.Left, true, true);
			_GridUtil.InitColumnUltraGrid(MENU, "TITLE", "이름"    , false, GridColDataType_emu.VarChar , 120, 120, Infragistics.Win.HAlign.Left, true, true);
			_GridUtil.InitColumnUltraGrid(MENU, "DATE" , "등록일시", false, GridColDataType_emu.DateTime, 200, 120, Infragistics.Win.HAlign.Left, true, false);

			_GridUtil.SetInitUltraGridBind(MENU);

			_GridUtil.InitializeGrid(this.FORM);
			_GridUtil.InitColumnUltraGrid(FORM, "FORM" , "화면"  , false, GridColDataType_emu.VarChar , 130, 130, Infragistics.Win.HAlign.Left, true, true);
			_GridUtil.InitColumnUltraGrid(FORM, "FIND" , "검색"  , false, GridColDataType_emu.CheckBox, 120, 120, Infragistics.Win.HAlign.Left, true, true);
			_GridUtil.InitColumnUltraGrid(FORM, "NEW"  , "추가"  , false, GridColDataType_emu.CheckBox, 120, 120, Infragistics.Win.HAlign.Left, true, true);
			_GridUtil.InitColumnUltraGrid(FORM, "SV"   , "저장"  , false, GridColDataType_emu.CheckBox, 120, 120, Infragistics.Win.HAlign.Left, true, true);
			_GridUtil.InitColumnUltraGrid(FORM, "DLT"  , "삭제"  , false, GridColDataType_emu.CheckBox, 120, 120, Infragistics.Win.HAlign.Left, true, true);
			_GridUtil.InitColumnUltraGrid(FORM, "RT"   , "초기화", false, GridColDataType_emu.CheckBox, 120, 120, Infragistics.Win.HAlign.Left, true, true);
			_GridUtil.InitColumnUltraGrid(FORM, "EX"   , "엑셀"  , false, GridColDataType_emu.CheckBox, 120, 120, Infragistics.Win.HAlign.Left, true, true);

			_GridUtil.SetInitUltraGridBind(FORM);


			Mysql.Combo(cboPart, "부서", "PART", "TB_MENU");
			Mysql.Combo(cboMenu, "메뉴", "MENU", "TB_MENU");
			Mysql.Combo(cboName, "이름", "TITLE", "TB_MENU");
		}

		public override void DoInquire()
		{
			DBHelper helper = new DBHelper();
			SqlDataAdapter Adapter = new SqlDataAdapter("MENU_S1", helper.sCon);

			Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			Adapter.SelectCommand.Parameters.AddWithValue("@PART", cboPart.SelectedItem.DataValue);
			Adapter.SelectCommand.Parameters.AddWithValue("@MENU", cboMenu.SelectedItem.DataValue);
			Adapter.SelectCommand.Parameters.AddWithValue("@TITLE", cboName.SelectedItem.DataValue);

			DataTable dtTemp = new DataTable();
			Adapter.Fill(dtTemp);
			MENU.DataSource = dtTemp;
			helper.Close();
		}

		public override void DoNew()
		{
			if (MENU.Rows.Count == 0) return;
			if (num == 1)
			{
				MENU.DisplayLayout.Bands[0].AddNew();
				MENU.ActiveRow.Cells["PART"].IgnoreRowColActivation = true;
				MENU.ActiveRow.Cells["PART"].Activation = Activation.AllowEdit;
			}
			else if (num == 2 && FORM.Rows.Count < 1)
			{
				if (MENU.ActiveRow == null)
				{
					MessageBox.Show("타이틀을 선택해야 합니다.");
					return;
				}
				FORM.DisplayLayout.Bands[0].AddNew();
				for(int i = 1; i < FORM.Columns.Count; i++)
					FORM.ActiveRow.Cells[i].Value = 0;
			}
		}

		public override void DoSave()
		{
			if (num == 0) return;
			if (MessageBox.Show($"{num}번째 화면을 저장하시겠습니까?", "화면 저장", MessageBoxButtons.YesNo) == DialogResult.No) return;
			DBHelper helper = new DBHelper();
			DataTable dtTemp = null;
			string sMessge = "";
			if (num == 1)
			{
				dtTemp = ((DataTable)MENU.DataSource).GetChanges();

				
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
								if (drRow["PART"].ToString() == "" || drRow["DATE"].ToString() == "") continue;

								helper.ExecuteNoneQuery("MENU_D", ("@PART", drRow["PART"].ToString()), ("@NUM", Convert.ToInt32(drRow["NUM"])), ("@TITLE", drRow["TITLE"].ToString()));
								break;
							case DataRowState.Added:
								if (Convert.ToString(drRow["PART"]) == "")       sMessge = "부서";
								else if (Convert.ToString(drRow["MENU"]) == "")  sMessge = "메뉴";
								else if (Convert.ToString(drRow["TITLE"]) == "") sMessge = "이름";
								if (sMessge != "")
								{
									throw new Exception(sMessge + "을 입력하지 않았습니다.");
								}
								helper.ExecuteNoneQuery("MENU_I", ("@PART", drRow["PART"].ToString()), ("@MENU", drRow["MENU"].ToString()), ("@TITLE", drRow["TITLE"].ToString()));
								break;
							case DataRowState.Modified:
								if (Convert.ToString(drRow["MENU"]) == "")       sMessge = "메뉴";
								else if (Convert.ToString(drRow["TITLE"]) == "") sMessge = "이름";
								if (sMessge != "")
								{
									throw new Exception(sMessge + "을 입력하지 않았습니다.");
								}
								helper.ExecuteNoneQuery("MENU_U", ("@PART", drRow["PART"].ToString()), ("@MENU", drRow["MENU"].ToString()), ("@TITLE", drRow["TITLE"].ToString()), ("@DATE", string.Format("{0:yyyy-MM-dd  HH:mm:ss}", drRow["DATE"])));
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
			else if (num == 2)
			{
				dtTemp = ((DataTable)FORM.DataSource).GetChanges();
				
				
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
								if (drRow["FORM"].ToString() == "") continue;

								helper.ExecuteNoneQuery("FORM_D", ("@FORM", drRow["FORM"].ToString()));
								
								break;
							case DataRowState.Added:
								if (Convert.ToString(drRow["FORM"]) == "") throw new Exception("화면을 입력하지 않았습니다.");
								helper.ExecuteNoneQuery("FORM_IP", ("@TITLE", Convert.ToString(MENU.ActiveRow.Cells["TITLE"].Value)), ("@FORM", drRow["FORM"].ToString()), ("@FIND", Convert.ToInt32(drRow["FIND"]))
																 , ("@SV", Convert.ToInt32(drRow["SV"])), ("@DLT", Convert.ToInt32(drRow["DLT"])), ("@NEW", Convert.ToInt32(drRow["NEW"])), ("@RT", Convert.ToInt32(drRow["RT"])), ("@EX", Convert.ToInt32(drRow["EX"])),("@TYPE", "I"));

								break;
							case DataRowState.Modified:
								if (Convert.ToString(drRow["FORM"]) == "") throw new Exception("화면을 입력하지 않았습니다.");
								helper.ExecuteNoneQuery("FORM_IP", ("@TITLE", Convert.ToString(MENU.ActiveRow.Cells["TITLE"].Value)), ("@FORM", drRow["FORM"].ToString()), ("@FIND", Convert.ToInt32(drRow["FIND"]))
																 , ("@SV", Convert.ToInt32(drRow["SV"])), ("@DLT", Convert.ToInt32(drRow["DLT"])), ("@NEW", Convert.ToInt32(drRow["NEW"])), ("@RT", Convert.ToInt32(drRow["RT"])), ("@EX", Convert.ToInt32(drRow["EX"])),("@TYPE", "U"));

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
					try
					{
						MENU_AfterRowActivate();
					}
					catch
					{
						FORM.DataSource = null;
					}

				}
			}
			

		}

		public override void DoDelete()
		{
			if (MessageBox.Show($"{num}번째 화면을 삭제하시겠습니까?", "데이터삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
			try
			{
				if (num == 1)
				{
					MENU.ActiveRow.Delete();
				}
				else if (num == 2)
				{
					FORM.ActiveRow.Delete();
				}
			}
			catch
			{
				MessageBox.Show("행을 선택해야 합니다.");
			}
		}

		private void MENU_AfterRowActivate(object sender = null, EventArgs e = null)
		{
			string TITLE = Convert.ToString(MENU.ActiveRow.Cells["TITLE"].Value);
			DBHelper helper = new DBHelper();
			SqlDataAdapter Adapter = new SqlDataAdapter("FORM_S", helper.sCon);

			Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			Adapter.SelectCommand.Parameters.AddWithValue("@TITLE", TITLE);

			DataTable dtTemp = new DataTable();
			Adapter.Fill(dtTemp);
			FORM.DataSource = dtTemp;
			helper.Close();
		}

		private void MENU_Click(object sender, EventArgs e)
		{
			num = 1;
		}

		private void FORM_Click(object sender, EventArgs e)
		{
			num = 2;
		}
	}
}
