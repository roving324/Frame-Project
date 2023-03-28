using Assambl;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinDock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form_List;
using System.Xml.Linq;
using System.Messaging;
using Infragistics.Documents.Reports.RTF.Defs;
using Telerik.WinControls.UI;
using System.Threading;

namespace TestProject
{
	public partial class Form_Home : Form
	{
		DataTable dtTemp3 = new DataTable();

		public Form_Home()
		{
			Form_Login login = new Form_Login();
			login.ShowDialog();
			if (!Convert.ToBoolean(login.Tag))
			{
				Environment.Exit(0);
			}
			InitializeComponent();
			Form_Load(true);
			this.Show();
		}

		private void Home_Load(object sender = null, EventArgs e = null)
		{
			DBHelper helper = new DBHelper();
			GBPanel.Size = new Size(this.Width*2/3, this.Height*2/3);
			Btn.btnHide(btnClose, btnFind, btnNew, btnDelete, btnSave, BtnReset, btnsubClose, btnsubFind, btnsubNew, btnsubDelete, btnsubSave,  BtnSubReset);
			MainName.Text = "메인화면";
			GBPanel2.Hide();
			picture();
			profil();
			// 메뉴 조회
			SqlDataAdapter Adapter = new SqlDataAdapter("MENU_S", helper.sCon);
			Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			Adapter.SelectCommand.Parameters.AddWithValue("@ID", common.sID);
			DataTable dtTemp = new DataTable();
			Adapter.Fill(dtTemp);
			Menu.Nodes.Clear();
			for (int i = 0; i < dtTemp.Rows.Count; i++)
			{
				string title = Convert.ToString(dtTemp.Rows[i]["MENU"]);
				
				if (Menu.GetNodeByKey(title) == null)
				{
					Menu.Nodes.Add(title, title); // 메뉴 타이틀이 없을 경우 추가
				}
				
				string subtitle = Convert.ToString(dtTemp.Rows[i]["TITLE"]);
				Menu.Nodes[title].Nodes.Add("", subtitle); // 소제목 ( "" = name, subtitle = text)
			}
			Calendar_DateChanged(); // 로드시 일정 바로 조회
			helper.Close();
		}

		private void picture()
		{
			if (common.sID == "") return;
			subPictureBox.Image = null;
			// 데이터베이스 오픈.
			SqlConnection sConn = new SqlConnection(common.sConn);
			sConn.Open();
			// database 에서 이미지 바이트 코드를 가져올 SQL 구문 작성.
			string sGaveCode = " SELECT PHONE,NAME,PICTURE " +
						   " FROM  TB_USER_R" +
						  $" WHERE ID ='{common.sID}' ";
			// Adapter 설정
			SqlDataAdapter Adapter = new SqlDataAdapter(sGaveCode, sConn);
			// dataTable 에서 결과 받기
			DataTable dtTemp = new DataTable();
			Adapter.Fill(dtTemp);
			if (dtTemp.Rows.Count == 0) return;

			//품목별 이미지 BYTE 코드가 있는지 체크


			// byte[] 배열 형식으로 받아올 변수 생성.
			Byte[] blmage = null;

			// byte 배열 형식으로 byte 코드 형변환.
			if (Convert.ToString(dtTemp.Rows[0]["PICTURE"]) != "")
			{
				blmage = (byte[])dtTemp.Rows[0]["PICTURE"];
				// byte[] 배열인 bImage 를 Bitmap(픽셀 이미지 로 변경해주는 클래스) 로 변환
				subPictureBox.Image = new Bitmap(new MemoryStream(blmage));
				PictureBox.Image = new Bitmap(new MemoryStream(blmage));
			}
			txtName.Text = dtTemp.Rows[0]["NAME"].ToString();
			txtPH.Text = dtTemp.Rows[0]["PHONE"].ToString();

			sConn.Close();
		}

