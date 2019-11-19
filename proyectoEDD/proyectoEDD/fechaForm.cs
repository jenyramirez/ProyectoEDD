using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoEDD
{
    public partial class fechaForm : Form
    {
        public int contador = 0;
        clienteForm clientes1;
        private static listaTabla lista1= new listaTabla();
        readonly tablaNueva nueva1 = new tablaNueva();

        public fechaForm()
        {
            InitializeComponent();
            comboDIA.SelectedIndex = 0;
            comboMES.SelectedIndex = 10;
            comboANO.SelectedIndex = 4;
        }

        internal static listaTabla Lista { get => lista1; set => lista1 = value; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            

            /*
            //VERIFICAR SI EXISTE
            if (nueva1.verificarFecha(dia, mes, ano))
            {
                lista1 = nueva1.retornarLista(dia, mes, ano);
                lista1.insertar(new nodoListaTabla(contador, nombre1, nit1, Convert.ToInt32(telefono1), genero1, correo1));
                MessageBox.Show("YA EXISTE LA FECHA");
            }
            else
            {
                insertarEnTabla(contador, dia, mes, ano);
            }*/
            


            //clientes1 = new clienteForm();
            //clientes1.Show();
            //this.Hide();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fechaForm_Load(object sender, EventArgs e)
        {

        }

        private void aceptar_Click_1(object sender, EventArgs e)
        {
            
            contador++;
            String nombre1 = nombre.Text;
            String nit1 = nit.Text;
            String telefono1 = telefono.Text;
            String genero1 = Convert.ToString(comboGenero.SelectedItem);
            String correo1 = corre.Text;
            lista1.insertar(new nodoListaTabla(contador, nombre1, nit1, Convert.ToInt32(telefono1), genero1, correo1));
            MessageBox.Show("Cliente ingresado existosamente", "EXCELENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        public void insertarEnTabla(int id, String dia, String mes, String ano)
        {
            nueva1.InsertarTabla(id, dia, mes, ano, lista1);
            nueva1.mostrar();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            String dia = Convert.ToString(comboDIA.SelectedItem);
            String mes = Convert.ToString(comboMES.SelectedItem);
            String ano = Convert.ToString(comboANO.SelectedItem);
            insertarEnTabla(contador, dia, mes, ano);
            MessageBox.Show("Informacion almacenada", "EXCELENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
