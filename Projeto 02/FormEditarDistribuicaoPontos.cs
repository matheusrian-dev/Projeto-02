using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_02
{
    public partial class FormEditarDistribuicaoPontos : Form
    {
        ClassDistribuicaoPontos distribuicao = new ClassDistribuicaoPontos();
        public FormEditarDistribuicaoPontos()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            distribuicao.CodDistribuicaoPontos = int.Parse(txtCodDistribuicaoPontos.Text);
            distribuicao.MostrarDistribuicao();
        }

        private void btnCadastrarConteudoCurso_Click(object sender, EventArgs e)
        {
            distribuicao.NomeInstrutor = txtNomeResponsavel.Text;
            distribuicao.ValorAtividade01 = decimal.Parse(txtValorAtividade1.Text);
            distribuicao.ValorAtividade02 = decimal.Parse(txtValorAtividade2.Text);
            distribuicao.ValorAtividade03 = decimal.Parse(txtValorAtividade3.Text);
            distribuicao.ValorAtividade04 = decimal.Parse(txtValorAtividade4.Text);
            distribuicao.ValorProvaInicial = decimal.Parse(txtValorProvaInicial.Text);
            distribuicao.ValorProvaFinal = decimal.Parse(txtValorProvaFinal.Text);
            distribuicao.Turma_CodTurma = int.Parse(txtCodTurma.Text);
            distribuicao.EditarDistribuicao();
        }
    }
}
