namespace PROYECTO02
{
    partial class EditarLibro
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewLibros = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsbnBuscar = new System.Windows.Forms.TextBox();
            this.panEditar = new System.Windows.Forms.Panel();
            this.txtAutorEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGeneroEdit = new System.Windows.Forms.TextBox();
            this.btnAutor = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTituloEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibros)).BeginInit();
            this.panEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegresar.Location = new System.Drawing.Point(10, 8);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(114, 36);
            this.btnRegresar.TabIndex = 34;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(275, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 106);
            this.label4.TabIndex = 33;
            this.label4.Text = "Editar  Libro";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridViewLibros
            // 
            this.dataGridViewLibros.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibros.Location = new System.Drawing.Point(121, 478);
            this.dataGridViewLibros.Name = "dataGridViewLibros";
            this.dataGridViewLibros.RowHeadersWidth = 51;
            this.dataGridViewLibros.RowTemplate.Height = 24;
            this.dataGridViewLibros.Size = new System.Drawing.Size(733, 186);
            this.dataGridViewLibros.TabIndex = 35;
            this.dataGridViewLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLibros_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(631, 151);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 36);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 42);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ingresa el nombre del usuario a editar";
            // 
            // txtIsbnBuscar
            // 
            this.txtIsbnBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIsbnBuscar.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbnBuscar.Location = new System.Drawing.Point(200, 151);
            this.txtIsbnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtIsbnBuscar.Name = "txtIsbnBuscar";
            this.txtIsbnBuscar.Size = new System.Drawing.Size(424, 37);
            this.txtIsbnBuscar.TabIndex = 36;
            // 
            // panEditar
            // 
            this.panEditar.BackColor = System.Drawing.Color.Transparent;
            this.panEditar.Controls.Add(this.btnLimpiar);
            this.panEditar.Controls.Add(this.btnEditar);
            this.panEditar.Controls.Add(this.txtAutorEdit);
            this.panEditar.Controls.Add(this.label6);
            this.panEditar.Controls.Add(this.txtGeneroEdit);
            this.panEditar.Controls.Add(this.btnAutor);
            this.panEditar.Controls.Add(this.txtIsbn);
            this.panEditar.Controls.Add(this.label3);
            this.panEditar.Controls.Add(this.txtTituloEdit);
            this.panEditar.Controls.Add(this.label5);
            this.panEditar.Location = new System.Drawing.Point(57, 205);
            this.panEditar.Name = "panEditar";
            this.panEditar.Size = new System.Drawing.Size(848, 253);
            this.panEditar.TabIndex = 39;
            this.panEditar.Paint += new System.Windows.Forms.PaintEventHandler(this.panEditar_Paint);
            // 
            // txtAutorEdit
            // 
            this.txtAutorEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAutorEdit.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutorEdit.Location = new System.Drawing.Point(115, 140);
            this.txtAutorEdit.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutorEdit.Name = "txtAutorEdit";
            this.txtAutorEdit.Size = new System.Drawing.Size(475, 37);
            this.txtAutorEdit.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 42);
            this.label6.TabIndex = 52;
            this.label6.Text = "Autor:";
            // 
            // txtGeneroEdit
            // 
            this.txtGeneroEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtGeneroEdit.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneroEdit.Location = new System.Drawing.Point(529, 13);
            this.txtGeneroEdit.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeneroEdit.Name = "txtGeneroEdit";
            this.txtGeneroEdit.Size = new System.Drawing.Size(291, 37);
            this.txtGeneroEdit.TabIndex = 51;
            // 
            // btnAutor
            // 
            this.btnAutor.AutoSize = true;
            this.btnAutor.BackColor = System.Drawing.Color.Transparent;
            this.btnAutor.Font = new System.Drawing.Font("Poppins Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutor.ForeColor = System.Drawing.Color.White;
            this.btnAutor.Location = new System.Drawing.Point(414, 11);
            this.btnAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Size = new System.Drawing.Size(110, 42);
            this.btnAutor.TabIndex = 50;
            this.btnAutor.Text = "Género:";
            // 
            // txtIsbn
            // 
            this.txtIsbn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIsbn.Enabled = false;
            this.txtIsbn.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.Location = new System.Drawing.Point(115, 16);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(4);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(291, 37);
            this.txtIsbn.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 42);
            this.label3.TabIndex = 48;
            this.label3.Text = "ISBN:";
            // 
            // txtTituloEdit
            // 
            this.txtTituloEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTituloEdit.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloEdit.Location = new System.Drawing.Point(115, 80);
            this.txtTituloEdit.Margin = new System.Windows.Forms.Padding(4);
            this.txtTituloEdit.Name = "txtTituloEdit";
            this.txtTituloEdit.Size = new System.Drawing.Size(475, 37);
            this.txtTituloEdit.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 42);
            this.label5.TabIndex = 46;
            this.label5.Text = "Título:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.Location = new System.Drawing.Point(445, 201);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(310, 36);
            this.btnLimpiar.TabIndex = 55;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(92, 201);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(310, 36);
            this.btnEditar.TabIndex = 54;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // EditarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(981, 708);
            this.Controls.Add(this.panEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIsbnBuscar);
            this.Controls.Add(this.dataGridViewLibros);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarLibro";
            this.Load += new System.EventHandler(this.EditarLibro_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EditarLibro_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibros)).EndInit();
            this.panEditar.ResumeLayout(false);
            this.panEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewLibros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsbnBuscar;
        private System.Windows.Forms.Panel panEditar;
        private System.Windows.Forms.TextBox txtAutorEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGeneroEdit;
        private System.Windows.Forms.Label btnAutor;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTituloEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEditar;
    }
}