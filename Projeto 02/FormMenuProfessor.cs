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
    public partial class FormMenuProfessor : Form
    {
        bool isPanelDropDownMenuOpen = false;
        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;

        public FormMenuProfessor()
        {
            InitializeComponent();
            // Esconde as telas de cada função para exibir somente a imagem inicial
            userControlLancarDistribuicaoPontos1.Visible = false;
            userControlLancarFrequenciaAluno1.Visible = false;
            userControlLancarNota1.Visible = false;
            userControlLancarPlanoAula1.Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenuDrop_Click(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Close();
            login.Show();
        }

        private void labelLancarDistribuicaoPontos_Click(object sender, EventArgs e)
        {
            // Esconde as telas não selecionadas
            label8.Visible = false;
            userControlLancarFrequenciaAluno1.Visible = false;
            userControlLancarNota1.Visible = false;
            userControlLancarPlanoAula1.Visible = false;
            // Exibe a tela selecionada
            userControlLancarDistribuicaoPontos1.Visible = true;
        }

        private void labelLancarFrequenciaAluno_Click(object sender, EventArgs e)
        {
            // Esconde as telas não selecionadas
            label8.Visible = false;
            userControlLancarNota1.Visible = false;
            userControlLancarPlanoAula1.Visible = false;
            userControlLancarDistribuicaoPontos1.Visible = false;
            // Exibe a tela selecionada
            userControlLancarFrequenciaAluno1.Visible = true;
        }

        private void labelLancarNota_Click(object sender, EventArgs e)
        {
            // Esconde as telas não selecionadas
            label8.Visible = false;
            userControlLancarPlanoAula1.Visible = false;
            userControlLancarDistribuicaoPontos1.Visible = false;
            userControlLancarFrequenciaAluno1.Visible = false;
            // Exibe a tela selecionada
            userControlLancarNota1.Visible = true;
        }

        private void labelLancarPlanoAula_Click(object sender, EventArgs e)
        {
            // Esconde as telas não selecionadas
            label8.Visible = false;
            userControlLancarDistribuicaoPontos1.Visible = false;
            userControlLancarFrequenciaAluno1.Visible = false;
            userControlLancarNota1.Visible = false;
            // Exibe a tela selecionada
            userControlLancarPlanoAula1.Visible = true;
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
                if (panelDropDownMenu.Height == 160)
                {
                    timer1.Stop();
                    isPanelDropDownMenuOpen = true;
                }
            }
        }
    }
}
