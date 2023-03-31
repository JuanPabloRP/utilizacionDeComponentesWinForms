using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReproductorDeMusica : Form
    {
        bool play = false;  
        string[] archivosMP3;
        string[] rutasArchivosMP3;

        public ReproductorDeMusica()
        {
            InitializeComponent();
        }

        private void imgAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDeBusqueda = new OpenFileDialog();
            CajaDeBusqueda.Multiselect = true;

            if (CajaDeBusqueda.ShowDialog() == DialogResult.OK)
            {
                archivosMP3 = CajaDeBusqueda.SafeFileNames;
                rutasArchivosMP3 = CajaDeBusqueda.FileNames;
                foreach (var archivoMP3 in archivosMP3)
                {
                    lstCanciones.Items.Add(archivoMP3);
                }
                Reproductor.URL = rutasArchivosMP3[0];
                lstCanciones.SelectedIndex = 0;
            }
        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = rutasArchivosMP3[lstCanciones.SelectedIndex];
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (Reproductor.currentMedia != null)
            {
                if (play)
                {
                    btnPlay.BackgroundImage = Properties.Resources.btnPlay;
                    Reproductor.Ctlcontrols.pause();
                    play = false;

                }
                else
                {
                    btnPlay.BackgroundImage = Properties.Resources.pause;

                    Reproductor.Ctlcontrols.play();
                    play = true;
                }
            }
        }


        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (Reproductor.currentMedia != null)
            {
                if(lstCanciones.SelectedIndex != 0)
                {
                    lstCanciones.SelectedIndex -= 1;
                }
                else
                {
                    lstCanciones.SelectedIndex = lstCanciones.Items.Count - 1;

                }
            }

            
            
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (Reproductor.currentMedia != null)
            {
                if (lstCanciones.SelectedIndex != lstCanciones.Items.Count - 1)
                {
                    lstCanciones.SelectedIndex += 1;
                }
                else
                {
                    lstCanciones.SelectedIndex = 0;
                }
            }
        }

        private void imgAdelante_Click(object sender, EventArgs e)
        {

        }

        private void btnIrANavegador_Click(object sender, EventArgs e)
        {
            Hide();
            Navegador browser = new Navegador();
            browser.Show();
        }
    }
}
