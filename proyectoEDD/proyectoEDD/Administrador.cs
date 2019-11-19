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
    public partial class Administrador : Form
    {
        //clienteForm clientes1;
        fechaForm formularioFecha;
        public Administrador()
        {
            InitializeComponent();
        }

        private void clientes_Click(object sender, EventArgs e)
        {
            formularioFecha = new fechaForm();
            formularioFecha.Show();
            //clientes1 = new clienteForm();
            //clientes1.Show();
        }
    }
}
