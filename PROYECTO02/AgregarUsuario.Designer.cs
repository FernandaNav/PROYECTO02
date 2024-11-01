namespace PROYECTO02
{
    partial class AgregarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreNew = new System.Windows.Forms.TextBox();
            this.txtPasswordNew = new System.Windows.Forms.TextBox();
            this.cmbUsuarioNew = new System.Windows.Forms.ComboBox();
            this.btnAgregarUser = new System.Windows.Forms.Button();
            this.btnLimpiar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(184, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(563, 106);
            this.label4.TabIndex = 11;
            this.label4.Text = "Agregar Usuario";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(235, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 42);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(235, 377);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 42);
            this.label3.TabIndex = 14;
            this.label3.Text = "Rol:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNombreNew
            // 
            this.txtNombreNew.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNombreNew.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreNew.Location = new System.Drawing.Point(287, 196);
            this.txtNombreNew.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreNew.Name = "txtNombreNew";
            this.txtNombreNew.Size = new System.Drawing.Size(424, 37);
            this.txtNombreNew.TabIndex = 15;
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPasswordNew.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordNew.Location = new System.Drawing.Point(287, 313);
            this.txtPasswordNew.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.Size = new System.Drawing.Size(424, 37);
            this.txtPasswordNew.TabIndex = 16;
            // 
            // cmbUsuarioNew
            // 
            this.cmbUsuarioNew.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbUsuarioNew.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuarioNew.FormattingEnabled = true;
            this.cmbUsuarioNew.Items.AddRange(new object[] {
            "Bibliotecario",
            "Lector"});
            this.cmbUsuarioNew.Location = new System.Drawing.Point(287, 422);
            this.cmbUsuarioNew.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUsuarioNew.Name = "cmbUsuarioNew";
            this.cmbUsuarioNew.Size = new System.Drawing.Size(424, 44);
            this.cmbUsuarioNew.TabIndex = 17;
            // 
            // btnAgregarUser
            // 
            this.btnAgregarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnAgregarUser.FlatAppearance.BorderSize = 0;
            this.btnAgregarUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAgregarUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.btnAgregarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUser.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarUser.Location = new System.Drawing.Point(287, 498);
            this.btnAgregarUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarUser.Name = "btnAgregarUser";
            this.btnAgregarUser.Size = new System.Drawing.Size(161, 60);
            this.btnAgregarUser.TabIndex = 18;
            this.btnAgregarUser.Text = "Agregar";
            this.btnAgregarUser.UseVisualStyleBackColor = false;
            this.btnAgregarUser.Click += new System.EventHandler(this.btnAgregarUser_Click);
            // 
            // btnLimpiar1
            // 
            this.btnLimpiar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnLimpiar1.FlatAppearance.BorderSize = 0;
            this.btnLimpiar1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpiar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.btnLimpiar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar1.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar1.Location = new System.Drawing.Point(551, 498);
            this.btnLimpiar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar1.Name = "btnLimpiar1";
            this.btnLimpiar1.Size = new System.Drawing.Size(161, 60);
            this.btnLimpiar1.TabIndex = 19;
            this.btnLimpiar1.Text = "Limpiar";
            this.btnLimpiar1.UseVisualStyleBackColor = false;
            this.btnLimpiar1.Click += new System.EventHandler(this.btnLimpiar1_Click);
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(185)))));
            this.Controls.Add(this.btnLimpiar1);
            this.Controls.Add(this.btnAgregarUser);
            this.Controls.Add(this.cmbUsuarioNew);
            this.Controls.Add(this.txtPasswordNew);
            this.Controls.Add(this.txtNombreNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgregarUsuario";
            this.Size = new System.Drawing.Size(981, 624);
            this.Load += new System.EventHandler(this.AgregarUsuario_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AgregarUsuario_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreNew;
        private System.Windows.Forms.TextBox txtPasswordNew;
        private System.Windows.Forms.ComboBox cmbUsuarioNew;
        private System.Windows.Forms.Button btnAgregarUser;
        private System.Windows.Forms.Button btnLimpiar1;
    }
}
