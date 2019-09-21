namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.txtBoxNumero1 = new System.Windows.Forms.TextBox();
            this.txtBoxNumero2 = new System.Windows.Forms.TextBox();
            this.ComboBoxOperadores = new System.Windows.Forms.ComboBox();
            this.btbOperar = new System.Windows.Forms.Button();
            this.btbBinarioDecimal = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvertirDecimalBinario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxNumero1
            // 
            this.txtBoxNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumero1.Location = new System.Drawing.Point(12, 62);
            this.txtBoxNumero1.Name = "txtBoxNumero1";
            this.txtBoxNumero1.Size = new System.Drawing.Size(173, 45);
            this.txtBoxNumero1.TabIndex = 1;
            this.txtBoxNumero1.Leave += new System.EventHandler(this.txtBoxNumero1_leave);
            // 
            // txtBoxNumero2
            // 
            this.txtBoxNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumero2.Location = new System.Drawing.Point(401, 63);
            this.txtBoxNumero2.Name = "txtBoxNumero2";
            this.txtBoxNumero2.Size = new System.Drawing.Size(173, 45);
            this.txtBoxNumero2.TabIndex = 3;
            this.txtBoxNumero2.Leave += new System.EventHandler(this.txtBoxNumero2_Leave);
            // 
            // ComboBoxOperadores
            // 
            this.ComboBoxOperadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxOperadores.FormattingEnabled = true;
            this.ComboBoxOperadores.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.ComboBoxOperadores.Location = new System.Drawing.Point(236, 61);
            this.ComboBoxOperadores.Name = "ComboBoxOperadores";
            this.ComboBoxOperadores.Size = new System.Drawing.Size(124, 46);
            this.ComboBoxOperadores.TabIndex = 2;
            this.ComboBoxOperadores.Leave += new System.EventHandler(this.ComboBoxOperadores_Leave);
            // 
            // btbOperar
            // 
            this.btbOperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbOperar.Location = new System.Drawing.Point(12, 139);
            this.btbOperar.Name = "btbOperar";
            this.btbOperar.Size = new System.Drawing.Size(173, 51);
            this.btbOperar.TabIndex = 4;
            this.btbOperar.Text = "Operar";
            this.btbOperar.UseVisualStyleBackColor = true;
            this.btbOperar.Click += new System.EventHandler(this.btbOperar_Click);
            // 
            // btbBinarioDecimal
            // 
            this.btbBinarioDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbBinarioDecimal.Location = new System.Drawing.Point(12, 196);
            this.btbBinarioDecimal.Name = "btbBinarioDecimal";
            this.btbBinarioDecimal.Size = new System.Drawing.Size(277, 51);
            this.btbBinarioDecimal.TabIndex = 7;
            this.btbBinarioDecimal.Text = "Convertir binario a decimal";
            this.btbBinarioDecimal.UseVisualStyleBackColor = true;
            this.btbBinarioDecimal.Click += new System.EventHandler(this.btbBinarioDecimal_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(205, 139);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(173, 51);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(400, 139);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(173, 51);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_click);
            // 
            // btnConvertirDecimalBinario
            // 
            this.btnConvertirDecimalBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirDecimalBinario.Location = new System.Drawing.Point(302, 196);
            this.btnConvertirDecimalBinario.Name = "btnConvertirDecimalBinario";
            this.btnConvertirDecimalBinario.Size = new System.Drawing.Size(272, 51);
            this.btnConvertirDecimalBinario.TabIndex = 8;
            this.btnConvertirDecimalBinario.Text = "Convertir decimal a binario";
            this.btnConvertirDecimalBinario.UseVisualStyleBackColor = true;
            this.btnConvertirDecimalBinario.Click += new System.EventHandler(this.btnConvertirDecimalBinario_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 39);
            this.label1.TabIndex = 9;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 259);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertirDecimalBinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btbBinarioDecimal);
            this.Controls.Add(this.btbOperar);
            this.Controls.Add(this.ComboBoxOperadores);
            this.Controls.Add(this.txtBoxNumero2);
            this.Controls.Add(this.txtBoxNumero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Bruno Goffredo del curso 2ºC";
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNumero1;
        private System.Windows.Forms.TextBox txtBoxNumero2;
        private System.Windows.Forms.ComboBox ComboBoxOperadores;
        private System.Windows.Forms.Button btbOperar;
        private System.Windows.Forms.Button btbBinarioDecimal;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvertirDecimalBinario;
        private System.Windows.Forms.Label label1;
    }
}

