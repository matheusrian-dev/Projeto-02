namespace Projeto_02
{
    partial class FormEditarPlanoCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarPlanoCurso));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodPlanoCurso = new System.Windows.Forms.TextBox();
            this.btnExcluirPlanoCurso = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtListaAtividades = new System.Windows.Forms.TextBox();
            this.btnAtualizarPlanoCurso = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodCurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnBuscarPlanoCurso = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelSuperior.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panelSuperior.Size = new System.Drawing.Size(684, 47);
            this.panelSuperior.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(234, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "Atualizar Plano de Curso";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(594, 7);
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
            this.btnFechar.Location = new System.Drawing.Point(636, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(45, 32);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(624, 592);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 38);
            this.label8.TabIndex = 51;
            this.label8.Text = "EF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCodPlanoCurso);
            this.groupBox1.Controls.Add(this.btnExcluirPlanoCurso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtListaAtividades);
            this.groupBox1.Controls.Add(this.btnAtualizarPlanoCurso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodCurso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPeriodo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(78, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 267);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "Código do Plano de Curso:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodPlanoCurso
            // 
            this.txtCodPlanoCurso.Location = new System.Drawing.Point(15, 245);
            this.txtCodPlanoCurso.Name = "txtCodPlanoCurso";
            this.txtCodPlanoCurso.ReadOnly = true;
            this.txtCodPlanoCurso.Size = new System.Drawing.Size(230, 20);
            this.txtCodPlanoCurso.TabIndex = 44;
            // 
            // btnExcluirPlanoCurso
            // 
            this.btnExcluirPlanoCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirPlanoCurso.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirPlanoCurso.Location = new System.Drawing.Point(399, 157);
            this.btnExcluirPlanoCurso.Name = "btnExcluirPlanoCurso";
            this.btnExcluirPlanoCurso.Size = new System.Drawing.Size(103, 71);
            this.btnExcluirPlanoCurso.TabIndex = 43;
            this.btnExcluirPlanoCurso.Text = "Excluir Plano de Curso";
            this.btnExcluirPlanoCurso.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Lista de Atividades Planejada:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtListaAtividades
            // 
            this.txtListaAtividades.Location = new System.Drawing.Point(286, 52);
            this.txtListaAtividades.Multiline = true;
            this.txtListaAtividades.Name = "txtListaAtividades";
            this.txtListaAtividades.Size = new System.Drawing.Size(230, 90);
            this.txtListaAtividades.TabIndex = 41;
            // 
            // btnAtualizarPlanoCurso
            // 
            this.btnAtualizarPlanoCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarPlanoCurso.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarPlanoCurso.Location = new System.Drawing.Point(286, 157);
            this.btnAtualizarPlanoCurso.Name = "btnAtualizarPlanoCurso";
            this.btnAtualizarPlanoCurso.Size = new System.Drawing.Size(107, 71);
            this.btnAtualizarPlanoCurso.TabIndex = 40;
            this.btnAtualizarPlanoCurso.Text = "Atualizar Plano de Curso";
            this.btnAtualizarPlanoCurso.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Código do Curso Referente:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodCurso
            // 
            this.txtCodCurso.Location = new System.Drawing.Point(15, 179);
            this.txtCodCurso.Name = "txtCodCurso";
            this.txtCodCurso.Size = new System.Drawing.Size(230, 20);
            this.txtCodCurso.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Carga Horária:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(15, 113);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(230, 20);
            this.txtPeriodo.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Matéria Referente:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 20);
            this.txtNome.TabIndex = 34;
            // 
            // btnBuscarPlanoCurso
            // 
            this.btnBuscarPlanoCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPlanoCurso.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPlanoCurso.Location = new System.Drawing.Point(257, 270);
            this.btnBuscarPlanoCurso.Name = "btnBuscarPlanoCurso";
            this.btnBuscarPlanoCurso.Size = new System.Drawing.Size(171, 52);
            this.btnBuscarPlanoCurso.TabIndex = 49;
            this.btnBuscarPlanoCurso.Text = "Buscar Plano de Curso";
            this.btnBuscarPlanoCurso.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 211);
            this.dataGridView1.TabIndex = 48;
            // 
            // FormEditarPlanoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(684, 639);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscarPlanoCurso);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditarPlanoCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditarPlanoCurso";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluirPlanoCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtListaAtividades;
        private System.Windows.Forms.Button btnAtualizarPlanoCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnBuscarPlanoCurso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodPlanoCurso;
    }
}