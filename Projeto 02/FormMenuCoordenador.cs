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
    public partial class FormMenuCoordenador : Form
    {
        bool isPanelDropDownMenuOpen = false;
        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;

        public FormMenuCoordenador()
        {
            InitializeComponent();
            // Esconde as telas de cada função para exibir somente a imagem inicial
            userControlGerenciarConteudoCurso1.Visible = false;
            userControlGerenciarPlanoCurso1.Visible = false;
            userControlGerenciarProfessor1.Visible = false;
            userControlRelatorioFrequenciaProfessor1.Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Close();
            login.Show();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Código responsável pelo movimento do DropDownMenu
            if (isPanelDropDownMenuOpen)
            {
                panelDropDownMenu.Height -= 40;
                if (panelDropDownMenu.Height == 0)
                {
                    timer1.Stop();
                    isPanelDropDownMenuOpen = false;
                }
            }

            else if (!isPanelDropDownMenuOpen)
            {
                panelDropDownMenu.Height += 40;
                if (panelDropDownMenu.Height == 200)
                {
                    timer1.Stop();
                    isPanelDropDownMenuOpen = true;
                }
            }
        }

        private void btnMenuDrop_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void labelGerenciarProfessor_Click(object sender, EventArgs e)
        {
            // Esconde as telas não selecionadas
            userControlGerenciarConteudoCurso1.Visible = false;
            userControlGerenciarPlanoCurso1.Visible = false;
            userControlRelatorioFrequenciaProfessor1.Visible = false;
            label8.Visible = false;
            // Exibe a tela selecionada
            userControlGerenciarProfessor1.Visible = true;
        }

        private void labelGerenciarPlanoCurso_Click(object sender, EventArgs e)
        {
            // Esconde as telas não selecionadas
            userControlGerenciarConteudoCurso1.Visible = false;
            userControlGerenciarProfessor1.Visible = false;
            userControlRelatorioFrequenciaProfessor1.Visible = false;
            label8.Visible = false;
            // Exibe a tela selecionada
            userControlGerenciarPlanoCurso1.Visible = true;
        }

        private void labelGerenciarConteudoCurso_Click(object sender, EventArgs e)
        {
            // Esconde as telas não selecionadas
            userControlGerenciarPlanoCurso1.Visible = false;
            userControlGerenciarProfessor1.Visible = false;
            userControlRelatorioFrequenciaProfessor1.Visible = false;
            label8.Visible = false;
            // Exibe a tela selecionada
            userControlGerenciarConteudoCurso1.Visible = true;
        }

        private void labelEmitirRelatorioFrequenciaProfessor_Click(object sender, EventArgs e)
        {
            // Esconde as telas não selecionadas
            userControlGerenciarConteudoCurso1.Visible = false;
            userControlGerenciarPlanoCurso1.Visible = false;
            userControlGerenciarProfessor1.Visible = false;
            label8.Visible = false;
            // Exibe a tela selecionada
            userControlRelatorioFrequenciaProfessor1.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
