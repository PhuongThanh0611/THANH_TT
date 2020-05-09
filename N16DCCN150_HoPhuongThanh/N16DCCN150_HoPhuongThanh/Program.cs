using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace N16DCCN150_HoPhuongThanh
{
    
    static class Program
    {
        public static SqlConnection connection = new SqlConnection();
        public static SqlDataReader myReader;
        public static SqlCommand sqlcmd;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        //public static String GetConnectionString()
        //{
        //    return @"Data Source=DESKTOP-T1T4751\SERVER1;Initial Catalog=N16DCCN150_HoPhuongThanh;User ID=sa;Password=123;";
        //}
        public static string connectionString = ConfigurationManager.ConnectionStrings["CHUNGKHOAN"].ConnectionString;
        public static SqlDataReader ExecSqlDataReader(string strLenh) // doc du lieu
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, connection);
            sqlcmd.CommandType = CommandType.Text;
            if (connection.State == ConnectionState.Closed) connection.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static int KetNoi()
        {
            try { 
            //if(connection == null)
            //{
                connection = new SqlConnection(connectionString);
                connection.Open();
                return 1;
            //}
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối database !!!" + ex.Message);
                return 0;
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            Application.Run(new FormMain());
        }
    }

}
