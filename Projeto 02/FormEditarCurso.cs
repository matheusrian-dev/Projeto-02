using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_02
{
    public partial class FormEditarCurso : Form
    {
        ClassCurso curso = new ClassCurso();

        public FormEditarCurso()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            curso.Nome = txtNome.Text;
            curso.CargaHoraria = int.Parse(txtCargaHoraria.Text);
            curso.EditarCurso(int.Parse(txtCodCurso.Text));
        }

        private void btnExcluirCurso_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que quer excluir esse cadastro?", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                curso.ExcluirCurso(int.Parse(txtCodCurso.Text));
            }
            else
            {

            }
        }

        private void btnBuscarCursos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = curso.MostrarCursos();
        }
    }
}
