namespace TP4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxEntregado = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxEnViaje = new System.Windows.Forms.ListBox();
            this.listBoxIngresando = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxTrackin = new System.Windows.Forms.MaskedTextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonMostrarTodos = new System.Windows.Forms.Button();
            this.richTextBoxMostrar = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxEntregado);
            this.groupBox1.Controls.Add(this.listBoxEnViaje);
            this.groupBox1.Controls.Add(this.listBoxIngresando);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Paquetes";
            // 
            // listBoxEntregado
            // 
            this.listBoxEntregado.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxEntregado.FormattingEnabled = true;
            this.listBoxEntregado.Location = new System.Drawing.Point(511, 45);
            this.listBoxEntregado.Name = "listBoxEntregado";
            this.listBoxEntregado.Size = new System.Drawing.Size(189, 212);
            this.listBoxEntregado.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 26);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // listBoxEnViaje
            // 
            this.listBoxEnViaje.FormattingEnabled = true;
            this.listBoxEnViaje.Location = new System.Drawing.Point(260, 45);
            this.listBoxEnViaje.Name = "listBoxEnViaje";
            this.listBoxEnViaje.Size = new System.Drawing.Size(189, 212);
            this.listBoxEnViaje.TabIndex = 16;
            // 
            // listBoxIngresando
            // 
            this.listBoxIngresando.FormattingEnabled = true;
            this.listBoxIngresando.Location = new System.Drawing.Point(21, 45);
            this.listBoxIngresando.Name = "listBoxIngresando";
            this.listBoxIngresando.Size = new System.Drawing.Size(189, 212);
            this.listBoxIngresando.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Entregado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "En viaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ingresando";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxDireccion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.maskedTextBoxTrackin);
            this.groupBox2.Controls.Add(this.buttonAgregar);
            this.groupBox2.Controls.Add(this.buttonMostrarTodos);
            this.groupBox2.Location = new System.Drawing.Point(513, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 146);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paquete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Direccion";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(10, 105);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDireccion.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tracking ID";
            // 
            // maskedTextBoxTrackin
            // 
            this.maskedTextBoxTrackin.Location = new System.Drawing.Point(9, 35);
            this.maskedTextBoxTrackin.Name = "maskedTextBoxTrackin";
            this.maskedTextBoxTrackin.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTrackin.TabIndex = 12;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(113, 19);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(91, 43);
            this.buttonAgregar.TabIndex = 10;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonMostrarTodos
            // 
            this.buttonMostrarTodos.Location = new System.Drawing.Point(113, 83);
            this.buttonMostrarTodos.Name = "buttonMostrarTodos";
            this.buttonMostrarTodos.Size = new System.Drawing.Size(91, 43);
            this.buttonMostrarTodos.TabIndex = 11;
            this.buttonMostrarTodos.Text = "Mostrar Todos";
            this.buttonMostrarTodos.UseVisualStyleBackColor = true;
            this.buttonMostrarTodos.Click += new System.EventHandler(this.buttonMostrarTodos_Click);
            // 
            // richTextBoxMostrar
            // 
            this.richTextBoxMostrar.Location = new System.Drawing.Point(13, 293);
            this.richTextBoxMostrar.Name = "richTextBoxMostrar";
            this.richTextBoxMostrar.ReadOnly = true;
            this.richTextBoxMostrar.Size = new System.Drawing.Size(494, 145);
            this.richTextBoxMostrar.TabIndex = 20;
            this.richTextBoxMostrar.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.richTextBoxMostrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Correo UTN por GoffredoBruno2C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxEntregado;
        private System.Windows.Forms.ListBox listBoxEnViaje;
        private System.Windows.Forms.ListBox listBoxIngresando;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTrackin;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonMostrarTodos;
        private System.Windows.Forms.RichTextBox richTextBoxMostrar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
    }
}

