namespace Projeto_02
{
    partial class UserControlGerenciarFuncionario
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
            this.btnGerenciarFuncionario = new System.Windows.Forms.Button();
            this.btnRegistrarSecretarioFuncionario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(658, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "EF";
            // 
            // btnGerenciarFuncionario
            // 
            this.btnGerenciarFuncionario.FlatAppearance.BorderSize = 2;
            this.btnGerenciarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarFuncionario.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarFuncionario.Location = new System.Drawing.Point(396, 156);
            this.btnGerenciarFuncionario.Name = "btnGerenciarFuncionario";
            this.btnGerenciarFuncionario.Size = new System.Drawing.Size(127, 68);
            this.btnGerenciarFuncionario.TabIndex = 12;
            this.btnGerenciarFuncionario.Text = "Gerenciar Funcionário Existente";
            this.btnGerenciarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarSecretarioFuncionario
            // 
            this.btnRegistrarSecretarioFuncionario.FlatAppearance.BorderSize = 2;
            this.btnRegistrarSecretarioFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarSecretarioFuncionario.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarSecretarioFuncionario.Location = new System.Drawing.Point(188, 156);
            this.btnRegistrarSecretarioFuncionario.Name = "btnRegistrarSecretarioFuncionario";
            this.btnRegistrarSecretarioFuncionario.Size = new System.Drawing.Size(127, 68);
            this.btnRegistrarSecretarioFuncionario.TabIndex = 11;
            this.btnRegistrarSecretarioFuncionario.Text = "Registrar Funcionário";
            this.btnRegistrarSecretarioFuncionario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gerenciamento de Funcionários";
            // 
            // UserControlGerenciarSecretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGerenciarFuncionario);
            this.Controls.Add(this.btnRegistrarSecretarioFuncionario);
            this.Controls.Add(this.label1);
            this.Name = "UserControlGerenciarSecretario";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGerenciarFuncionario;
        private System.Windows.Forms.Button btnRegistrarSecretarioFuncionario;
        private System.Windows.Forms.Label label1;
    }
}
