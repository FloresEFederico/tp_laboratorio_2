
namespace FrmFabrica
{
    partial class FrmBaseDeDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaseDeDatos));
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.lblListaProductos = new System.Windows.Forms.Label();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtIdABorrar = new System.Windows.Forms.TextBox();
            this.lblBorrar = new System.Windows.Forms.Label();
            this.btnMostrarSoloJuegosDeMesa = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnMostrarSoloVideoJuegos = new System.Windows.Forms.Button();
            this.pnlMostrarPorTipo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.pnlMostrarPorTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProductos
            // 
            this.lstProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 18;
            this.lstProductos.Location = new System.Drawing.Point(12, 29);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(294, 148);
            this.lstProductos.TabIndex = 0;
            // 
            // lblListaProductos
            // 
            this.lblListaProductos.AutoSize = true;
            this.lblListaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProductos.Location = new System.Drawing.Point(12, 10);
            this.lblListaProductos.Name = "lblListaProductos";
            this.lblListaProductos.Size = new System.Drawing.Size(174, 18);
            this.lblListaProductos.TabIndex = 1;
            this.lblListaProductos.Text = "Listado de Productos:";
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(348, 12);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersVisible = false;
            this.dgvTabla.Size = new System.Drawing.Size(519, 239);
            this.dgvTabla.TabIndex = 2;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInsertar.Location = new System.Drawing.Point(13, 184);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(129, 50);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "Insertar Producto";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.Location = new System.Drawing.Point(12, 285);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(84, 44);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtIdABorrar
            // 
            this.txtIdABorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtIdABorrar.Location = new System.Drawing.Point(212, 250);
            this.txtIdABorrar.Name = "txtIdABorrar";
            this.txtIdABorrar.Size = new System.Drawing.Size(35, 24);
            this.txtIdABorrar.TabIndex = 5;
            // 
            // lblBorrar
            // 
            this.lblBorrar.AutoSize = true;
            this.lblBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblBorrar.Location = new System.Drawing.Point(9, 250);
            this.lblBorrar.Name = "lblBorrar";
            this.lblBorrar.Size = new System.Drawing.Size(197, 18);
            this.lblBorrar.TabIndex = 6;
            this.lblBorrar.Text = "Ingrese idJuego a borrar:";
            // 
            // btnMostrarSoloJuegosDeMesa
            // 
            this.btnMostrarSoloJuegosDeMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMostrarSoloJuegosDeMesa.Location = new System.Drawing.Point(193, 14);
            this.btnMostrarSoloJuegosDeMesa.Name = "btnMostrarSoloJuegosDeMesa";
            this.btnMostrarSoloJuegosDeMesa.Size = new System.Drawing.Size(169, 50);
            this.btnMostrarSoloJuegosDeMesa.TabIndex = 8;
            this.btnMostrarSoloJuegosDeMesa.Tag = "JuegoDeMesa";
            this.btnMostrarSoloJuegosDeMesa.Text = "Mostrar Solo Juegos de Mesa";
            this.btnMostrarSoloJuegosDeMesa.UseVisualStyleBackColor = true;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMostrarTodos.Location = new System.Drawing.Point(364, 14);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(169, 50);
            this.btnMostrarTodos.TabIndex = 9;
            this.btnMostrarTodos.Tag = "Todos";
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // btnMostrarSoloVideoJuegos
            // 
            this.btnMostrarSoloVideoJuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMostrarSoloVideoJuegos.Location = new System.Drawing.Point(18, 14);
            this.btnMostrarSoloVideoJuegos.Name = "btnMostrarSoloVideoJuegos";
            this.btnMostrarSoloVideoJuegos.Size = new System.Drawing.Size(169, 50);
            this.btnMostrarSoloVideoJuegos.TabIndex = 7;
            this.btnMostrarSoloVideoJuegos.Tag = "VideoJuego";
            this.btnMostrarSoloVideoJuegos.Text = "Mostrar Solo VideoJuegos";
            this.btnMostrarSoloVideoJuegos.UseVisualStyleBackColor = true;
            // 
            // pnlMostrarPorTipo
            // 
            this.pnlMostrarPorTipo.Controls.Add(this.btnMostrarSoloJuegosDeMesa);
            this.pnlMostrarPorTipo.Controls.Add(this.btnMostrarTodos);
            this.pnlMostrarPorTipo.Controls.Add(this.btnMostrarSoloVideoJuegos);
            this.pnlMostrarPorTipo.Location = new System.Drawing.Point(331, 265);
            this.pnlMostrarPorTipo.Name = "pnlMostrarPorTipo";
            this.pnlMostrarPorTipo.Size = new System.Drawing.Size(536, 72);
            this.pnlMostrarPorTipo.TabIndex = 10;
            // 
            // FrmBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 349);
            this.Controls.Add(this.pnlMostrarPorTipo);
            this.Controls.Add(this.lblBorrar);
            this.Controls.Add(this.txtIdABorrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.lblListaProductos);
            this.Controls.Add(this.lstProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBaseDeDatos";
            this.Text = "Base de Datos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBaseDeDatos_FormClosing);
            this.Load += new System.EventHandler(this.FrmBaseDeDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.pnlMostrarPorTipo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Label lblListaProductos;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtIdABorrar;
        private System.Windows.Forms.Label lblBorrar;
        private System.Windows.Forms.Button btnMostrarSoloJuegosDeMesa;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnMostrarSoloVideoJuegos;
        private System.Windows.Forms.Panel pnlMostrarPorTipo;
    }
}