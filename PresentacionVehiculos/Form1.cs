using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibTransportes;
using LibTransportes.Vehiculo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PresentacionVehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearCamion_Click(object sender, EventArgs e)
        {
            Camion camion = new Camion(6, "BMW", "Mercaderia", true);
            MessageBox.Show(camion.ImprimirCamión());
            
            
        }

        private void btnCrearRemolque_Click(object sender, EventArgs e)
        {
            Remolque remolque = new Remolque("Rojo", true);
            MessageBox.Show(remolque.ImprimirRemolque());
        }
    }
}
