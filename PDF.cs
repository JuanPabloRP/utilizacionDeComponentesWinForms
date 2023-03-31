using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PDF : Form
    {
        public PDF()
        {
            InitializeComponent();
        }

        private void abrirPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openPDF.ShowDialog();
            pdfEjemplo.src = openPDF.FileName;
        }

        private void btnIrAReproductor_Click(object sender, EventArgs e)
        {
            Hide();
            ReproductorDeMusica reproductor = new ReproductorDeMusica();
            reproductor.Show();
        }

        private void btnIrANavegador_Click(object sender, EventArgs e)
        {
            Hide();
            Navegador browser = new Navegador();
            browser.Show();
        }
    }
}
