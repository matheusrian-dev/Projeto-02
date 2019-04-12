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
    public partial class UserControlGerenciarProfessor : UserControl
    {
        public UserControlGerenciarProfessor()
        {
            InitializeComponent();
        }

        private void btnGerenciarProfessor_Click(object sender, EventArgs e)
        {
            FormEditarProfessor editProf = new FormEditarProfessor();
            editProf.Show();
        }

        private void btnRegistrarProfessor_Click(object sender, EventArgs e)
        {
            FormCadastrarProfessor insertProf = new FormCadastrarProfessor();
            insertProf.Show();
        }
    }
}
