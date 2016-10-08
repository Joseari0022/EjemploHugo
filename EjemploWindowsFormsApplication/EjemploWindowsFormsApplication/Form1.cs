using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploWindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LlenarClase(Usuarios u)
        {
            u.NombreUsuario = NombretextBox.Text;
            u.Contrasena = ContrasenatextBox.Text;
        }
        private void Savebutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();

            LlenarClase(usuario);
            UsuariosBLL.Insetar(usuario);
        }
    }
}
