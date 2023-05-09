using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.IO.Compression;

namespace Assambl
{
    public partial class Form_ProcessBar : Form
    {
        private Thread myDownload;
        private string Constr = "Data Source=222.235.141.8; Initial Catalog=KDTB_2JO; User ID= 2JO ; Password = 1234 ";
        string startFolder = string.Empty;

        public Form_ProcessBar()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Text = common.version + " 버전으로 업데이트 중...";
            if (this.FDB.ShowDialog() == DialogResult.OK)
            {
                startFolder = this.FDB.SelectedPath;
                myDownload = new Thread(DataDownLoding);
                myDownload.Start();
            }
            else
            {
                this.Tag = "Fail";
                this.Close();
            }
        }

        private void DataDownLoding()
        {
            string startFolder = DatabaseDownload(common.version);
            
            this.Tag = "Success";
            //var fs = new FileStream(startFolder + "\\" + "setup.txt", FileMode.Create);
            //var sw = new StreamWriter(fs);
            //sw.WriteLine(common.version);
            //sw.Close();
            //fs.Close();
            this.Close();
        }

        private string DatabaseDownload(string M_Num)
        {
           using (var Conn = new SqlConnection(Constr))
            {

                //Conn.Open();
                //var sql =
                //    $"Select DataLength(M_File) AS Data, M_FileName From Table_File WHERE M_Num='{M_Num}'";
                //SqlDataAdapter adapter = new SqlDataAdapter(sql, Conn);
                //DataTable dtTemp = new DataTable();
                //adapter.Fill(dtTemp);
                //
                //int itotalLength = dtTemp.Rows.Count;
                //ProgressBar.Maximum = itotalLength;
                //ProgressBar.Value = 0;
                //
                //byte[] buf = null;
                //
                //
                //for (int i = 0; i < dtTemp.Rows.Count; i++)
                //{
                //    int totalLength = Convert.ToInt32(dtTemp.Rows[i]["Data"]);
                //    
                //    sql = $"Select M_File From Table_File WHERE M_Num = '{M_Num}' AND M_FileName = '{dtTemp.Rows[i]["M_FileName"]}'";
                //    SqlCommand cmd = new SqlCommand(sql, Conn);
                //    SqlDataReader reader =
                //        cmd.ExecuteReader(CommandBehavior.SequentialAccess);
                //    reader.Read();
                //    long remainder = totalLength;
                //    
                //    int bufferSize = 20048;
                //    if (totalLength < bufferSize)
                //    {
                //        totalLength = bufferSize;
                //    }
                //    buf = new byte[(int)totalLength];
                //    int startIndex = 0;
                //    long retval = reader.GetBytes(0, startIndex, buf, 0, bufferSize);
                //    remainder -= retval;
                //    while (remainder > 0)
                //    {
                //        startIndex += bufferSize;
                //        if (remainder < bufferSize)
                //        {
                //            bufferSize = (int)remainder;
                //        }
                //        retval = reader.GetBytes(0, startIndex, buf, startIndex, bufferSize);
                //        remainder -= retval;
                //        
                //        Thread.Sleep(100);
                //    }
                //    reader.Close();
                //    var Fs = new FileStream(startFolder+ "\\" + Convert.ToString(dtTemp.Rows[i]["M_FileName"]), FileMode.Create);
                //    Fs.Write(buf, 0, buf.Length);
                //    Fs.Close();
                //    this.ProgressBar.Value += 1;
                //    this.Text = $"{common.version} 버전으로 업데이트 중... ({i} / { dtTemp.Rows.Count})";
                //}
                Conn.Open();
                var sql =
                    "Select DataLength(M_File) From Table_File WHERE M_Num = @M_Num";
                SqlParameter param = new SqlParameter("@M_Num", SqlDbType.VarChar);
                param.Value = M_Num;
                SqlCommand cmd = new SqlCommand(sql, Conn);
                cmd.Parameters.Add(param);
                int totalLength = Convert.ToInt32(cmd.ExecuteScalar());
                this.ProgressBar.Maximum = totalLength;
                this.ProgressBar.Value = 0;
                sql = "Select M_File From Table_File WHERE M_Num = @M_Num";
                param = new SqlParameter("@M_Num", SqlDbType.VarChar);
                param.Value = M_Num;
                cmd = new SqlCommand(sql, Conn);
                cmd.Parameters.Add(param);
                SqlDataReader reader =
                    cmd.ExecuteReader(CommandBehavior.SequentialAccess);
                reader.Read();
                long remainder = totalLength;
                int bufferSize = 20048;
                if (totalLength < bufferSize)
                {
                    totalLength = bufferSize;
                }
                byte[] buf = new byte[(int)totalLength];
                int startIndex = 0;
                long retval = reader.GetBytes(0, startIndex, buf, 0, bufferSize);
                remainder -= retval;
                while (remainder > 0)
                {
                    startIndex += bufferSize;
                    if (remainder < bufferSize)
                    {
                        bufferSize = (int)remainder;
                    }
                    retval = reader.GetBytes(0, startIndex, buf, startIndex, bufferSize);
                    remainder -= retval;
                    this.ProgressBar.Value = startIndex;
                    Thread.Sleep(100);
                }
                this.ProgressBar.Value = totalLength;
                reader.Close();
                sql = $"Select M_FileName From Table_File WHERE M_Num='{M_Num}'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, Conn);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);
                var Fs = new FileStream(startFolder + "\\" + Convert.ToString(dtTemp.Rows[0]["M_FileName"]), FileMode.Create);
                Fs.Write(buf, 0, buf.Length);
                Fs.Close();
                
                this.Text = "설치 중...";
                UnzipFile(startFolder + "\\" + Convert.ToString(dtTemp.Rows[0]["M_FileName"]), startFolder + "\\" + Convert.ToString(dtTemp.Rows[0]["M_FileName"]).Replace(".zip",""));
                //this.ProgressBar.Value += 1;
                return startFolder;
            }
        }

        private void Form_ProcessBar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Tag == null) this.Tag = "Fail";
        }

        public static void UnzipFile(string zipPath, string unzipPath)
        {
            try
            {
                if (Directory.Exists(unzipPath))
                {
                    Directory.Delete(unzipPath);
                }
                ZipFile.ExtractToDirectory(zipPath, unzipPath);
                File.Delete(zipPath);
            }
            catch
            {
            }
        }
    }
}