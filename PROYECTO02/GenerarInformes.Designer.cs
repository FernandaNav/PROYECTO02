namespace PROYECTO02
{
    partial class GenerarInformes
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.btnLibrosSolicitados = new System.Windows.Forms.Button();
            this.btnOpAgregarU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(73)))));
            this.label4.Location = new System.Drawing.Point(195, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(554, 106);
            this.label4.TabIndex = 13;
            this.label4.Text = "Elige una opción";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLibrosSolicitados
            // 
            this.btnLibrosSolicitados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnLibrosSolicitados.FlatAppearance.BorderSize = 0;
            this.btnLibrosSolicitados.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLibrosSolicitados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.btnLibrosSolicitados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrosSolicitados.Font = new System.Drawing.Font("Poppins Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLibrosSolicitados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLibrosSolicitados.Location = new System.Drawing.Point(313, 373);
            this.btnLibrosSolicitados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLibrosSolicitados.Name = "btnLibrosSolicitados";
            this.btnLibrosSolicitados.Size = new System.Drawing.Size(329, 91);
            this.btnLibrosSolicitados.TabIndex = 12;
            this.btnLibrosSolicitados.Text = "Libros Más Solicitados";
            this.btnLibrosSolicitados.UseVisualStyleBackColor = false;
            this.btnLibrosSolicitados.Click += new System.EventHandler(this.btnLibrosSolicitados_Click);
            // 
            // btnOpAgregarU
            // 
            this.btnOpAgregarU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnOpAgregarU.FlatAppearance.BorderSize = 0;
            this.btnOpAgregarU.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOpAgregarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.btnOpAgregarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpAgregarU.Font = new System.Drawing.Font("Poppins Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnOpAgregarU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpAgregarU.Location = new System.Drawing.Point(313, 246);
            this.btnOpAgregarU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpAgregarU.Name = "btnOpAgregarU";
            this.btnOpAgregarU.Size = new System.Drawing.Size(329, 91);
            this.btnOpAgregarU.TabIndex = 11;
            this.btnOpAgregarU.Text = "Préstamos Activos";
            this.btnOpAgregarU.UseVisualStyleBackColor = false;
            this.btnOpAgregarU.Click += new System.EventHandler(this.btnOpAgregarU_Click);
            // 
            // GenerarInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(185)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLibrosSolicitados);
            this.Controls.Add(this.btnOpAgregarU);
            this.Name = "GenerarInformes";
            this.Size = new System.Drawing.Size(981, 624);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GenerarInformes_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLibrosSolicitados;
        private System.Windows.Forms.Button btnOpAgregarU;
    }
}
