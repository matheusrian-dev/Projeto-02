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
    public partial class UserControlLancarPlanoAula : UserControl
    {
        public UserControlLancarPlanoAula()
        {
            InitializeComponent();
        }

        private void btnLancarPlanoAula_Click(object sender, EventArgs e)
        {
            FormCriarPlanoAula criarPlanoAula = new FormCriarPlanoAula();
            criarPlanoAula.Show();
        }

        private void btnAtualizarPlanoAula_Click(object sender, EventArgs e)
        {
            FormEditarPlanoAula editarPA = new FormEditarPlanoAula();
            editarPA.Show();
        }
    }
}
