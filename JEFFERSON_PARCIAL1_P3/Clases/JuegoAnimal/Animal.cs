using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEFFERSON_PARCIAL1_P3.Clases.JuegoAnimal
{
    class Animal
    {
        public string id_ani { get; set; }
        public string nombre { get; set; }
        public string caracteristica { get; set; }

        public List<Animal> properties { get; set; }

        public Animal()
        {
            properties = new List<Animal>();
        }

        public List<Animal> CargaAnimales()
        {

            return new Existentes().CargarAni();
        }
       
    }
}
