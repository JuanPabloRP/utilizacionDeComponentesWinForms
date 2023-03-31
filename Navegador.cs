using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Navegador : Form
    {
        public Navegador()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webEjemplo.GoHome();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            webEjemplo.GoBack();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            webEjemplo.GoForward();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            webEjemplo.Refresh();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webEjemplo.Stop();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            webEjemplo.Navigate(txtBusqueda.Text);
        }

        private void btnIrAReproductor_Click(object sender, EventArgs e)
        {
            Hide();
            ReproductorDeMusica reproductor = new ReproductorDeMusica();
            reproductor.Show();
        }

        private void btnIrAPDF_Click(object sender, EventArgs e)
        {
            Hide();
            PDF pdfPage = new PDF();
            pdfPage.Show();
        }
    }
}
