﻿namespace UI.Desktop
{
    partial class PersonasDesktop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.cb_TipoPersona = new System.Windows.Forms.ComboBox();
            this.cb_IdPlan = new System.Windows.Forms.ComboBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txt_IdPersona = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_legajo = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.dtp_fechaNac = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Persona:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Nacimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Plan:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tipo de Persona:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Legajo:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(363, 184);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(127, 33);
            this.btn_aceptar.TabIndex = 10;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // cb_TipoPersona
            // 
            this.cb_TipoPersona.FormattingEnabled = true;
            this.cb_TipoPersona.Location = new System.Drawing.Point(473, 125);
            this.cb_TipoPersona.Name = "cb_TipoPersona";
            this.cb_TipoPersona.Size = new System.Drawing.Size(121, 24);
            this.cb_TipoPersona.TabIndex = 9;
            // 
            // cb_IdPlan
            // 
            this.cb_IdPlan.FormattingEnabled = true;
            this.cb_IdPlan.Location = new System.Drawing.Point(473, 91);
            this.cb_IdPlan.Name = "cb_IdPlan";
            this.cb_IdPlan.Size = new System.Drawing.Size(121, 24);
            this.cb_IdPlan.TabIndex = 8;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(496, 184);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(127, 33);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txt_IdPersona
            // 
            this.txt_IdPersona.Location = new System.Drawing.Point(113, 21);
            this.txt_IdPersona.Name = "txt_IdPersona";
            this.txt_IdPersona.ReadOnly = true;
            this.txt_IdPersona.Size = new System.Drawing.Size(100, 22);
            this.txt_IdPersona.TabIndex = 13;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(113, 57);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(179, 22);
            this.txt_Nombre.TabIndex = 0;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(113, 95);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(179, 22);
            this.txt_Apellido.TabIndex = 1;
            // 
            // txt_legajo
            // 
            this.txt_legajo.Location = new System.Drawing.Point(113, 160);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Size = new System.Drawing.Size(100, 22);
            this.txt_legajo.TabIndex = 4;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(113, 195);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(179, 22);
            this.txt_email.TabIndex = 5;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(473, 58);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(173, 22);
            this.txt_telefono.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Dirección:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(113, 129);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(179, 22);
            this.txt_direccion.TabIndex = 3;
            // 
            // dtp_fechaNac
            // 
            this.dtp_fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaNac.Location = new System.Drawing.Point(473, 21);
            this.dtp_fechaNac.Name = "dtp_fechaNac";
            this.dtp_fechaNac.Size = new System.Drawing.Size(173, 22);
            this.dtp_fechaNac.TabIndex = 6;
            // 
            // PersonasDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 260);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtp_fechaNac);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_legajo);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_IdPersona);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.cb_IdPlan);
            this.Controls.Add(this.cb_TipoPersona);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonasDesktop";
            this.Text = "PersonasDesktop";
            this.Load += new System.EventHandler(this.PersonasDesktop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.ComboBox cb_TipoPersona;
        private System.Windows.Forms.ComboBox cb_IdPlan;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox txt_IdPersona;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_legajo;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.DateTimePicker dtp_fechaNac;
    }
}