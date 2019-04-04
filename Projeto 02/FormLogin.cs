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
        public FormLogin()
        {
            InitializeComponent();
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
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            txtEmail.Visible = false;
            txtSenha.Visible = false;
            linkLabel1.Visible = false;
            btnEntrar.Visible = false;
            btnVoltar.Visible = true;
            userControlEsqueceuSenha1.Visible = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            txtEmail.Visible = true;
            txtSenha.Visible = true;
            linkLabel1.Visible = true;
            btnEntrar.Visible = true;
            btnVoltar.Visible = false;
            userControlEsqueceuSenha1.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
