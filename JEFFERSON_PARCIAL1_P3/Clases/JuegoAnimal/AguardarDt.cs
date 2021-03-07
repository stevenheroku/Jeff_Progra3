using JEFFERSON_PARCIAL1_P3.Clases.BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEFFERSON_PARCIAL1_P3.Clases.JuegoAnimal
{
    class AguardarDt
    {

        public string id_animal { get; set; }
        public string nombre { get; set; }

        public string carac { get; set; }


        public void guardaNuevo(string nom, string caract)
        {
            nombre = nom;
            carac = caract;


            String sql_ = @"insert into examenanimales (Nombre,Caracteristica)
            values ( '" + nombre + "','" + carac + "')";
            new Conexion().EjecutaSQLDirecto(sql_);

        }

    }
}
