using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoEDD.listaUsuarios
{
    class nodoUsuario
    {
        public String tipoUsuario;
        public String nombreUsuario;
        public String contrasenaUsuario;
        nodoUsuario siguiente;

        public nodoUsuario getSiguiente()
        {
            return siguiente;
        }

        public void setSiguiente(nodoUsuario siguiente)
        {
            this.siguiente = siguiente;
        }

        public nodoUsuario(String tipo, String nombre, String contrasena)
        {
            tipoUsuario = tipo;
            nombreUsuario = nombre;
            contrasenaUsuario = contrasena;
        }
    }
}
