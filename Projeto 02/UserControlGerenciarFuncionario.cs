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
    public partial class UserControlGerenciarFuncionario : UserControl
    {
        public UserControlGerenciarFuncionario()
        {
            InitializeComponent();
        }

        private void btnRegistrarSecretarioFuncionario_Click(object sender, EventArgs e)
        {
            FormCadastrarFuncionario insertfuncionario = new FormCadastrarFuncionario();
            insertfuncionario.Show();
        }

        private void btnGerenciarFuncionario_Click(object sender, EventArgs e)
        {
            FormEditarFuncionario editFuncionario = new FormEditarFuncionario();
            editFuncionario.Show();
        }
    }
}
