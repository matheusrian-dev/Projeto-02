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
    public partial class UserControlLancarDistribuicaoPontos : UserControl
    {
        ClassDistribuicaoPontos distribuicao = new ClassDistribuicaoPontos();
        public UserControlLancarDistribuicaoPontos()
        {
            InitializeComponent();
        }

        private void UserControlLancarDistribuicaoPontos_Load(object sender, EventArgs e)
        {
            FormEditarDistribuicaoPontos editarDP = new FormEditarDistribuicaoPontos();
            editarDP.Show();
        }

        private void btnRegistrarDistribuicaoPontos_Click(object sender, EventArgs e)
        {
            distribuicao.NomeInstrutor = txtNomeResponsavel.Text;
            distribuicao.ValorAtividade01 = decimal.Parse(txtValorAtividade1.Text);
            distribuicao.ValorAtividade02 = decimal.Parse(txtValorAtividade2.Text);
            distribuicao.ValorAtividade03 = decimal.Parse(txtValorAtividade3.Text);
            distribuicao.ValorAtividade04 = decimal.Parse(txtValorAtividade4.Text);
            distribuicao.ValorProvaInicial = decimal.Parse(txtValorProvaInicial.Text);
            distribuicao.ValorProvaFinal = decimal.Parse(txtValorProvaFinal.Text);
            distribuicao.Turma_CodTurma = int.Parse(txtCodTurma.Text);
            distribuicao.CadastrarDistribuicao();
        }
    }
}
