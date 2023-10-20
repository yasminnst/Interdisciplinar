
namespace Interdisciplinar
{
    partial class Inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.TelaSplash = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TelaSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // TelaSplash
            // 
            this.TelaSplash.Image = ((System.Drawing.Image)(resources.GetObject("TelaSplash.Image")));
            this.TelaSplash.Location = new System.Drawing.Point(-33, -121);
            this.TelaSplash.Name = "TelaSplash";
            this.TelaSplash.Size = new System.Drawing.Size(1089, 799);
            this.TelaSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TelaSplash.TabIndex = 0;
            this.TelaSplash.TabStop = false;
            this.TelaSplash.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 648);
            this.Controls.Add(this.TelaSplash);
            this.Name = "Inicio";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TelaSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TelaSplash;
        private System.Windows.Forms.Timer timer1;
    }
}

