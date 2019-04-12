namespace Projeto_02
{
    partial class FormMenuSecretaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuSecretaria));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnMenuDrop = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelDropDownMenu = new System.Windows.Forms.Panel();
            this.labelEmitirDiploma = new System.Windows.Forms.Label();
            this.labelEmitirHistoricoEscolar = new System.Windows.Forms.Label();
            this.labelEmitirFrequenciaAluno = new System.Windows.Forms.Label();
            this.labelEmitirBoletim = new System.Windows.Forms.Label();
            this.labelEmitirCertificadoConclusao = new System.Windows.Forms.Label();
            this.labelEmitirCertificadoMatricula = new System.Windows.Forms.Label();
            this.labelGerenciarTurmas = new System.Windows.Forms.Label();
            this.labelGerenciarAluno = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.userControlGerenciarAluno1 = new Projeto_02.UserControlGerenciarAluno();
            this.userControlGerenciarTurma1 = new Projeto_02.UserControlGerenciarTurma();
            this.userControlEmissaoCertificadoMatricula1 = new Projeto_02.UserControlEmissaoCertificadoMatricula();
            this.userControlEmissaoCertificadoConclusao1 = new Projeto_02.UserControlEmissaoCertificadoConclusao();
            this.userControlEmissaoBoletim1 = new Projeto_02.UserControlEmissaoBoletim();
            this.userControlRelatorioFrequenciaAluno1 = new Projeto_02.UserControlRelatorioFrequenciaAluno();
            this.userControlHistoricoEscolar1 = new Projeto_02.UserControlHistoricoEscolar();
            this.userControlEmissaoDiploma1 = new Projeto_02.UserControlEmissaoDiploma();
            this.panelSuperior.SuspendLayout();
            this.panelDropDownMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(142)))));
            this.panelSuperior.Controls.Add(this.btnMenuDrop);
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Controls.Add(this.btnFechar);
            this.panelSuperior.Controls.Add(this.button2);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(710, 47);
            this.panelSuperior.TabIndex = 3;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            this.panelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseMove);
            this.panelSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseUp);
            // 
            // btnMenuDrop
            // 
            this.btnMenuDrop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuDrop.BackgroundImage")));
            this.btnMenuDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenuDrop.FlatAppearance.BorderSize = 0;
            this.btnMenuDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDrop.Location = new System.Drawing.Point(3, 6);
            this.btnMenuDrop.Name = "btnMenuDrop";
            this.btnMenuDrop.Size = new System.Drawing.Size(52, 35);
            this.btnMenuDrop.TabIndex = 4;
            this.btnMenuDrop.UseVisualStyleBackColor = true;
            this.btnMenuDrop.Click += new System.EventHandler(this.btnMenuDrop_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(620, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(36, 32);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(662, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(36, 32);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(620, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 32);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panelDropDownMenu
            // 
            this.panelDropDownMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(142)))));
            this.panelDropDownMenu.Controls.Add(this.labelEmitirDiploma);
            this.panelDropDownMenu.Controls.Add(this.labelEmitirHistoricoEscolar);
            this.panelDropDownMenu.Controls.Add(this.labelEmitirFrequenciaAluno);
            this.panelDropDownMenu.Controls.Add(this.labelEmitirBoletim);
            this.panelDropDownMenu.Controls.Add(this.labelEmitirCertificadoConclusao);
            this.panelDropDownMenu.Controls.Add(this.labelEmitirCertificadoMatricula);
            this.panelDropDownMenu.Controls.Add(this.labelGerenciarTurmas);
            this.panelDropDownMenu.Controls.Add(this.labelGerenciarAluno);
            this.panelDropDownMenu.Location = new System.Drawing.Point(0, 47);
            this.panelDropDownMenu.Name = "panelDropDownMenu";
            this.panelDropDownMenu.Size = new System.Drawing.Size(242, 0);
            this.panelDropDownMenu.TabIndex = 4;
            // 
            // labelEmitirDiploma
            // 
            this.labelEmitirDiploma.AutoSize = true;
            this.labelEmitirDiploma.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmitirDiploma.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelEmitirDiploma.Location = new System.Drawing.Point(27, 270);
            this.labelEmitirDiploma.Name = "labelEmitirDiploma";
            this.labelEmitirDiploma.Size = new System.Drawing.Size(150, 22);
            this.labelEmitirDiploma.TabIndex = 10;
            this.labelEmitirDiploma.Text = "Emissão do Diploma";
            this.labelEmitirDiploma.Click += new System.EventHandler(this.labelEmitirDiploma_Click);
            // 
            // labelEmitirHistoricoEscolar
            // 
            this.labelEmitirHistoricoEscolar.AutoSize = true;
            this.labelEmitirHistoricoEscolar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmitirHistoricoEscolar.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelEmitirHistoricoEscolar.Location = new System.Drawing.Point(27, 243);
            this.labelEmitirHistoricoEscolar.Name = "labelEmitirHistoricoEscolar";
            this.labelEmitirHistoricoEscolar.Size = new System.Drawing.Size(205, 22);
            this.labelEmitirHistoricoEscolar.TabIndex = 9;
            this.labelEmitirHistoricoEscolar.Text = "Emissão do Histórico Escolar";
            this.labelEmitirHistoricoEscolar.Click += new System.EventHandler(this.labelEmitirHistoricoEscolar_Click);
            // 
            // labelEmitirFrequenciaAluno
            // 
            this.labelEmitirFrequenciaAluno.AutoSize = true;
            this.labelEmitirFrequenciaAluno.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmitirFrequenciaAluno.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelEmitirFrequenciaAluno.Location = new System.Drawing.Point(27, 194);
            this.labelEmitirFrequenciaAluno.Name = "labelEmitirFrequenciaAluno";
            this.labelEmitirFrequenciaAluno.Size = new System.Drawing.Size(171, 44);
            this.labelEmitirFrequenciaAluno.TabIndex = 8;
            this.labelEmitirFrequenciaAluno.Text = "Emissão do Relatório de\r\nFrequência do Aluno";
            this.labelEmitirFrequenciaAluno.Click += new System.EventHandler(this.labelEmitirFrequenciaAluno_Click);
            // 
            // labelEmitirBoletim
            // 
            this.labelEmitirBoletim.AutoSize = true;
            this.labelEmitirBoletim.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmitirBoletim.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelEmitirBoletim.Location = new System.Drawing.Point(27, 167);
            this.labelEmitirBoletim.Name = "labelEmitirBoletim";
            this.labelEmitirBoletim.Size = new System.Drawing.Size(142, 22);
            this.labelEmitirBoletim.TabIndex = 7;
            this.labelEmitirBoletim.Text = "Emissão de Boletim";
            this.labelEmitirBoletim.Click += new System.EventHandler(this.labelEmitirBoletim_Click);
            // 
            // labelEmitirCertificadoConclusao
            // 
            this.labelEmitirCertificadoConclusao.AutoSize = true;
            this.labelEmitirCertificadoConclusao.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmitirCertificadoConclusao.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelEmitirCertificadoConclusao.Location = new System.Drawing.Point(27, 118);
            this.labelEmitirCertificadoConclusao.Name = "labelEmitirCertificadoConclusao";
            this.labelEmitirCertificadoConclusao.Size = new System.Drawing.Size(164, 44);
            this.labelEmitirCertificadoConclusao.TabIndex = 6;
            this.labelEmitirCertificadoConclusao.Text = "Emissão de Certificado\r\nde Conclusão";
            this.labelEmitirCertificadoConclusao.Click += new System.EventHandler(this.labelEmitirCertificadoConclusao_Click);
            // 
            // labelEmitirCertificadoMatricula
            // 
            this.labelEmitirCertificadoMatricula.AutoSize = true;
            this.labelEmitirCertificadoMatricula.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmitirCertificadoMatricula.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelEmitirCertificadoMatricula.Location = new System.Drawing.Point(27, 69);
            this.labelEmitirCertificadoMatricula.Name = "labelEmitirCertificadoMatricula";
            this.labelEmitirCertificadoMatricula.Size = new System.Drawing.Size(168, 44);
            this.labelEmitirCertificadoMatricula.TabIndex = 5;
            this.labelEmitirCertificadoMatricula.Text = "Emissão de Certificado \r\nde Matrícula";
            this.labelEmitirCertificadoMatricula.Click += new System.EventHandler(this.labelEmitirCertificadoMatricula_Click);
            // 
            // labelGerenciarTurmas
            // 
            this.labelGerenciarTurmas.AutoSize = true;
            this.labelGerenciarTurmas.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerenciarTurmas.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelGerenciarTurmas.Location = new System.Drawing.Point(27, 42);
            this.labelGerenciarTurmas.Name = "labelGerenciarTurmas";
            this.labelGerenciarTurmas.Size = new System.Drawing.Size(131, 22);
            this.labelGerenciarTurmas.TabIndex = 4;
            this.labelGerenciarTurmas.Text = "Gerenciar Turmas";
            this.labelGerenciarTurmas.Click += new System.EventHandler(this.labelGerenciarTurmas_Click);
            // 
            // labelGerenciarAluno
            // 
            this.labelGerenciarAluno.AutoSize = true;
            this.labelGerenciarAluno.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerenciarAluno.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelGerenciarAluno.Location = new System.Drawing.Point(27, 15);
            this.labelGerenciarAluno.Name = "labelGerenciarAluno";
            this.labelGerenciarAluno.Size = new System.Drawing.Size(138, 22);
            this.labelGerenciarAluno.TabIndex = 3;
            this.labelGerenciarAluno.Text = "Gerenciar Aluno(a)";
            this.labelGerenciarAluno.Click += new System.EventHandler(this.labelGerenciarAluno_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(271, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 131);
            this.label8.TabIndex = 7;
            this.label8.Text = "EF";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(12, 348);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(61, 55);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // userControlGerenciarAluno1
            // 
            this.userControlGerenciarAluno1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlGerenciarAluno1.Location = new System.Drawing.Point(0, 47);
            this.userControlGerenciarAluno1.Name = "userControlGerenciarAluno1";
            this.userControlGerenciarAluno1.Size = new System.Drawing.Size(710, 367);
            this.userControlGerenciarAluno1.TabIndex = 9;
            // 
            // userControlGerenciarTurma1
            // 
            this.userControlGerenciarTurma1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlGerenciarTurma1.Location = new System.Drawing.Point(0, 47);
            this.userControlGerenciarTurma1.Name = "userControlGerenciarTurma1";
            this.userControlGerenciarTurma1.Size = new System.Drawing.Size(710, 367);
            this.userControlGerenciarTurma1.TabIndex = 10;
            // 
            // userControlEmissaoCertificadoMatricula1
            // 
            this.userControlEmissaoCertificadoMatricula1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlEmissaoCertificadoMatricula1.Location = new System.Drawing.Point(0, 47);
            this.userControlEmissaoCertificadoMatricula1.Name = "userControlEmissaoCertificadoMatricula1";
            this.userControlEmissaoCertificadoMatricula1.Size = new System.Drawing.Size(710, 367);
            this.userControlEmissaoCertificadoMatricula1.TabIndex = 11;
            // 
            // userControlEmissaoCertificadoConclusao1
            // 
            this.userControlEmissaoCertificadoConclusao1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlEmissaoCertificadoConclusao1.Location = new System.Drawing.Point(0, 47);
            this.userControlEmissaoCertificadoConclusao1.Name = "userControlEmissaoCertificadoConclusao1";
            this.userControlEmissaoCertificadoConclusao1.Size = new System.Drawing.Size(710, 367);
            this.userControlEmissaoCertificadoConclusao1.TabIndex = 12;
            // 
            // userControlEmissaoBoletim1
            // 
            this.userControlEmissaoBoletim1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlEmissaoBoletim1.Location = new System.Drawing.Point(0, 47);
            this.userControlEmissaoBoletim1.Name = "userControlEmissaoBoletim1";
            this.userControlEmissaoBoletim1.Size = new System.Drawing.Size(710, 367);
            this.userControlEmissaoBoletim1.TabIndex = 13;
            // 
            // userControlRelatorioFrequenciaAluno1
            // 
            this.userControlRelatorioFrequenciaAluno1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlRelatorioFrequenciaAluno1.Location = new System.Drawing.Point(0, 47);
            this.userControlRelatorioFrequenciaAluno1.Name = "userControlRelatorioFrequenciaAluno1";
            this.userControlRelatorioFrequenciaAluno1.Size = new System.Drawing.Size(710, 367);
            this.userControlRelatorioFrequenciaAluno1.TabIndex = 14;
            // 
            // userControlHistoricoEscolar1
            // 
            this.userControlHistoricoEscolar1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlHistoricoEscolar1.Location = new System.Drawing.Point(0, 47);
            this.userControlHistoricoEscolar1.Name = "userControlHistoricoEscolar1";
            this.userControlHistoricoEscolar1.Size = new System.Drawing.Size(710, 367);
            this.userControlHistoricoEscolar1.TabIndex = 15;
            // 
            // userControlEmissaoDiploma1
            // 
            this.userControlEmissaoDiploma1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlEmissaoDiploma1.Location = new System.Drawing.Point(0, 47);
            this.userControlEmissaoDiploma1.Name = "userControlEmissaoDiploma1";
            this.userControlEmissaoDiploma1.Size = new System.Drawing.Size(710, 367);
            this.userControlEmissaoDiploma1.TabIndex = 16;
            // 
            // FormMenuSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(710, 415);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelDropDownMenu);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.userControlGerenciarAluno1);
            this.Controls.Add(this.userControlGerenciarTurma1);
            this.Controls.Add(this.userControlEmissaoCertificadoMatricula1);
            this.Controls.Add(this.userControlEmissaoCertificadoConclusao1);
            this.Controls.Add(this.userControlEmissaoBoletim1);
            this.Controls.Add(this.userControlRelatorioFrequenciaAluno1);
            this.Controls.Add(this.userControlHistoricoEscolar1);
            this.Controls.Add(this.userControlEmissaoDiploma1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenuSecretaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuSecretaria";
            this.panelSuperior.ResumeLayout(false);
            this.panelDropDownMenu.ResumeLayout(false);
            this.panelDropDownMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Button btnMenuDrop;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelDropDownMenu;
        private System.Windows.Forms.Label labelEmitirBoletim;
        private System.Windows.Forms.Label labelEmitirCertificadoConclusao;
        private System.Windows.Forms.Label labelEmitirCertificadoMatricula;
        private System.Windows.Forms.Label labelGerenciarTurmas;
        private System.Windows.Forms.Label labelGerenciarAluno;
        private System.Windows.Forms.Label labelEmitirDiploma;
        private System.Windows.Forms.Label labelEmitirHistoricoEscolar;
        private System.Windows.Forms.Label labelEmitirFrequenciaAluno;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVoltar;
        private UserControlGerenciarAluno userControlGerenciarAluno1;
        private UserControlGerenciarTurma userControlGerenciarTurma1;
        private UserControlEmissaoCertificadoMatricula userControlEmissaoCertificadoMatricula1;
        private UserControlEmissaoCertificadoConclusao userControlEmissaoCertificadoConclusao1;
        private UserControlEmissaoBoletim userControlEmissaoBoletim1;
        private UserControlRelatorioFrequenciaAluno userControlRelatorioFrequenciaAluno1;
        private UserControlHistoricoEscolar userControlHistoricoEscolar1;
        private UserControlEmissaoDiploma userControlEmissaoDiploma1;
    }
}