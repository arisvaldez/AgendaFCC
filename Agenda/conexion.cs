using System.Data.SQLite;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Agenda
{
    class conexion
    {
        public static SQLiteConnection conectar() 
        {
            string database = Application.StartupPath + "\\mydatabase.db";
            SQLiteConnection cn = new SQLiteConnection("Data Source = " + database);
            cn.Open();
            return cn;
        }

        public static SqlConnection conectarSQLServer()
        {
            //conectionString
            string database = "myagenda";
            string server = "127.0.0.1";
            string uid = "adm";
            string pwd = "123456";
            SqlConnection cn = new SqlConnection($"database={database};server={server};uid={uid};pwd={pwd}");
            cn.Open();
            return cn;
        }
    }
}
