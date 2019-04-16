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
    public partial class FormEditarTurma : Form
    {
        ClassTurma turma = new ClassTurma();
        public FormEditarTurma()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEditarTurma_Click(object sender, EventArgs e)
        {
            turma.Curso_CodCurso = int.Parse(txtCodCurso.Text);
            turma.Nome = txtNome.Text;
            turma.NomeInstrutor = txtNomeInstrutor.Text;
            turma.CodTurma = int.Parse(txtCodTurma.Text);
            turma.EditarTurma();
        }

        private void btnExcluirTurma_Click(object sender, EventArgs e)
        {
            turma.Curso_CodCurso = int.Parse(txtCodCurso.Text);
            turma.Nome = txtNome.Text;
            turma.NomeInstrutor = txtNomeInstrutor.Text;
            turma.CodTurma = int.Parse(txtCodTurma.Text);
            DialogResult result = MessageBox.Show("Tem certeza que quer excluir esse cadastro?", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                turma.ExcluirTurma();
            }
            else
            {

            }
        }

        private void btnBuscarTurmas_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = turma.MostrarTurma();
        }
    }
}
