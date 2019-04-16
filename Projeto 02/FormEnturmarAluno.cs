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
    public partial class FormEnturmarAluno : Form
    {
        ClassAluno aluno = new ClassAluno();
        ClassTurma turma = new ClassTurma();
        public FormEnturmarAluno()
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

        private void btnBuscarAlunos_Click(object sender, EventArgs e)
        {
            aluno.MostrarAlunos();
        }

        private void btnBuscarTurmas_Click(object sender, EventArgs e)
        {
            turma.MostrarTurma();
        }

        private void btnEnturmarAluno_Click(object sender, EventArgs e)
        {
            aluno.EnturmarAluno(int.Parse(txtCodAluno.Text));
        }
    }
}
