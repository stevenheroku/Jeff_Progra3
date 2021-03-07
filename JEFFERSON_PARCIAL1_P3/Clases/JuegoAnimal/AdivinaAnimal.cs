using JEFFERSON_PARCIAL1_P3.Clases.ArbolBinario;
using JEFFERSON_PARCIAL1_P3.Clases.BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEFFERSON_PARCIAL1_P3.Clases.JuegoAnimal
{
    class AdivinaAnimal
    {
        int cant;
        private static Nodo raiz;
        List<Animal> nodos = new Animal().CargaAnimales();
        //List<Animal> mimica = new Animal().Cargarmimicas();

        public AdivinaAnimal()
        {
                raiz = new Nodo("Elefante");
        }

       
        public void jugar()
        {

            CargaranimalesNodo();
            Nodo nodo = raiz;
            //Console.WriteLine(nodo.dato.ToString()+"?");
            //Console.WriteLine(nodo.dato.ToString() + "?");
            while (nodo != null)// pregunta
            {
                if (nodo.izquierda != null)// pregunta existente
                {
                    Console.WriteLine("\nTU ANIMAL "+nodo.valorNodo() + "??");
                    nodo = (respuesta()) ? nodo.izquierda : nodo.derecha;

                }
                else
                {
                    Console.WriteLine($"Ya se, es un {nodo.valorNodo()}?");
                    if (respuesta())
                    {
                        Console.WriteLine("Gane!!    :)");
                    }
                    else
                    {
                        //Conexion n = new Conexion();
                        animalNuevo(nodo);
                        //n.MostrarAnimales(nodo);
                    }
                    nodo = null;
                    return;
                }
            }// final del ciclo while
        }// fin del metodo jugar



        //respuesta que hace al usuario
        public bool respuesta()
        {
            while (true)
            {
                String resp = Console.ReadLine().ToLower().Trim();
                if (resp.Equals("si")) return true;
                if (resp.Equals("no")) return false;
                Console.WriteLine("La respuesta debe ser si o no");

            }
        }// fin de la respuesta al usuario





        public void animalNuevo(Nodo nodo)

        {
            //Console.WriteLine(name);
            //Console.WriteLine(mimica);
            Conexion cn = new Conexion();
            String animalNodo = (String)nodo.valorNodo();
            Console.WriteLine("Cual es tu animal pues?");
            string nuevoA = Console.ReadLine();
            Console.WriteLine($"Que pregunta con respuesta si / no puedo hacer para poder decir que es un {nuevoA}");
            string carac = Console.ReadLine();
            Nodo nodo1 = new Nodo(animalNodo);
            Nodo nodo2 = new Nodo(nuevoA);
            Console.WriteLine($"Para un(a) {nuevoA} la respuesta es si o no ?");
            nodo.nuevoValor(carac + "?");





            if (respuesta())
            {
                nodo.izquierda = nodo2;
                nodo.derecha = nodo1;
            }
            else
            {
                nodo.izquierda = nodo1;
                nodo.derecha = nodo2;
            }

            //valido la lista si el animal que esta ingresando el usuario ya esta
            // si ya existe el animal mostrar un mensaje y volvera a preguntar si desea volver a jugar
            if (nodos.Any(x => x.nombre == nuevoA))
            {
                Console.WriteLine("\nEse animal ya existe en la base de datos");
                Console.WriteLine("Debe insertar un  animal que no exista");
            }
            else
            {
                AguardarDt insert = new AguardarDt();
                insert.guardaNuevo(nuevoA, carac);
                Console.WriteLine("NUEVO ANIMAL REGISTRADO CORRECTAMENTE");
            }


            //string cadena = "insert into juegoanimals(Nombre,Caracteristica) values ('" + nuevoA + "','" + carac + "')"; 
            //new Conexion().EjecutaSQLDirecto(cadena);



        }

        public void CargaranimalesNodo()
        {
            Existentes enlistar = new Existentes();
            enlistar.ListadeAnimales();

            //valido la cantidad de datos que tiene mi lista que la cargo de la  base de datos
            //si es mayor que 0 entonces entra al if
            if (nodos.Count > 0)
            {



                if (nodos.Count == 0)
                {
                    //creo un nuevo nodo
                    // raiz = new Nodo(nodo.nombre);
                    Console.WriteLine("NO HAY DATOS EN LA LISTA");

                }
                else
                {
                    for (int i = 0; i < enlistar.characteristic.Count; i++)
                    {
                        //creo un nuevo nodocondicion que va ser nodo caracteristica
                        Nodo nodoCondicion = new Nodo(enlistar.characteristic[i]);
                        // al nodo condicion.izquierda le paso a la izquiera el nombre del animal
                        nodoCondicion.izquierda = new Nodo(enlistar.name[i]);
                        // y el nodo derecha va ser la caracteristica del animal por ejemplo maulla!
                        nodoCondicion.derecha = raiz;
                        //raiz va tomar el valor de nodocondicion 
                        raiz = nodoCondicion;
                    }

                }

                // hasta terminar de recorrer toda la lista y si en todos digo que no es el animal
                //entonces preguntara cual es tu animal y ese animal lo aguardo en la base de datos
                // junto con la característica y al volver a ejecutar el programa carga los animales
                // y se crea el arbol en el nodo raiz y va ir mostrando la caracteristica de cada uno
                //
                int pausa = 0;

            }
        }
        public void ImprimirTodos()
        {
            Existentes list = new Existentes();
            list.ListadeAnimales();
            Console.WriteLine("\t\tAnimal" + "\t\tCaracteristica\n");
            int posicion = 1;
            for (int i = 0; i < nodos.Count; i++)
            {
                //Console.WriteLine("\tAnimal"+"\t\tCaracteristica");
                Console.WriteLine("Posicion: " + posicion + "\t" + list.name[i] + "\t\t" + list.characteristic[i]);
                posicion++;
            }

        }



    }
}
