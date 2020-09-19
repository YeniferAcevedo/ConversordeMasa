namespace ConversordePeso
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtPesoKg = new System.Windows.Forms.TextBox();
            this.rdbMiligramos = new System.Windows.Forms.RadioButton();
            this.rdbGramos = new System.Windows.Forms.RadioButton();
            this.rdbDecagramos = new System.Windows.Forms.RadioButton();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(63, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de Masa";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Arial", 12F);
            this.btnConvertir.Location = new System.Drawing.Point(160, 186);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(84, 33);
            this.btnConvertir.TabIndex = 1;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtPesoKg
            // 
            this.txtPesoKg.Font = new System.Drawing.Font("Arial", 14F);
            this.txtPesoKg.Location = new System.Drawing.Point(27, 186);
            this.txtPesoKg.Name = "txtPesoKg";
            this.txtPesoKg.Size = new System.Drawing.Size(100, 29);
            this.txtPesoKg.TabIndex = 2;
            // 
            // rdbMiligramos
            // 
            this.rdbMiligramos.AutoSize = true;
            this.rdbMiligramos.Font = new System.Drawing.Font("Arial", 14F);
            this.rdbMiligramos.Location = new System.Drawing.Point(17, 30);
            this.rdbMiligramos.Name = "rdbMiligramos";
            this.rdbMiligramos.Size = new System.Drawing.Size(119, 26);
            this.rdbMiligramos.TabIndex = 3;
            this.rdbMiligramos.TabStop = true;
            this.rdbMiligramos.Text = "Miligramos";
            this.rdbMiligramos.UseVisualStyleBackColor = true;
            // 
            // rdbGramos
            // 
            this.rdbGramos.AutoSize = true;
            this.rdbGramos.Font = new System.Drawing.Font("Arial", 14F);
            this.rdbGramos.Location = new System.Drawing.Point(17, 67);
            this.rdbGramos.Name = "rdbGramos";
            this.rdbGramos.Size = new System.Drawing.Size(96, 26);
            this.rdbGramos.TabIndex = 5;
            this.rdbGramos.TabStop = true;
            this.rdbGramos.Text = "Gramos";
            this.rdbGramos.UseVisualStyleBackColor = true;
            // 
            // rdbDecagramos
            // 
            this.rdbDecagramos.AutoSize = true;
            this.rdbDecagramos.Font = new System.Drawing.Font("Arial", 14F);
            this.rdbDecagramos.Location = new System.Drawing.Point(17, 106);
            this.rdbDecagramos.Name = "rdbDecagramos";
            this.rdbDecagramos.Size = new System.Drawing.Size(137, 26);
            this.rdbDecagramos.TabIndex = 6;
            this.rdbDecagramos.TabStop = true;
            this.rdbDecagramos.Text = "Decagramos";
            this.rdbDecagramos.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnBorrar.Location = new System.Drawing.Point(27, 292);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(84, 33);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(23, 240);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(21, 22);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(23, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(507, 44);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingrese el peso en Kg, seleccione unidad que desea y\r\nluego presione convertir:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMiligramos);
            this.groupBox1.Controls.Add(this.rdbGramos);
            this.groupBox1.Controls.Add(this.rdbDecagramos);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(275, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 156);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unidades de Masa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 355);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtPesoKg);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conversor de Masa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtPesoKg;
        private System.Windows.Forms.RadioButton rdbMiligramos;
        private System.Windows.Forms.RadioButton rdbGramos;
        private System.Windows.Forms.RadioButton rdbDecagramos;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

