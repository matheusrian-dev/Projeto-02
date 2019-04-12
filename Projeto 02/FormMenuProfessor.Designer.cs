namespace Projeto_02
{
    partial class FormMenuProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuProfessor));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnMenuDrop = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelDropDownMenu = new System.Windows.Forms.Panel();
            this.labelLancarNota = new System.Windows.Forms.Label();
            this.labelLancarPlanoAula = new System.Windows.Forms.Label();
            this.labelLancarFrequenciaAluno = new System.Windows.Forms.Label();
            this.labelLancarDistribuicaoPontos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.userControlLancarDistribuicaoPontos1 = new Projeto_02.UserControlLancarDistribuicaoPontos();
            this.userControlLancarPlanoAula1 = new Projeto_02.UserControlLancarPlanoAula();
            this.userControlLancarNota1 = new Projeto_02.UserControlLancarNota();
            this.userControlLancarFrequenciaAluno1 = new Projeto_02.UserControlLancarFrequenciaAluno();
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
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelDropDownMenu
            // 
            this.panelDropDownMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(142)))));
            this.panelDropDownMenu.Controls.Add(this.labelLancarNota);
            this.panelDropDownMenu.Controls.Add(this.labelLancarPlanoAula);
            this.panelDropDownMenu.Controls.Add(this.labelLancarFrequenciaAluno);
            this.panelDropDownMenu.Controls.Add(this.labelLancarDistribuicaoPontos);
            this.panelDropDownMenu.Location = new System.Drawing.Point(0, 47);
            this.panelDropDownMenu.Name = "panelDropDownMenu";
            this.panelDropDownMenu.Size = new System.Drawing.Size(242, 0);
            this.panelDropDownMenu.TabIndex = 4;
            // 
            // labelLancarNota
            // 
            this.labelLancarNota.AutoSize = true;
            this.labelLancarNota.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLancarNota.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelLancarNota.Location = new System.Drawing.Point(12, 130);
            this.labelLancarNota.Name = "labelLancarNota";
            this.labelLancarNota.Size = new System.Drawing.Size(96, 22);
            this.labelLancarNota.TabIndex = 6;
            this.labelLancarNota.Text = "Lançar Nota";
            this.labelLancarNota.Click += new System.EventHandler(this.labelLancarNota_Click);
            // 
            // labelLancarPlanoAula
            // 
            this.labelLancarPlanoAula.AutoSize = true;
            this.labelLancarPlanoAula.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLancarPlanoAula.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelLancarPlanoAula.Location = new System.Drawing.Point(12, 98);
            this.labelLancarPlanoAula.Name = "labelLancarPlanoAula";
            this.labelLancarPlanoAula.Size = new System.Drawing.Size(154, 22);
            this.labelLancarPlanoAula.TabIndex = 5;
            this.labelLancarPlanoAula.Text = "Lançar Plano de Aula";
            this.labelLancarPlanoAula.Click += new System.EventHandler(this.labelLancarPlanoAula_Click);
            // 
            // labelLancarFrequenciaAluno
            // 
            this.labelLancarFrequenciaAluno.AutoSize = true;
            this.labelLancarFrequenciaAluno.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLancarFrequenciaAluno.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelLancarFrequenciaAluno.Location = new System.Drawing.Point(12, 44);
            this.labelLancarFrequenciaAluno.Name = "labelLancarFrequenciaAluno";
            this.labelLancarFrequenciaAluno.Size = new System.Drawing.Size(188, 44);
            this.labelLancarFrequenciaAluno.TabIndex = 4;
            this.labelLancarFrequenciaAluno.Text = "Lançar Frequência dos(as)\r\n Alunos(as)";
            this.labelLancarFrequenciaAluno.Click += new System.EventHandler(this.labelLancarFrequenciaAluno_Click);
            // 
            // labelLancarDistribuicaoPontos
            // 
            this.labelLancarDistribuicaoPontos.AutoSize = true;
            this.labelLancarDistribuicaoPontos.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLancarDistribuicaoPontos.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelLancarDistribuicaoPontos.Location = new System.Drawing.Point(12, 12);
            this.labelLancarDistribuicaoPontos.Name = "labelLancarDistribuicaoPontos";
            this.labelLancarDistribuicaoPontos.Size = new System.Drawing.Size(214, 22);
            this.labelLancarDistribuicaoPontos.TabIndex = 3;
            this.labelLancarDistribuicaoPontos.Text = "Lançar Distribuição de Pontos";
            this.labelLancarDistribuicaoPontos.Click += new System.EventHandler(this.labelLancarDistribuicaoPontos_Click);
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
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(12, 348);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(61, 55);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // userControlLancarDistribuicaoPontos1
            // 
            this.userControlLancarDistribuicaoPontos1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlLancarDistribuicaoPontos1.Location = new System.Drawing.Point(0, 47);
            this.userControlLancarDistribuicaoPontos1.Name = "userControlLancarDistribuicaoPontos1";
            this.userControlLancarDistribuicaoPontos1.Size = new System.Drawing.Size(710, 367);
            this.userControlLancarDistribuicaoPontos1.TabIndex = 8;
            // 
            // userControlLancarPlanoAula1
            // 
            this.userControlLancarPlanoAula1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlLancarPlanoAula1.Location = new System.Drawing.Point(0, 47);
            this.userControlLancarPlanoAula1.Name = "userControlLancarPlanoAula1";
            this.userControlLancarPlanoAula1.Size = new System.Drawing.Size(710, 367);
            this.userControlLancarPlanoAula1.TabIndex = 9;
            // 
            // userControlLancarNota1
            // 
            this.userControlLancarNota1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlLancarNota1.Location = new System.Drawing.Point(0, 47);
            this.userControlLancarNota1.Name = "userControlLancarNota1";
            this.userControlLancarNota1.Size = new System.Drawing.Size(710, 367);
            this.userControlLancarNota1.TabIndex = 10;
            // 
            // userControlLancarFrequenciaAluno1
            // 
            this.userControlLancarFrequenciaAluno1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlLancarFrequenciaAluno1.Location = new System.Drawing.Point(0, 47);
            this.userControlLancarFrequenciaAluno1.Name = "userControlLancarFrequenciaAluno1";
            this.userControlLancarFrequenciaAluno1.Size = new System.Drawing.Size(710, 367);
            this.userControlLancarFrequenciaAluno1.TabIndex = 11;
            // 
            // FormMenuProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(710, 415);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelDropDownMenu);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.userControlLancarDistribuicaoPontos1);
            this.Controls.Add(this.userControlLancarPlanoAula1);
            this.Controls.Add(this.userControlLancarNota1);
            this.Controls.Add(this.userControlLancarFrequenciaAluno1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenuProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuProfessor";
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelDropDownMenu;
        private System.Windows.Forms.Label labelLancarNota;
        private System.Windows.Forms.Label labelLancarPlanoAula;
        private System.Windows.Forms.Label labelLancarFrequenciaAluno;
        private System.Windows.Forms.Label labelLancarDistribuicaoPontos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVoltar;
        private UserControlLancarDistribuicaoPontos userControlLancarDistribuicaoPontos1;
        private UserControlLancarPlanoAula userControlLancarPlanoAula1;
        private UserControlLancarNota userControlLancarNota1;
        private UserControlLancarFrequenciaAluno userControlLancarFrequenciaAluno1;
    }
}