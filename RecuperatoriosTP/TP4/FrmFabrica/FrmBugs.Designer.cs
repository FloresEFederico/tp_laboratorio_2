
namespace FrmFabrica
{
    partial class FrmBugs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBugs));
            this.lstJuegosBugueados = new System.Windows.Forms.ListBox();
            this.btnArreglar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstJuegosBugueados
            // 
            this.lstJuegosBugueados.FormattingEnabled = true;
            this.lstJuegosBugueados.Location = new System.Drawing.Point(13, 13);
            this.lstJuegosBugueados.Name = "lstJuegosBugueados";
            this.lstJuegosBugueados.Size = new System.Drawing.Size(250, 147);
            this.lstJuegosBugueados.TabIndex = 0;
            // 
            // btnArreglar
            // 
            this.btnArreglar.Location = new System.Drawing.Point(283, 93);
            this.btnArreglar.Name = "btnArreglar";
            this.btnArreglar.Size = new System.Drawing.Size(159, 27);
            this.btnArreglar.TabIndex = 1;
            this.btnArreglar.Text = "Arreglar Bugs";
            this.btnArreglar.UseVisualStyleBackColor = true;
            this.btnArreglar.Click += new System.EventHandler(this.btnArreglar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(283, 126);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(159, 27);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(453, 165);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnArreglar);
            this.Controls.Add(this.lstJuegosBugueados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de VideoJuegos con bugs";
            this.Load += new System.EventHandler(this.FrmBugs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstJuegosBugueados;
        private System.Windows.Forms.Button btnArreglar;
        private System.Windows.Forms.Button btnCancelar;
    }
}