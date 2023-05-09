using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Assambl;

namespace Form_List
{
   
    public partial class Form_Update : Form
    {
        FileInfo f = null;
        IEnumerable<string> fileList = null;

        private string Constr = "Data Source=222.235.141.8; Initial Catalog=KDTB_2JO; User ID= 2JO ; Password = 1234 ";
        public Form_Update()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var Conn = new SqlConnection(Constr);
                    var srt = File.OpenText("setup.txt");
                    var str = srt.ReadLine();
                    string sql = $"Select * From Table_File WHERE M_Num='{str}'";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, Conn);
                    DataTable dtTemp = new DataTable();
                    adapter.Fill(dtTemp);
                    if(dtTemp.Rows.Count > 0)
                    {
                        MessageBox.Show("존해하는 버전으로 확인 후 다시 시도하십시오.");
                        return;
                    }
                    this.lblVersion.Text = Convert.ToString(str);
                    //string startFolder = this.FDB.SelectedPath;
                    //txtFile.Text = startFolder;
                    //this.txtFile.Text = this.ofdFile.FileName;
                    f = new FileInfo(this.ofdFile.FileName);
                    //startFolder = @"c:\program files\Microsoft Visual Studio 9.0\VC#";
                    //fileList = System.IO.Directory.GetFiles(startFolder, "*.*", System.IO.SearchOption.AllDirectories);
                    //var fileQuery = from file in fileList select GetFileLength(file);

                    //this.txtFile.Text = this.ofdFile.FileName;
                    //f = new FileInfo(this.ofdFile.FileName);
                    this.lblPath.Text = f.DirectoryName;
                    this.lblName.Text = f.Name;
                    this.lblSize.Text = f.Length.ToString() + " byte";
                    //this.lbldisDate.Text = f.LastWriteTime.ToString();
                    
                }
                catch
                {
                    return;
                }
            }
        }

        static System.IO.FileInfo GetFileLength(string filename)
        {
            System.IO.FileInfo fi = null;
            try
            {
                fi = new System.IO.FileInfo(filename);
            }
            catch (System.IO.FileNotFoundException)
            {
                fi = null;
            }
            return fi;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (lblVersion.Text == "") return;
            panel1.Cursor = Cursors.AppStarting;
            var conn = new SqlConnection(common.sConn);
            conn.Open();
            
            try
            {
                //var fileQuery = from file in fileList select GetFileLength(file);
                //var cmd = conn.CreateCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.Transaction = sTran;
                //string Date = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
                //foreach (var f in fileQuery)
                //{
                //    
                //    var fs = f.OpenRead();
                //    var bytebuffer = new byte[fs.Length];
                //    fs.Read(bytebuffer, 0, Convert.ToInt32(fs.Length));
                //    cmd.Parameters.Clear();
                //    string[] sNames = (f.FullName.Replace("\\", "/")).Split('/');
                //    string sNmae = sNames[sNames.Length - 1];
                //    var Sql = $"INSERT Table_File(M_Num,M_File,M_FileName,Date) values ('{txtVersion.Text}',@M_File,'{sNmae}','{Date}')";
                //    cmd.CommandText = Sql;
                //    cmd.Parameters.Add(new SqlParameter("@M_File",
                //        System.Data.SqlDbType.Image)).Value = bytebuffer;
                //    cmd.ExecuteNonQuery();
                //    
                //    fs.Close();
                //}

                var fs = f.OpenRead();
                var bytebuffer = new byte[fs.Length];
                fs.Read(bytebuffer, 0, Convert.ToInt32(fs.Length));
                var cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string Date = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
                var Sql = $"INSERT Table_File(M_Num,M_File,M_FileName,Date) values ('{lblVersion.Text}',@M_File,'{f.Name}','{Date}')";
                cmd.CommandText = Sql;
                cmd.Parameters.Add(new SqlParameter("@M_File",
                    System.Data.SqlDbType.Image)).Value = bytebuffer;
                var iResult = cmd.ExecuteNonQuery();
                conn.Close();
                fs.Close();
                MessageBox.Show("저장이 정상적으로 되었습니다.", "알림",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private int DataSave()
        {
            var Conn = new SqlConnection(common.sConn);
            Conn.Open();
            var strSQL = "insert Table_Update set M_Date=M_Date + 1";
            var myCom = new SqlCommand(strSQL, Conn);
            var i = myCom.ExecuteNonQuery();
            Conn.Close();

            return i;
        }
    }
}
