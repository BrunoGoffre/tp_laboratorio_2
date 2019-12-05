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
        /// <summary>
        /// Limpia todos los campos de el formulario
        /// </summary>
        public void Limpiar()
        {
            txtBoxNumero1.Clear();
            txtBoxNumero2.Clear();
            label1.Text = "";
            ComboBoxOperadores.Text = "";
        }
        /// <summary>
        /// Devulve la operacion indicado por parametros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.Operar(new Numero(numero1), new Numero(numero2), operador);
        }
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCerrar_click(object sender, EventArgs e)
        {
            Close();
        }        
        /// <summary>
        /// Utiliza el metodo Limpiar y establece los botones DecimalBinario y Binario y decimal en false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnConvertirDecimalBinario.Enabled = false;
            btbBinarioDecimal.Enabled = false;
        }
        /// <summary>
        /// Utiliza el metodo operar y establece el botono DeciamalBinario en true y BinarioDecimal en false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOperar_Click(object sender, EventArgs e)
        {
            label1.Text = Operar(txtBoxNumero1.Text, txtBoxNumero2.Text, ComboBoxOperadores.Text).ToString();
            btnConvertirDecimalBinario.Enabled = true;
            btbBinarioDecimal.Enabled = false;                
        }
        /// <summary>
        /// Convierte el resultante de la operacion a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBinarioDecimal_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                label1.Text = Numero.BinarioDecimal(label1.Text);
                btbBinarioDecimal.Enabled = false;
                btnConvertirDecimalBinario.Enabled = true;
            }
        }
        /// <summary>
        /// Convierte el resultante de la conversion previa a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
