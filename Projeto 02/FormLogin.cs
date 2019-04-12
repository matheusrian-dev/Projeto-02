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
    public partial class FormLogin : Form
    {
        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;
        ClassFuncionario funcionario = new ClassFuncionario();

        public FormLogin()
        {
            InitializeComponent();
            // Esconde a tela de Esqueceu sua Senha e o botão de retornar ao inicializar o programa 
            btnVoltar.Visible = false;
            userControlEsqueceuSenha1.Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
        }

        private void panelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - MouPosX, MousePosition.Y - MouPosY);
            }
        }

        private void panelSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Esconde todos os componentes que não são úteis para a tela de Esqueceu sua Senha
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            txtEmail.Visible = false;
            txtSenha.Visible = false;
            linkLabel1.Visible = false;
            btnEntrar.Visible = false;
            btnShowHidePassword.Visible = false;
            // Exibe a tela de Esqueceu sua Senha e o botão para escondê-la
            btnVoltar.Visible = true;
            userControlEsqueceuSenha1.Visible = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Exibe os componentes da tela de login
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            txtEmail.Visible = true;
            txtSenha.Visible = true;
            linkLabel1.Visible = true;
            btnEntrar.Visible = true;
            btnShowHidePassword.Visible = true;
            // Esconde os componentes da tela Esqueceu sua Senha
            btnVoltar.Visible = false;
            userControlEsqueceuSenha1.Visible = false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            funcionario.Email = txtEmail.Text;
            funcionario.Senha = txtSenha.Text;
            //funcionario.RealizarLogin();
            //if(funcionario.RealizarLogin == true)
            //{
            //    if(funcionario.Cargo == "Bibliotecário(a)" || funcionario.Cargo == "Auxiliar de Serviços Gerais" || funcionario.Cargo == "Pedagogo(a)")
            //    {
            //        MessageBox.Show("Bem vindo ao Sistema!" + "\n" +"Funcionário: " + funcionario.Nome + "\n"
            //                 + "Infelizmente não há funcionalidades acessíveis"+ "\n" +" para o seu cargo." );
            //    }
            //    else
            //    {
            //        MessageBox.Show("Funcionário: " + funcionario.Nome + "\n"
            //                 + "\n" + "Bem vindo ao Sistema!");
            //        if (funcionario.Cargo == "Professor(a)")
            //        {
            //            FormMenuProfessor professor = new FormMenuProfessor();
            //            this.Hide();
            //            professor.Show();
            //        }
            //        else if (funcionario.Cargo == "Diretor(a)")
            //        {
            //            FormMenuDiretor menudiretor = new FormMenuDiretor();
            //            this.Hide();
            //            menudiretor.Show();
            //        }
            //        else if (funcionario.Cargo == "Coordenador(a)")
            //        {
            //            FormMenuCoordenador coordenador = new FormMenuCoordenador();
            //            this.Hide();
            //            coordenador.Show();
            //        }
            //        else if (funcionario.Cargo == "Secretário(a)")
            //        {
            //            FormMenuSecretaria secretaria = new FormMenuSecretaria();
            //            this.Hide();
            //            secretaria.Show();
            //        }
            //    }
                
            //}
            //else
            //{
            //    MessageBox.Show("Funcionário não encontrado, tente novamente.");
            //}
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            // Código que permite visualizar e mascarar o campo da senha
            if(txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
