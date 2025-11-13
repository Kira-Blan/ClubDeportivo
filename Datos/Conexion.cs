using iText.StyledXmlParser.Jsoup.Safety;
using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;

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

        private Conexion() // asignamos valores a las variables de la conexion
        {
            // variables usadas para la repetición de líneas de código

            bool correcto = false;
            int mensaje;
            // creamos las variables para recibir los datos desde el teclado
            // =============================================================

            string T_servidor = "Servidor";
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave"; // se antepuso la T para indicar que vienen desde el teclado

            /* -------------------------------------------------------------
             * ciclo while para volver a repetir el ingreso de datos
             * la variable correcto la inicializamos para ingresar al ciclo
             * -------------------------------------------------------------*/

            while (correcto != true)
            {
                // Armamos los cuadros de dialogo para el ingreso de datos
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese puerto", "DATOS DE INSTALACIÓN MySQL");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
                T_clave = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese clave", "DATOS DE INSTALACIÓN MySQL");


                /* ------------------------------------------------------------------------
                 * controlamos que los datos ingresados para acceder a MySQL sean correctos
                 * -----------------------------------------------------------------------*/

                mensaje = (int)MessageBox.Show("Su ingreso: Servidor: " + T_servidor + " Puerto: " + T_puerto + " Usuario: " + T_usuario + " Clave: " + T_clave, "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mensaje != 6) // el valor 6 corresponde al SI
                {
                    MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                    correcto = false;
                }
                else
                {
                    correcto = true;
                }
            }


            // reemplazamos los datos concretos que teniamos por las variables

            this.baseDatos = "ComC_Grupo18";
            this.servidor = T_servidor; // "localhost";
            this.puerto = T_puerto; // "3306";
            this.usuario = T_usuario; // "root";
            this.clave = T_clave;   // "";
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
