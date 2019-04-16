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
    public partial class FormCadastrarAluno : Form
    {
        ClassAluno aluno = new ClassAluno();
        public FormCadastrarAluno()
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

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            aluno.Nome = txtNome.Text;
            aluno.DataNascimento = DateTime.Parse(dtpDataNascimento.Text);
            aluno.NomeResponsavel = txtNomeResponsavel.Text;
            aluno.TelefoneContato = mskTelefone.Text;
            aluno.Endereco = txtEndereco.Text;
            aluno.Sexo = cboSexo.Text;
            aluno.GrauEscolaridade = txtGrauEscolaridade.Text;
            aluno.CadastrarAluno();
        }
    }
}
