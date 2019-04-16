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
    public partial class FormCadastrarFuncionario : Form
    {
        ClassFuncionario funcionario = new ClassFuncionario();
        public FormCadastrarFuncionario()
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

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            funcionario.Cpf = mskCpf.Text;
            funcionario.Nome = txtNome.Text;
            funcionario.Telefone = mskTelefone.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Senha = txtSenha.Text;
            funcionario.Sexo = cboSexo.Text;
            funcionario.Cargo = cboCargo.Text;
            funcionario.CadastrarFuncionario();
        }
    }
}
