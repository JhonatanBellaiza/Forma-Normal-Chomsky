using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNC
{
    /*
     * Clase que representa la grámatica de chomsky
     * @autor Christian Alberto Tamayo Robayo, Jhonnatan Bellaiza Caicedo, Cesar Botina
     */
    static class Program
    {
        /*
         * <summary>
         * Punto de entrada principal para la aplicación.
         * </summary>
         */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VentanaPrincipal());
        }
    }
}
