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
    public partial class FormEditarAluno : Form
    {
        ClassAluno aluno = new ClassAluno();
        public FormEditarAluno()
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

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            aluno.Nome = txtNome.Text;
            aluno.DataNascimento = DateTime.Parse(dtpDataNascimento.Text);
            aluno.NomeResponsavel = txtNomeResponsavel.Text;
            aluno.TelefoneContato = mskTelefone.Text;
            aluno.Endereco = txtEndereco.Text;
            aluno.Sexo = cboSexo.Text;
            aluno.GrauEscolaridade = txtGrauEscolaridade.Text;
            aluno.EditarAluno(int.Parse(txtCodAluno.Text));
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que quer excluir esse cadastro?", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                aluno.ExcluirAluno(int.Parse(txtCodAluno.Text));
            }
            else
            {

            }
        }

        private void btnBuscarAlunos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = aluno.MostrarAlunos();
        }
    }
}
