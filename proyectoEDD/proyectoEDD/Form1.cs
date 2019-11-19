using proyectoEDD.listaUsuarios;
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
    public partial class Form1 : Form
    {
        private static insertarLista nueva = new insertarLista();
        Administrador admin;

        internal static insertarLista Nueva { 
            get => nueva; 
            set => nueva = value; 
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void registro_Click(object sender, EventArgs e)
        {
            Registro resgistro = new Registro();
            resgistro.Show();
            this.Hide();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            String nombreE = usuario.Text;
            String contrasenaE = insertarLista.encriptar(contrasena.Text);
            //MessageBox.Show(contrasenaE);
            if (insertarLista.mostrarLista(nombreE, contrasenaE))
            {
                String tipo = insertarLista.tipo(nombreE, contrasenaE);
                if (tipo.Equals("Administrador"))
                {
                    admin = new Administrador();
                    admin.Show();
                    this.Hide();
                }
                else
                {

                }
            }
            else
            {
                if (insertarLista.contador!=1)
                {
                    MessageBox.Show("El nombre de usuario y contraseña no coinciden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        public String desincriptar(String cadena)
        {
            string resultado = string.Empty;
            Byte[] desincriptar = Convert.FromBase64String(cadena);
            resultado = System.Text.Encoding.Unicode.GetString(desincriptar);
            //MessageBox.Show(resultado);
            return resultado;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
