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
    public partial class UserControlGerenciarTurma : UserControl
    {
        public UserControlGerenciarTurma()
        {
            InitializeComponent();
        }

        private void btnRegistrarTurma_Click(object sender, EventArgs e)
        {
            FormCriarTurma criarT = new FormCriarTurma();
            criarT.Show();
        }

        private void btnGerenciarTurma_Click(object sender, EventArgs e)
        {
            FormEditarTurma editarT = new FormEditarTurma();
            editarT.Show();
        }
    }
}