		private void Form_Load(bool reset, string name = null,string title = null)
		{
			DBHelper helper = new DBHelper();
			try
			{
				Assembly assembly = null;
				Type typeForm	  = null;
				Form Test		  = null;
				

				if (reset)
				{
					if (PC2.Controls.Count > 0) PC2.Controls.RemoveAt(0);
					assembly = Assembly.LoadFrom(Application.StartupPath + @"\" + "Assambl.DLL");
					typeForm = assembly.GetType("Assambl.Base_Form", true);
					Test = (Form)Activator.CreateInstance(typeForm);
					Test.TopLevel = false;
					PC2.Controls.Add(Test);
					Test.Show();
					Btn.btnHide(btnsubClose, btnsubFind, btnsubNew, btnsubDelete, btnsubSave, BtnSubReset);
					dockManager.DockAreas[5].Panes[0].Text = "보조화면";
					return;
				}
				assembly = Assembly.LoadFrom(Application.StartupPath + @"\" + "Form_List.DLL");
				typeForm = assembly.GetType("Form_List." + name, true);
				Test = (Form)Activator.CreateInstance(typeForm);
				Test.TopLevel = false;
				if (BtnPC1.Checked)
				{
					if (PC1.Controls.Count > 0) PC1.Controls.RemoveAt(0);
					PC1.Controls.Add(Test);
					Test.Show();
					SqlDataAdapter Adapter = new SqlDataAdapter("FORM_S", helper.sCon);
					Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
					Adapter.SelectCommand.Parameters.AddWithValue("@TITLE", title);
					DataTable dTtemp = new DataTable();
					Adapter.Fill(dTtemp);
					if (Convert.ToInt32(dTtemp.Rows[0]["FIND"]) == 1) btnFind.Show();
					else btnFind.Hide();
					if (Convert.ToInt32(dTtemp.Rows[0]["NEW"]) == 1) btnNew.Show();
					else btnNew.Hide();
					if (Convert.ToInt32(dTtemp.Rows[0]["DLT"]) == 1) btnDelete.Show();
					else btnDelete.Hide();
					if (Convert.ToInt32(dTtemp.Rows[0]["SV"]) == 1) btnSave.Show();
					else btnSave.Hide();
					if (Convert.ToInt32(dTtemp.Rows[0]["RT"]) == 1) BtnReset.Show();
					else BtnReset.Hide();
					btnClose.Show();
					btnClose.BringToFront(); // 맨 앞으로
					MainName.Text = title;
				}
				else
				{
					if (PC2.Controls.Count > 0) PC2.Controls.RemoveAt(0);
					PC2.Controls.Add(Test);
					Test.Show();

					SqlDataAdapter Adapter = new SqlDataAdapter("FORM_S", helper.sCon);
					Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
					Adapter.SelectCommand.Parameters.AddWithValue("@TITLE", title);
					DataTable dTtemp = new DataTable();
					Adapter.Fill(dTtemp);
					if (Convert.ToInt32(dTtemp.Rows[0]["FIND"]) == 1) btnsubFind.Show();
					else btnsubFind.Hide();
					if (Convert.ToInt32(dTtemp.Rows[0]["NEW"]) == 1) btnsubNew.Show();
					else btnsubNew.Hide();
					if (Convert.ToInt32(dTtemp.Rows[0]["DLT"]) == 1) btnsubDelete.Show();
					else btnsubDelete.Hide();
					if (Convert.ToInt32(dTtemp.Rows[0]["SV"]) == 1) btnsubSave.Show();
					else btnsubSave.Hide();
					if (Convert.ToInt32(dTtemp.Rows[0]["RT"]) == 1) BtnSubReset.Show();
					else BtnSubReset.Hide();
					btnsubClose.Show();
					btnClose.BringToFront();
					GBPanel2.Show();
					dockManager.DockAreas[5].Panes[0].Text = title;
				}
			}
			catch
			{
				MessageBox.Show("화면을 불러올 수 없습니다.");
			}
			finally
			{
				helper.Close();
			}
		}

		private void BtnLogout_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("로그아웃 하시겠습니까?","로그아웃",MessageBoxButtons.YesNo) == DialogResult.No)
			{
				return;
			}
			DBHelper helper = new DBHelper();
			helper.ExecuteNoneQuery("LoginList_U", ("@ID", common.sID));

			Form_Login login = new Form_Login();
			if (PC1.Controls.Count > 0) PC1.Controls.RemoveAt(0);
			if (PC2.Controls.Count > 0) PC2.Controls.RemoveAt(0);
			helper.Close();
			base.Hide();
			login.ShowDialog();
			if (!Convert.ToBoolean(login.Tag))
			{
				Environment.Exit(0);
			}
			base.Show();
			Home_Load();
		}

