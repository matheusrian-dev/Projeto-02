namespace Projeto_02
{
    partial class UserControlLancarNota
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
            this.btnEditarNotaAluno = new System.Windows.Forms.Button();
            this.btnLancarNotaAluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditarNotaAluno
            // 
            this.btnEditarNotaAluno.FlatAppearance.BorderSize = 2;
            this.btnEditarNotaAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarNotaAluno.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarNotaAluno.Location = new System.Drawing.Point(524, 258);
            this.btnEditarNotaAluno.Name = "btnEditarNotaAluno";
            this.btnEditarNotaAluno.Size = new System.Drawing.Size(127, 68);
            this.btnEditarNotaAluno.TabIndex = 42;
            this.btnEditarNotaAluno.Text = "Editar Nota do Aluno";
            this.btnEditarNotaAluno.UseVisualStyleBackColor = true;
            // 
            // btnLancarNotaAluno
            // 
            this.btnLancarNotaAluno.FlatAppearance.BorderSize = 2;
            this.btnLancarNotaAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancarNotaAluno.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancarNotaAluno.Location = new System.Drawing.Point(391, 258);
            this.btnLancarNotaAluno.Name = "btnLancarNotaAluno";
            this.btnLancarNotaAluno.Size = new System.Drawing.Size(127, 68);
            this.btnLancarNotaAluno.TabIndex = 41;
            this.btnLancarNotaAluno.Text = "Lançar Nota do Aluno";
            this.btnLancarNotaAluno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 37);
            this.label1.TabIndex = 40;
            this.label1.Text = "Lançamento da Nota do Aluno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(659, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 30);
            this.label8.TabIndex = 39;
            this.label8.Text = "EF";
            // 
            // UserControlLancarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btnEditarNotaAluno);
            this.Controls.Add(this.btnLancarNotaAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "UserControlLancarNota";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarNotaAluno;
        private System.Windows.Forms.Button btnLancarNotaAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}
