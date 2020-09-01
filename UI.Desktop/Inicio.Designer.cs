namespace UI.Desktop
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pInicio = new System.Windows.Forms.Panel();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.txtMenu = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.tlInicio = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Personas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pInicio.SuspendLayout();
            this.tlInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::UI.Desktop.Properties.Resources.LogoAcademia;
            this.pictureBox1.Location = new System.Drawing.Point(312, 224);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(729, 514);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pInicio
            // 
            this.pInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pInicio.Controls.Add(this.btn_Personas);
            this.pInicio.Controls.Add(this.btnPlanes);
            this.pInicio.Controls.Add(this.btnMaterias);
            this.pInicio.Controls.Add(this.btnEspecialidades);
            this.pInicio.Controls.Add(this.txtMenu);
            this.pInicio.Controls.Add(this.btnUsuarios);
            this.pInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInicio.Location = new System.Drawing.Point(4, 224);
            this.pInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pInicio.Name = "pInicio";
            this.pInicio.Size = new System.Drawing.Size(300, 514);
            this.pInicio.TabIndex = 1;
            // 
            // btnPlanes
            // 
            this.btnPlanes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlanes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanes.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnPlanes.FlatAppearance.BorderSize = 3;
            this.btnPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanes.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanes.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnPlanes.Location = new System.Drawing.Point(61, 297);
            this.btnPlanes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(171, 57);
            this.btnPlanes.TabIndex = 7;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.UseVisualStyleBackColor = false;
            this.btnPlanes.Click += new System.EventHandler(this.btn_Planes_Click);
            // 
            // btnMaterias
            // 
            this.btnMaterias.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMaterias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaterias.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnMaterias.FlatAppearance.BorderSize = 3;
            this.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterias.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterias.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnMaterias.Location = new System.Drawing.Point(61, 214);
            this.btnMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(171, 57);
            this.btnMaterias.TabIndex = 6;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.UseVisualStyleBackColor = false;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEspecialidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEspecialidades.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnEspecialidades.FlatAppearance.BorderSize = 3;
            this.btnEspecialidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspecialidades.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecialidades.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnEspecialidades.Location = new System.Drawing.Point(61, 135);
            this.btnEspecialidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Size = new System.Drawing.Size(171, 57);
            this.btnEspecialidades.TabIndex = 5;
            this.btnEspecialidades.Text = "Especialidades";
            this.btnEspecialidades.UseVisualStyleBackColor = false;
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // txtMenu
            // 
            this.txtMenu.AutoSize = true;
            this.txtMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenu.Location = new System.Drawing.Point(129, 15);
            this.txtMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(46, 17);
            this.txtMenu.TabIndex = 2;
            this.txtMenu.Text = "ABMS";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnUsuarios.FlatAppearance.BorderSize = 3;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnUsuarios.Location = new System.Drawing.Point(61, 55);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(171, 57);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(312, 0);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(729, 220);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "ACADEMIA";
            this.txtTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlInicio
            // 
            this.tlInicio.ColumnCount = 2;
            this.tlInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.5F));
            this.tlInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.5F));
            this.tlInicio.Controls.Add(this.txtTitulo, 1, 0);
            this.tlInicio.Controls.Add(this.pInicio, 0, 1);
            this.tlInicio.Controls.Add(this.pictureBox1, 1, 1);
            this.tlInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlInicio.Location = new System.Drawing.Point(0, 0);
            this.tlInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlInicio.Name = "tlInicio";
            this.tlInicio.RowCount = 2;
            this.tlInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.77778F));
            this.tlInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.22222F));
            this.tlInicio.Size = new System.Drawing.Size(1045, 742);
            this.tlInicio.TabIndex = 0;
            // 
            // btn_Personas
            // 
            this.btn_Personas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Personas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Personas.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btn_Personas.FlatAppearance.BorderSize = 3;
            this.btn_Personas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Personas.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Personas.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Personas.Location = new System.Drawing.Point(61, 373);
            this.btn_Personas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Personas.Name = "btn_Personas";
            this.btn_Personas.Size = new System.Drawing.Size(171, 57);
            this.btn_Personas.TabIndex = 8;
            this.btn_Personas.Text = "Personas";
            this.btn_Personas.UseVisualStyleBackColor = false;
            this.btn_Personas.Click += new System.EventHandler(this.btn_Personas_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1045, 742);
            this.Controls.Add(this.tlInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.Opacity = 0.3D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Shown += new System.EventHandler(this.Inicio_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pInicio.ResumeLayout(false);
            this.pInicio.PerformLayout();
            this.tlInicio.ResumeLayout(false);
            this.tlInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pInicio;
        private System.Windows.Forms.Label txtMenu;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.TableLayoutPanel tlInicio;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btn_Personas;
    }
}