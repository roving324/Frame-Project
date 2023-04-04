# Frame_Project

## 저장프로시저 메서드

```
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
			string[] arry = Array.ConvertAll(parameters, p => (p ?? string.Empty).ToString()); // object[] => string[]로 변환 , p => (p ??string.Empty).ToString() : 람다식
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
```

## 목록 조회

```
// 아이디에 해당하는 부서 조회 후 메뉴 Tree 부서에 따른 목록 조회
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
	
	// 타이틀이 있을 경우 하위 목록으로 추가
	string subtitle = Convert.ToString(dtTemp.Rows[i]["TITLE"]);
	Menu.Nodes[title].Nodes.Add("", subtitle); // 소제목 ( "" = name, subtitle = text)
}
Calendar_DateChanged(); // 로드시 일정 바로 조회
helper.Close();
```

## SQL 데이터 추가시 바로 윈품 이벤트 호출
```
// SQLServer 에서 PUSH 방식으로 데이터 게더링.
		SqlDependency sd;


		public Form1()
		{
			InitializeComponent();

 

		}

		private void button1_Click(object sender, EventArgs e)
		{
			sCon = new SqlConnection(sConn);
			sCon.Open();

			SqlDependency.Start(sConn);
			GetLastDBState(true);
		}

		public void GetLastDBState(bool FirstStart)
		{

			// 반드시 테이블의 스키마 dbo 를 붙이고 사용한다.
			SqlCommand sc = new SqlCommand(@"select [message], [senddate] from dbo.TB_Message", sCon);
			sd = new SqlDependency(sc);

			sd.OnChange += Sd_OnChange;
			SqlDataReader rdr =  sc.ExecuteReader();
			rdr.Close();
			if (FirstStart) return;

			// 새로운 insert 내역이 발생 하였을 경우 Database 접근.
			
			SqlDataAdapter Adapter = new SqlDataAdapter("select top 1 senddate, message from dbo.TB_Message order by senddate desc", sCon);
			DataTable dtTemp = new DataTable();
			Adapter.Fill(dtTemp);
			this.Invoke(new Action(() => { textBox2.Text += dtTemp.Rows[0]["senddate"].ToString() + " \r\n" + dtTemp.Rows[0]["message"].ToString() + "\r\n\r\n"; }));
			this.Invoke(new Action(delegate ()
			{
				textBox2.Text += dtTemp.Rows[0]["senddate"].ToString() +  " \r\n" +  dtTemp.Rows[0]["message"].ToString() + "\r\n\r\n";
			}));
		}

		private void Sd_OnChange(object sender, SqlNotificationEventArgs e)
		{
			
			if (e.Info.ToString() == "Insert")
			{
				GetLastDBState(false);
			}
			else

			{
				GetLastDBState(true);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SqlDependency.Stop(sConn);
		}
```
