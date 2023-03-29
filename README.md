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
