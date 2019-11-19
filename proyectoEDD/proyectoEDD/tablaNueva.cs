using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoEDD
{
    class tablaNueva
    {
        Tabla tabla = new Tabla();
        nodoTablaHash nuevo;
        public tablaNueva()
        {
            tabla.definirTamano();
        }
        
        public void InsertarTabla(int id, String dia, String mes, String ano , listaTabla lista) 
        {
            nuevo = new nodoTablaHash
            {
                id = id,
                dia = dia,
                mes = mes,
                ano = ano,
                lista = lista
            };
            //MessageBox.Show("ENTRA");
            tabla.obtenerK(nuevo);
        }

        public void mostrar()
        {
            tabla.ver();
        }


        public bool verificarFecha(String dia, String mes, String ano)
        {
            if (tabla.verificarTabla(dia, mes, ano))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public listaTabla retornarLista(String dia, String mes, String ano)
        {
            return tabla.retornarLista(dia, mes, ano);
        }

    }
}
