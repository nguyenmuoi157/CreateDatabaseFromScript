using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chuoiketNoi.Text = @"Data Source =.\SQLEXPRESS; Initial Catalog = InitDatabase; Integrated Security = True";
        }
        
        private void taoData_Click(object sender, EventArgs e)
        {
            try
            {
                var connString = @"Data Source =.\SQLEXPRESS; Initial Catalog = QLKTX; Integrated Security = True";
                var chuoiKetNoi = chuoiketNoi.Text;
                if(!string.IsNullOrEmpty(chuoiketNoi.Text))
                {
                    connString = chuoiKetNoi;
                }
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    ScriptData scriptData = new ScriptData();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "USE [master]";
                    cmd.ExecuteNonQuery();


                    cmd.CommandText = scriptData.CreateDataBase.ToString();
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "USE [QL_TT_CanBo]";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = scriptData.CreateTable1.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateTable2.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateTable3.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateTable4.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateTable5.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateTable6.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateTable7.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateTable8.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateTable9.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateTable10.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateTable11.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateTable12.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateTable13.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateTable14.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateTable15.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateTable16.ToString();
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = scriptData.CreateFunction1.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateFunction2.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateFunction3.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateFunction4.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateFunction5.ToString();
                    cmd.ExecuteNonQuery();


                    cmd.CommandText = scriptData.CreateForeignKey1.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateForeignKey2.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateForeignKey3.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateForeignKey4.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateForeignKey5.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateForeignKey6.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateForeignKey7.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateForeignKey8.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateForeignKey9.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateForeignKey10.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateForeignKey11.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateForeignKey12.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = scriptData.CreateForeignKey13.ToString();
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "USE [master]";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "ALTER DATABASE [QL_TT_CanBo] SET  READ_WRITE ";
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    MessageBox.Show("tạo xong");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
