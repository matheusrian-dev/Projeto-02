namespace Projeto_02
{
    partial class UserControlGerenciarBibliotecario
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
            this.btnGerenciarBibliotecario = new System.Windows.Forms.Button();
            this.btnRegistrarBibliotecario = new System.Windows.Forms.Button();
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
            this.label8.TabIndex = 18;
            this.label8.Text = "EF";
            // 
            // btnGerenciarBibliotecario
            // 
            this.btnGerenciarBibliotecario.FlatAppearance.BorderSize = 2;
            this.btnGerenciarBibliotecario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarBibliotecario.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarBibliotecario.Location = new System.Drawing.Point(412, 156);
            this.btnGerenciarBibliotecario.Name = "btnGerenciarBibliotecario";
            this.btnGerenciarBibliotecario.Size = new System.Drawing.Size(127, 68);
            this.btnGerenciarBibliotecario.TabIndex = 16;
            this.btnGerenciarBibliotecario.Text = "Gerenciar Bibliotecário(a) Existente";
            this.btnGerenciarBibliotecario.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarBibliotecario
            // 
            this.btnRegistrarBibliotecario.FlatAppearance.BorderSize = 2;
            this.btnRegistrarBibliotecario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarBibliotecario.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarBibliotecario.Location = new System.Drawing.Point(204, 156);
            this.btnRegistrarBibliotecario.Name = "btnRegistrarBibliotecario";
            this.btnRegistrarBibliotecario.Size = new System.Drawing.Size(127, 68);
            this.btnRegistrarBibliotecario.TabIndex = 15;
            this.btnRegistrarBibliotecario.Text = "Registrar Bibliotecário(a)";
            this.btnRegistrarBibliotecario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gerenciamento de Bibliotecários";
            // 
            // UserControlGerenciarBibliotecario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGerenciarBibliotecario);
            this.Controls.Add(this.btnRegistrarBibliotecario);
            this.Controls.Add(this.label1);
            this.Name = "UserControlGerenciarBibliotecario";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGerenciarBibliotecario;
        private System.Windows.Forms.Button btnRegistrarBibliotecario;
        private System.Windows.Forms.Label label1;
    }
}
