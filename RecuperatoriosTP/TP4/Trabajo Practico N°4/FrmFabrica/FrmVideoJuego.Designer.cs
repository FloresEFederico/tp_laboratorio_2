
namespace FrmFabrica
{
    partial class FrmVideoJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVideoJuego));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtClasificacion = new System.Windows.Forms.TextBox();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFormato = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.grpPlataformas = new System.Windows.Forms.GroupBox();
            this.ckbPc = new System.Windows.Forms.CheckBox();
            this.ckbSmartPhone = new System.Windows.Forms.CheckBox();
            this.ckbSwitch = new System.Windows.Forms.CheckBox();
            this.ckbXbox = new System.Windows.Forms.CheckBox();
            this.ckbPlaystation = new System.Windows.Forms.CheckBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblHr = new System.Windows.Forms.Label();
            this.lblMas = new System.Windows.Forms.Label();
            this.lblAnios = new System.Windows.Forms.Label();
            this.grpPlataformas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(319, 325);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Fabricar!";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(423, 325);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(34, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.ForeColor = System.Drawing.Color.Black;
            this.lblClasificacion.Location = new System.Drawing.Point(233, 68);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(69, 13);
            this.lblClasificacion.TabIndex = 3;
            this.lblClasificacion.Text = "Clasificacion:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(21, 261);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(37, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Location = new System.Drawing.Point(319, 65);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Size = new System.Drawing.Size(19, 20);
            this.txtClasificacion.TabIndex = 6;
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(24, 287);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(265, 107);
            this.rtbDescripcion.TabIndex = 7;
            this.rtbDescripcion.Text = "";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.Color.Black;
            this.lblTipo.Location = new System.Drawing.Point(37, 99);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.ForeColor = System.Drawing.Color.Black;
            this.lblFormato.Location = new System.Drawing.Point(37, 152);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(48, 13);
            this.lblFormato.TabIndex = 10;
            this.lblFormato.Text = "Formato:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.ForeColor = System.Drawing.Color.Black;
            this.lblDuracion.Location = new System.Drawing.Point(37, 207);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(53, 13);
            this.lblDuracion.TabIndex = 11;
            this.lblDuracion.Text = "Duracion:";
            // 
            // grpPlataformas
            // 
            this.grpPlataformas.Controls.Add(this.ckbPc);
            this.grpPlataformas.Controls.Add(this.ckbSmartPhone);
            this.grpPlataformas.Controls.Add(this.ckbSwitch);
            this.grpPlataformas.Controls.Add(this.ckbXbox);
            this.grpPlataformas.Controls.Add(this.ckbPlaystation);
            this.grpPlataformas.ForeColor = System.Drawing.Color.Black;
            this.grpPlataformas.Location = new System.Drawing.Point(236, 109);
            this.grpPlataformas.Name = "grpPlataformas";
            this.grpPlataformas.Size = new System.Drawing.Size(213, 140);
            this.grpPlataformas.TabIndex = 12;
            this.grpPlataformas.TabStop = false;
            this.grpPlataformas.Text = "Plataformas:";
            // 
            // ckbPc
            // 
            this.ckbPc.AutoSize = true;
            this.ckbPc.Location = new System.Drawing.Point(7, 84);
            this.ckbPc.Name = "ckbPc";
            this.ckbPc.Size = new System.Drawing.Size(40, 17);
            this.ckbPc.TabIndex = 4;
            this.ckbPc.Text = "PC";
            this.ckbPc.UseVisualStyleBackColor = true;
            // 
            // ckbSmartPhone
            // 
            this.ckbSmartPhone.AutoSize = true;
            this.ckbSmartPhone.Location = new System.Drawing.Point(93, 61);
            this.ckbSmartPhone.Name = "ckbSmartPhone";
            this.ckbSmartPhone.Size = new System.Drawing.Size(84, 17);
            this.ckbSmartPhone.TabIndex = 3;
            this.ckbSmartPhone.Text = "SmartPhone";
            this.ckbSmartPhone.UseVisualStyleBackColor = true;
            // 
            // ckbSwitch
            // 
            this.ckbSwitch.AutoSize = true;
            this.ckbSwitch.Location = new System.Drawing.Point(7, 61);
            this.ckbSwitch.Name = "ckbSwitch";
            this.ckbSwitch.Size = new System.Drawing.Size(58, 17);
            this.ckbSwitch.TabIndex = 2;
            this.ckbSwitch.Text = "Switch";
            this.ckbSwitch.UseVisualStyleBackColor = true;
            // 
            // ckbXbox
            // 
            this.ckbXbox.AutoSize = true;
            this.ckbXbox.Location = new System.Drawing.Point(93, 39);
            this.ckbXbox.Name = "ckbXbox";
            this.ckbXbox.Size = new System.Drawing.Size(50, 17);
            this.ckbXbox.TabIndex = 1;
            this.ckbXbox.Text = "Xbox";
            this.ckbXbox.UseVisualStyleBackColor = true;
            // 
            // ckbPlaystation
            // 
            this.ckbPlaystation.AutoSize = true;
            this.ckbPlaystation.Location = new System.Drawing.Point(7, 38);
            this.ckbPlaystation.Name = "ckbPlaystation";
            this.ckbPlaystation.Size = new System.Drawing.Size(77, 17);
            this.ckbPlaystation.TabIndex = 0;
            this.ckbPlaystation.Text = "Playstation";
            this.ckbPlaystation.UseVisualStyleBackColor = true;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(89, 99);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(93, 21);
            this.cmbTipo.TabIndex = 13;
            // 
            // cmbFormato
            // 
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Location = new System.Drawing.Point(91, 152);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(61, 21);
            this.cmbFormato.TabIndex = 14;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(91, 207);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(32, 20);
            this.txtDuracion.TabIndex = 15;
            // 
            // lblHr
            // 
            this.lblHr.AutoSize = true;
            this.lblHr.ForeColor = System.Drawing.Color.Black;
            this.lblHr.Location = new System.Drawing.Point(129, 210);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(23, 13);
            this.lblHr.TabIndex = 16;
            this.lblHr.Text = "Hrs";
            // 
            // lblMas
            // 
            this.lblMas.AutoSize = true;
            this.lblMas.Location = new System.Drawing.Point(300, 68);
            this.lblMas.Name = "lblMas";
            this.lblMas.Size = new System.Drawing.Size(13, 13);
            this.lblMas.TabIndex = 17;
            this.lblMas.Text = "+";
            // 
            // lblAnios
            // 
            this.lblAnios.AutoSize = true;
            this.lblAnios.ForeColor = System.Drawing.Color.Black;
            this.lblAnios.Location = new System.Drawing.Point(344, 68);
            this.lblAnios.Name = "lblAnios";
            this.lblAnios.Size = new System.Drawing.Size(31, 13);
            this.lblAnios.TabIndex = 18;
            this.lblAnios.Text = "Años";
            // 
            // FrmVideoJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(526, 412);
            this.Controls.Add(this.lblAnios);
            this.Controls.Add(this.lblMas);
            this.Controls.Add(this.lblHr);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.cmbFormato);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.grpPlataformas);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.rtbDescripcion);
            this.Controls.Add(this.txtClasificacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVideoJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoJuego";
            this.Load += new System.EventHandler(this.FrmJuego_Load);
            this.grpPlataformas.ResumeLayout(false);
            this.grpPlataformas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtClasificacion;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.GroupBox grpPlataformas;
        private System.Windows.Forms.CheckBox ckbPlaystation;
        private System.Windows.Forms.CheckBox ckbPc;
        private System.Windows.Forms.CheckBox ckbSmartPhone;
        private System.Windows.Forms.CheckBox ckbSwitch;
        private System.Windows.Forms.CheckBox ckbXbox;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbFormato;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblHr;
        private System.Windows.Forms.Label lblMas;
        private System.Windows.Forms.Label lblAnios;
    }
}