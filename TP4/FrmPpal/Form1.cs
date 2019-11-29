using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace TP4
{
    public partial class Form1 : Form
    {
        Correo correo;
        public Form1()
        {
            InitializeComponent();
            this.correo = new Correo();
        }
        private void ActualizarEstados()
        {
            this.listBoxIngresando.Items.Clear();
            this.listBoxEnViaje.Items.Clear();
            this.listBoxEntregado.Items.Clear();

            foreach (Paquete p in correo.Paquetes)
            {

                if (p.Estado == Paquete.EEstado.ingresado)
                {
                    listBoxIngresando.Items.Add(p);
                }
                else if (p.Estado == Paquete.EEstado.EnViaje)
                {
                    listBoxEnViaje.Items.Add(p);
                }
                else
                {
                    listBoxEntregado.Items.Add(p);
                }
            }
        }

        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
            }
        }


        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Paquete paquete = new Paquete(textBoxDireccion.Text, maskedTextBoxTrackin.Text);
            paquete.InformarEstado += paq_InformaEstado;
            try
            {
                this.correo += paquete;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar paquete");
            }
            this.ActualizarEstados();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            correo.FinEntrega();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)listBoxEntregado.SelectedItem);
        }

        private void buttonMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (!(elemento is null))
            {
                this.richTextBoxMostrar.Text = elemento.MostrarDatos(elemento);
                try
                {
                    this.richTextBoxMostrar.Text.Guardar("Salida.txt");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo");
                }
            }
        }
    }
}
