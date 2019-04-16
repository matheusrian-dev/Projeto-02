namespace Projeto_02
{
    partial class FormEditarTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarTurma));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluirTurma = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodCurso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditarTurma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeInstrutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodTurma = new System.Windows.Forms.TextBox();
            this.btnBuscarTurmas = new System.Windows.Forms.Button();
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
            this.panelSuperior.Size = new System.Drawing.Size(618, 47);
            this.panelSuperior.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(169, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "Atualização de Cadastro da Turma";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(536, 7);
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
            this.btnFechar.Location = new System.Drawing.Point(573, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(45, 32);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluirTurma
            // 
            this.btnExcluirTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirTurma.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirTurma.Location = new System.Drawing.Point(424, 293);
            this.btnExcluirTurma.Name = "btnExcluirTurma";
            this.btnExcluirTurma.Size = new System.Drawing.Size(95, 74);
            this.btnExcluirTurma.TabIndex = 49;
            this.btnExcluirTurma.Text = "Excluir Cadastro da Turma";
            this.btnExcluirTurma.UseVisualStyleBackColor = true;
            this.btnExcluirTurma.Click += new System.EventHandler(this.btnExcluirTurma_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(306, 222);
            this.dataGridView1.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 47;
            this.label3.Text = "Código do Curso:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodCurso
            // 
            this.txtCodCurso.Location = new System.Drawing.Point(323, 204);
            this.txtCodCurso.Name = "txtCodCurso";
            this.txtCodCurso.Size = new System.Drawing.Size(230, 20);
            this.txtCodCurso.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(558, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 38);
            this.label8.TabIndex = 45;
            this.label8.Text = "EF";
            // 
            // btnEditarTurma
            // 
            this.btnEditarTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarTurma.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTurma.Location = new System.Drawing.Point(323, 293);
            this.btnEditarTurma.Name = "btnEditarTurma";
            this.btnEditarTurma.Size = new System.Drawing.Size(95, 74);
            this.btnEditarTurma.TabIndex = 44;
            this.btnEditarTurma.Text = "Atualizar Cadastro da Turma";
            this.btnEditarTurma.UseVisualStyleBackColor = true;
            this.btnEditarTurma.Click += new System.EventHandler(this.btnEditarTurma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nome do Instrutor Responsável:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomeInstrutor
            // 
            this.txtNomeInstrutor.Location = new System.Drawing.Point(323, 146);
            this.txtNomeInstrutor.Name = "txtNomeInstrutor";
            this.txtNomeInstrutor.Size = new System.Drawing.Size(230, 20);
            this.txtNomeInstrutor.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(323, 88);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 20);
            this.txtNome.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "Código da Turma:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodTurma
            // 
            this.txtCodTurma.Location = new System.Drawing.Point(323, 262);
            this.txtCodTurma.Name = "txtCodTurma";
            this.txtCodTurma.Size = new System.Drawing.Size(230, 20);
            this.txtCodTurma.TabIndex = 50;
            // 
            // btnBuscarTurmas
            // 
            this.btnBuscarTurmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTurmas.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTurmas.Location = new System.Drawing.Point(8, 311);
            this.btnBuscarTurmas.Name = "btnBuscarTurmas";
            this.btnBuscarTurmas.Size = new System.Drawing.Size(153, 38);
            this.btnBuscarTurmas.TabIndex = 57;
            this.btnBuscarTurmas.Text = "Buscar Turmas";
            this.btnBuscarTurmas.UseVisualStyleBackColor = true;
            this.btnBuscarTurmas.Click += new System.EventHandler(this.btnBuscarTurmas_Click);
            // 
            // FormEditarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(618, 379);
            this.Controls.Add(this.btnBuscarTurmas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodTurma);
            this.Controls.Add(this.btnExcluirTurma);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodCurso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEditarTurma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeInstrutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditarTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditarTurma";
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
        private System.Windows.Forms.Button btnExcluirTurma;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodCurso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditarTurma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeInstrutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodTurma;
        private System.Windows.Forms.Button btnBuscarTurmas;
    }
}