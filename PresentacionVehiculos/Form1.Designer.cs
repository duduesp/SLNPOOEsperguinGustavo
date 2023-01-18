namespace PresentacionVehiculos
{
    partial class Form1
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
            this.btnCrearCamion = new System.Windows.Forms.Button();
            this.btnCrearRemolque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearCamion
            // 
            this.btnCrearCamion.Location = new System.Drawing.Point(52, 43);
            this.btnCrearCamion.Name = "btnCrearCamion";
            this.btnCrearCamion.Size = new System.Drawing.Size(233, 71);
            this.btnCrearCamion.TabIndex = 0;
            this.btnCrearCamion.Text = "Crear Camión";
            this.btnCrearCamion.UseVisualStyleBackColor = true;
            this.btnCrearCamion.Click += new System.EventHandler(this.btnCrearCamion_Click);
            // 
            // btnCrearRemolque
            // 
            this.btnCrearRemolque.Location = new System.Drawing.Point(52, 172);
            this.btnCrearRemolque.Name = "btnCrearRemolque";
            this.btnCrearRemolque.Size = new System.Drawing.Size(233, 79);
            this.btnCrearRemolque.TabIndex = 1;
            this.btnCrearRemolque.Text = "Crear Remolque";
            this.btnCrearRemolque.UseVisualStyleBackColor = true;
            this.btnCrearRemolque.Click += new System.EventHandler(this.btnCrearRemolque_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearRemolque);
            this.Controls.Add(this.btnCrearCamion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCamion;
        private System.Windows.Forms.Button btnCrearRemolque;
    }
}

