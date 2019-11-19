using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoEDD
{
    class nodoListaTabla
    {
        public int id;
        public String nombre;
        public String nit;
        public int telefono;
        public String genero;
        public String correo;
        nodoListaTabla siguiente;

        public nodoListaTabla getSiguiente()
        {
            return siguiente;
        }

        public void setSiguiente(nodoListaTabla siguiente)
        {
            this.siguiente = siguiente;
        }

        public nodoListaTabla(int id, String nombre, String nit, int telefono, String genero, String correo)
        {
            this.nombre = nombre;
            this.nit = nit;
            this.telefono = telefono;
            this.genero = genero;
            this.correo = correo;
        }
    }
}
