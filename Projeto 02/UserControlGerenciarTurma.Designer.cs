namespace Projeto_02
{
    partial class UserControlGerenciarTurma
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
            this.btnGerenciarTurma = new System.Windows.Forms.Button();
            this.btnRegistrarTurma = new System.Windows.Forms.Button();
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
            this.label8.TabIndex = 26;
            this.label8.Text = "EF";
            // 
            // btnGerenciarTurma
            // 
            this.btnGerenciarTurma.FlatAppearance.BorderSize = 2;
            this.btnGerenciarTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarTurma.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarTurma.Location = new System.Drawing.Point(394, 149);
            this.btnGerenciarTurma.Name = "btnGerenciarTurma";
            this.btnGerenciarTurma.Size = new System.Drawing.Size(127, 68);
            this.btnGerenciarTurma.TabIndex = 24;
            this.btnGerenciarTurma.Text = "Gerenciar Turma Existente";
            this.btnGerenciarTurma.UseVisualStyleBackColor = true;
            this.btnGerenciarTurma.Click += new System.EventHandler(this.btnGerenciarTurma_Click);
            // 
            // btnRegistrarTurma
            // 
            this.btnRegistrarTurma.FlatAppearance.BorderSize = 2;
            this.btnRegistrarTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarTurma.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarTurma.Location = new System.Drawing.Point(186, 149);
            this.btnRegistrarTurma.Name = "btnRegistrarTurma";
            this.btnRegistrarTurma.Size = new System.Drawing.Size(127, 68);
            this.btnRegistrarTurma.TabIndex = 23;
            this.btnRegistrarTurma.Text = "Registrar Turma";
            this.btnRegistrarTurma.UseVisualStyleBackColor = true;
            this.btnRegistrarTurma.Click += new System.EventHandler(this.btnRegistrarTurma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "Gerenciamento de Turmas";
            // 
            // UserControlGerenciarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGerenciarTurma);
            this.Controls.Add(this.btnRegistrarTurma);
            this.Controls.Add(this.label1);
            this.Name = "UserControlGerenciarTurma";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGerenciarTurma;
        private System.Windows.Forms.Button btnRegistrarTurma;
        private System.Windows.Forms.Label label1;
    }
}
