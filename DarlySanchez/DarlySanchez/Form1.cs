using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarlySanchez
{
    public partial class CalculoIntereses : Form
    {
        public CalculoIntereses()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            {
                deposito();
            }


            private void deposito()
            {
                int interes;
                int deposito;
                int resultado;

                listBox1.Items.Add("Enero");
                deposito = 200000;
                interes = Convert.ToInt32(deposito * 0.015);
                resultado = interes;
                listBox1.Items.Add(interes);
                listBox1.Items.Add("Febrero");
                deposito = 200000;
                interes = Convert.ToInt32(deposito * 0.015 * 2);
                resultado = interes;
                listBox1.Items.Add(interes);
                listBox1.Items.Add("Marzo");
                deposito = 200000;
                interes = Convert.ToInt32(deposito * 0.015 * 3);
                resultado = interes;
                listBox1.Items.Add(interes);
                listBox1.Items.Add("Abril");
                deposito = 200000;
                interes = Convert.ToInt32(deposito * 0.015 * 4);
                resultado = interes;
                listBox1.Items.Add(interes);
                listBox1.Items.Add("Mayo");
                deposito = 200000;
                interes = Convert.ToInt32(deposito * 0.015 * 5);
                resultado = interes;
                listBox1.Items.Add(interes);
                listBox1.Items.Add("Junio");
                deposito = 200000;
                interes = Convert.ToInt32(deposito * 0.015 * 6);
                resultado = interes;
                listBox1.Items.Add(interes);
                listBox1.Items.Add("Julio");
                deposito = 200000;
                interes = Convert.ToInt32(deposito * 0.015 * 7);
                resultado = interes;
                listBox1.Items.Add(interes);
                listBox1.Items.Add("Agosto");
                deposito = 200000;
                interes = Convert.ToInt32(deposito * 0.015 * 8);
                resultado = interes;
                listBox1.Items.Add(interes);
                listBox1.Items.Add("Septiembre");
                deposito = 200000;
                interes = Convert.ToInt32(deposito * 0.015 * 9);
                resultado = interes;
                listBox1.Items.Add(interes);
                listBox1.Items.Add("Octubre");
                deposito = 200000;
                interes = Convert.ToInt32(deposito * 0.015 * 10);
                resultado = interes;
                listBox1.Items.Add(interes);
                listBox1.Items.Add("Noviembre");
                deposito = 200000;
                interes = Convert.ToInt32(deposito * 0.015 * 11);
                resultado = interes;
                listBox1.Items.Add(interes);
                listBox1.Items.Add("Diciembre");
                deposito = 200000;
                interes = Convert.ToInt32(deposito * 0.015 * 12);
                resultado = interes;
                listBox1.Items.Add(interes);
            }
        }
    }


  