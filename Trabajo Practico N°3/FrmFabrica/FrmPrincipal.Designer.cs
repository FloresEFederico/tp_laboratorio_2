
namespace FrmFabrica
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnVideoJuego = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnArreglo = new System.Windows.Forms.Button();
            this.btnJuegoDeMesa = new System.Windows.Forms.Button();
            this.rtbListaDeJuegos = new System.Windows.Forms.RichTextBox();
            this.btnAgregarEspacio = new System.Windows.Forms.Button();
            this.btnGuardarTexto = new System.Windows.Forms.Button();
            this.btnLeerTexto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVideoJuego
            // 
            this.btnVideoJuego.BackColor = System.Drawing.Color.DimGray;
            this.btnVideoJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoJuego.ForeColor = System.Drawing.Color.White;
            this.btnVideoJuego.Location = new System.Drawing.Point(12, 75);
            this.btnVideoJuego.Name = "btnVideoJuego";
            this.btnVideoJuego.Size = new System.Drawing.Size(161, 65);
            this.btnVideoJuego.TabIndex = 0;
            this.btnVideoJuego.Text = "Fabricar VideoJuego";
            this.btnVideoJuego.UseVisualStyleBackColor = false;
            this.btnVideoJuego.Click += new System.EventHandler(this.btnVideoJuego_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.DimGray;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(363, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(432, 49);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Lista de juegos fabricados";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(12, 301);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 63);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar en Xml";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.DimGray;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(192, 301);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(143, 63);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar Datos Xml";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnArreglo
            // 
            this.btnArreglo.BackColor = System.Drawing.Color.DimGray;
            this.btnArreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArreglo.ForeColor = System.Drawing.Color.White;
            this.btnArreglo.Location = new System.Drawing.Point(97, 163);
            this.btnArreglo.Name = "btnArreglo";
            this.btnArreglo.Size = new System.Drawing.Size(161, 40);
            this.btnArreglo.TabIndex = 4;
            this.btnArreglo.Text = "Arreglar Bugs de VideoJuegos";
            this.btnArreglo.UseVisualStyleBackColor = false;
            this.btnArreglo.Click += new System.EventHandler(this.btnArreglo_Click);
            // 
            // btnJuegoDeMesa
            // 
            this.btnJuegoDeMesa.BackColor = System.Drawing.Color.DimGray;
            this.btnJuegoDeMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuegoDeMesa.ForeColor = System.Drawing.Color.White;
            this.btnJuegoDeMesa.Location = new System.Drawing.Point(192, 75);
            this.btnJuegoDeMesa.Name = "btnJuegoDeMesa";
            this.btnJuegoDeMesa.Size = new System.Drawing.Size(155, 65);
            this.btnJuegoDeMesa.TabIndex = 5;
            this.btnJuegoDeMesa.Text = "Fabricar Juego de Mesa";
            this.btnJuegoDeMesa.UseVisualStyleBackColor = false;
            this.btnJuegoDeMesa.Click += new System.EventHandler(this.btnJuegoDeMesa_Click);
            // 
            // rtbListaDeJuegos
            // 
            this.rtbListaDeJuegos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbListaDeJuegos.Location = new System.Drawing.Point(363, 65);
            this.rtbListaDeJuegos.Name = "rtbListaDeJuegos";
            this.rtbListaDeJuegos.Size = new System.Drawing.Size(432, 390);
            this.rtbListaDeJuegos.TabIndex = 6;
            this.rtbListaDeJuegos.Text = "";
            // 
            // btnAgregarEspacio
            // 
            this.btnAgregarEspacio.BackColor = System.Drawing.Color.DimGray;
            this.btnAgregarEspacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEspacio.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEspacio.Location = new System.Drawing.Point(19, 392);
            this.btnAgregarEspacio.Name = "btnAgregarEspacio";
            this.btnAgregarEspacio.Size = new System.Drawing.Size(130, 63);
            this.btnAgregarEspacio.TabIndex = 7;
            this.btnAgregarEspacio.Text = "Agregar Espacio";
            this.btnAgregarEspacio.UseVisualStyleBackColor = false;
            this.btnAgregarEspacio.Click += new System.EventHandler(this.btnAgregarEspacio_Click);
            // 
            // btnGuardarTexto
            // 
            this.btnGuardarTexto.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardarTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTexto.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTexto.Location = new System.Drawing.Point(12, 232);
            this.btnGuardarTexto.Name = "btnGuardarTexto";
            this.btnGuardarTexto.Size = new System.Drawing.Size(137, 63);
            this.btnGuardarTexto.TabIndex = 8;
            this.btnGuardarTexto.Text = "Guardar Archivo Texto";
            this.btnGuardarTexto.UseVisualStyleBackColor = false;
            this.btnGuardarTexto.Click += new System.EventHandler(this.btnGuardarTexto_Click);
            // 
            // btnLeerTexto
            // 
            this.btnLeerTexto.BackColor = System.Drawing.Color.DimGray;
            this.btnLeerTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerTexto.ForeColor = System.Drawing.Color.White;
            this.btnLeerTexto.Location = new System.Drawing.Point(192, 232);
            this.btnLeerTexto.Name = "btnLeerTexto";
            this.btnLeerTexto.Size = new System.Drawing.Size(143, 63);
            this.btnLeerTexto.TabIndex = 9;
            this.btnLeerTexto.Text = "Leer Archivo Texto";
            this.btnLeerTexto.UseVisualStyleBackColor = false;
            this.btnLeerTexto.Click += new System.EventHandler(this.btnLeerTexto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DimGray;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(192, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(143, 63);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(807, 467);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLeerTexto);
            this.Controls.Add(this.btnGuardarTexto);
            this.Controls.Add(this.btnAgregarEspacio);
            this.Controls.Add(this.rtbListaDeJuegos);
            this.Controls.Add(this.btnJuegoDeMesa);
            this.Controls.Add(this.btnArreglo);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnVideoJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabrica de Juegos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVideoJuego;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnArreglo;
        private System.Windows.Forms.Button btnJuegoDeMesa;
        private System.Windows.Forms.RichTextBox rtbListaDeJuegos;
        private System.Windows.Forms.Button btnAgregarEspacio;
        private System.Windows.Forms.Button btnGuardarTexto;
        private System.Windows.Forms.Button btnLeerTexto;
        private System.Windows.Forms.Button btnSalir;
    }
}

