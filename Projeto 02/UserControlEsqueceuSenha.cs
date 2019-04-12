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
    public partial class UserControlEsqueceuSenha : UserControl
    {
        public UserControlEsqueceuSenha()
        {
            InitializeComponent();
        }

        private void btnEnviarSenha_Click(object sender, EventArgs e)
        {
            ClassFuncionario funcionario = new ClassFuncionario();
            //funcionario.EsqueceuSenha(txtEmail.Text);
            //if (funcionario.EsqueceuSenha(txtEmail.Text) == true)
            //{
            //    MessageBox.Show("Email Enviado com Sucesso!");
            //}
            //else
            //{
            //    MessageBox.Show("Email não Encontrado.");
            //}
        }
    }
}
