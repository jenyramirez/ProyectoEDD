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
    public partial class Registro : Form
    {
        int contadorBoton = 1;
        public Form1 nuevo1 = new Form1();
        Registro nuevo;
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuarios = nombre.Text;
            String contra = contrasena.Text;
            String tipo = Convert.ToString(comboTipo.SelectedItem);

            switch (contadorBoton)
            {
                case 1:
                    if (usuarios.Equals(""))
                    {
                        MessageBox.Show("Necesita el nombre del usuario para poder registrarse", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else if (contra.Equals(""))
                    {
                        MessageBox.Show("Necesita una contrasena para poder registrarse", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        contadorBoton = 2;
                    }
                    break;

                case 2:
                    if (tipo.Equals("Administrador"))
                    {
                        if (contraAdministrador.Visible==true)
                        {
                            String contraAdministrador1 = contraAdministrador.Text;
                            if (contraAdministrador1.Equals("12345"))
                            {
                                MessageBox.Show("Registro como administrador realizado existosamente", "EXCELENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form1.Nueva.insertar(tipo, usuarios, contra);
                                nuevo1.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("La contrasena exclusiva del administrador no coincide", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese la contrasena exclusiva del administrador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            contraAdministrador.Enabled = true;
                            contraAdministrador.Visible = true;
                            labelContraAdministrador.Visible = true;
                        }
                    }
                    else if (tipo.Equals("Gestor de operaciones"))
                    {
                        Form1.Nueva.insertar(tipo, usuarios, contra);
                        contraAdministrador.Enabled = false;
                        contraAdministrador.Visible = false;
                        labelContraAdministrador.Visible = false;
                        MessageBox.Show("Usuario ingresado existosamente", "EXCELENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 nuevo = new Form1();
                        nuevo.Show();
                        this.Hide();
                        contadorBoton = 3;
                        //Aqui se inserta a la lista enlazada la informacion
                    }
                    break;

                case 3:
                    contraAdministrador.Enabled = false;
                    contraAdministrador.Visible = false;
                    labelContraAdministrador.Visible = false;
                    contadorBoton = 1;
                    break;
            }
        }

        private void labelContraAdministrador_Click(object sender, EventArgs e)
        {

        }
    }
}
