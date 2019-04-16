namespace Projeto_02
{
    partial class FormEnturmarAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnturmarAluno));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodAluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodTurma = new System.Windows.Forms.TextBox();
            this.btnBuscarAlunos = new System.Windows.Forms.Button();
            this.btnBuscarTurmas = new System.Windows.Forms.Button();
            this.btnEnturmarAluno = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.Controls.Add(this.label9);
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Controls.Add(this.btnFechar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(677, 47);
            this.panelSuperior.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(260, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "Enturmar Alunos";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(578, 7);
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
            this.btnFechar.Location = new System.Drawing.Point(620, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(45, 32);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(382, 301);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Código do Aluno:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodAluno
            // 
            this.txtCodAluno.Location = new System.Drawing.Point(427, 83);
            this.txtCodAluno.Name = "txtCodAluno";
            this.txtCodAluno.Size = new System.Drawing.Size(230, 20);
            this.txtCodAluno.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Código da Turma:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodTurma
            // 
            this.txtCodTurma.Location = new System.Drawing.Point(427, 140);
            this.txtCodTurma.Name = "txtCodTurma";
            this.txtCodTurma.Size = new System.Drawing.Size(230, 20);
            this.txtCodTurma.TabIndex = 17;
            // 
            // btnBuscarAlunos
            // 
            this.btnBuscarAlunos.FlatAppearance.BorderSize = 2;
            this.btnBuscarAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAlunos.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAlunos.Location = new System.Drawing.Point(427, 176);
            this.btnBuscarAlunos.Name = "btnBuscarAlunos";
            this.btnBuscarAlunos.Size = new System.Drawing.Size(94, 52);
            this.btnBuscarAlunos.TabIndex = 26;
            this.btnBuscarAlunos.Text = "Buscar Alunos ";
            this.btnBuscarAlunos.UseVisualStyleBackColor = true;
            this.btnBuscarAlunos.Click += new System.EventHandler(this.btnBuscarAlunos_Click);
            // 
            // btnBuscarTurmas
            // 
            this.btnBuscarTurmas.FlatAppearance.BorderSize = 2;
            this.btnBuscarTurmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTurmas.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTurmas.Location = new System.Drawing.Point(527, 176);
            this.btnBuscarTurmas.Name = "btnBuscarTurmas";
            this.btnBuscarTurmas.Size = new System.Drawing.Size(94, 52);
            this.btnBuscarTurmas.TabIndex = 27;
            this.btnBuscarTurmas.Text = "Buscar Turmas";
            this.btnBuscarTurmas.UseVisualStyleBackColor = true;
            this.btnBuscarTurmas.Click += new System.EventHandler(this.btnBuscarTurmas_Click);
            // 
            // btnEnturmarAluno
            // 
            this.btnEnturmarAluno.FlatAppearance.BorderSize = 2;
            this.btnEnturmarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnturmarAluno.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnturmarAluno.Location = new System.Drawing.Point(427, 253);
            this.btnEnturmarAluno.Name = "btnEnturmarAluno";
            this.btnEnturmarAluno.Size = new System.Drawing.Size(194, 52);
            this.btnEnturmarAluno.TabIndex = 28;
            this.btnEnturmarAluno.Text = "Enturmar Aluno";
            this.btnEnturmarAluno.UseVisualStyleBackColor = true;
            this.btnEnturmarAluno.Click += new System.EventHandler(this.btnEnturmarAluno_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(627, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 30);
            this.label8.TabIndex = 29;
            this.label8.Text = "EF";
            // 
            // FormEnturmarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(677, 367);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEnturmarAluno);
            this.Controls.Add(this.btnBuscarTurmas);
            this.Controls.Add(this.btnBuscarAlunos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodTurma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodAluno);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEnturmarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEnturmarAluno";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodTurma;
        private System.Windows.Forms.Button btnBuscarAlunos;
        private System.Windows.Forms.Button btnBuscarTurmas;
        private System.Windows.Forms.Button btnEnturmarAluno;
        private System.Windows.Forms.Label label8;
    }
}