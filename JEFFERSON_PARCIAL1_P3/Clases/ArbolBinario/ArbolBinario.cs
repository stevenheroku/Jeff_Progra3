using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEFFERSON_PARCIAL1_P3.Clases.ArbolBinario
{
    class ArbolBinario
    {
        protected Nodo raiz;

        public ArbolBinario()
        {
            raiz = null;
        }
        public ArbolBinario(Nodo Valorraiz)
        {
            this.raiz = Valorraiz;
        }

        public Nodo getRaiz()
        {
            return raiz;
        }

        ////public int totalNodosNivel(Nodo aux, int n)
        ////{
        ////    if (aux != null)
        ////    {
        ////        if (n == 0)
        ////        {
        ////            return totalNodosNivel(aux->subarbolIzquierdo, n - 1) + totalNodosNivel(aux->subarbolDerecho, n - 1) + 1;
        ////        }
        ////        else
        ////        {
        ////            return totalNodosNivel(aux->subarbolIzquierdo, n - 1) + totalNodosNivel(aux->subarbolDerecho, n - 1);

        ////        }
        ////    }
        ////    return 0;
        ////}

        //public int contarHojas(Nodo arbol)
        //{
        //    if (arbol == null)
        //    {
        //        return 0;
        //    }
        //    if ((arbol->subarbolDerecho == null) && (arbol->subarbolIzquierdo == null))
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return contarHojas(arbol->subarbolIzquierdo) + contarHojas(arbol->subarbolDerecho);
        //    }
        //}



        public Nodo raizArbol()
        {
            return raiz;
        }

        bool esVacio()
        {
            return raiz == null;
        }

        public static Nodo nuevoArbol(Nodo ramaIzqda, object dato, Nodo ramaDrcha)
        {
            return new Nodo(ramaIzqda, dato, ramaDrcha);
        }
    }
}
