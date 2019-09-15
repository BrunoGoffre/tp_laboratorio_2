using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public void limpiar()
        {
            txtBoxNumero1.Clear();
            txtBoxNumero2.Clear();
            label1.Text = "";
            ComboBoxOperadores.Text = "";
        }
        public FormCalculadora()
        {
            InitializeComponent();
            ComboBoxOperadores.Enabled = true;
        }

        private void btnCerrar_click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtBoxNumero1_leave(object sender, EventArgs e)
        {
            double aux;
            if (!(double.TryParse(txtBoxNumero1.Text, out aux)))
            {
                MessageBox.Show("Error. Datos invalidos");
                txtBoxNumero1.Focus();
            }
        }

        private void txtBoxNumero2_Leave(object sender, EventArgs e)
        {
            double aux;
            if (!(double.TryParse(txtBoxNumero2.Text, out aux)))
            {
                MessageBox.Show("Error. Datos invalidos");
                txtBoxNumero2.Focus();
            }
        }

        private void btbOperar_Click(object sender, EventArgs e)
        {
            double numero1, numero2;

            if (txtBoxNumero1.Text != "" && txtBoxNumero2.Text != "")
            {
                double.TryParse(txtBoxNumero1.Text, out numero1);
                double.TryParse(txtBoxNumero2.Text, out numero2);
                string auxStr = ComboBoxOperadores.Text;            
                label1.Text = Calculadora.operar(numero1, numero2,auxStr).ToString();
            }         
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            
        }

        private void ComboBoxOperadores_Leave(object sender, EventArgs e)
        {
            string aux = ComboBoxOperadores.Text;

            if (aux != "+" && aux != "-" && aux != "/" && aux != "*")
            {
                MessageBox.Show("Datos, Invalido");
                ComboBoxOperadores.Focus();
            }
        }

        private void btbBinarioDecimal_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                label1.Text = Numero.binarioDecimal(label1.Text);
            }
        }

        private void btnConvertirDecimalBinario_Click(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(label1.Text, out aux) && label1.Text != "")
            {
                aux = Math.Abs(aux);
                label1.Text = Numero.decimalBinario(aux);
            }
                     
        }
    }
}
