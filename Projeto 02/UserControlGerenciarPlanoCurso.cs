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
    public partial class UserControlGerenciarPlanoCurso : UserControl
    {
        public UserControlGerenciarPlanoCurso()
        {
            InitializeComponent();
        }

        private void btnRegistrarPlanoCurso_Click(object sender, EventArgs e)
        {
            FormCriarPlanoCurso planoC = new FormCriarPlanoCurso();
            planoC.Show();
        }

        private void btnGerenciarPlanoCurso_Click(object sender, EventArgs e)
        {
            FormEditarPlanoCurso editarPlanoC = new FormEditarPlanoCurso();
            editarPlanoC.Show();
        }
    }
}
