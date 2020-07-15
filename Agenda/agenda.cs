using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Agenda
{
    class agenda
    {
        private SQLiteConnection cn = null;
        private SQLiteCommand cmd = null;
        private SQLiteDataReader reader = null;
        private DataTable table = null;

        public bool Insertar(string nombre, string telefono) 
        {
            string query = $"INSERT INTO directorio(nombre,telefono)VALUES('{nombre}','{telefono}')";
            return ExecuteNonQuery(query);
        }

        public bool Eliminar(int id) 
        {
           string query = $"DELETE FROM directorio WHERE id ='{id}'";
           return ExecuteNonQuery(query);
        }

        public bool Actualizar(int id, string nombre, string telefono) 
        {
           string query = $"UPDATE directorio SET nombre = {nombre},telefono ={telefono} WHERE id='{id}'";
           return ExecuteNonQuery(query);
        }

        private bool ExecuteNonQuery(string query) 
        {
            try
            {
                cn = conexion.conectar();
                cmd = new SQLiteCommand(query, cn);
                int rest = cmd.ExecuteNonQuery();
                if (rest == 1)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + " " + e.StackTrace);
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return false;
        }

        public DataTable Consultar()
        {
            string query = "SELECT * FROM directorio";
            return ExecuteReader(query);
        }

        public DataTable Filtrar(string texto)
        {
            string query = $"SELECT * FROM directorio WHERE Nombre LIKE '%{texto}%' OR Telefono LIKE '%{texto}%'";
            return ExecuteReader(query);
        }

        private DataTable ExecuteReader(string query) 
        {
            try
            {
                NombreColumnas();
                cn = conexion.conectar();
                cmd = new SQLiteCommand(query, cn);

                reader = cmd.ExecuteReader();

                int c = 0;
                while (reader.Read())
                {
                    c++;
                    object[] fila = new object[] { reader["id"], c, reader["nombre"], reader["telefono"] };
                    table.Rows.Add(fila);
                }

                reader.Close();
                return table;

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show( e.Message + " " +e.StackTrace);
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return table;
        }

        private void NombreColumnas() 
        {
            table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("N.");
            table.Columns.Add("Nombre");
            table.Columns.Add("Telefono");
        }
    }
}
