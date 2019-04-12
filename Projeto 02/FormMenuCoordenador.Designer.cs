namespace Projeto_02
{
    partial class FormMenuCoordenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuCoordenador));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnMenuDrop = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelDropDownMenu = new System.Windows.Forms.Panel();
            this.labelEmitirRelatorioFrequenciaProfessor = new System.Windows.Forms.Label();
            this.labelGerenciarPlanoAula = new System.Windows.Forms.Label();
            this.labelGerenciarPlanoCurso = new System.Windows.Forms.Label();
            this.labelGerenciarConteudoCurso = new System.Windows.Forms.Label();
            this.labelGerenciarProfessor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.userControlGerenciarProfessor1 = new Projeto_02.UserControlGerenciarProfessor();
            this.userControlGerenciarConteudoCurso1 = new Projeto_02.UserControlGerenciarConteudoCurso();
            this.userControlGerenciarPlanoAula1 = new Projeto_02.UserControlGerenciarPlanoAula();
            this.userControlGerenciarPlanoCurso1 = new Projeto_02.UserControlGerenciarPlanoCurso();
            this.userControlRelatorioFrequenciaProfessor1 = new Projeto_02.UserControlRelatorioFrequenciaProfessor();
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
            this.panelSuperior.TabIndex = 2;
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
            this.panelDropDownMenu.Controls.Add(this.labelEmitirRelatorioFrequenciaProfessor);
            this.panelDropDownMenu.Controls.Add(this.labelGerenciarPlanoAula);
            this.panelDropDownMenu.Controls.Add(this.labelGerenciarPlanoCurso);
            this.panelDropDownMenu.Controls.Add(this.labelGerenciarConteudoCurso);
            this.panelDropDownMenu.Controls.Add(this.labelGerenciarProfessor);
            this.panelDropDownMenu.Location = new System.Drawing.Point(0, 47);
            this.panelDropDownMenu.Name = "panelDropDownMenu";
            this.panelDropDownMenu.Size = new System.Drawing.Size(242, 0);
            this.panelDropDownMenu.TabIndex = 3;
            // 
            // labelEmitirRelatorioFrequenciaProfessor
            // 
            this.labelEmitirRelatorioFrequenciaProfessor.AutoSize = true;
            this.labelEmitirRelatorioFrequenciaProfessor.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmitirRelatorioFrequenciaProfessor.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelEmitirRelatorioFrequenciaProfessor.Location = new System.Drawing.Point(27, 147);
            this.labelEmitirRelatorioFrequenciaProfessor.Name = "labelEmitirRelatorioFrequenciaProfessor";
            this.labelEmitirRelatorioFrequenciaProfessor.Size = new System.Drawing.Size(172, 44);
            this.labelEmitirRelatorioFrequenciaProfessor.TabIndex = 7;
            this.labelEmitirRelatorioFrequenciaProfessor.Text = "Emitir Relatório de\r\nFrequência do Professor";
            this.labelEmitirRelatorioFrequenciaProfessor.Click += new System.EventHandler(this.labelEmitirRelatorioFrequenciaProfessor_Click);
            // 
            // labelGerenciarPlanoAula
            // 
            this.labelGerenciarPlanoAula.AutoSize = true;
            this.labelGerenciarPlanoAula.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerenciarPlanoAula.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelGerenciarPlanoAula.Location = new System.Drawing.Point(27, 114);
            this.labelGerenciarPlanoAula.Name = "labelGerenciarPlanoAula";
            this.labelGerenciarPlanoAula.Size = new System.Drawing.Size(172, 22);
            this.labelGerenciarPlanoAula.TabIndex = 6;
            this.labelGerenciarPlanoAula.Text = "Gerenciar Plano de Aula";
            this.labelGerenciarPlanoAula.Click += new System.EventHandler(this.labelGerenciarPlanoAula_Click);
            // 
            // labelGerenciarPlanoCurso
            // 
            this.labelGerenciarPlanoCurso.AutoSize = true;
            this.labelGerenciarPlanoCurso.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerenciarPlanoCurso.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelGerenciarPlanoCurso.Location = new System.Drawing.Point(27, 81);
            this.labelGerenciarPlanoCurso.Name = "labelGerenciarPlanoCurso";
            this.labelGerenciarPlanoCurso.Size = new System.Drawing.Size(182, 22);
            this.labelGerenciarPlanoCurso.TabIndex = 5;
            this.labelGerenciarPlanoCurso.Text = "Gerenciar Plano de Curso";
            this.labelGerenciarPlanoCurso.Click += new System.EventHandler(this.labelGerenciarPlanoCurso_Click);
            // 
            // labelGerenciarConteudoCurso
            // 
            this.labelGerenciarConteudoCurso.AutoSize = true;
            this.labelGerenciarConteudoCurso.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerenciarConteudoCurso.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelGerenciarConteudoCurso.Location = new System.Drawing.Point(27, 48);
            this.labelGerenciarConteudoCurso.Name = "labelGerenciarConteudoCurso";
            this.labelGerenciarConteudoCurso.Size = new System.Drawing.Size(211, 22);
            this.labelGerenciarConteudoCurso.TabIndex = 4;
            this.labelGerenciarConteudoCurso.Text = "Gerenciar Conteúdo do Curso";
            this.labelGerenciarConteudoCurso.Click += new System.EventHandler(this.labelGerenciarConteudoCurso_Click);
            // 
            // labelGerenciarProfessor
            // 
            this.labelGerenciarProfessor.AutoSize = true;
            this.labelGerenciarProfessor.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerenciarProfessor.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelGerenciarProfessor.Location = new System.Drawing.Point(27, 15);
            this.labelGerenciarProfessor.Name = "labelGerenciarProfessor";
            this.labelGerenciarProfessor.Size = new System.Drawing.Size(160, 22);
            this.labelGerenciarProfessor.TabIndex = 3;
            this.labelGerenciarProfessor.Text = "Gerenciar Professor(a)";
            this.labelGerenciarProfessor.Click += new System.EventHandler(this.labelGerenciarProfessor_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
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
            this.btnVoltar.TabIndex = 5;
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
            this.label8.TabIndex = 6;
            this.label8.Text = "EF";
            // 
            // userControlGerenciarProfessor1
            // 
            this.userControlGerenciarProfessor1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlGerenciarProfessor1.Location = new System.Drawing.Point(0, 47);
            this.userControlGerenciarProfessor1.Name = "userControlGerenciarProfessor1";
            this.userControlGerenciarProfessor1.Size = new System.Drawing.Size(710, 367);
            this.userControlGerenciarProfessor1.TabIndex = 7;
            // 
            // userControlGerenciarConteudoCurso1
            // 
            this.userControlGerenciarConteudoCurso1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlGerenciarConteudoCurso1.Location = new System.Drawing.Point(0, 47);
            this.userControlGerenciarConteudoCurso1.Name = "userControlGerenciarConteudoCurso1";
            this.userControlGerenciarConteudoCurso1.Size = new System.Drawing.Size(710, 367);
            this.userControlGerenciarConteudoCurso1.TabIndex = 8;
            // 
            // userControlGerenciarPlanoAula1
            // 
            this.userControlGerenciarPlanoAula1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlGerenciarPlanoAula1.Location = new System.Drawing.Point(0, 47);
            this.userControlGerenciarPlanoAula1.Name = "userControlGerenciarPlanoAula1";
            this.userControlGerenciarPlanoAula1.Size = new System.Drawing.Size(710, 367);
            this.userControlGerenciarPlanoAula1.TabIndex = 9;
            // 
            // userControlGerenciarPlanoCurso1
            // 
            this.userControlGerenciarPlanoCurso1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlGerenciarPlanoCurso1.Location = new System.Drawing.Point(0, 47);
            this.userControlGerenciarPlanoCurso1.Name = "userControlGerenciarPlanoCurso1";
            this.userControlGerenciarPlanoCurso1.Size = new System.Drawing.Size(710, 367);
            this.userControlGerenciarPlanoCurso1.TabIndex = 10;
            // 
            // userControlRelatorioFrequenciaProfessor1
            // 
            this.userControlRelatorioFrequenciaProfessor1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlRelatorioFrequenciaProfessor1.Location = new System.Drawing.Point(0, 47);
            this.userControlRelatorioFrequenciaProfessor1.Name = "userControlRelatorioFrequenciaProfessor1";
            this.userControlRelatorioFrequenciaProfessor1.Size = new System.Drawing.Size(710, 367);
            this.userControlRelatorioFrequenciaProfessor1.TabIndex = 11;
            // 
            // FormMenuCoordenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(710, 415);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panelDropDownMenu);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.userControlGerenciarProfessor1);
            this.Controls.Add(this.userControlGerenciarConteudoCurso1);
            this.Controls.Add(this.userControlGerenciarPlanoAula1);
            this.Controls.Add(this.userControlGerenciarPlanoCurso1);
            this.Controls.Add(this.userControlRelatorioFrequenciaProfessor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenuCoordenador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuCoordenador";
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
        private System.Windows.Forms.Label labelEmitirRelatorioFrequenciaProfessor;
        private System.Windows.Forms.Label labelGerenciarPlanoAula;
        private System.Windows.Forms.Label labelGerenciarPlanoCurso;
        private System.Windows.Forms.Label labelGerenciarConteudoCurso;
        private System.Windows.Forms.Label labelGerenciarProfessor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label8;
        private UserControlGerenciarProfessor userControlGerenciarProfessor1;
        private UserControlGerenciarConteudoCurso userControlGerenciarConteudoCurso1;
        private UserControlGerenciarPlanoAula userControlGerenciarPlanoAula1;
        private UserControlGerenciarPlanoCurso userControlGerenciarPlanoCurso1;
        private UserControlRelatorioFrequenciaProfessor userControlRelatorioFrequenciaProfessor1;
    }
}