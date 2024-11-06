namespace PROYECTO02
{
    partial class Crear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear));
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiar1 = new System.Windows.Forms.Button();
            this.btnAgregarUser = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(19, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 36);
            this.button1.TabIndex = 40;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar1
            // 
            this.btnLimpiar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnLimpiar1.FlatAppearance.BorderSize = 0;
            this.btnLimpiar1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpiar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.btnLimpiar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar1.Font = new System.Drawing.Font("Poppins Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar1.Location = new System.Drawing.Point(561, 545);
            this.btnLimpiar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar1.Name = "btnLimpiar1";
            this.btnLimpiar1.Size = new System.Drawing.Size(294, 60);
            this.btnLimpiar1.TabIndex = 39;
            this.btnLimpiar1.Text = "Limpiar";
            this.btnLimpiar1.UseVisualStyleBackColor = false;
            this.btnLimpiar1.Click += new System.EventHandler(this.btnLimpiar1_Click);
            // 
            // btnAgregarUser
            // 
            this.btnAgregarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnAgregarUser.FlatAppearance.BorderSize = 0;
            this.btnAgregarUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAgregarUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.btnAgregarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUser.Font = new System.Drawing.Font("Poppins Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregarUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarUser.Location = new System.Drawing.Point(146, 545);
            this.btnAgregarUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarUser.Name = "btnAgregarUser";
            this.btnAgregarUser.Size = new System.Drawing.Size(258, 60);
            this.btnAgregarUser.TabIndex = 38;
            this.btnAgregarUser.Text = "Agregar";
            this.btnAgregarUser.UseVisualStyleBackColor = false;
            this.btnAgregarUser.Click += new System.EventHandler(this.btnAgregarUser_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbRol.Enabled = false;
            this.cmbRol.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Bibliotecario",
            "Lector"});
            this.cmbRol.Location = new System.Drawing.Point(353, 409);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(433, 44);
            this.cmbRol.TabIndex = 37;
            this.cmbRol.Text = "Lector";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPassword.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(353, 321);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(433, 37);
            this.txtPassword.TabIndex = 36;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNombre.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(353, 233);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(433, 37);
            this.txtNombre.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(275, 408);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 42);
            this.label3.TabIndex = 34;
            this.label3.Text = "Rol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(213, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 42);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 42);
            this.label1.TabIndex = 32;
            this.label1.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(73)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(202, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(584, 106);
            this.label4.TabIndex = 31;
            this.label4.Text = "¡Crea tu Usuario!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(896, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Crear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1003, 704);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar1);
            this.Controls.Add(this.btnAgregarUser);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Crear_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiar1;
        private System.Windows.Forms.Button btnAgregarUser;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}