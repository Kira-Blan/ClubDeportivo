using MySql.Data.MySqlClient;

namespace clubDeportivo.Datos
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion()
        {
            this.baseDatos = "proyecto"; 
            this.servidor = "localhost";
            this.puerto = "3307";
            this.usuario = "root";
            this.clave = "";
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          "; port=" + this.puerto +
                                          "; username=" + this.usuario +
                                          "; password=" + this.clave +
                                          "; Database=" + this.baseDatos;
            }
            catch (Exception)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
