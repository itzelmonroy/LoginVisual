using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox_usuario_TextChanged(object sender, EventArgs e)
        {
            InitializeComponent(); 
        }

        private void Button_salir_Click(object sender, EventArgs e)
        {
            this.Close(); //cierra el formulario 
        }

        private void Button_ingresar_Click(object sender, EventArgs e)
        {
            if (textBox_usuario.Text=="juancho" && popo.Text=="123tamarindo")
            {
                MessageBox.Show("bienvenido don juancho");
                this.Hide();
                ventana2 CursosVentana = new ventana2();
                CursosVentana.Show();
                this.Visible = false; 
            }
            else
            {
                MessageBox.Show("usuario o contraseña no válidas");
                textBox_usuario.Text = "";
                popo.Text = "";
                textBox_usuario.Focus(); 

            }
        }

        private void TextBox_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                popo.Focus(); 
            }
        }
    }
}
