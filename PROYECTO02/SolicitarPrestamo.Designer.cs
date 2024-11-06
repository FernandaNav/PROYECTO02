namespace PROYECTO02
{
    partial class SolicitarPrestamo
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIsbnBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins Black", 46F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(73)))));
            this.label4.Location = new System.Drawing.Point(68, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(807, 135);
            this.label4.TabIndex = 11;
            this.label4.Text = "Solicitar Préstamo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Paint += new System.Windows.Forms.PaintEventHandler(this.label4_Paint);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Poppins Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(402, 399);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 47);
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIsbnBuscar
            // 
            this.txtIsbnBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIsbnBuscar.Font = new System.Drawing.Font("Poppins Light", 16F);
            this.txtIsbnBuscar.Location = new System.Drawing.Point(258, 327);
            this.txtIsbnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtIsbnBuscar.Name = "txtIsbnBuscar";
            this.txtIsbnBuscar.Size = new System.Drawing.Size(424, 47);
            this.txtIsbnBuscar.TabIndex = 39;
            this.txtIsbnBuscar.TextChanged += new System.EventHandler(this.txtIsbnBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(209, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 42);
            this.label1.TabIndex = 41;
            this.label1.Text = "Ingresa el ISBN del libro que quieras solicitar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SolicitarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(185)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIsbnBuscar);
            this.Controls.Add(this.label4);
            this.Name = "SolicitarPrestamo";
            this.Size = new System.Drawing.Size(981, 624);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SolicitarPrestamo_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIsbnBuscar;
        private System.Windows.Forms.Label label1;
    }
}
