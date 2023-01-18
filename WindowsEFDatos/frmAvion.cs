using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Dac;
using WindowsEFDatos.Modelos;

namespace WindowsEFDatos
{
    public partial class frmAvion : Form
    {
        public frmAvion()
        {
            InitializeComponent();
        }

        private void frmAvion_Load(object sender, EventArgs e)
        {
            MostrarAviones();
        }


        private void MostrarAviones()
        {
            GridAviones.DataSource = AdmAvion.Listar();
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion() {Capacidad = Convert.ToInt32(textCapacidad.Text),
                Denominacion = textDenominacion.Text };
            int filasAfectadas = AdmAvion.Insertar(avion);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert Ok");
                MostrarAviones();
            }

        }

        private void btnMostrarAviones_Click(object sender, EventArgs e)
        {
            MostrarAviones();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion() { IdAvion = Convert.ToInt32(textId.Text) };

            int filasAfectadas = AdmAvion.Eliminar(avion.IdAvion);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarAviones();
            }

        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textId.Text);

            Avion avion = AdmAvion.TraerUno(id);
            MessageBox.Show(Convert.ToString("Capacidad: " + avion.Capacidad + "\nDenominación: " + avion.Denominacion + "\nLinea Aerea: " + avion.LineaAerea));

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion() { Capacidad = Convert.ToInt32(textCapacidad.Text), 
                Denominacion = textDenominacion.Text, IdAvion = Convert.ToInt32(textId.Text) };

            int filasAfectadas = AdmAvion.Editar(avion);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Edicion ok");
                MostrarAviones();
            }
        }






    }
}
