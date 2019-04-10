namespace Projeto_02
{
    partial class FormMenuDiretor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuDiretor));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnMenuDrop = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelDropDownMenu = new System.Windows.Forms.Panel();
            this.labelEmitirRelatorioFrequencia = new System.Windows.Forms.Label();
            this.labelGerenciarAuxiliar = new System.Windows.Forms.Label();
            this.labelGerenciarBibliotecario = new System.Windows.Forms.Label();
            this.labelGerenciarSecretario = new System.Windows.Forms.Label();
            this.labelGerenciarCoordenador = new System.Windows.Forms.Label();
            this.labelGerenciarPedagogo = new System.Windows.Forms.Label();
            this.labelGerenciarCurso = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.userControlGerenciarPedagogo1 = new Projeto_02.UserControlGerenciarPedagogo();
            this.userControlGerenciarCoordenador1 = new Projeto_02.UserControlGerenciarCoordenador();
            this.userControlGerenciarCurso1 = new Projeto_02.UserControlGerenciarCurso();
            this.userControlGerenciarBibliotecario1 = new Projeto_02.UserControlGerenciarBibliotecario();
            this.userControlGerenciarAuxiliarSG1 = new Projeto_02.UserControlGerenciarAuxiliarSG();
            this.userControlGerenciarSecretario1 = new Projeto_02.UserControlGerenciarSecretario();
            this.userControlRelatorioFrequenciaFuncionarios1 = new Projeto_02.UserControlRelatorioFrequenciaFuncionarios();
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
            this.panelSuperior.TabIndex = 1;
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
            this.panelDropDownMenu.Controls.Add(this.labelEmitirRelatorioFrequencia);
            this.panelDropDownMenu.Controls.Add(this.labelGerenciarAuxiliar);
            this.panelDropDownMenu.Controls.Add(this.labelGerenciarBibliotecario);
            this.panelDropDownMenu.Controls.Add(this.labelGerenciarSecretario);
            this.panelDropDownMenu.Controls.Add(this.labelGerenciarCoordenador);
            this.panelDropDownMenu.Controls.Add(this.labelGerenciarPedagogo);
            this.panelDropDownMenu.Controls.Add(this.labelGerenciarCurso);
            this.panelDropDownMenu.Location = new System.Drawing.Point(0, 47);
            this.panelDropDownMenu.Name = "panelDropDownMenu";
            this.panelDropDownMenu.Size = new System.Drawing.Size(242, 0);
            this.panelDropDownMenu.TabIndex = 2;
            // 
            // labelEmitirRelatorioFrequencia
            // 
            this.labelEmitirRelatorioFrequencia.AutoSize = true;
            this.labelEmitirRelatorioFrequencia.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmitirRelatorioFrequencia.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelEmitirRelatorioFrequencia.Location = new System.Drawing.Point(27, 224);
            this.labelEmitirRelatorioFrequencia.Name = "labelEmitirRelatorioFrequencia";
            this.labelEmitirRelatorioFrequencia.Size = new System.Drawing.Size(203, 44);
            this.labelEmitirRelatorioFrequencia.TabIndex = 9;
            this.labelEmitirRelatorioFrequencia.Text = "Emitir Relatório de \r\nFrequência dos Funcionários";
            this.labelEmitirRelatorioFrequencia.Click += new System.EventHandler(this.labelEmitirRelatorioFrequencia_Click);
            // 
            // labelGerenciarAuxiliar
            // 
            this.labelGerenciarAuxiliar.AutoSize = true;
            this.labelGerenciarAuxiliar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerenciarAuxiliar.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelGerenciarAuxiliar.Location = new System.Drawing.Point(27, 180);
            this.labelGerenciarAuxiliar.Name = "labelGerenciarAuxiliar";
            this.labelGerenciarAuxiliar.Size = new System.Drawing.Size(156, 44);
            this.labelGerenciarAuxiliar.TabIndex = 8;
            this.labelGerenciarAuxiliar.Text = "Gerenciar Auxiliar de \r\nServiços Gerais";
            this.labelGerenciarAuxiliar.Click += new System.EventHandler(this.labelGerenciarAuxiliar_Click);
            // 
            // labelGerenciarBibliotecario
            // 
            this.labelGerenciarBibliotecario.AutoSize = true;
            this.labelGerenciarBibliotecario.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerenciarBibliotecario.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelGerenciarBibliotecario.Location = new System.Drawing.Point(27, 147);
            this.labelGerenciarBibliotecario.Name = "labelGerenciarBibliotecario";
            this.labelGerenciarBibliotecario.Size = new System.Drawing.Size(182, 22);
            this.labelGerenciarBibliotecario.TabIndex = 7;
            this.labelGerenciarBibliotecario.Text = "Gerenciar Bibliotecário(a)";
            this.labelGerenciarBibliotecario.Click += new System.EventHandler(this.labelGerenciarBibliotecario_Click);
            // 
            // labelGerenciarSecretario
            // 
            this.labelGerenciarSecretario.AutoSize = true;
            this.labelGerenciarSecretario.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerenciarSecretario.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelGerenciarSecretario.Location = new System.Drawing.Point(27, 114);
            this.labelGerenciarSecretario.Name = "labelGerenciarSecretario";
            this.labelGerenciarSecretario.Size = new System.Drawing.Size(165, 22);
            this.labelGerenciarSecretario.TabIndex = 6;
            this.labelGerenciarSecretario.Text = "Gerenciar Secretário(a)";
            this.labelGerenciarSecretario.Click += new System.EventHandler(this.labelGerenciarSecretario_Click);
            // 
            // labelGerenciarCoordenador
            // 
            this.labelGerenciarCoordenador.AutoSize = true;
            this.labelGerenciarCoordenador.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerenciarCoordenador.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelGerenciarCoordenador.Location = new System.Drawing.Point(27, 81);
            this.labelGerenciarCoordenador.Name = "labelGerenciarCoordenador";
            this.labelGerenciarCoordenador.Size = new System.Drawing.Size(187, 22);
            this.labelGerenciarCoordenador.TabIndex = 5;
            this.labelGerenciarCoordenador.Text = "Gerenciar Coordenador(a)";
            this.labelGerenciarCoordenador.Click += new System.EventHandler(this.labelGerenciarCoordenador_Click);
            // 
            // labelGerenciarPedagogo
            // 
            this.labelGerenciarPedagogo.AutoSize = true;
            this.labelGerenciarPedagogo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerenciarPedagogo.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelGerenciarPedagogo.Location = new System.Drawing.Point(27, 48);
            this.labelGerenciarPedagogo.Name = "labelGerenciarPedagogo";
            this.labelGerenciarPedagogo.Size = new System.Drawing.Size(165, 22);
            this.labelGerenciarPedagogo.TabIndex = 4;
            this.labelGerenciarPedagogo.Text = "Gerenciar Pedagogo(a)";
            this.labelGerenciarPedagogo.Click += new System.EventHandler(this.labelGerenciarPedagogo_Click);
            // 
            // labelGerenciarCurso
            // 
            this.labelGerenciarCurso.AutoSize = true;
            this.labelGerenciarCurso.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerenciarCurso.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelGerenciarCurso.Location = new System.Drawing.Point(27, 15);
            this.labelGerenciarCurso.Name = "labelGerenciarCurso";
            this.labelGerenciarCurso.Size = new System.Drawing.Size(120, 22);
            this.labelGerenciarCurso.TabIndex = 3;
            this.labelGerenciarCurso.Text = "Gerenciar Curso";
            this.labelGerenciarCurso.Click += new System.EventHandler(this.labelGerenciarCurso_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 28;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(271, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 131);
            this.label8.TabIndex = 5;
            this.label8.Text = "EF";
            // 
            // userControlGerenciarPedagogo1
            // 
            this.userControlGerenciarPedagogo1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlGerenciarPedagogo1.Location = new System.Drawing.Point(0, 47);
            this.userControlGerenciarPedagogo1.Name = "userControlGerenciarPedagogo1";
            this.userControlGerenciarPedagogo1.Size = new System.Drawing.Size(710, 367);
            this.userControlGerenciarPedagogo1.TabIndex = 7;
            // 
            // userControlGerenciarCoordenador1
            // 
            this.userControlGerenciarCoordenador1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlGerenciarCoordenador1.Location = new System.Drawing.Point(0, 47);
            this.userControlGerenciarCoordenador1.Name = "userControlGerenciarCoordenador1";
            this.userControlGerenciarCoordenador1.Size = new System.Drawing.Size(710, 367);
            this.userControlGerenciarCoordenador1.TabIndex = 8;
            // 
            // userControlGerenciarCurso1
            // 
            this.userControlGerenciarCurso1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlGerenciarCurso1.Location = new System.Drawing.Point(0, 47);
            this.userControlGerenciarCurso1.Name = "userControlGerenciarCurso1";
            this.userControlGerenciarCurso1.Size = new System.Drawing.Size(710, 367);
            this.userControlGerenciarCurso1.TabIndex = 6;
            // 
            // userControlGerenciarBibliotecario1
            // 
            this.userControlGerenciarBibliotecario1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlGerenciarBibliotecario1.Location = new System.Drawing.Point(0, 47);
            this.userControlGerenciarBibliotecario1.Name = "userControlGerenciarBibliotecario1";
            this.userControlGerenciarBibliotecario1.Size = new System.Drawing.Size(710, 367);
            this.userControlGerenciarBibliotecario1.TabIndex = 9;
            // 
            // userControlGerenciarAuxiliarSG1
            // 
            this.userControlGerenciarAuxiliarSG1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlGerenciarAuxiliarSG1.Location = new System.Drawing.Point(0, 47);
            this.userControlGerenciarAuxiliarSG1.Name = "userControlGerenciarAuxiliarSG1";
            this.userControlGerenciarAuxiliarSG1.Size = new System.Drawing.Size(710, 367);
            this.userControlGerenciarAuxiliarSG1.TabIndex = 10;
            // 
            // userControlGerenciarSecretario1
            // 
            this.userControlGerenciarSecretario1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlGerenciarSecretario1.Location = new System.Drawing.Point(0, 47);
            this.userControlGerenciarSecretario1.Name = "userControlGerenciarSecretario1";
            this.userControlGerenciarSecretario1.Size = new System.Drawing.Size(710, 367);
            this.userControlGerenciarSecretario1.TabIndex = 11;
            // 
            // userControlRelatorioFrequenciaFuncionarios1
            // 
            this.userControlRelatorioFrequenciaFuncionarios1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlRelatorioFrequenciaFuncionarios1.Location = new System.Drawing.Point(0, 47);
            this.userControlRelatorioFrequenciaFuncionarios1.Name = "userControlRelatorioFrequenciaFuncionarios1";
            this.userControlRelatorioFrequenciaFuncionarios1.Size = new System.Drawing.Size(710, 367);
            this.userControlRelatorioFrequenciaFuncionarios1.TabIndex = 12;
            // 
            // FormMenuDiretor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(710, 415);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panelDropDownMenu);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.userControlGerenciarPedagogo1);
            this.Controls.Add(this.userControlGerenciarCoordenador1);
            this.Controls.Add(this.userControlGerenciarCurso1);
            this.Controls.Add(this.userControlGerenciarBibliotecario1);
            this.Controls.Add(this.userControlGerenciarAuxiliarSG1);
            this.Controls.Add(this.userControlGerenciarSecretario1);
            this.Controls.Add(this.userControlRelatorioFrequenciaFuncionarios1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuDiretor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuDiretor";
            this.panelSuperior.ResumeLayout(false);
            this.panelDropDownMenu.ResumeLayout(false);
            this.panelDropDownMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelDropDownMenu;
        private System.Windows.Forms.Label labelGerenciarCurso;
        private System.Windows.Forms.Label labelEmitirRelatorioFrequencia;
        private System.Windows.Forms.Label labelGerenciarAuxiliar;
        private System.Windows.Forms.Label labelGerenciarBibliotecario;
        private System.Windows.Forms.Label labelGerenciarSecretario;
        private System.Windows.Forms.Label labelGerenciarCoordenador;
        private System.Windows.Forms.Label labelGerenciarPedagogo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMenuDrop;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label8;
        private UserControlGerenciarCurso userControlGerenciarCurso1;
        private UserControlGerenciarPedagogo userControlGerenciarPedagogo1;
        private UserControlGerenciarCoordenador userControlGerenciarCoordenador1;
        private UserControlGerenciarBibliotecario userControlGerenciarBibliotecario1;
        private UserControlGerenciarAuxiliarSG userControlGerenciarAuxiliarSG1;
        private UserControlGerenciarSecretario userControlGerenciarSecretario1;
        private UserControlRelatorioFrequenciaFuncionarios userControlRelatorioFrequenciaFuncionarios1;
    }
}