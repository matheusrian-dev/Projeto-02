namespace Projeto_02
{
    partial class UserControlLancarDistribuicaoPontos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerenciarDistribuicaoPontos = new System.Windows.Forms.Button();
            this.btnRegistrarDistribuicaoPontos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(659, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 30);
            this.label8.TabIndex = 31;
            this.label8.Text = "EF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 37);
            this.label1.TabIndex = 32;
            this.label1.Text = "Distribuição de Pontos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGerenciarDistribuicaoPontos
            // 
            this.btnGerenciarDistribuicaoPontos.FlatAppearance.BorderSize = 2;
            this.btnGerenciarDistribuicaoPontos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarDistribuicaoPontos.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarDistribuicaoPontos.Location = new System.Drawing.Point(524, 258);
            this.btnGerenciarDistribuicaoPontos.Name = "btnGerenciarDistribuicaoPontos";
            this.btnGerenciarDistribuicaoPontos.Size = new System.Drawing.Size(127, 68);
            this.btnGerenciarDistribuicaoPontos.TabIndex = 34;
            this.btnGerenciarDistribuicaoPontos.Text = "Atualizar Distribuição de Pontos";
            this.btnGerenciarDistribuicaoPontos.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarDistribuicaoPontos
            // 
            this.btnRegistrarDistribuicaoPontos.FlatAppearance.BorderSize = 2;
            this.btnRegistrarDistribuicaoPontos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarDistribuicaoPontos.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarDistribuicaoPontos.Location = new System.Drawing.Point(391, 258);
            this.btnRegistrarDistribuicaoPontos.Name = "btnRegistrarDistribuicaoPontos";
            this.btnRegistrarDistribuicaoPontos.Size = new System.Drawing.Size(127, 68);
            this.btnRegistrarDistribuicaoPontos.TabIndex = 33;
            this.btnRegistrarDistribuicaoPontos.Text = "Registrar Distribuição de Pontos";
            this.btnRegistrarDistribuicaoPontos.UseVisualStyleBackColor = true;
            // 
            // UserControlLancarDistribuicaoPontos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btnGerenciarDistribuicaoPontos);
            this.Controls.Add(this.btnRegistrarDistribuicaoPontos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "UserControlLancarDistribuicaoPontos";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerenciarDistribuicaoPontos;
        private System.Windows.Forms.Button btnRegistrarDistribuicaoPontos;
    }
}
