using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNACH.calculador.windows
{
    public partial class Form1 : Form
    {

        public Form1()
        {
         
            InitializeComponent();
        }

        /*Botonoes Operaciones*/
        private void button1_Click(object sender, EventArgs e)
        {

            igual.Text = (Convert.ToDouble(primern.Text) *
            Convert.ToDouble(segundon.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            igual.Text = (Convert.ToDouble(primern.Text) +
             Convert.ToDouble(segundon.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            igual.Text = (Convert.ToDouble(primern.Text) -
            Convert.ToDouble(segundon.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            igual.Text = (Convert.ToDouble(primern.Text) /
            Convert.ToDouble(segundon.Text)).ToString();

        }
        private void button7_Click(object sender, EventArgs e)
        {
            igual.Text = (Convert.ToDouble(primern.Text) /
             Convert.ToDouble(segundon.Text)).ToString();

        }
        /*Boton Limpiar*/
        private void button5_Click(object sender, EventArgs e)
        {
            primern.Text = " ";
            segundon.Text = " ";
            igual.Text = " ";
        }

        /*Boton Salir*/
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void primern_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void segundon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
