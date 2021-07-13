
namespace FrmFabrica
{
    partial class FrmJuegoDeMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJuegoDeMesa));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAnios = new System.Windows.Forms.Label();
            this.lblMas = new System.Windows.Forms.Label();
            this.txtClasificacion = new System.Windows.Forms.TextBox();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rtbObjetivo = new System.Windows.Forms.RichTextBox();
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.cmbTablero = new System.Windows.Forms.ComboBox();
            this.grpElementos = new System.Windows.Forms.GroupBox();
            this.ckbPiezas = new System.Windows.Forms.CheckBox();
            this.ckbDados = new System.Windows.Forms.CheckBox();
            this.ckbCartas = new System.Windows.Forms.CheckBox();
            this.lblTablero = new System.Windows.Forms.Label();
            this.grpElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(14, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblAnios
            // 
            this.lblAnios.AutoSize = true;
            this.lblAnios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnios.Location = new System.Drawing.Point(266, 42);
            this.lblAnios.Name = "lblAnios";
            this.lblAnios.Size = new System.Drawing.Size(35, 13);
            this.lblAnios.TabIndex = 22;
            this.lblAnios.Text = "Años";
            // 
            // lblMas
            // 
            this.lblMas.AutoSize = true;
            this.lblMas.Location = new System.Drawing.Point(222, 42);
            this.lblMas.Name = "lblMas";
            this.lblMas.Size = new System.Drawing.Size(13, 13);
            this.lblMas.TabIndex = 21;
            this.lblMas.Text = "+";
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Location = new System.Drawing.Point(241, 39);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Size = new System.Drawing.Size(19, 20);
            this.txtClasificacion.TabIndex = 20;
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasificacion.Location = new System.Drawing.Point(155, 42);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(83, 13);
            this.lblClasificacion.TabIndex = 19;
            this.lblClasificacion.Text = "Clasificacion:";
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(14, 103);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(119, 67);
            this.rtbDescripcion.TabIndex = 26;
            this.rtbDescripcion.Text = "";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(11, 85);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(78, 13);
            this.lblDescripcion.TabIndex = 25;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(412, 147);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(327, 147);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Fabricar!";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rtbObjetivo
            // 
            this.rtbObjetivo.Location = new System.Drawing.Point(151, 126);
            this.rtbObjetivo.Name = "rtbObjetivo";
            this.rtbObjetivo.Size = new System.Drawing.Size(170, 44);
            this.rtbObjetivo.TabIndex = 28;
            this.rtbObjetivo.Text = "";
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.AutoSize = true;
            this.lblObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetivo.Location = new System.Drawing.Point(155, 104);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(58, 13);
            this.lblObjetivo.TabIndex = 27;
            this.lblObjetivo.Text = "Objetivo:";
            // 
            // cmbTablero
            // 
            this.cmbTablero.FormattingEnabled = true;
            this.cmbTablero.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbTablero.Location = new System.Drawing.Point(219, 73);
            this.cmbTablero.Name = "cmbTablero";
            this.cmbTablero.Size = new System.Drawing.Size(41, 21);
            this.cmbTablero.TabIndex = 31;
            // 
            // grpElementos
            // 
            this.grpElementos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpElementos.Controls.Add(this.ckbPiezas);
            this.grpElementos.Controls.Add(this.ckbDados);
            this.grpElementos.Controls.Add(this.ckbCartas);
            this.grpElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpElementos.Location = new System.Drawing.Point(327, 39);
            this.grpElementos.Name = "grpElementos";
            this.grpElementos.Size = new System.Drawing.Size(160, 87);
            this.grpElementos.TabIndex = 30;
            this.grpElementos.TabStop = false;
            this.grpElementos.Text = "Elementos:";
            // 
            // ckbPiezas
            // 
            this.ckbPiezas.AutoSize = true;
            this.ckbPiezas.Location = new System.Drawing.Point(7, 61);
            this.ckbPiezas.Name = "ckbPiezas";
            this.ckbPiezas.Size = new System.Drawing.Size(63, 17);
            this.ckbPiezas.TabIndex = 2;
            this.ckbPiezas.Text = "Piezas";
            this.ckbPiezas.UseVisualStyleBackColor = true;
            // 
            // ckbDados
            // 
            this.ckbDados.AutoSize = true;
            this.ckbDados.Location = new System.Drawing.Point(93, 39);
            this.ckbDados.Name = "ckbDados";
            this.ckbDados.Size = new System.Drawing.Size(62, 17);
            this.ckbDados.TabIndex = 1;
            this.ckbDados.Text = "Dados";
            this.ckbDados.UseVisualStyleBackColor = true;
            // 
            // ckbCartas
            // 
            this.ckbCartas.AutoSize = true;
            this.ckbCartas.Location = new System.Drawing.Point(7, 38);
            this.ckbCartas.Name = "ckbCartas";
            this.ckbCartas.Size = new System.Drawing.Size(62, 17);
            this.ckbCartas.TabIndex = 0;
            this.ckbCartas.Text = "Cartas";
            this.ckbCartas.UseVisualStyleBackColor = true;
            // 
            // lblTablero
            // 
            this.lblTablero.AutoSize = true;
            this.lblTablero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablero.Location = new System.Drawing.Point(155, 76);
            this.lblTablero.Name = "lblTablero";
            this.lblTablero.Size = new System.Drawing.Size(57, 13);
            this.lblTablero.TabIndex = 29;
            this.lblTablero.Text = "Tablero?";
            // 
            // FrmJuegoDeMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(504, 219);
            this.Controls.Add(this.cmbTablero);
            this.Controls.Add(this.grpElementos);
            this.Controls.Add(this.lblTablero);
            this.Controls.Add(this.rtbObjetivo);
            this.Controls.Add(this.lblObjetivo);
            this.Controls.Add(this.rtbDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblAnios);
            this.Controls.Add(this.lblMas);
            this.Controls.Add(this.txtClasificacion);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmJuegoDeMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego De Mesa";
            this.Load += new System.EventHandler(this.FrmJuegoDeMesa_Load);
            this.grpElementos.ResumeLayout(false);
            this.grpElementos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAnios;
        private System.Windows.Forms.Label lblMas;
        private System.Windows.Forms.TextBox txtClasificacion;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RichTextBox rtbObjetivo;
        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.ComboBox cmbTablero;
        private System.Windows.Forms.GroupBox grpElementos;
        private System.Windows.Forms.CheckBox ckbPiezas;
        private System.Windows.Forms.CheckBox ckbDados;
        private System.Windows.Forms.CheckBox ckbCartas;
        private System.Windows.Forms.Label lblTablero;
    }
}