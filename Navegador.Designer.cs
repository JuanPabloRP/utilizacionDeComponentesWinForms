
namespace WindowsFormsApp1
{
    partial class Navegador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webEjemplo = new System.Windows.Forms.WebBrowser();
            this.btnIrAReproductor = new System.Windows.Forms.Button();
            this.btnIrAPDF = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webEjemplo
            // 
            this.webEjemplo.Location = new System.Drawing.Point(1, 50);
            this.webEjemplo.MinimumSize = new System.Drawing.Size(20, 20);
            this.webEjemplo.Name = "webEjemplo";
            this.webEjemplo.ScriptErrorsSuppressed = true;
            this.webEjemplo.Size = new System.Drawing.Size(744, 326);
            this.webEjemplo.TabIndex = 2;
            this.webEjemplo.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // btnIrAReproductor
            // 
            this.btnIrAReproductor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIrAReproductor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIrAReproductor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIrAReproductor.ForeColor = System.Drawing.Color.White;
            this.btnIrAReproductor.Location = new System.Drawing.Point(108, 403);
            this.btnIrAReproductor.Name = "btnIrAReproductor";
            this.btnIrAReproductor.Size = new System.Drawing.Size(96, 35);
            this.btnIrAReproductor.TabIndex = 12;
            this.btnIrAReproductor.Text = "Ir al reproductor";
            this.btnIrAReproductor.UseVisualStyleBackColor = false;
            this.btnIrAReproductor.Click += new System.EventHandler(this.btnIrAReproductor_Click);
            // 
            // btnIrAPDF
            // 
            this.btnIrAPDF.BackColor = System.Drawing.Color.Maroon;
            this.btnIrAPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIrAPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIrAPDF.ForeColor = System.Drawing.Color.White;
            this.btnIrAPDF.Location = new System.Drawing.Point(558, 403);
            this.btnIrAPDF.Name = "btnIrAPDF";
            this.btnIrAPDF.Size = new System.Drawing.Size(75, 35);
            this.btnIrAPDF.TabIndex = 13;
            this.btnIrAPDF.Text = "Ir al PDF";
            this.btnIrAPDF.UseVisualStyleBackColor = false;
            this.btnIrAPDF.Click += new System.EventHandler(this.btnIrAPDF_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(67, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(20, 23);
            this.btnAtras.TabIndex = 14;
            this.btnAtras.Text = "<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(93, 12);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(20, 23);
            this.btnSiguiente.TabIndex = 15;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(119, 12);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(59, 23);
            this.btnRecargar.TabIndex = 16;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(184, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(52, 23);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "Parar";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(49, 23);
            this.btnHome.TabIndex = 18;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(242, 14);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(372, 20);
            this.txtBusqueda.TabIndex = 19;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(620, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Navegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnIrAPDF);
            this.Controls.Add(this.btnIrAReproductor);
            this.Controls.Add(this.webEjemplo);
            this.Name = "Navegador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navegador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webEjemplo;
        private System.Windows.Forms.Button btnIrAReproductor;
        private System.Windows.Forms.Button btnIrAPDF;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
    }
}