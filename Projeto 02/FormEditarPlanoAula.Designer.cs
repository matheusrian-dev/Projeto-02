namespace Projeto_02
{
    partial class FormEditarPlanoAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarPlanoAula));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluirPlanoAula = new System.Windows.Forms.Button();
            this.btnAtualizarPlanoAula = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodPlanoAula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodTurma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnBuscarPlanoAula = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuartoH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTerceiroH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSegundoH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrimeiroH = new System.Windows.Forms.TextBox();
            this.dtpDataAula = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
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
            this.label9.Location = new System.Drawing.Point(239, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "Atualizar Plano de Aula";
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
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(624, 660);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 38);
            this.label8.TabIndex = 51;
            this.label8.Text = "EF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDataAula);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtQuartoH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTerceiroH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSegundoH);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPrimeiroH);
            this.groupBox1.Controls.Add(this.btnExcluirPlanoAula);
            this.groupBox1.Controls.Add(this.btnAtualizarPlanoAula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodPlanoAula);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodTurma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Location = new System.Drawing.Point(78, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 348);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // btnExcluirPlanoAula
            // 
            this.btnExcluirPlanoAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirPlanoAula.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirPlanoAula.Location = new System.Drawing.Point(274, 276);
            this.btnExcluirPlanoAula.Name = "btnExcluirPlanoAula";
            this.btnExcluirPlanoAula.Size = new System.Drawing.Size(166, 59);
            this.btnExcluirPlanoAula.TabIndex = 43;
            this.btnExcluirPlanoAula.Text = "Excluir Plano de Aula";
            this.btnExcluirPlanoAula.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarPlanoAula
            // 
            this.btnAtualizarPlanoAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarPlanoAula.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarPlanoAula.Location = new System.Drawing.Point(106, 276);
            this.btnAtualizarPlanoAula.Name = "btnAtualizarPlanoAula";
            this.btnAtualizarPlanoAula.Size = new System.Drawing.Size(162, 59);
            this.btnAtualizarPlanoAula.TabIndex = 40;
            this.btnAtualizarPlanoAula.Text = "Atualizar Plano de Aula";
            this.btnAtualizarPlanoAula.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Código do Plano de Aula:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodPlanoAula
            // 
            this.txtCodPlanoAula.Location = new System.Drawing.Point(15, 174);
            this.txtCodPlanoAula.Name = "txtCodPlanoAula";
            this.txtCodPlanoAula.ReadOnly = true;
            this.txtCodPlanoAula.Size = new System.Drawing.Size(230, 20);
            this.txtCodPlanoAula.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Código da Turma:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodTurma
            // 
            this.txtCodTurma.Location = new System.Drawing.Point(15, 110);
            this.txtCodTurma.Name = "txtCodTurma";
            this.txtCodTurma.Size = new System.Drawing.Size(230, 20);
            this.txtCodTurma.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "CPF do Instrutor Responsável:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(15, 46);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(230, 20);
            this.txtCPF.TabIndex = 34;
            // 
            // btnBuscarPlanoAula
            // 
            this.btnBuscarPlanoAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPlanoAula.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPlanoAula.Location = new System.Drawing.Point(257, 270);
            this.btnBuscarPlanoAula.Name = "btnBuscarPlanoAula";
            this.btnBuscarPlanoAula.Size = new System.Drawing.Size(171, 52);
            this.btnBuscarPlanoAula.TabIndex = 49;
            this.btnBuscarPlanoAula.Text = "Buscar Plano de Aula";
            this.btnBuscarPlanoAula.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 211);
            this.dataGridView1.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 18);
            this.label4.TabIndex = 53;
            this.label4.Text = "Atividade do Quarto Horário:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuartoH
            // 
            this.txtQuartoH.Location = new System.Drawing.Point(274, 238);
            this.txtQuartoH.Name = "txtQuartoH";
            this.txtQuartoH.ReadOnly = true;
            this.txtQuartoH.Size = new System.Drawing.Size(230, 20);
            this.txtQuartoH.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 18);
            this.label6.TabIndex = 51;
            this.label6.Text = "Atividade do Terceiro Horário:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTerceiroH
            // 
            this.txtTerceiroH.Location = new System.Drawing.Point(274, 174);
            this.txtTerceiroH.Name = "txtTerceiroH";
            this.txtTerceiroH.Size = new System.Drawing.Size(230, 20);
            this.txtTerceiroH.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(271, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "Atividade do Segundo Horário:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSegundoH
            // 
            this.txtSegundoH.Location = new System.Drawing.Point(274, 110);
            this.txtSegundoH.Name = "txtSegundoH";
            this.txtSegundoH.Size = new System.Drawing.Size(230, 20);
            this.txtSegundoH.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(271, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 18);
            this.label10.TabIndex = 47;
            this.label10.Text = "Atividade do Primeiro Horário:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrimeiroH
            // 
            this.txtPrimeiroH.Location = new System.Drawing.Point(274, 46);
            this.txtPrimeiroH.Name = "txtPrimeiroH";
            this.txtPrimeiroH.Size = new System.Drawing.Size(230, 20);
            this.txtPrimeiroH.TabIndex = 46;
            // 
            // dtpDataAula
            // 
            this.dtpDataAula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAula.Location = new System.Drawing.Point(15, 238);
            this.dtpDataAula.Name = "dtpDataAula";
            this.dtpDataAula.Size = new System.Drawing.Size(230, 20);
            this.dtpDataAula.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 18);
            this.label11.TabIndex = 54;
            this.label11.Text = "Data da Aula:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEditarPlanoAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(684, 707);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscarPlanoAula);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditarPlanoAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditarPlanoAula";
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
        private System.Windows.Forms.Button btnExcluirPlanoAula;
        private System.Windows.Forms.Button btnAtualizarPlanoAula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodPlanoAula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodTurma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnBuscarPlanoAula;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuartoH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTerceiroH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSegundoH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrimeiroH;
        private System.Windows.Forms.DateTimePicker dtpDataAula;
        private System.Windows.Forms.Label label11;
    }
}