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
    public partial class UserControlGerenciarConteudoCurso : UserControl
    {
        public UserControlGerenciarConteudoCurso()
        {
            InitializeComponent();
        }

        private void btnRegistrarConteudoCurso_Click(object sender, EventArgs e)
        {
            FormInserirConteudoCurso inserirC = new FormInserirConteudoCurso();
            inserirC.Show();
        }

        private void btnGerenciarConteudoCurso_Click(object sender, EventArgs e)
        {
            FormEditarConteudoCurso editarC = new FormEditarConteudoCurso();
            editarC.Show();
        }
    }
}
