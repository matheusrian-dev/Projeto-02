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
    public partial class FormMenuSecretaria : Form
    {
        bool isPanelDropDownMenuOpen = false;
        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;

        public FormMenuSecretaria()
        {
            InitializeComponent();
            userControlEmissaoBoletim1.Visible = false;
            userControlEmissaoCertificadoMatricula1.Visible = false;
            userControlEmissaoCertificadoConclusao1.Visible = false;
            userControlEmissaoDiploma1.Visible = false;
            userControlGerenciarAluno1.Visible = false;
            userControlGerenciarTurma1.Visible = false;
            userControlHistoricoEscolar1.Visible = false;
            userControlRelatorioFrequenciaAluno1.Visible = false;
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Close();
            login.Show();
        }

        private void labelEmitirDiploma_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            userControlEmissaoBoletim1.Visible = false;
            userControlEmissaoCertificadoMatricula1.Visible = false;
            userControlEmissaoCertificadoConclusao1.Visible = false;
            userControlGerenciarAluno1.Visible = false;
            userControlGerenciarTurma1.Visible = false;
            userControlHistoricoEscolar1.Visible = false;
            userControlRelatorioFrequenciaAluno1.Visible = false;
            userControlEmissaoDiploma1.Visible = true;
        }

        private void labelEmitirFrequenciaAluno_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            userControlEmissaoBoletim1.Visible = false;
            userControlEmissaoCertificadoMatricula1.Visible = false;
            userControlEmissaoCertificadoConclusao1.Visible = false;
            userControlGerenciarAluno1.Visible = false;
            userControlGerenciarTurma1.Visible = false;
            userControlHistoricoEscolar1.Visible = false;
            userControlEmissaoDiploma1.Visible = false;
            userControlRelatorioFrequenciaAluno1.Visible = true;
        }

        private void labelEmitirHistoricoEscolar_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            userControlEmissaoBoletim1.Visible = false;
            userControlEmissaoCertificadoMatricula1.Visible = false;
            userControlEmissaoCertificadoConclusao1.Visible = false;
            userControlGerenciarAluno1.Visible = false;
            userControlGerenciarTurma1.Visible = false;
            userControlEmissaoDiploma1.Visible = false;
            userControlRelatorioFrequenciaAluno1.Visible = false;
            userControlHistoricoEscolar1.Visible = true;
        }

        private void labelEmitirBoletim_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            userControlEmissaoCertificadoMatricula1.Visible = false;
            userControlEmissaoCertificadoConclusao1.Visible = false;
            userControlGerenciarAluno1.Visible = false;
            userControlGerenciarTurma1.Visible = false;
            userControlEmissaoDiploma1.Visible = false;
            userControlRelatorioFrequenciaAluno1.Visible = false;
            userControlHistoricoEscolar1.Visible = false;
            userControlEmissaoBoletim1.Visible = true;
        }

        private void labelEmitirCertificadoConclusao_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            userControlEmissaoCertificadoMatricula1.Visible = false;
            userControlGerenciarAluno1.Visible = false;
            userControlGerenciarTurma1.Visible = false;
            userControlEmissaoDiploma1.Visible = false;
            userControlRelatorioFrequenciaAluno1.Visible = false;
            userControlHistoricoEscolar1.Visible = false;
            userControlEmissaoBoletim1.Visible = false;
            userControlEmissaoCertificadoConclusao1.Visible = true;
        }

        private void labelEmitirCertificadoMatricula_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            userControlGerenciarAluno1.Visible = false;
            userControlGerenciarTurma1.Visible = false;
            userControlEmissaoDiploma1.Visible = false;
            userControlRelatorioFrequenciaAluno1.Visible = false;
            userControlHistoricoEscolar1.Visible = false;
            userControlEmissaoBoletim1.Visible = false;
            userControlEmissaoCertificadoConclusao1.Visible = false;
            userControlEmissaoCertificadoMatricula1.Visible = true;
        }

        private void labelGerenciarAluno_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            userControlGerenciarTurma1.Visible = false;
            userControlEmissaoDiploma1.Visible = false;
            userControlRelatorioFrequenciaAluno1.Visible = false;
            userControlHistoricoEscolar1.Visible = false;
            userControlEmissaoBoletim1.Visible = false;
            userControlEmissaoCertificadoConclusao1.Visible = false;
            userControlEmissaoCertificadoMatricula1.Visible = false;
            userControlGerenciarAluno1.Visible = true;
        }

        private void labelGerenciarTurmas_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            userControlEmissaoDiploma1.Visible = false;
            userControlRelatorioFrequenciaAluno1.Visible = false;
            userControlHistoricoEscolar1.Visible = false;
            userControlEmissaoBoletim1.Visible = false;
            userControlEmissaoCertificadoConclusao1.Visible = false;
            userControlEmissaoCertificadoMatricula1.Visible = false;
            userControlGerenciarAluno1.Visible = false;
            userControlGerenciarTurma1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isPanelDropDownMenuOpen)
            {
                panelDropDownMenu.Height -= 30;
                if (panelDropDownMenu.Height == 0)
                {
                    timer1.Stop();
                    isPanelDropDownMenuOpen = false;
                }
            }

            else if (!isPanelDropDownMenuOpen)
            {
                panelDropDownMenu.Height += 30;
                if (panelDropDownMenu.Height == 300)
                {
                    timer1.Stop();
                    isPanelDropDownMenuOpen = true;
                }
            }
        }
    }
}
