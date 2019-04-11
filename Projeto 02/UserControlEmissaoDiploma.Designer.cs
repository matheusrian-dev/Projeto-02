namespace Projeto_02
{
    partial class UserControlEmissaoDiploma
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeAlunoDesejado = new System.Windows.Forms.TextBox();
            this.btnEmitirDiploma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Nome do(a) Aluno(a):";
            // 
            // txtNomeAlunoDesejado
            // 
            this.txtNomeAlunoDesejado.Location = new System.Drawing.Point(146, 301);
            this.txtNomeAlunoDesejado.Name = "txtNomeAlunoDesejado";
            this.txtNomeAlunoDesejado.Size = new System.Drawing.Size(291, 20);
            this.txtNomeAlunoDesejado.TabIndex = 59;
            // 
            // btnEmitirDiploma
            // 
            this.btnEmitirDiploma.FlatAppearance.BorderSize = 2;
            this.btnEmitirDiploma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitirDiploma.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitirDiploma.Location = new System.Drawing.Point(480, 285);
            this.btnEmitirDiploma.Name = "btnEmitirDiploma";
            this.btnEmitirDiploma.Size = new System.Drawing.Size(89, 51);
            this.btnEmitirDiploma.TabIndex = 57;
            this.btnEmitirDiploma.Text = "Emitir Diploma";
            this.btnEmitirDiploma.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 32);
            this.label1.TabIndex = 58;
            this.label1.Text = "Emissão do Diploma do Aluno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(662, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 30);
            this.label8.TabIndex = 56;
            this.label8.Text = "EF";
            // 
            // UserControlEmissaoDiploma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeAlunoDesejado);
            this.Controls.Add(this.btnEmitirDiploma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "UserControlEmissaoDiploma";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeAlunoDesejado;
        private System.Windows.Forms.Button btnEmitirDiploma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}
