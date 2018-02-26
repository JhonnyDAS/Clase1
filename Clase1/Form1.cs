using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clase1
{
    public partial class Form1 : Form
    {
        double _a, _b;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double a, b;
            Validar(out a, out b);
            Resultado(a, b);
        }

        private void Resultado(double a, double b)
        {
            double s;
            s = a + b;
            lblResultado.Text = s.ToString();
        }

        private void Validar(out double a, out double b)
        {
            if (txtNumUno.Text != "")
                a = Convert.ToDouble(txtNumUno.Text);
            else
                a = 0;

            if (txtNumDos.Text != String.Empty)
                b = Convert.ToDouble(txtNumDos.Text);
            else
                b = 0;
        }
    }
}
