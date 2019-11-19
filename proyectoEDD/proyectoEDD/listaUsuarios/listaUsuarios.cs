using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoEDD.listaUsuarios
{
    class listaUsuarios
    {
        public nodoUsuario inicio;
        public nodoUsuario fin;
        public String temporalLista;
        // public inicio inicio1= new inicio();

        public listaUsuarios()
        {

        }

        public bool vacia()
        {
            if (inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void insertar(nodoUsuario nuevo)
        {
            nodoUsuario actual;
            if (vacia())
            {
                actual = new nodoUsuario(nuevo.tipoUsuario, nuevo.nombreUsuario, nuevo.contrasenaUsuario);
                inicio = actual;
                fin = actual;
            }
            else
            {
                actual = nuevo;
                fin.setSiguiente(actual);
                fin = actual;
            }
        }

        public void Mostrar()
        {
            if (inicio == null)
            {
                //System.out.println("La lista esta vacia");

            }
            else
            {
                nodoUsuario temporal = inicio;
                while (temporal != null)
                {
                    //System.out.println(temporal.tipo + "  " + temporal.nombreVariable + "  " + temporal.valorVariable);
                    temporal = temporal.getSiguiente();
                }
            }
        }
    }
}
