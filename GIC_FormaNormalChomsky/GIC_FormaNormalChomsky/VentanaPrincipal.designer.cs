﻿namespace FNC
{
    partial class VentanaPrincipal
    {
       
        private System.ComponentModel.IContainer components = null;

      
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(447, 203);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(210, 315);
            this.txtEntrada.TabIndex = 0;
            // 
            // txtSalida
            // 
            this.txtSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(704, 203);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(343, 315);
            this.txtSalida.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "GIC (Ingrese aquí la gramatica)";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(701, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Forma Normal de Chomsky \r\n";
            // 
            // butPaso1
            // 
            this.butPaso1.Location = new System.Drawing.Point(31, 94);
            this.butPaso1.Name = "butPaso1";
            this.butPaso1.Size = new System.Drawing.Size(129, 43);
            this.butPaso1.TabIndex = 15;
            this.butPaso1.Text = "Eliminar no terminables";
            this.butPaso1.UseVisualStyleBackColor = true;
            this.butPaso1.Click += new System.EventHandler(this.butPaso1_Click);
            // 
            // butPaso2
            // 
            this.butPaso2.Location = new System.Drawing.Point(31, 179);
            this.butPaso2.Name = "butPaso2";
            this.butPaso2.Size = new System.Drawing.Size(129, 47);
            this.butPaso2.TabIndex = 16;
            this.butPaso2.Text = "Eliminar no alcanzables";
            this.butPaso2.UseVisualStyleBackColor = true;
            this.butPaso2.Click += new System.EventHandler(this.butPaso2_Click);
            // 
            // butPaso3
            // 
            this.butPaso3.Location = new System.Drawing.Point(31, 276);
            this.butPaso3.Name = "butPaso3";
            this.butPaso3.Size = new System.Drawing.Size(129, 41);
            this.butPaso3.TabIndex = 17;
            this.butPaso3.Text = "Simular producciones lambda";
            this.butPaso3.UseVisualStyleBackColor = true;
            this.butPaso3.Click += new System.EventHandler(this.butPaso3_Click);
            // 
            // butPaso5
            // 
            this.butPaso5.Location = new System.Drawing.Point(214, 438);
            this.butPaso5.Name = "butPaso5";
            this.butPaso5.Size = new System.Drawing.Size(129, 41);
            this.butPaso5.TabIndex = 18;
            this.butPaso5.Text = "Variable por cada terminal";
            this.butPaso5.UseVisualStyleBackColor = true;
            this.butPaso5.Click += new System.EventHandler(this.butPaso5_Click);
            // 
            // butPaso6
            // 
            this.butPaso6.Location = new System.Drawing.Point(116, 504);
            this.butPaso6.Name = "butPaso6";
            this.butPaso6.Size = new System.Drawing.Size(129, 41);
            this.butPaso6.TabIndex = 19;
            this.butPaso6.Text = "produccion binarias";
            this.butPaso6.UseVisualStyleBackColor = true;
            this.butPaso6.Click += new System.EventHandler(this.butPaso6_Click);
            // 
            // txtNoAlcanzables
            // 
            this.txtNoAlcanzables.Location = new System.Drawing.Point(195, 195);
            this.txtNoAlcanzables.Name = "txtNoAlcanzables";
            this.txtNoAlcanzables.Size = new System.Drawing.Size(103, 20);
            this.txtNoAlcanzables.TabIndex = 20;
            // 
            // txtNoTerminables
            // 
            this.txtNoTerminables.Location = new System.Drawing.Point(195, 106);
            this.txtNoTerminables.Name = "txtNoTerminables";
            this.txtNoTerminables.Size = new System.Drawing.Size(103, 20);
            this.txtNoTerminables.TabIndex = 21;
            // 
            // txtAnulables
            // 
            this.txtAnulables.Location = new System.Drawing.Point(195, 292);
            this.txtAnulables.Name = "txtAnulables";
            this.txtAnulables.Size = new System.Drawing.Size(103, 20);
            this.txtAnulables.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(94, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Algoritmo de conversion";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(192, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "No terminables";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(192, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "No alcanzables";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(192, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Anulables";
            // 
            // butPaso4
            // 
            this.butPaso4.Location = new System.Drawing.Point(31, 438);
            this.butPaso4.Name = "butPaso4";
            this.butPaso4.Size = new System.Drawing.Size(129, 41);
            this.butPaso4.TabIndex = 27;
            this.butPaso4.Text = "Simular producciones Unitarias";
            this.butPaso4.UseVisualStyleBackColor = true;
            this.butPaso4.Click += new System.EventHandler(this.butPaso4_Click);
            // 
            // comboBoxConjunto
            // 
            this.comboBoxConjunto.FormattingEnabled = true;
            this.comboBoxConjunto.Location = new System.Drawing.Point(31, 371);
            this.comboBoxConjunto.Name = "comboBoxConjunto";
            this.comboBoxConjunto.Size = new System.Drawing.Size(129, 21);
            this.comboBoxConjunto.TabIndex = 28;
            this.comboBoxConjunto.SelectedIndexChanged += new System.EventHandler(this.comboBoxConjunto_SelectedIndexChanged);
            // 
            // txtConjUnitario
            // 
            this.txtConjUnitario.Location = new System.Drawing.Point(195, 371);
            this.txtConjUnitario.Name = "txtConjUnitario";
            this.txtConjUnitario.Size = new System.Drawing.Size(103, 20);
            this.txtConjUnitario.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(28, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Conjunto Unitario";
            // 
            // butLimpiar
            // 
            this.butLimpiar.Location = new System.Drawing.Point(642, 601);
            this.butLimpiar.Name = "butLimpiar";
            this.butLimpiar.Size = new System.Drawing.Size(169, 66);
            this.butLimpiar.TabIndex = 31;
            this.butLimpiar.Text = "LIMPIAR";
            this.butLimpiar.UseVisualStyleBackColor = true;
            this.butLimpiar.Click += new System.EventHandler(this.butLimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(283, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(545, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "GIC EN FORMA NORMAL DE CHOMSKY";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(9, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "1)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(9, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "2)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(9, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "3)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(9, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "4)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(9, 452);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "5)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(192, 452);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "6)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(94, 518);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "7)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 83);
            this.panel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.butPaso3);
            this.panel2.Controls.Add(this.butPaso1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.butPaso2);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.butPaso5);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.butPaso6);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtNoAlcanzables);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtNoTerminables);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtAnulables);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtConjUnitario);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.comboBoxConjunto);
            this.panel2.Controls.Add(this.butPaso4);
            this.panel2.Location = new System.Drawing.Point(12, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 611);
            this.panel2.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GIC_FormaNormalChomsky.Properties.Resources.icon__2_;
            this.pictureBox1.Location = new System.Drawing.Point(1006, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 84);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(1021, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Cerrar";
            this.label16.Click += new System.EventHandler(this.Label16_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1082, 722);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.txtEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gramatica en FNC";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
    }
}

