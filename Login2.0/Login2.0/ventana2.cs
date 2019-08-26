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
    public partial class ventana2 : Form
    {
        public ventana2()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button_compras_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion; 
            if (checkBox_visual.Checked==true)
            {
                conteo++; 
            }
            if (checkBox_visualbasic.Checked==true)
            {
                conteo++; 
            }
            if (radioButton_tarjeta.Checked==true)
            {
                seleccion =  " Tarjeta de credito"; 
            }
            else
            {
                seleccion = "PayPal"; 
            }
            MessageBox.Show("Has seleccionado" + conteo + "cursos y tu metodo de pago es" + seleccion); 
        }

        private void Button_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Visible = true; 
        }

        private void RadioButton_paypal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Ventana2_Load(object sender, EventArgs e)
        {
            if ((int)e.KeyChar==(int)Keys.Enter)
            {
                
            }
        }
    }
}
