using JEFFERSON_PARCIAL1_P3.Clases.BaseDatos;
using JEFFERSON_PARCIAL1_P3.Clases.JuegoAnimal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEFFERSON_PARCIAL1_P3
{
    class Program
    {

        public static void juegoAnimales()
        {
            Console.WriteLine("Juguemos a Adivinar Animales");
            Boolean otrojuego = true;
            AdivinaAnimal juego = new AdivinaAnimal();

            do
            {

                juego.jugar(); ;
                Console.WriteLine("Jugamos otra vez?");
                otrojuego = juego.respuesta();
                Console.Clear();

            } while (otrojuego);
        }

        public static void volveraJugar()
        {
            Console.WriteLine("JUEGO DE ADIVINAR ANIMALES");
            Console.WriteLine("1.EMPEZAR A JUGAR");
            Console.WriteLine("2.OBTENER TODOS LOS DATOS DEL ARBOL");
            int opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    Console.WriteLine("ANIMALES QUE YA ESTAN AGUARDADOS");
                    Conexion conectar = new Conexion();
                    conectar.conectarbd();
                    juegoAnimales();

                    break;

                case 2:
                    AdivinaAnimal print = new AdivinaAnimal();
                    print.ImprimirTodos();

                    break;

                default:

                    break;
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            //Conexion conectar = new Conexion();
            //conectar.conectarbd();
            //juegoAnimales();

            int opcion;
            do
            {
                volveraJugar();
               

                Console.WriteLine("Desea volver a jugar");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                 opcion = int.Parse(Console.ReadLine());
                Console.Clear();
               
            } while (opcion !=2);
            




        }
    }
}
