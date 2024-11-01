namespace PROYECTO02
{
    partial class MostrarUsuarios
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
            this.listaUsuarios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(311, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 106);
            this.label4.TabIndex = 12;
            this.label4.Text = "Usuarios";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listaUsuarios
            // 
            this.listaUsuarios.FormattingEnabled = true;
            this.listaUsuarios.ItemHeight = 16;
            this.listaUsuarios.Location = new System.Drawing.Point(282, 149);
            this.listaUsuarios.Name = "listaUsuarios";
            this.listaUsuarios.Size = new System.Drawing.Size(392, 180);
            this.listaUsuarios.TabIndex = 13;
            // 
            // MostrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(185)))));
            this.Controls.Add(this.listaUsuarios);
            this.Controls.Add(this.label4);
            this.Name = "MostrarUsuarios";
            this.Size = new System.Drawing.Size(981, 624);
            this.Load += new System.EventHandler(this.MostrarUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listaUsuarios;
    }
}
