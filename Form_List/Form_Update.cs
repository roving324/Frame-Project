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
using System.IO.Compression;

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
            
            if (this.FDB.ShowDialog() == DialogResult.OK)
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
                        MessageBox.Show("이미 존재하는 버전으로 확인 후 다시 시도하십시오.");
                        return;
                    }
                    this.lblVersion.Text = Convert.ToString(str);
                    this.lblPath.Text = this.FDB.SelectedPath;
                    int count = FDB.SelectedPath.LastIndexOf('\\') + 1;
                    this.lblName.Text = FDB.SelectedPath.Substring(count);
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

            int i = FDB.SelectedPath.LastIndexOf('\\') + 1;
            ZipDirectory(FDB.SelectedPath, Application.StartupPath + FDB.SelectedPath.Substring(i) + ".zip");
            f = new FileInfo(Application.StartupPath + FDB.SelectedPath.Substring(i) + ".zip");

            panel1.Cursor = Cursors.AppStarting;
            var conn = new SqlConnection(common.sConn);
            conn.Open();
            
            try
            {
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
                File.Delete(Application.StartupPath + FDB.SelectedPath.Substring(i) + ".zip");
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

        public static void ZipDirectory(string directoryPath, string outputZipPath)
        {
            try
            {
                if (File.Exists(outputZipPath))
                {
                    File.Delete(outputZipPath);
                }

                ZipFile.CreateFromDirectory(directoryPath, outputZipPath);

                
            }
            catch
            {
                
            }
        }
    }
}
