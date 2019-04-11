namespace Projeto_02
{
    partial class UserControlLancarFrequenciaAluno
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
            this.btnEditarFrequenciaAluno = new System.Windows.Forms.Button();
            this.btnLancarFrequenciaAluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditarFrequenciaAluno
            // 
            this.btnEditarFrequenciaAluno.FlatAppearance.BorderSize = 2;
            this.btnEditarFrequenciaAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarFrequenciaAluno.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFrequenciaAluno.Location = new System.Drawing.Point(524, 258);
            this.btnEditarFrequenciaAluno.Name = "btnEditarFrequenciaAluno";
            this.btnEditarFrequenciaAluno.Size = new System.Drawing.Size(127, 68);
            this.btnEditarFrequenciaAluno.TabIndex = 38;
            this.btnEditarFrequenciaAluno.Text = "Editar Frequência do Aluno";
            this.btnEditarFrequenciaAluno.UseVisualStyleBackColor = true;
            // 
            // btnLancarFrequenciaAluno
            // 
            this.btnLancarFrequenciaAluno.FlatAppearance.BorderSize = 2;
            this.btnLancarFrequenciaAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancarFrequenciaAluno.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancarFrequenciaAluno.Location = new System.Drawing.Point(391, 258);
            this.btnLancarFrequenciaAluno.Name = "btnLancarFrequenciaAluno";
            this.btnLancarFrequenciaAluno.Size = new System.Drawing.Size(127, 68);
            this.btnLancarFrequenciaAluno.TabIndex = 37;
            this.btnLancarFrequenciaAluno.Text = "Lançar Frequência do Aluno";
            this.btnLancarFrequenciaAluno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 74);
            this.label1.TabIndex = 36;
            this.label1.Text = "Lançamento da Frequência\r\ndo Aluno";
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
            this.label8.TabIndex = 35;
            this.label8.Text = "EF";
            // 
            // UserControlLancarFrequenciaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btnEditarFrequenciaAluno);
            this.Controls.Add(this.btnLancarFrequenciaAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "UserControlLancarFrequenciaAluno";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarFrequenciaAluno;
        private System.Windows.Forms.Button btnLancarFrequenciaAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}
