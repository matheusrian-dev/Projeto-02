namespace Projeto_02
{
    partial class UserControlGerenciarAluno
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.btnGerenciarAluno = new System.Windows.Forms.Button();
            this.btnRegistrarAluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(662, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 30);
            this.label8.TabIndex = 22;
            this.label8.Text = "EF";
            // 
            // btnGerenciarAluno
            // 
            this.btnGerenciarAluno.FlatAppearance.BorderSize = 2;
            this.btnGerenciarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarAluno.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarAluno.Location = new System.Drawing.Point(396, 149);
            this.btnGerenciarAluno.Name = "btnGerenciarAluno";
            this.btnGerenciarAluno.Size = new System.Drawing.Size(127, 68);
            this.btnGerenciarAluno.TabIndex = 20;
            this.btnGerenciarAluno.Text = "Gerenciar Aluno(a) Existente";
            this.btnGerenciarAluno.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarAluno
            // 
            this.btnRegistrarAluno.FlatAppearance.BorderSize = 2;
            this.btnRegistrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarAluno.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAluno.Location = new System.Drawing.Point(188, 149);
            this.btnRegistrarAluno.Name = "btnRegistrarAluno";
            this.btnRegistrarAluno.Size = new System.Drawing.Size(127, 68);
            this.btnRegistrarAluno.TabIndex = 19;
            this.btnRegistrarAluno.Text = "Registrar Aluno(a)";
            this.btnRegistrarAluno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Gerenciamento de Alunos";
            // 
            // UserControlGerenciarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGerenciarAluno);
            this.Controls.Add(this.btnRegistrarAluno);
            this.Controls.Add(this.label1);
            this.Name = "UserControlGerenciarAluno";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGerenciarAluno;
        private System.Windows.Forms.Button btnRegistrarAluno;
        private System.Windows.Forms.Label label1;
    }
}
