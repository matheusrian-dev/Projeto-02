namespace Projeto_02
{
    partial class FormEditarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarFuncionario));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditarFuncionario = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnExcluirFuncionario = new System.Windows.Forms.Button();
            this.btnBuscarFuncionarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelSuperior
            // 
            this.panelSuperior.Controls.Add(this.label9);
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Controls.Add(this.btnFechar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(856, 47);
            this.panelSuperior.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(310, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "Atualização de Funcionário";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(766, 7);
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
            this.btnFechar.Location = new System.Drawing.Point(808, 7);
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
            this.label8.Location = new System.Drawing.Point(796, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 38);
            this.label8.TabIndex = 18;
            this.label8.Text = "EF";
            // 
            // btnEditarFuncionario
            // 
            this.btnEditarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarFuncionario.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFuncionario.Location = new System.Drawing.Point(612, 244);
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.Size = new System.Drawing.Size(108, 65);
            this.btnEditarFuncionario.TabIndex = 33;
            this.btnEditarFuncionario.Text = "Atualizar Funcionário";
            this.btnEditarFuncionario.UseVisualStyleBackColor = true;
            this.btnEditarFuncionario.Click += new System.EventHandler(this.btnEditarFuncionario_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(609, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "CPF:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(609, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Sexo:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(609, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Cargo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Senha:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "CPF:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Prefiro Não Responder"});
            this.cboSexo.Location = new System.Drawing.Point(612, 151);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(230, 21);
            this.cboSexo.TabIndex = 25;
            // 
            // cboCargo
            // 
            this.cboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Pedagogo(a)",
            "Coordenador(a)",
            "Secretário(a)",
            "Bibliotecário(a)",
            "Auxiliar de Serviços Gerais"});
            this.cboCargo.Location = new System.Drawing.Point(612, 93);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(230, 21);
            this.cboCargo.TabIndex = 24;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(612, 210);
            this.mskTelefone.Mask = "(99) 99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(230, 20);
            this.mskTelefone.TabIndex = 23;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(356, 268);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(230, 20);
            this.txtSenha.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(356, 210);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(356, 94);
            this.mskCpf.Mask = "999.999.999-99";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(230, 20);
            this.mskCpf.TabIndex = 20;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(356, 152);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 20);
            this.txtNome.TabIndex = 19;
            // 
            // btnExcluirFuncionario
            // 
            this.btnExcluirFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirFuncionario.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFuncionario.Location = new System.Drawing.Point(726, 244);
            this.btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            this.btnExcluirFuncionario.Size = new System.Drawing.Size(108, 65);
            this.btnExcluirFuncionario.TabIndex = 34;
            this.btnExcluirFuncionario.Text = "Excluir Funcionário";
            this.btnExcluirFuncionario.UseVisualStyleBackColor = true;
            this.btnExcluirFuncionario.Click += new System.EventHandler(this.btnExcluirFuncionario_Click);
            // 
            // btnBuscarFuncionarios
            // 
            this.btnBuscarFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFuncionarios.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFuncionarios.Location = new System.Drawing.Point(12, 324);
            this.btnBuscarFuncionarios.Name = "btnBuscarFuncionarios";
            this.btnBuscarFuncionarios.Size = new System.Drawing.Size(153, 38);
            this.btnBuscarFuncionarios.TabIndex = 51;
            this.btnBuscarFuncionarios.Text = "Buscar Funcionarios";
            this.btnBuscarFuncionarios.UseVisualStyleBackColor = true;
            this.btnBuscarFuncionarios.Click += new System.EventHandler(this.btnBuscarFuncionarios_Click);
            // 
            // FormEditarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(856, 374);
            this.Controls.Add(this.btnBuscarFuncionarios);
            this.Controls.Add(this.btnExcluirFuncionario);
            this.Controls.Add(this.btnEditarFuncionario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditarFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditarFuncionario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnExcluirFuncionario;
        private System.Windows.Forms.Button btnBuscarFuncionarios;
    }
}