
namespace FrmFabrica
{
    partial class FrmControlDeCalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControlDeCalidad));
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.btnProbarJuego = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnVolverAProbar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProductos
            // 
            this.lstProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 16;
            this.lstProductos.Location = new System.Drawing.Point(13, 13);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(255, 132);
            this.lstProductos.TabIndex = 0;
            // 
            // btnProbarJuego
            // 
            this.btnProbarJuego.BackColor = System.Drawing.Color.Gray;
            this.btnProbarJuego.ForeColor = System.Drawing.Color.White;
            this.btnProbarJuego.Location = new System.Drawing.Point(344, 30);
            this.btnProbarJuego.Name = "btnProbarJuego";
            this.btnProbarJuego.Size = new System.Drawing.Size(123, 44);
            this.btnProbarJuego.TabIndex = 1;
            this.btnProbarJuego.Text = "Probar Juego";
            this.btnProbarJuego.UseVisualStyleBackColor = false;
            this.btnProbarJuego.Click += new System.EventHandler(this.btnProbarJuego_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.Gray;
            this.btnResultado.ForeColor = System.Drawing.Color.White;
            this.btnResultado.Location = new System.Drawing.Point(322, 103);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(165, 42);
            this.btnResultado.TabIndex = 2;
            this.btnResultado.Text = "Resultado del Control";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnVolverAProbar
            // 
            this.btnVolverAProbar.BackColor = System.Drawing.Color.Gray;
            this.btnVolverAProbar.ForeColor = System.Drawing.Color.White;
            this.btnVolverAProbar.Location = new System.Drawing.Point(13, 151);
            this.btnVolverAProbar.Name = "btnVolverAProbar";
            this.btnVolverAProbar.Size = new System.Drawing.Size(98, 38);
            this.btnVolverAProbar.TabIndex = 3;
            this.btnVolverAProbar.Text = "Volver a Probar";
            this.btnVolverAProbar.UseVisualStyleBackColor = false;
            this.btnVolverAProbar.Click += new System.EventHandler(this.btnVolverAProbar_Click);
            // 
            // FrmControlDeCalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(516, 197);
            this.Controls.Add(this.btnVolverAProbar);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnProbarJuego);
            this.Controls.Add(this.lstProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmControlDeCalidad";
            this.Text = "Control de Calidad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmControlDeCalidad_FormClosing);
            this.Load += new System.EventHandler(this.FrmControlDeCalidad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Button btnProbarJuego;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnVolverAProbar;
    }
}