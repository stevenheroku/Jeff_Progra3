using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEFFERSON_PARCIAL1_P3.Clases.ArbolBinario
{
    class Nodo
    {
        public object dato;
        public Nodo izquierda;
        public Nodo derecha;


        public Nodo(object valor)
        {

            dato = valor;
            izquierda = null;
            derecha = null;

        }

        public Nodo(Nodo ramaizquierda, object valor, Nodo ramaderecha)
        {
            dato = valor;
            izquierda = ramaizquierda;
            derecha = ramaderecha;
        }

        public void visitar()
        {
            Console.WriteLine(dato + "<->");
        }

        public object valorNodo()
        {
            return dato;
        }

        public Nodo subarbolDerecho()
        {
            return derecha;
        }

        public Nodo subarbolIzquierdo()
        {
            return izquierda;
        }

        public void nuevoValor(object nv)
        {
            dato = nv;
        }

        public void ramaIzquierda(Nodo n)
        {
            izquierda = n;
        }

        public void ramaDerecha(Nodo a)
        {
            derecha = a;
        }

    }
}
