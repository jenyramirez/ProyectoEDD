using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoEDD
{
    class listaTabla
    {
        public nodoListaTabla inicio;
        public nodoListaTabla fin;
        public String temporalLista;
        // public inicio inicio1= new inicio();

        public listaTabla()
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


        public void insertar(nodoListaTabla nuevo)
        {
            nodoListaTabla actual;
            if (vacia())
            {
                actual = new nodoListaTabla(nuevo.id, nuevo.nombre, nuevo.nit, nuevo.telefono, nuevo.genero, nuevo.correo);
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
                MessageBox.Show("La lista esta vacia");

            }
            else
            {
                nodoListaTabla temporal = inicio;
                while (temporal != null)
                {
                    MessageBox.Show("-->" + temporal.nombre);
                    //System.out.println(temporal.tipo + "  " + temporal.nombreVariable + "  " + temporal.valorVariable);
                    temporal = temporal.getSiguiente();
                }
            }
        }
    }
}
