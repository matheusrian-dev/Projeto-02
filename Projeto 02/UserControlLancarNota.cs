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
    public partial class UserControlLancarNota : UserControl
    {
        ClassNota nota = new ClassNota();
        public UserControlLancarNota()
        {
            InitializeComponent();
        }

        private void btnLancarNotaAluno_Click(object sender, EventArgs e)
        {
            nota.NotaAtividade01 = decimal.Parse(txtValorAtividade1.Text);
            nota.NotaAtividade02 = decimal.Parse(txtValorAtividade2.Text);
            nota.NotaAtividade03 = decimal.Parse(txtValorAtividade3.Text);
            nota.NotaAtividade04 = decimal.Parse(txtValorAtividade4.Text);
            nota.NotaProvaInicial = decimal.Parse(txtValorProvaInicial.Text);
            nota.NotaProvaFinal = decimal.Parse(txtValorProvaFinal.Text);
            nota.Aluno_CodAluno = int.Parse(txtCodAluno.Text);
            nota.DistribuicaoPontos_CodDistribuicaoPontos = int.Parse(txtCodDistribuicao.Text);
            nota.InserirNotas();
        }
    }
}
