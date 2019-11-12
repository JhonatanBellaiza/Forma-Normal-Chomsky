namespace FNC
{
    partial class VentanaPrincipal
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
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butPaso1 = new System.Windows.Forms.Button();
            this.butPaso2 = new System.Windows.Forms.Button();
            this.butPaso3 = new System.Windows.Forms.Button();
            this.butPaso5 = new System.Windows.Forms.Button();
            this.butPaso6 = new System.Windows.Forms.Button();
            this.txtNoAlcanzables = new System.Windows.Forms.TextBox();
            this.txtNoTerminables = new System.Windows.Forms.TextBox();
            this.txtAnulables = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.butPaso4 = new System.Windows.Forms.Button();
            this.comboBoxConjunto = new System.Windows.Forms.ComboBox();
            this.txtConjUnitario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(29, 190);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(279, 387);
            this.txtEntrada.TabIndex = 0;
            // 
            // txtSalida
            // 
            this.txtSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(875, 177);
            this.txtSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(456, 387);
            this.txtSalida.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "GIC (Ingrese aquí la gramatica)";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(885, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Forma Normal de Chomsky \r\n";
            // 
            // butPaso1
            // 
            this.butPaso1.Location = new System.Drawing.Point(415, 199);
            this.butPaso1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butPaso1.Name = "butPaso1";
            this.butPaso1.Size = new System.Drawing.Size(172, 53);
            this.butPaso1.TabIndex = 15;
            this.butPaso1.Text = "Eliminar no terminables";
            this.butPaso1.UseVisualStyleBackColor = true;
            this.butPaso1.Click += new System.EventHandler(this.butPaso1_Click);
            // 
            // butPaso2
            // 
            this.butPaso2.Location = new System.Drawing.Point(415, 304);
            this.butPaso2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butPaso2.Name = "butPaso2";
            this.butPaso2.Size = new System.Drawing.Size(172, 58);
            this.butPaso2.TabIndex = 16;
            this.butPaso2.Text = "Eliminar no alcanzables";
            this.butPaso2.UseVisualStyleBackColor = true;
            this.butPaso2.Click += new System.EventHandler(this.butPaso2_Click);
            // 
            // butPaso3
            // 
            this.butPaso3.Location = new System.Drawing.Point(415, 423);
            this.butPaso3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butPaso3.Name = "butPaso3";
            this.butPaso3.Size = new System.Drawing.Size(172, 50);
            this.butPaso3.TabIndex = 17;
            this.butPaso3.Text = "Simular producciones lambda";
            this.butPaso3.UseVisualStyleBackColor = true;
            this.butPaso3.Click += new System.EventHandler(this.butPaso3_Click);
            // 
            // butPaso5
            // 
            this.butPaso5.Location = new System.Drawing.Point(659, 623);
            this.butPaso5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butPaso5.Name = "butPaso5";
            this.butPaso5.Size = new System.Drawing.Size(172, 50);
            this.butPaso5.TabIndex = 18;
            this.butPaso5.Text = "Variable por cada terminal";
            this.butPaso5.UseVisualStyleBackColor = true;
            this.butPaso5.Click += new System.EventHandler(this.butPaso5_Click);
            // 
            // butPaso6
            // 
            this.butPaso6.Location = new System.Drawing.Point(528, 704);
            this.butPaso6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butPaso6.Name = "butPaso6";
            this.butPaso6.Size = new System.Drawing.Size(172, 50);
            this.butPaso6.TabIndex = 19;
            this.butPaso6.Text = "produccion binarias";
            this.butPaso6.UseVisualStyleBackColor = true;
            this.butPaso6.Click += new System.EventHandler(this.butPaso6_Click);
            // 
            // txtNoAlcanzables
            // 
            this.txtNoAlcanzables.Location = new System.Drawing.Point(633, 324);
            this.txtNoAlcanzables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoAlcanzables.Name = "txtNoAlcanzables";
            this.txtNoAlcanzables.Size = new System.Drawing.Size(136, 22);
            this.txtNoAlcanzables.TabIndex = 20;
            // 
            // txtNoTerminables
            // 
            this.txtNoTerminables.Location = new System.Drawing.Point(633, 214);
            this.txtNoTerminables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoTerminables.Name = "txtNoTerminables";
            this.txtNoTerminables.Size = new System.Drawing.Size(136, 22);
            this.txtNoTerminables.TabIndex = 21;
            // 
            // txtAnulables
            // 
            this.txtAnulables.Location = new System.Drawing.Point(633, 443);
            this.txtAnulables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnulables.Name = "txtAnulables";
            this.txtAnulables.Size = new System.Drawing.Size(136, 22);
            this.txtAnulables.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(404, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Algoritmo de conversion";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(629, 194);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "No terminables";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(629, 304);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "No alcanzables";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(629, 423);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Anulables";
            // 
            // butPaso4
            // 
            this.butPaso4.Location = new System.Drawing.Point(415, 623);
            this.butPaso4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butPaso4.Name = "butPaso4";
            this.butPaso4.Size = new System.Drawing.Size(172, 50);
            this.butPaso4.TabIndex = 27;
            this.butPaso4.Text = "Simular producciones Unitarias";
            this.butPaso4.UseVisualStyleBackColor = true;
            this.butPaso4.Click += new System.EventHandler(this.butPaso4_Click);
            // 
            // comboBoxConjunto
            // 
            this.comboBoxConjunto.FormattingEnabled = true;
            this.comboBoxConjunto.Location = new System.Drawing.Point(415, 540);
            this.comboBoxConjunto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxConjunto.Name = "comboBoxConjunto";
            this.comboBoxConjunto.Size = new System.Drawing.Size(171, 24);
            this.comboBoxConjunto.TabIndex = 28;
            this.comboBoxConjunto.SelectedIndexChanged += new System.EventHandler(this.comboBoxConjunto_SelectedIndexChanged);
            // 
            // txtConjUnitario
            // 
            this.txtConjUnitario.Location = new System.Drawing.Point(633, 540);
            this.txtConjUnitario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConjUnitario.Name = "txtConjUnitario";
            this.txtConjUnitario.Size = new System.Drawing.Size(136, 22);
            this.txtConjUnitario.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 521);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Conjunto Unitario";
            // 
            // butLimpiar
            // 
            this.butLimpiar.Location = new System.Drawing.Point(1013, 607);
            this.butLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butLimpiar.Name = "butLimpiar";
            this.butLimpiar.Size = new System.Drawing.Size(225, 81);
            this.butLimpiar.TabIndex = 31;
            this.butLimpiar.Text = "LIMPIAR";
            this.butLimpiar.UseVisualStyleBackColor = true;
            this.butLimpiar.Click += new System.EventHandler(this.butLimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(545, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "GIC EN FORMA NORMAL DE CHOMSKY";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "1)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 324);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "2)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 441);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "3)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(385, 544);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "4)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(385, 640);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "5)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(629, 640);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "6)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(499, 721);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 17);
            this.label15.TabIndex = 39;
            this.label15.Text = "7)";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1384, 769);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butLimpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConjUnitario);
            this.Controls.Add(this.comboBoxConjunto);
            this.Controls.Add(this.butPaso4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAnulables);
            this.Controls.Add(this.txtNoTerminables);
            this.Controls.Add(this.txtNoAlcanzables);
            this.Controls.Add(this.butPaso6);
            this.Controls.Add(this.butPaso5);
            this.Controls.Add(this.butPaso3);
            this.Controls.Add(this.butPaso2);
            this.Controls.Add(this.butPaso1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.txtEntrada);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.Text = "Gramatica en FNC";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butPaso1;
        private System.Windows.Forms.Button butPaso2;
        private System.Windows.Forms.Button butPaso3;
        private System.Windows.Forms.Button butPaso5;
        private System.Windows.Forms.Button butPaso6;
        private System.Windows.Forms.TextBox txtNoAlcanzables;
        private System.Windows.Forms.TextBox txtNoTerminables;
        private System.Windows.Forms.TextBox txtAnulables;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button butPaso4;
        private System.Windows.Forms.ComboBox comboBoxConjunto;
        private System.Windows.Forms.TextBox txtConjUnitario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butLimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

