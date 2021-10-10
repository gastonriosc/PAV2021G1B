using GridFreaks.GUILayer.Colores;
using GridFreaks.GUILayer.Facturas;
using GridFreaks.GUILayer.Marcas;
using GridFreaks.GUILayer.Prendas;
using GridFreaks.GUILayer.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridFreaks
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(frmInicio.GetfrmInicio());
            //Application.Run(new frmUsuarios());
            //Application.Run(new frmPrendas());
            //Application.Run(new frmColores());
            //Application.Run(new frmMarcas());
            //Application.Run(frmFacturas.GetfrmFacturas());

        }
    }
}
