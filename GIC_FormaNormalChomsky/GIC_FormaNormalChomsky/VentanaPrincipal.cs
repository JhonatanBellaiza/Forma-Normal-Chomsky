using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNC
{
    /*
     * Clase que representa la grámatica de chomsky
     * @autor Christian Alberto Tamayo Robayo, Jhonnatan Bellaiza Caicedo, Cesar Botina
     */
    public partial class VentanaPrincipal : Form
    {
        private Gramatica g;
        public VentanaPrincipal()
        {
            InitializeComponent();

            txtSalida.ReadOnly = true;

            butPaso2.Enabled = false;
            butPaso3.Enabled = false;
            butPaso4.Enabled = false;
            butPaso5.Enabled = false;
            butPaso6.Enabled = false;

            txtNoTerminables.ReadOnly = true;
            txtNoAlcanzables.ReadOnly = true;
            txtAnulables.ReadOnly = true;
            txtConjUnitario.ReadOnly = true;

        }

        /*
         * Al presionar este boton se carga la gramatica
         */
        private void butPaso1_Click(object sender, EventArgs e)
        {
            if(txtEntrada.Text.Trim().Count() > 0)
            {
                try
                {
                    g = new Gramatica(txtEntrada.Text);
                    List<char> noTerminables = g.darNoTerminables();

                    string cadena = "ninguna";
                    if (noTerminables.Count() > 0)
                    {
                        cadena = "";
                        for (int i = 0; i < noTerminables.Count(); i++)
                        {
                            char noTerminable = noTerminables.ElementAt(i);

                            cadena = cadena + noTerminable + " ";
                        }
                    }

                    txtNoTerminables.Text = cadena;
                    g.eliminarNoTerminables();
                    txtSalida.Text = g.ToString();

                    butPaso1.Enabled = false;
                    butPaso2.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe insertar una gramatica");
            }
            
        }

        private void butPaso2_Click(object sender, EventArgs e)
        {
            /*
             * Si se llega a este paso es porque la gramatica ya esta creada
             */
            List<char> noAlcanzables = g.darNoAlcanzables();

            string cadena = "ninguna";
            if (noAlcanzables.Count() > 0)
            {
                cadena = "";
                for (int i = 0; i < noAlcanzables.Count(); i++)
                {
                    char noAlcanzable = noAlcanzables.ElementAt(i);

                    cadena = cadena + noAlcanzable + " ";
                }
            }

            txtNoAlcanzables.Text = cadena;
            g.eliminarNoAlcanzables();
            txtSalida.Text = g.ToString();

            butPaso2.Enabled = false;
            butPaso3.Enabled = true;
        }

        private void butPaso3_Click(object sender, EventArgs e)
        {
            List<char> anulables = g.darAnulables();

            string cadena = "ninguna";
            if (anulables.Count() > 0)
            {
                cadena = "";
                for (int i = 0; i < anulables.Count(); i++)
                {
                    char anulable = anulables.ElementAt(i);

                    cadena = cadena + anulable + " ";
                }
            }

            txtAnulables.Text = cadena;
            g.eliminarProduccionesLambda();
            txtSalida.Text = g.ToString();

            butPaso3.Enabled = false;
            butPaso4.Enabled = true;

            /*
             * Se agregan elementos al comboBox
             */
            foreach(char variable in g.darGeneradores())
            {
                comboBoxConjunto.Items.Add(variable);
            }
            
        }

        private void comboBoxConjunto_SelectedIndexChanged(object sender, EventArgs e)
        {
            char generador = (Char)comboBoxConjunto.SelectedItem;

            string cadena4 = "";
            List<char> conjunto = g.darConjuntoUnitario(generador);

            for (int i = 0; i < conjunto.Count(); i++)
            {
                cadena4 = cadena4 + conjunto.ElementAt(i) + " ";
            }

            txtConjUnitario.Text = cadena4;
        }

        private void butPaso4_Click(object sender, EventArgs e)
        {
            g.eliminarProduccionesUnitarias();

            txtSalida.Text = g.ToString();

            comboBoxConjunto.Enabled = false;
            butPaso4.Enabled = false;
            butPaso5.Enabled = true;
            
        }

        private void butPaso5_Click(object sender, EventArgs e)
        {
            try
            {
                g.generarVariablesPorCadaTerminal();
                txtSalida.Text = g.ToString();

                butPaso5.Enabled = false;
                butPaso6.Enabled = true;
            }
            catch(Exception)
            {
                /************************************
                 **********NOTA IMPORTANTE***********
                 ************************************
                 *
                 * El unico error que se puede producir en esta fase, es que no hayan 
                 * suficientes variables para obtener producciones binarias.
                 */
                MessageBox.Show("No hay suficientes variables en el abecedario para generar " +
                    "producciones binarias con esta gramatica");
                limpiar();      
            }
            
        }

        private void butPaso6_Click(object sender, EventArgs e)
        {
            try
            {
                g.generarProduccionesBinarias();
                txtSalida.Text = g.ToString();

                butPaso6.Enabled = false;
                MessageBox.Show("¡Se ha generado una GIC G`en Forma normal de Chomsky    equivalente a G de forma exitosa!" + Environment.NewLine );

            }
            catch(Exception)
            {
                /************************************
                 **********NOTA IMPORTANTE***********
                 ************************************
                 *
                 * El unico error que se puede producir en esta fase, es que no hayan 
                 * suficientes variables para obtener producciones binarias.
                 */
                MessageBox.Show("No hay suficientes variables en el abecedario para generar " +
                    "producciones binarias con esta gramatica");
                limpiar();
            }
           
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        public void limpiar()
        {
            g = null;
            txtSalida.Clear();
            txtEntrada.Clear();

            butPaso1.Enabled = true;
            butPaso2.Enabled = false;
            butPaso3.Enabled = false;
            butPaso4.Enabled = false;
            butPaso5.Enabled = false;
            butPaso6.Enabled = false;

            txtNoTerminables.Clear();
            txtNoAlcanzables.Clear();
            txtAnulables.Clear();
            txtConjUnitario.Clear();
            comboBoxConjunto.Enabled = true;
            comboBoxConjunto.Items.Clear();

        }

        public Gramatica darGramatica()
        {
            return g;
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
