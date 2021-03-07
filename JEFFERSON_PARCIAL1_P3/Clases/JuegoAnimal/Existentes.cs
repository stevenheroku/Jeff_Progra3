using JEFFERSON_PARCIAL1_P3.Clases.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEFFERSON_PARCIAL1_P3.Clases.JuegoAnimal
{
    class Existentes
    {

        public List<string> name = new List<string>();
        public List<string> characteristic = new List<string>();
        public List<Animal> CargarAni()
        {
            Conexion cn = new Conexion();
            Animal users = new Animal();
            List<Animal> nomanimals = new List<Animal>();

            DataTable dt = cn.consultaTablaDirecta($"SELECT * FROM examenanimales ");
            //SELECT animalnombre FROM animales WHERE idanimales =1;
            //DataTable dt = cn.consultaTablaDirecta($"SELECT Nombre FROM juegoanimals WHERE id_animal");

            foreach (DataRow dr in dt.Rows)
            {

                // nomanimals.Add(dr[ani].ToString());a

                //users.id_ani = dr["id_animal"].ToString();
                users.nombre = dr["Nombre"].ToString();
                users.caracteristica = dr["Caracteristica"].ToString();
                nomanimals.Add(users);
                users = new Animal();

            }
            return nomanimals;
        }

        public void ListadeAnimales()
        {
            Conexion cn = new Conexion();
            Animal users = new Animal();


            DataTable dt = cn.consultaTablaDirecta("SELECT *  FROM examenanimales");

            foreach (DataRow dr in dt.Rows)
            {
                name.Add(dr["Nombre"].ToString());
                characteristic.Add(dr["Caracteristica"].ToString());

            }

        }


    }
}
