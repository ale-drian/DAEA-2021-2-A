using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularOB_Click(object sender, EventArgs e)
        {
            String opcion = cmbOperacion.SelectedIndex.ToString();
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);
            switch (opcion)
            {
                case "0":
                    txtResultadoOB.Text = (num1 + num2).ToString();
                    break;
                case "1":
                    txtResultadoOB.Text = (num1 - num2).ToString();
                    break;
                case "2":
                    txtResultadoOB.Text = (num1 * num2).ToString();
                    break;
                case "3":
                    if (num2 != 0)
                    {
                        txtResultadoOB.Text = ((Double)num1 / (Double)num2).ToString();
                    }
                    else {
                        txtResultadoOB.Text = "Error";
                    }
                    break;
            }
        }

        private void btnCalcularCT_Click(object sender, EventArgs e)
        {

            String escala = cmbEscala.SelectedItem.ToString();
            int temperatura = Convert.ToInt32(txtTemperatura.Text);
            switch (escala)
            {
                case "C":
                    double gradosF = 9 * temperatura / 5 + 32;
                    txtResultadoCT.Text = gradosF.ToString() + "°F";
                    break;
                case "F":
                    double gradosC = 5 * (temperatura - 32) / 9;
                    txtResultadoCT.Text = gradosC.ToString() + "°C";
                    break;
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            lbxListado.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                String mensaje = "La raíz cuadrada de " + i + " es: " +  Math.Sqrt(i);
                lbxListado.Items.Add(mensaje);
            }
        }

        private static bool esPrimo(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        private void btnPrimos_Click(object sender, EventArgs e)
        {
            int primo = 0;
            int contador = 0;
            lbxListado.Items.Clear();
            while (contador < 10)
            {
                if (esPrimo(primo))
                {
                    contador++;
                    lbxListado.Items.Add($"El primo N° {contador} es {primo}");
                }
                primo++;
            }
        }
    }
}
