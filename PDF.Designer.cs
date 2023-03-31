namespace WindowsFormsApp1
{
    partial class PDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDF));
            this.btnIrANavegador = new System.Windows.Forms.Button();
            this.btnIrAReproductor = new System.Windows.Forms.Button();
            this.pdfEjemplo = new AxAcroPDFLib.AxAcroPDF();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPDF = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pdfEjemplo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIrANavegador
            // 
            this.btnIrANavegador.BackColor = System.Drawing.Color.Maroon;
            this.btnIrANavegador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIrANavegador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIrANavegador.ForeColor = System.Drawing.Color.White;
            this.btnIrANavegador.Location = new System.Drawing.Point(596, 384);
            this.btnIrANavegador.Name = "btnIrANavegador";
            this.btnIrANavegador.Size = new System.Drawing.Size(88, 35);
            this.btnIrANavegador.TabIndex = 15;
            this.btnIrANavegador.Text = "Ir al navegador";
            this.btnIrANavegador.UseVisualStyleBackColor = false;
            this.btnIrANavegador.Click += new System.EventHandler(this.btnIrANavegador_Click);
            // 
            // btnIrAReproductor
            // 
            this.btnIrAReproductor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIrAReproductor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIrAReproductor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIrAReproductor.ForeColor = System.Drawing.Color.White;
            this.btnIrAReproductor.Location = new System.Drawing.Point(145, 384);
            this.btnIrAReproductor.Name = "btnIrAReproductor";
            this.btnIrAReproductor.Size = new System.Drawing.Size(96, 35);
            this.btnIrAReproductor.TabIndex = 14;
            this.btnIrAReproductor.Text = "Ir al reproductor";
            this.btnIrAReproductor.UseVisualStyleBackColor = false;
            this.btnIrAReproductor.Click += new System.EventHandler(this.btnIrAReproductor_Click);
            // 
            // pdfEjemplo
            // 
            this.pdfEjemplo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pdfEjemplo.Enabled = true;
            this.pdfEjemplo.Location = new System.Drawing.Point(0, 24);
            this.pdfEjemplo.Name = "pdfEjemplo";
            this.pdfEjemplo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfEjemplo.OcxState")));
            this.pdfEjemplo.Size = new System.Drawing.Size(788, 322);
            this.pdfEjemplo.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirPDFToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirPDFToolStripMenuItem
            // 
            this.abrirPDFToolStripMenuItem.Name = "abrirPDFToolStripMenuItem";
            this.abrirPDFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirPDFToolStripMenuItem.Text = "Abrir PDF";
            this.abrirPDFToolStripMenuItem.Click += new System.EventHandler(this.abrirPDFToolStripMenuItem_Click);
            // 
            // openPDF
            // 
            this.openPDF.FileName = "Busca archivo PDF para abrir";
            // 
            // PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 430);
            this.Controls.Add(this.pdfEjemplo);
            this.Controls.Add(this.btnIrANavegador);
            this.Controls.Add(this.btnIrAReproductor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF";
            ((System.ComponentModel.ISupportInitialize)(this.pdfEjemplo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIrANavegador;
        private System.Windows.Forms.Button btnIrAReproductor;
        private AxAcroPDFLib.AxAcroPDF pdfEjemplo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirPDFToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openPDF;
    }
}