using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            ComboBoxOperadores.Text = ComboBoxOperadores.Items[0].ToString();            
        }

        public void Limpiar()
        {
            txtBoxNumero1.Clear();
            txtBoxNumero2.Clear();
            label1.Text = "";
            ComboBoxOperadores.Text = "";
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.Operar(new Numero(numero1), new Numero(numero2), operador);
        }

        private void ButtonCerrar_click(object sender, EventArgs e)
        {
            Close();
        }        

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnConvertirDecimalBinario.Enabled = false;
            btbBinarioDecimal.Enabled = false;
        }

        private void ButtonOperar_Click(object sender, EventArgs e)
        {
            label1.Text = Operar(txtBoxNumero1.Text, txtBoxNumero2.Text, ComboBoxOperadores.Text).ToString();
            btnConvertirDecimalBinario.Enabled = true;
            btbBinarioDecimal.Enabled = false;                
        }

        private void ButtonBinarioDecimal_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                label1.Text = Numero.BinarioDecimal(label1.Text);
                btbBinarioDecimal.Enabled = false;
                btnConvertirDecimalBinario.Enabled = true;
            }
        }

        private void ButtonConvertirDecimalBinario_Click(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(label1.Text, out aux) && label1.Text != "")
            {
                aux = Math.Abs(aux);
                label1.Text = Numero.DecimalBinario(aux);
                btbBinarioDecimal.Enabled = true;
                btnConvertirDecimalBinario.Enabled = false;
            }                     
        }
    }
}
