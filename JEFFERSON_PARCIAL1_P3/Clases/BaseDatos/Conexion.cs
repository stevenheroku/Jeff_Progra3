using JEFFERSON_PARCIAL1_P3.Clases.ArbolBinario;
using JEFFERSON_PARCIAL1_P3.Clases.JuegoAnimal;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEFFERSON_PARCIAL1_P3.Clases.BaseDatos
{
    class Conexion
    {
        MySqlConnection conexionBD;
        private String cadenaConexion { get; }

        public Conexion()
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "animales"; //Nombre de la base de datos
            string usuario = "root"; //Usuario de acceso a MySQL
            string password = ""; //Contraseña de usuario de acceso a MySQL


            cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";
        }

        public void cerraConexion()
        {
            conexionBD.Close();
        }

        public void abrirConexion()
        {
            conexionBD = new MySqlConnection(cadenaConexion);
            conexionBD.Open();
        }

        public void conectarbd()
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "animales"; //Nombre de la base de datos
            string usuario = "root"; //Usuario de acceso a MySQL
            string password = ""; //Contraseña de usuario de acceso a MySQL
            string datos = null; //Variable para almacenar el resultado

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            try
            {
                string consulta = "SELECT * from examenanimales"; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader
               
                Console.WriteLine("\nCONECTADO CORECTAMENTE!! EMPEZEMOS EL JUEGO\n");

                //while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                //{
                    
                //    datos += reader.GetString(1) + "\t" + reader.GetString(2) + "\n"; //Almacena cada registro con un salto de linea
                //}

                //Console.WriteLine(datos);

                //Console.WriteLine("CONECTADO CORECTAMENTE!! EMPEZEMOS EL JUEGO");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error Al Conectar a la Base de Datos" + ex.Message); //Si existe un error aquí muestra el mensaje
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }

        }
       
        //lo uso para hacer el select a la tabla y cargar todos los registros en la la lista 
        
        public DataTable consultaTablaDirecta(String sqll)
        {
            abrirConexion();
            MySqlDataReader dr;
            MySqlCommand comm = new MySqlCommand(sqll, conexionBD);
            dr = comm.ExecuteReader();

            var dataTable = new DataTable();
            dataTable.Load(dr);
            cerraConexion();
            return dataTable;
        }


        //insertar animales
        public void EjecutaSQLDirecto(String sqll)
        {
            abrirConexion();
            try
            {

                MySqlCommand comm = new MySqlCommand(sqll, conexionBD);
                comm.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                cerraConexion();
            }
        }


    }
}
