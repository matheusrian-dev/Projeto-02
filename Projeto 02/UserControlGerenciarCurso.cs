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
    public partial class UserControlGerenciarCurso : UserControl
    {
        public UserControlGerenciarCurso()
        {
            InitializeComponent();
        }

        private void btnRegistrarCurso_Click(object sender, EventArgs e)
        {
            FormCadastrarCurso cadastrarC = new FormCadastrarCurso();
            cadastrarC.Show();
        }

        private void btnGerenciarCurso_Click(object sender, EventArgs e)
        {
            FormEditarCurso editarC = new FormEditarCurso();
            editarC.Show();
        }
    }
}
