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
    public partial class FormMenuDiretor : Form
    {
        bool isPanelDropDownMenuOpen = false;
        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;

        public FormMenuDiretor()
        {
            InitializeComponent();
            userControlGerenciarCurso1.Visible = false;
            userControlGerenciarPedagogo1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isPanelDropDownMenuOpen)
            {
                panelDropDownMenu.Height -= 28;
                if (panelDropDownMenu.Height == 0)
                {
                    timer1.Stop();
                    isPanelDropDownMenuOpen = false;
                }
            }
            else if (!isPanelDropDownMenuOpen)
            {
                panelDropDownMenu.Height += 28;
                if(panelDropDownMenu.Height == 280)
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void labelGerenciarCurso_Click(object sender, EventArgs e)
        {
            userControlGerenciarCurso1.Visible = true;
            userControlGerenciarPedagogo1.Visible = false;
            label8.Visible = false;
        }

        private void labelGerenciarPedagogo_Click(object sender, EventArgs e)
        {
            userControlGerenciarCurso1.Visible = false;
            userControlGerenciarPedagogo1.Visible = true;
            label8.Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Close();
            login.Show();
        }
    }
}
