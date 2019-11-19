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
    public partial class clienteForm : Form
    {
        listaTabla lista;
        private tablaNueva nueva1 = new tablaNueva();

        public int contador = 0;
        public clienteForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            contador++;
            String nombre1 = nombre.Text;
            String nit1 = nit.Text;
            int telefono1 = Convert.ToInt32(telefono.Text);
            String genero1 = Convert.ToString(comboGenero.SelectedItem);
            String correo1 = corre.Text;
            fechaForm.Lista.insertar(new nodoListaTabla(contador, nombre1, nit1, telefono1, genero1, correo1));
            MessageBox.Show("Cliente ingresado existosamente", "EXCELENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //insertarEnTabla(contador, nombre1, nit1, telefono1, genero1, correo1);
        }


        public void insertarEnTabla(int id, String dia, String mes, String ano)
        {
            nueva1.InsertarTabla(id, dia, mes, ano, lista);
            nueva1.mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
