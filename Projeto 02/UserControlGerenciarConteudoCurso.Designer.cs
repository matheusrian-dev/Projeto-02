namespace Projeto_02
{
    partial class UserControlGerenciarConteudoCurso
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
            this.btnGerenciarConteudoCurso = new System.Windows.Forms.Button();
            this.btnRegistrarConteudoCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(661, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 30);
            this.label8.TabIndex = 22;
            this.label8.Text = "EF";
            // 
            // btnGerenciarConteudoCurso
            // 
            this.btnGerenciarConteudoCurso.FlatAppearance.BorderSize = 2;
            this.btnGerenciarConteudoCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarConteudoCurso.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarConteudoCurso.Location = new System.Drawing.Point(399, 159);
            this.btnGerenciarConteudoCurso.Name = "btnGerenciarConteudoCurso";
            this.btnGerenciarConteudoCurso.Size = new System.Drawing.Size(127, 68);
            this.btnGerenciarConteudoCurso.TabIndex = 20;
            this.btnGerenciarConteudoCurso.Text = "Gerenciar Conteúdo do Curso Existente";
            this.btnGerenciarConteudoCurso.UseVisualStyleBackColor = true;
            this.btnGerenciarConteudoCurso.Click += new System.EventHandler(this.btnGerenciarConteudoCurso_Click);
            // 
            // btnRegistrarConteudoCurso
            // 
            this.btnRegistrarConteudoCurso.FlatAppearance.BorderSize = 2;
            this.btnRegistrarConteudoCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarConteudoCurso.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarConteudoCurso.Location = new System.Drawing.Point(191, 159);
            this.btnRegistrarConteudoCurso.Name = "btnRegistrarConteudoCurso";
            this.btnRegistrarConteudoCurso.Size = new System.Drawing.Size(127, 68);
            this.btnRegistrarConteudoCurso.TabIndex = 19;
            this.btnRegistrarConteudoCurso.Text = "Registrar Conteúdo do Curso";
            this.btnRegistrarConteudoCurso.UseVisualStyleBackColor = true;
            this.btnRegistrarConteudoCurso.Click += new System.EventHandler(this.btnRegistrarConteudoCurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 74);
            this.label1.TabIndex = 21;
            this.label1.Text = "Gerenciamento do Conteúdo\r\ndo Curso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlGerenciarConteudoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGerenciarConteudoCurso);
            this.Controls.Add(this.btnRegistrarConteudoCurso);
            this.Controls.Add(this.label1);
            this.Name = "UserControlGerenciarConteudoCurso";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGerenciarConteudoCurso;
        private System.Windows.Forms.Button btnRegistrarConteudoCurso;
        private System.Windows.Forms.Label label1;
    }
}
