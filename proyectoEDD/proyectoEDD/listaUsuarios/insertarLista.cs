using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoEDD.listaUsuarios
{
    class insertarLista
    {
        public static listaUsuarios listaNueva;
        public static int contador=0;
        public insertarLista()
        {
            listaNueva = new listaUsuarios();
        }

        public void insertar(String tipo, String nombre, String contrasena)
        {
            String resultado = encriptar(contrasena);   
            listaNueva.insertar(new nodoUsuario(tipo, nombre, resultado));
            //MessageBox.Show(tipo + " " + nombre + " " + resultado);
            //MessageBox.Show(tipo + " " + nombre + " " + contrasena);
        }

        public static String encriptar(String cadena)
        {
            String resultado = string.Empty;
            Byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(cadena);
            resultado = Convert.ToBase64String(encriptar);
            return resultado;
        }

        public static bool mostrarLista(String nombre, String contrasena)
        {
            if (listaNueva.inicio == null)
            {
                //System.out.println("La lista esta vacia");
                contador++;
                MessageBox.Show("No hay usuarios registrados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                nodoUsuario temporal = listaNueva.inicio;
                while (temporal != null)
                {
                    if (temporal.nombreUsuario.Equals(nombre) && temporal.contrasenaUsuario.Equals(contrasena))
                    {
                        return true;
                    }
                    //MessageBox.Show(temporal.tipoUsuario + "  " + temporal.nombreUsuario + "  " + temporal.contrasenaUsuario);
                    temporal = temporal.getSiguiente();
                }
            }
            return false;
        }

        public static String tipo(String nombre, String contrasena)
        {
            if (listaNueva.inicio == null)
            {
                //System.out.println("La lista esta vacia");
                contador++;
                MessageBox.Show("No hay usuarios registrados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                nodoUsuario temporal = listaNueva.inicio;
                while (temporal != null)
                {
                    if (temporal.nombreUsuario.Equals(nombre) && temporal.contrasenaUsuario.Equals(contrasena))
                    {
                        return temporal.tipoUsuario;
                    }
                    //MessageBox.Show(temporal.tipoUsuario + "  " + temporal.nombreUsuario + "  " + temporal.contrasenaUsuario);
                    temporal = temporal.getSiguiente();
                }
            }
            return " ";
        }
    }
}
