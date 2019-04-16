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
    public partial class FormCriarTurma : Form
    {
        ClassTurma turma = new ClassTurma();
        public FormCriarTurma()
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

        private void btnRegistrarTurma_Click(object sender, EventArgs e)
        {
            turma.Curso_CodCurso = int.Parse(txtCodigoCurso.Text);
            turma.Nome = txtNome.Text;
            turma.NomeInstrutor = txtInstrutorResponsavel.Text;
            turma.InserirTurmas();
        }

        private void btnEnturmarAlunos_Click(object sender, EventArgs e)
        {
            FormEnturmarAluno enturmar = new FormEnturmarAluno();
            enturmar.Show();
        }
    }
}
