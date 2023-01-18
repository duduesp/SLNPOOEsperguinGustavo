namespace WindowsEFDatos
{
    partial class frmAvion
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnMostrarAviones = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnTraer = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.GridAviones = new System.Windows.Forms.DataGridView();
            this.textCapacidad = new System.Windows.Forms.TextBox();
            this.textDenominacion = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridAviones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(503, 12);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(182, 48);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnMostrarAviones
            // 
            this.btnMostrarAviones.Location = new System.Drawing.Point(503, 92);
            this.btnMostrarAviones.Name = "btnMostrarAviones";
            this.btnMostrarAviones.Size = new System.Drawing.Size(180, 65);
            this.btnMostrarAviones.TabIndex = 1;
            this.btnMostrarAviones.Text = "Mostrar Aviones";
            this.btnMostrarAviones.UseVisualStyleBackColor = true;
            this.btnMostrarAviones.Click += new System.EventHandler(this.btnMostrarAviones_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(499, 177);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(182, 62);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Aviones";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnTraer
            // 
            this.btnTraer.Location = new System.Drawing.Point(499, 257);
            this.btnTraer.Name = "btnTraer";
            this.btnTraer.Size = new System.Drawing.Size(186, 71);
            this.btnTraer.TabIndex = 3;
            this.btnTraer.Text = "Traer";
            this.btnTraer.UseVisualStyleBackColor = true;
            this.btnTraer.Click += new System.EventHandler(this.btnTraer_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(503, 351);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(178, 68);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // GridAviones
            // 
            this.GridAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAviones.Location = new System.Drawing.Point(68, 216);
            this.GridAviones.Name = "GridAviones";
            this.GridAviones.Size = new System.Drawing.Size(316, 193);
            this.GridAviones.TabIndex = 5;
            // 
            // textCapacidad
            // 
            this.textCapacidad.Location = new System.Drawing.Point(299, 22);
            this.textCapacidad.Name = "textCapacidad";
            this.textCapacidad.Size = new System.Drawing.Size(158, 20);
            this.textCapacidad.TabIndex = 9;
            // 
            // textDenominacion
            // 
            this.textDenominacion.Location = new System.Drawing.Point(302, 85);
            this.textDenominacion.Name = "textDenominacion";
            this.textDenominacion.Size = new System.Drawing.Size(154, 20);
            this.textDenominacion.TabIndex = 10;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(308, 158);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(147, 20);
            this.textId.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Capacidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Denominacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID";
            // 
            // frmAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textDenominacion);
            this.Controls.Add(this.textCapacidad);
            this.Controls.Add(this.GridAviones);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnTraer);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnMostrarAviones);
            this.Controls.Add(this.btnInsertar);
            this.Name = "frmAvion";
            this.Text = "frmAvion";
            this.Load += new System.EventHandler(this.frmAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAviones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnMostrarAviones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnTraer;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView GridAviones;
        private System.Windows.Forms.TextBox textCapacidad;
        private System.Windows.Forms.TextBox textDenominacion;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}