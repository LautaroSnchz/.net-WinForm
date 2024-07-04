namespace TrabajoFinal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.nupEdad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPais = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbNoBinario = new System.Windows.Forms.RadioButton();
            this.gbCurso = new System.Windows.Forms.GroupBox();
            this.chkc = new System.Windows.Forms.CheckBox();
            this.chkCplus = new System.Windows.Forms.CheckBox();
            this.chkJavaScript = new System.Windows.Forms.CheckBox();
            this.btoIngresar = new System.Windows.Forms.Button();
            this.mtbCUIT = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbCUIT);
            this.groupBox1.Controls.Add(this.nupEdad);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle del Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CUIT/L";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(84, 66);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // nupEdad
            // 
            this.nupEdad.Location = new System.Drawing.Point(84, 96);
            this.nupEdad.Name = "nupEdad";
            this.nupEdad.Size = new System.Drawing.Size(100, 20);
            this.nupEdad.TabIndex = 7;
            this.nupEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pais";
            // 
            // lbPais
            // 
            this.lbPais.FormattingEnabled = true;
            this.lbPais.Items.AddRange(new object[] {
            "Argentina",
            "Brazil",
            "Chile",
            "Peru"});
            this.lbPais.Location = new System.Drawing.Point(79, 240);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(270, 108);
            this.lbPais.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNoBinario);
            this.groupBox2.Controls.Add(this.rbFemenino);
            this.groupBox2.Controls.Add(this.rbMasculino);
            this.groupBox2.Location = new System.Drawing.Point(501, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 142);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genero";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(26, 29);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(26, 62);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbNoBinario
            // 
            this.rbNoBinario.AutoSize = true;
            this.rbNoBinario.Location = new System.Drawing.Point(26, 96);
            this.rbNoBinario.Name = "rbNoBinario";
            this.rbNoBinario.Size = new System.Drawing.Size(74, 17);
            this.rbNoBinario.TabIndex = 2;
            this.rbNoBinario.TabStop = true;
            this.rbNoBinario.Text = "No Binario";
            this.rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // gbCurso
            // 
            this.gbCurso.Controls.Add(this.chkJavaScript);
            this.gbCurso.Controls.Add(this.chkCplus);
            this.gbCurso.Controls.Add(this.chkc);
            this.gbCurso.Location = new System.Drawing.Point(491, 231);
            this.gbCurso.Name = "gbCurso";
            this.gbCurso.Size = new System.Drawing.Size(200, 117);
            this.gbCurso.TabIndex = 4;
            this.gbCurso.TabStop = false;
            this.gbCurso.Text = "Curso";
            // 
            // chkc
            // 
            this.chkc.AutoSize = true;
            this.chkc.Location = new System.Drawing.Point(10, 34);
            this.chkc.Name = "chkc";
            this.chkc.Size = new System.Drawing.Size(40, 17);
            this.chkc.TabIndex = 0;
            this.chkc.Text = "C#";
            this.chkc.UseVisualStyleBackColor = true;
            // 
            // chkCplus
            // 
            this.chkCplus.AutoSize = true;
            this.chkCplus.Location = new System.Drawing.Point(10, 57);
            this.chkCplus.Name = "chkCplus";
            this.chkCplus.Size = new System.Drawing.Size(45, 17);
            this.chkCplus.TabIndex = 1;
            this.chkCplus.Text = "C++";
            this.chkCplus.UseVisualStyleBackColor = true;
            // 
            // chkJavaScript
            // 
            this.chkJavaScript.AutoSize = true;
            this.chkJavaScript.Location = new System.Drawing.Point(10, 85);
            this.chkJavaScript.Name = "chkJavaScript";
            this.chkJavaScript.Size = new System.Drawing.Size(76, 17);
            this.chkJavaScript.TabIndex = 2;
            this.chkJavaScript.Text = "JavaScript";
            this.chkJavaScript.UseVisualStyleBackColor = true;
            // 
            // btoIngresar
            // 
            this.btoIngresar.Location = new System.Drawing.Point(571, 388);
            this.btoIngresar.Name = "btoIngresar";
            this.btoIngresar.Size = new System.Drawing.Size(120, 23);
            this.btoIngresar.TabIndex = 5;
            this.btoIngresar.Text = "Ingresar";
            this.btoIngresar.UseVisualStyleBackColor = true;
            this.btoIngresar.Click += new System.EventHandler(this.btoIngresar_Click);
            // 
            // mtbCUIT
            // 
            this.mtbCUIT.Location = new System.Drawing.Point(84, 125);
            this.mtbCUIT.Mask = "00-00000000-0";
            this.mtbCUIT.Name = "mtbCUIT";
            this.mtbCUIT.Size = new System.Drawing.Size(100, 20);
            this.mtbCUIT.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btoIngresar);
            this.Controls.Add(this.gbCurso);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbPais);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbCurso.ResumeLayout(false);
            this.gbCurso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupEdad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbPais;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNoBinario;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.GroupBox gbCurso;
        private System.Windows.Forms.CheckBox chkJavaScript;
        private System.Windows.Forms.CheckBox chkCplus;
        private System.Windows.Forms.CheckBox chkc;
        private System.Windows.Forms.Button btoIngresar;
        private System.Windows.Forms.MaskedTextBox mtbCUIT;
    }
}

