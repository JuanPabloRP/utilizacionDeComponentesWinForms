
namespace WindowsFormsApp1
{
    partial class ReproductorDeMusica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReproductorDeMusica));
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.imgAgregar = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnIrANavegador = new System.Windows.Forms.Button();
            this.btnIrAPDF = new System.Windows.Forms.Button();
            this.pnlContainerReproductor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(71, 24);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(282, 62);
            this.Reproductor.TabIndex = 4;
            // 
            // lstCanciones
            // 
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.Location = new System.Drawing.Point(37, 236);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(346, 95);
            this.lstCanciones.TabIndex = 6;
            this.lstCanciones.SelectedIndexChanged += new System.EventHandler(this.lstCanciones_SelectedIndexChanged);
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar.Location = new System.Drawing.Point(158, 208);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(117, 20);
            this.lblAgregar.TabIndex = 7;
            this.lblAgregar.Text = "Agregar sonido";
            // 
            // imgAgregar
            // 
            this.imgAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAgregar.Image = ((System.Drawing.Image)(resources.GetObject("imgAgregar.Image")));
            this.imgAgregar.Location = new System.Drawing.Point(129, 206);
            this.imgAgregar.Name = "imgAgregar";
            this.imgAgregar.Size = new System.Drawing.Size(23, 22);
            this.imgAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAgregar.TabIndex = 5;
            this.imgAgregar.TabStop = false;
            this.imgAgregar.Click += new System.EventHandler(this.imgAgregar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtras.BackgroundImage")));
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtras.Location = new System.Drawing.Point(94, 118);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(49, 50);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.BackgroundImage")));
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Location = new System.Drawing.Point(257, 118);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(45, 50);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Location = new System.Drawing.Point(181, 118);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(45, 50);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnIrANavegador
            // 
            this.btnIrANavegador.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIrANavegador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIrANavegador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIrANavegador.ForeColor = System.Drawing.Color.White;
            this.btnIrANavegador.Location = new System.Drawing.Point(37, 403);
            this.btnIrANavegador.Name = "btnIrANavegador";
            this.btnIrANavegador.Size = new System.Drawing.Size(96, 35);
            this.btnIrANavegador.TabIndex = 11;
            this.btnIrANavegador.Text = "Ir al navegador";
            this.btnIrANavegador.UseVisualStyleBackColor = false;
            this.btnIrANavegador.Click += new System.EventHandler(this.btnIrANavegador_Click);
            // 
            // btnIrAPDF
            // 
            this.btnIrAPDF.BackColor = System.Drawing.Color.Maroon;
            this.btnIrAPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIrAPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIrAPDF.ForeColor = System.Drawing.Color.White;
            this.btnIrAPDF.Location = new System.Drawing.Point(308, 403);
            this.btnIrAPDF.Name = "btnIrAPDF";
            this.btnIrAPDF.Size = new System.Drawing.Size(75, 35);
            this.btnIrAPDF.TabIndex = 12;
            this.btnIrAPDF.Text = "Ir al PDF";
            this.btnIrAPDF.UseVisualStyleBackColor = false;
            this.btnIrAPDF.Click += new System.EventHandler(this.btnIrAPDF_Click);
            // 
            // pnlContainerReproductor
            // 
            this.pnlContainerReproductor.BackColor = System.Drawing.Color.Lavender;
            this.pnlContainerReproductor.Location = new System.Drawing.Point(-4, -1);
            this.pnlContainerReproductor.Name = "pnlContainerReproductor";
            this.pnlContainerReproductor.Size = new System.Drawing.Size(436, 380);
            this.pnlContainerReproductor.TabIndex = 13;
            // 
            // ReproductorDeMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.btnIrAPDF);
            this.Controls.Add(this.btnIrANavegador);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.lstCanciones);
            this.Controls.Add(this.imgAgregar);
            this.Controls.Add(this.Reproductor);
            this.Controls.Add(this.pnlContainerReproductor);
            this.Name = "ReproductorDeMusica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor de música";
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.PictureBox imgAgregar;
        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnIrANavegador;
        private System.Windows.Forms.Button btnIrAPDF;
        private System.Windows.Forms.Panel pnlContainerReproductor;
    }
}

