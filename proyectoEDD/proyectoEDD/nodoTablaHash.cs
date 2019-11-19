using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoEDD
{
    class nodoTablaHash
    {
        public int id;
        public String dia;
        public String mes;
        public String ano;
        public listaTabla lista = new listaTabla();
        public int indice;

        public nodoTablaHash(int id, String dia, String mes, String ano, listaTabla lista)
        {
            this.id = id;
            this.mes = mes;
            this.ano = mes;
            this.lista = lista;
        }

        public nodoTablaHash()
        {
            id = 0;
            dia = " ";
            mes = " ";
            ano = " ";
        }
    }
}
