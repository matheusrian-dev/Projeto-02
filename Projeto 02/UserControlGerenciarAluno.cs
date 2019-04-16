using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_02
{
    public partial class UserControlGerenciarAluno : UserControl
    {
        public UserControlGerenciarAluno()
        {
            InitializeComponent();
        }

        private void btnRegistrarAluno_Click(object sender, EventArgs e)
        {
            FormCadastrarAluno cadastrarA = new FormCadastrarAluno();
            cadastrarA.Show();
        }

        private void btnGerenciarAluno_Click(object sender, EventArgs e)
        {
            FormEditarAluno editarA = new FormEditarAluno();
            editarA.Show();
        }
    }
}
