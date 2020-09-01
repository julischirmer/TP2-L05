using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios formUsuarios = new Usuarios();
            formUsuarios.Show();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            Especialidades formEspecialidades = new Especialidades();
            formEspecialidades.Show();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            Materias formMaterias = new Materias();
            formMaterias.Show();
        }

        private void Inicio_Shown(object sender, EventArgs e)
        {
            Login ingresoForm = new Login();
            ingresoForm.ShowDialog();
            if(ingresoForm.DialogResult != DialogResult.OK)
            {
                this.Dispose();
            } else
            {
                this.Opacity = 100;
            }
        }

        private void btn_Planes_Click(object sender, EventArgs e)
        {
            Planes formPlanes = new Planes();
            formPlanes.Show();
        }

        private void btn_Personas_Click(object sender, EventArgs e)
        {
            Personas formPersonas = new Personas();
            formPersonas.Show();
        }
    }
}
