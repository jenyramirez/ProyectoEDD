using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoEDD
{
    class Tabla
    {
        private nodoTablaHash[] arreglo;
        private int tamano;
        private int contadorTamano = 0;
        private nodoTablaHash[] nuevoTamano=null;
        private BitArray IsPrime;
        private int contadorRe = 0;
        private int contador2 = 0;

        public Tabla()
        {
            //definirTamano();
        }

        public void definirTamano()
        {
            tamano = 3;
            //this.tamano = tamano;
            arreglo = new nodoTablaHash[tamano];

            for (int i = 0; i < arreglo.Length; i++)
            {
                nodoTablaHash nuevo = new nodoTablaHash();
                nuevo.indice = -1;
                arreglo[i] = nuevo;
            }
            IsPrime = ESieve(1000);
            //Cuando tenga el menos 1 quiere decir que no tiene nada que aun esta vacio
        }

        public void obtenerK(nodoTablaHash nuevoNodo)
        {
            int contador1 = 0;
            String temporal = " ";
            int suma = 0;
            MessageBox.Show("ENTRA");
            String cadena = nuevoNodo.dia + nuevoNodo.mes + nuevoNodo.ano;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (contador1 == 3)
                {
                    funcionHash(suma, arreglo, nuevoNodo);
                }
                int nombreCliente = Encoding.ASCII.GetBytes(cadena.ToString())[i];
                suma += nombreCliente;
                //temporal+=nombreCliente.charAt(i);
                contador1++;
            }
        }


        public void funcionHash(int k, nodoTablaHash[] arreglo, nodoTablaHash nuevoNodo)
        {
            int indiceTemporal;
            double porcentaje;
            indiceTemporal = k % tamano;
            //System.out.println("El indice es-->"+indiceTemporal);
            int direccionamiento = 0;
            //SI EXISTEN COLICIONES
                
            
            while (arreglo[indiceTemporal].indice != -1)
            {
                MessageBox.Show(contador2+"-->"+arreglo.Length);
                if (contador2 >= arreglo.Length)
                {
                    tamano= Convert.ToInt32(SiguientePrimo(tamano));
                    contadorTamano = 1;
                    MessageBox.Show("AQUI ES EL REHASHING" + tamano);
                    break;
                }

                MessageBox.Show("Ocurrio una colision-->"+(indiceTemporal-1) + " Cambia a-->" + indiceTemporal);
                direccionamiento = (int)((Math.Pow((indiceTemporal + 1), 2)) + k);
                indiceTemporal = direccionamiento;
                indiceTemporal++;
                indiceTemporal %= tamano;
                contadorRe++;
                //contadorTamano++;
                break;
            }
            arreglo[indiceTemporal].indice = 0;
            arreglo[indiceTemporal].dia = nuevoNodo.dia;
            arreglo[indiceTemporal].mes = nuevoNodo.mes;
            arreglo[indiceTemporal].ano = nuevoNodo.ano;
            arreglo[indiceTemporal].lista = nuevoNodo.lista;

            porcentaje = (50.0 * tamano) / 100.0;
            
            contador2++;
        }

        public long SiguientePrimo(long numero)
        {
            //MessageBox.Show("ENTRA");
            nodoTablaHash[] temporal;
            int nuevoTamano1 = 0;
            long b = numero;
            nuevoTamano1 = siguientePrimo(Convert.ToInt32(b));
            tamano = nuevoTamano1;
            //int nuevo1 = nuevoTamano.Length - nuevoTamano1;
            ///arreglo = new nodoTablaHash[nuevoTamano1];
            //Array.Copy(arreglo, nuevoTamano1, 0);
            //arreglo = nuevoTamano;
            temporal = new nodoTablaHash[nuevoTamano1];

            for (int i = 0; i < temporal.Length; i++)
            {
                nodoTablaHash nuevo = new nodoTablaHash();
                nuevo.indice = -1;
                temporal[i] = nuevo;
            }

            for (int i=0; i< arreglo.Length;i++)
            {
                if (arreglo[i].indice == 0)
                {
                    temporal[i].indice = arreglo[i].indice;
                    temporal[i].dia = arreglo[i].dia;
                    temporal[i].mes = arreglo[i].mes;
                    temporal[i].ano = arreglo[i].ano;
                    temporal[i].lista = arreglo[i].lista;
                }
                else
                {
                    temporal[i].indice = arreglo[i].indice;
                }

            }

            arreglo = new nodoTablaHash[nuevoTamano1];
            for (int i = 0; i < arreglo.Length; i++)
            {
                nodoTablaHash nuevo = new nodoTablaHash();
                nuevo.indice = -1;
                arreglo[i] = nuevo;
            }

            for (int i = 0; i < temporal.Length; i++)
            {
                if (temporal[i].indice == 0)
                {
                    arreglo[i].indice = temporal[i].indice;
                    arreglo[i].dia = temporal[i].dia;
                    arreglo[i].mes = temporal[i].mes;
                    arreglo[i].ano = temporal[i].ano;
                    arreglo[i].lista = temporal[i].lista;
                }
                else
                {
                    arreglo[i].indice = temporal[i].indice;
                }
            }

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == null)
                {
                    nodoTablaHash nuevo = new nodoTablaHash();
                    nuevo.indice = -1;
                    arreglo[i] = nuevo;
                }
                else
                {
                    //MessageBox.Show("====>"+ arreglo[i].indice.ToString());
                }
            }
            long nuevo2 = long.Parse(Convert.ToString(siguientePrimo(Convert.ToInt32(b))), System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowLeadingSign);
            MessageBox.Show(nuevo2.ToString());
            contador2 = 0;
            return nuevo2;
        }



        public static BitArray ESieve(int upperLimit)
        {
            int sieveBound = (int)(upperLimit - 1);
            int upperSqrt = (int)Math.Sqrt(sieveBound);
            BitArray PrimeBits = new BitArray(sieveBound + 1, true);
            PrimeBits[0] = false;
            PrimeBits[1] = false;

            for (int j=4; j<sieveBound; j+=2)
            {
                PrimeBits[j] = false;
            }

            for (int i=3; i<=upperSqrt; i+=2)
            {
                if (PrimeBits[i])
                {
                    int inc = i * 2;
                    for (int j=i*i; j<=sieveBound; j+=inc)
                    {
                        PrimeBits[j] = false;
                    }
                }
            }
            return PrimeBits;
        }

        public int siguientePrimo(int b)
        {
            b++;
            for (; b < IsPrime.Length; b++)
            {
                if (IsPrime[b])
                    return b;
            }
            return -1;
        }


        public void ver()
        {
            MessageBox.Show("\n\n=====VER=====");
            for (int j = 0; j < arreglo.Length; j++)
            {
                MessageBox.Show("[" + j + "] " + arreglo[j].dia.ToString());
                arreglo[j].lista.Mostrar();
            }
            MessageBox.Show("=================\n");
        }

        public bool verificarTabla(String dia, String mes, String ano)
        {
            for (int j = 0; j < arreglo.Length; j++)
            {
                if ((arreglo[j].dia.ToString()).Equals(dia))
                {
                    if ((arreglo[j].mes.ToString()).Equals(mes))
                    {
                        if ((arreglo[j].ano.ToString()).Equals(ano))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }


        public listaTabla retornarLista(String dia, String mes, String ano)
        {
            for (int j = 0; j < arreglo.Length; j++)
            {
                if ((arreglo[j].dia.ToString()).Equals(dia))
                {
                    if ((arreglo[j].mes.ToString()).Equals(mes))
                    {
                        if ((arreglo[j].ano.ToString()).Equals(ano))
                        {
                            return arreglo[j].lista;
                        }
                    }
                }
            }
            return null;
        }
    }
}
