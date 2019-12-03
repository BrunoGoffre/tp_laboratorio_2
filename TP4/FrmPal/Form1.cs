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

namespace Practica_de_tp4
{
    public partial class Form1 : Form
    {
        Correo correo;
        public Form1()
        {
            InitializeComponent();
            this.correo = new Correo();
            PaqueteDAO.EventoDAO += BaseInformaEstado;
        }
        /// <summary>
        /// Invoca el hilo principal para enviar un MessegeBox
        /// </summary>
        /// <param name="mensaje"></param>
        public void BaseInformaEstado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                PaqueteDAO.DelegadoPaqueteDAO d = new PaqueteDAO.DelegadoPaqueteDAO(BaseInformaEstado);
                this.Invoke(d, new object[] {mensaje});
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }
        /// <summary>
        /// Agrega un nuevo paquete en base a ambos textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Paquete paquete = new Paquete(textBoxDireccion.Text, maskedTextBoxTracking.Text);
            paquete.InformaEstado += paq_InformaEstado;
            try
            {
                correo += paquete;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.ActualizarEstado();
        }
        /// <summary>
        /// Invoca al hilo principal y actualiza los estados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstado();
            }
        }
        /// <summary>
        /// Limpia los listBox y establece cada paquete en sus respetivos listbox
        /// </summary>
        public void ActualizarEstado()
        {
            listBoxEntregado.Items.Clear();
            listBoxEnViaje.Items.Clear();
            listBoxIngresando.Items.Clear();

            foreach (Paquete item in this.correo.Paquetes)
            {
                switch(item.Estado)
                {
                    case Paquete.EEstado.Ingresando:
                        listBoxIngresando.Items.Add(item);
                        break;

                    case Paquete.EEstado.EnViaje:
                        listBoxEnViaje.Items.Add(item);
                        break;

                    case Paquete.EEstado.Entregado:
                        listBoxEntregado.Items.Add(item);
                        break;
                }
            }
        }
        /// <summary>
        /// Cierra todos los hilos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            correo.FinEntregas();
        }
        /// <summary>
        /// Muestra todos los paquetes en el textbox indicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }
        /// <summary>
        /// Si el elemento no es nulo, guarda el texto en un en un archivo
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>
        public void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (!(elemento is null))
            {
                richTextBoxMostrar.Text = elemento.MostrarDatos(elemento);

                try
                {
                    richTextBoxMostrar.Text.Guardar("Salida.txt");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        /// <summary>
        /// guarda el texto seleccionado en un archivo de texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)listBoxEntregado.SelectedItem);
        }
    }
}