		private void BtnExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("프로그램을 종료하시겠습니까?", "프로그램 종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				
				if (MessageBox.Show("로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					DBHelper helper = new DBHelper();
					helper.ExecuteNoneQuery("LoginList_U", ("@ID", common.sID));
					helper.Close();
					Environment.Exit(0);
				}
				else
				{
					Environment.Exit(0);
				}
			}
		}

		private void Form_Home_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				DBHelper helper = new DBHelper();
				helper.ExecuteNoneQuery("LoginList_U", ("@ID", common.sID));
				helper.Close();
				Environment.Exit(0);
			}
			else
			{
				this.Cursor = Cursors.WaitCursor;
				Environment.Exit(0);
			}
		}

		private void Menu_AfterActivate(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e = null)
		{
			DBHelper helper = new DBHelper();
			Infragistics.Win.UltraWinTree.UltraTree Name = (Infragistics.Win.UltraWinTree.UltraTree)sender;
			string name = Name.ActiveNode.Text;
			SqlDataAdapter Adapter = new SqlDataAdapter("FORM_S", helper.sCon);
			Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			Adapter.SelectCommand.Parameters.AddWithValue("@TITLE", name);
			DataTable dTtemp = new DataTable();
			Adapter.Fill(dTtemp);
			helper.Close();
			if (dTtemp.Rows.Count == 0) return;
			Form_Load(false,Convert.ToString(dTtemp.Rows[0]["FORM"].ToString()), name);
		}


		private void GBPanel_Resize(object sender = null, EventArgs e = null)
		{
			// 화면 사이즈 조절 1. 화면 담기 2. 기존화면 지우기 3. 틀 생성 4. 다시 담기 5. 보여주기
			if (PC1.Controls.Count > 0)
			{
				Form Temp = (Form)PC1.Controls[0];
				PC1.Controls.RemoveAt(0);
				Temp.Size = new Size(PC1.Width, PC1.Height);
				PC1.Controls.Add(Temp);
				Temp.Show();
			}
		}
		private void GBPanel2_Resize(object sender, EventArgs e)
		{
			if (PC2.Controls.Count > 0)
			{
				Form Temp = (Form)PC2.Controls[0];
				PC2.Controls.RemoveAt(0);
				Temp.Size = new Size(PC2.Width, PC2.Height);
				PC2.Controls.Add(Temp);
				Temp.Show();
			}
		}

		private void BtnCalendar_Click(object sender, EventArgs e)
		{
			string alram = "N";
			string date2 = string.Format("{0:yyyy-MM-dd}", Calendar.SelectionStart);
			string time  = string.Format("{0:H:mm:ss}"   , dttime.Value);

			string datetime = date2 + " " + time;
			string message  = txtmessage.Text;
			if (cbAlram.Checked == true)
			{
				alram = "Y";
			}
			DBHelper helper = new DBHelper();
			helper.ExecuteNoneQuery("Alram_I", ("@ID", common.sID), ("@DATETIME", datetime), ("@MESSAGE", message), ("@ALRAMFLAG", alram));
			helper.Close();
			txtmessage.Text = "";
			MessageBox.Show("메모가 등록이 되었습니다.");
			Calendar_DateChanged();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			if (PC1.Controls.Count > 0)
			{
				PC1.Controls.RemoveAt(0);
				Btn.btnHide(btnClose, btnFind, btnNew, btnSave, btnDelete, BtnReset);
				MainName.Text = "메인화면";
			}
		}

		private void btnsubClose_Click(object sender, EventArgs e)
		{
			Form_Load(true); 
		}

		private void btnUpload_Click(object sender, EventArgs e)
		{
			if (PictureBox.Image == null) return; // 저장 대상 이미지 미오픈.

			DialogResult drResult = MessageBox.Show("현재 이미지를 품목에 등록 하시겠습니까?", "이미지 저장", MessageBoxButtons.YesNo);
			if (drResult == DialogResult.No) return;
			Byte[] bImage = null; // 이미지 파일이 등록 될 Byte 배열.

			/*
						--------------      BinaryReader    --------------    FileStream      --------------   
						 APP (Byte)      <--------------->   RAM(Binary)   <--------------->   File(Byte)
						--------------                      --------------                    --------------
						Byte 바이트     : CPU 가 아닌 가상머신(OS) 에서 이해 할수 있는 코드 의 이진 파일.
						Binary 바이너리 : 컴퓨터(CPU) 가 인식 할 수 있는 0,1 로 이루어진 이진 코드. 
					*/

			// 2. 파일 스트림을 통해 파일을 오픈 하고 바이너리 형식으로 변환
			// FileMode.Open : 경로에 있는 사진 파일에 접근
			// FileAccess.Read : 읽기 전용으로 읽어 오겠다.
			FileStream stream = new FileStream(Convert.ToString(PictureBox.Tag), FileMode.Open, FileAccess.Read);

			// 3. 스트림을 통해 읽어온 Binary 코드 Byte 코드 변환.
			BinaryReader reader = new BinaryReader(stream);

			// 4. 만들어진 Binary 코드의 이미지를 Byte 화 하여 APP 의 데이터 자료형 구조에 담는다.
			bImage = reader.ReadBytes(Convert.ToInt32(stream.Length));

			// 5. 바이너리 리더 종료
			reader.Close();
			// 6. 파일 스트림 종료.
			stream.Close();

			SqlConnection sCon = new SqlConnection(common.sConn);
			SqlCommand cmd = new SqlCommand();
			sCon.Open();
			cmd.Connection = sCon;
			string sUPdateSql = " UPDATE TB_USER_R" +
							 $"  SET      PICTURE = @PICTURE " + // 품목 이미지 변수 생성
							 $"  WHERE    ID  = '{common.sID}' ";

			cmd.Parameters.AddWithValue("@PICTURE", bImage);
			cmd.CommandText = sUPdateSql;
			cmd.ExecuteNonQuery();

			MessageBox.Show("이미지가 정상적으로 등록 되었습니다.");

			sCon.Close();
			picture();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (PictureBox.Image == null)
			{
				MessageBox.Show("이미지가 없는 파일 입니다.");
				return;
			}
			// 품목별 이미지를 삭제 (null 로 update)

			// 데이터 베이스 오픈
			SqlConnection scon = new SqlConnection(common.sConn);
			SqlCommand cmd = new SqlCommand();

			scon.Open();
			// 커맨드 설정


			// 커맨드 주소 연결
			cmd.Connection = scon;

			string sUpdate = $"UPDATE TB_USER_R SET PICTURE = NULL WHERE ID = '{common.sID}' ";

			cmd.CommandText = sUpdate;
			cmd.ExecuteNonQuery();
			PictureBox.Image = null;
			MessageBox.Show("정상적으로 이미지가 삭제 되었습니다.");
			picture();
		}

		private void profil()
		{
			if (common.sID == "") return;

			SqlConnection sConn = new SqlConnection(common.sConn);
			sConn.Open();

			string sProfile = " SELECT ID, NAME, PHONE, SEX, PART, RANK " +
						  " FROM TB_USER_R" +
						 $" WHERE ID ='{common.sID}' ";

			SqlDataAdapter adapter = new SqlDataAdapter(sProfile, sConn);
			DataTable dtTemp = new DataTable();
			adapter.Fill(dtTemp);
			if (dtTemp.Rows.Count == 0) return;
			txtPName.Text  = dtTemp.Rows[0]["NAME"].ToString();
			txtPId.Text    = dtTemp.Rows[0]["ID"].ToString();
			txtPPH.Text    = dtTemp.Rows[0]["PHONE"].ToString();
			txtPSex.Text   = dtTemp.Rows[0]["SEX"].ToString();
			txtPPart.Text  = dtTemp.Rows[0]["PART"].ToString();
			txtPLevel.Text = dtTemp.Rows[0]["RANK"].ToString();
			txtPPPW.Text   = "비밀번호";
		}

		private void ultraNavigationBar1_Click(object sender, EventArgs e)
		{
			// 파일 탐색기 호출(OpenFileDialog : 파일탐색기 클래스, Window 제공 API)
			OpenFileDialog dialog = new OpenFileDialog();
			DialogResult dialogResult = dialog.ShowDialog();
			// 사진 취소 버튼 눌렀을때 리턴
			if (dialogResult != DialogResult.OK) return;

			// 사진을 선택 하였을 경우 처리되는 로직
			string sImafeFilePath = dialog.FileName; // 사진 파일이 저장되어 있는 폴더의 경로 와 사진 파일의 정보.
													 // 사진 파일의 경로를 찾아가 Byte[] 배열 형식으로 반환하여 이미지 뷰어(picItemImage) 에 표현한다.
			PictureBox.Image = Bitmap.FromFile(sImafeFilePath);
			PictureBox.Tag = sImafeFilePath;
		}

		private void btnEvent_Click(object sender, EventArgs e)
		{
			Infragistics.Win.Misc.UltraButton btn = (Infragistics.Win.Misc.UltraButton)sender;
			Base_Form Child = null;
			if (btn.Parent.Parent.Controls[1].Name == "PC1") Child = (Base_Form)PC1.Controls[0];
			else if (btn.Parent.Parent.Controls[0].Name == "PC2") Child = (Base_Form)PC2.Controls[0];


			switch (btn.Text)
			{
				case "조회":
					Child.DoInquire();
					break;
				case "저장":
					Child.DoSave();
					break;
				case "삭제":
					Child.DoDelete();
					break;
				case "추가":
					Child.DoNew();
					break;
				case "초기화":
					Child.DoReset();
					break;
			}
		}

		private void Calendar_DateChanged(object sender = null, DateRangeEventArgs e = null)
		{
			txtmessage2.Text = "";
			string ST = "";
			if (Calendar.SelectionStart == null)
			{
				ST = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
			}
			else
			{
				ST = string.Format("{0:yyyy-MM-dd}", Calendar.SelectionStart);
			}
			DBHelper helper = new DBHelper();
			SqlDataAdapter Adapter = new SqlDataAdapter("Alram_S", helper.sCon);
			Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			Adapter.SelectCommand.Parameters.AddWithValue("@ID", common.sID);
			Adapter.SelectCommand.Parameters.AddWithValue("@ST", ST);
			DataTable dtTemp = new DataTable();
			Adapter.Fill(dtTemp);
			helper.Close();
			if (dtTemp.Rows.Count == 0) return;
			StringBuilder sbAddress = new StringBuilder();
			for (int i = 0; i < dtTemp.Rows.Count; i++)
			{
				string DT = dtTemp.Rows[i]["DATETIME"].ToString();
				string MG = dtTemp.Rows[i]["MESSAGE"].ToString();
				string AF = dtTemp.Rows[i]["ALRAMFLAG"].ToString();
				if (AF == "Y") AF = "[알람]";
				else AF = "";


				sbAddress.Append(DT + AF + "\r\n");
				sbAddress.Append(MG + "\r\n" + "\r\n");

			}
			txtmessage2.Text = sbAddress.ToString();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			DBHelper helper = new DBHelper();
			try
			{
				string ND = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
				NowTime.Text = ND;

				
				SqlDataAdapter Adapter = new SqlDataAdapter("Alram_s1", helper.sCon);
				Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				Adapter.SelectCommand.Parameters.AddWithValue("@ID", common.sID);
				Adapter.SelectCommand.Parameters.AddWithValue("@ND", ND);
				DataTable dtTemp = new DataTable();
				Adapter.Fill(dtTemp);

				if (dtTemp.Rows.Count > 0)
				{
					MessageBox.Show(dtTemp.Rows[0]["MESSAGE"].ToString());
				}
				string ND2 = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
				SqlDataAdapter Adapter2 = new SqlDataAdapter("MESSENGER_S", helper.sCon);
				Adapter2.SelectCommand.CommandType = CommandType.StoredProcedure;
				Adapter2.SelectCommand.Parameters.AddWithValue("@DATETIME", ND2);
				DataTable dtTemp2 = new DataTable();
				Adapter2.Fill(dtTemp2);
				helper.Close();

				if (dtTemp2.Rows.Count == dtTemp3.Rows.Count)
				{
					return;
				}
				dtTemp3 = dtTemp2;
				if (dtTemp2.Rows.Count == 0) return;

				StringBuilder sbAddress = new StringBuilder();
				for (int i = 0; i < dtTemp2.Rows.Count; i++)
				{
					string NM = dtTemp2.Rows[i]["NAME"].ToString();
					string PR = dtTemp2.Rows[i]["PART"].ToString();
					string RN = dtTemp2.Rows[i]["RANK"].ToString();
					string DT = dtTemp2.Rows[i]["DATETIME"].ToString();
					string CT = dtTemp2.Rows[i]["CONTENTS"].ToString();

					sbAddress.Append($"[{DT}]{"\r\n"}");
					sbAddress.Append($"[{PR}][{RN}][{NM}]{"\r\n"}");
					sbAddress.Append(CT + "\r\n" + "\r\n");
				}
				txtMesinger.Text = sbAddress.ToString();
				txtMesinger.SelectionStart = txtMesinger.Text.Length;
				txtMesinger.ScrollToCaret();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString()); 
			}
			finally
			{
				helper.Close();
			}
			
		}
		private void btnspend_Click(object sender, EventArgs e)
		{
			if (txtMe.Text == "") return;
			string ME = txtMe.Text;
			string ST = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
			DBHelper helper = new DBHelper();
			helper.ExecuteNoneQuery("MESSENGER_I", ("@ID", common.sID), ("@DATETIME", ST), ("@CONTENTS", ME));
			helper.Close();
			txtMe.Text = "";
		}

		private void txtMe_KeyDown(object sender, KeyEventArgs e)
		{
			if (txtMe.Text == "") return;
			if (e.KeyCode == Keys.Enter)
			{
				btnspend_Click(sender, e);
				txtMe.Focus();
				SendKeys.Send("{BACKSPACE}");
			}
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("오늘 일정이 전체 삭제 하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				string ST = "";
				if (Calendar.SelectionStart == null)
				{
					ST = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
				}
				else
				{
					ST = string.Format("{0:yyyy-MM-dd}", Calendar.SelectionStart);
				}

				DBHelper helper = new DBHelper();
				helper.ExecuteNoneQuery("Alram_D", ("@ID", common.sID), ("@DATE", ST));
				helper.Close();
				txtmessage2.Text = "";
			}

			else return;
		}

		private void btnPSave_Click(object sender, EventArgs e)
		{


			string ID    = txtPId.Text;
			string Pw    = txtPPPW.Text;
			string Name  = txtPName.Text;
			string SEX   = txtPSex.Text;
			string Phone = txtPPH.Text;
			string PART  = txtPPart.Text;
			string RANK  = txtPLevel.Text;

			DBHelper helper = new DBHelper();
			if (btnPSave.Text == "수정")
			{
				// 1 비밀번호 가 일치 하는제 데이터 베이스에서 확인
				SqlDataAdapter Adapter = new SqlDataAdapter("Profil_PwCheck_S", helper.sCon);
				Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				Adapter.SelectCommand.Parameters.AddWithValue("@ID", common.sID);
				Adapter.SelectCommand.Parameters.AddWithValue("@PW", Pw);

				DataTable dtTemp = new DataTable();
				Adapter.Fill(dtTemp);


				if (Convert.ToString(dtTemp.Rows[0]["CHECKFLAG"]) != "1")
				{
					MessageBox.Show("비밀번호가 일치하지 않습니다.");
					return;
				}
				DialogResult drResult = MessageBox.Show("프로필을 수정하시겠습니까?", "프로필 수정", MessageBoxButtons.YesNo);

				if (drResult == DialogResult.Yes)
				{

					MessageBox.Show("수정 할 수 있습니다.");

					txtPName.ReadOnly = false;
					txtPSex.ReadOnly  = false;
					txtPPH.ReadOnly   = false;

					btnPSave.Text = "저장";
					return;

				}
				if (drResult == DialogResult.No)
				{
					MessageBox.Show("수정을 취소 하였습니다.");
					return;
				}

			}
			else if (btnPSave.Text == "저장")
			{

				DialogResult drResult1 = MessageBox.Show("프로필을 변경하시겠습니까?", "프로필 변경", MessageBoxButtons.YesNo);
				if (drResult1 == DialogResult.No)
				{
					MessageBox.Show("변경을 취소하였습니다.");
					profil();
					return;
				}
				helper.ExecuteNoneQuery("Profil_U1", ("@ID", ID), ("@Name", Name), ("@PHONE", Phone), ("@SEX", SEX)
												   , ("@PART", PART), ("@RANK", RANK), ("@PW", Pw));

				MessageBox.Show("정상적으로 수정을 완료 하였습니다.");


				btnPSave.Text     = "수정";
				txtPName.ReadOnly = true;
				txtPSex.ReadOnly  = true;
				txtPPH.ReadOnly   = true;

				txtPPPW.Text = "비밀번호";
			}
			helper.Close();
		}

		private void txtMesinger_DoubleClick(object sender, EventArgs e)
		{
			txtMesinger.SelectionStart = txtMesinger.Text.Length;
			txtMesinger.ScrollToCaret();
		}
	}
}
