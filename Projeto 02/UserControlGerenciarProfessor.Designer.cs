namespace Projeto_02
{
    partial class UserControlGerenciarProfessor
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
            this.btnGerenciarProfessor = new System.Windows.Forms.Button();
            this.btnRegistrarProfessor = new System.Windows.Forms.Button();
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
            this.label8.TabIndex = 18;
            this.label8.Text = "EF";
            // 
            // btnGerenciarProfessor
            // 
            this.btnGerenciarProfessor.FlatAppearance.BorderSize = 2;
            this.btnGerenciarProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarProfessor.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarProfessor.Location = new System.Drawing.Point(396, 157);
            this.btnGerenciarProfessor.Name = "btnGerenciarProfessor";
            this.btnGerenciarProfessor.Size = new System.Drawing.Size(127, 68);
            this.btnGerenciarProfessor.TabIndex = 16;
            this.btnGerenciarProfessor.Text = "Gerenciar Professor(a) Existente";
            this.btnGerenciarProfessor.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarProfessor
            // 
            this.btnRegistrarProfessor.FlatAppearance.BorderSize = 2;
            this.btnRegistrarProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarProfessor.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProfessor.Location = new System.Drawing.Point(188, 157);
            this.btnRegistrarProfessor.Name = "btnRegistrarProfessor";
            this.btnRegistrarProfessor.Size = new System.Drawing.Size(127, 68);
            this.btnRegistrarProfessor.TabIndex = 15;
            this.btnRegistrarProfessor.Text = "Registrar Professor(a)";
            this.btnRegistrarProfessor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gerenciamento de Professores";
            // 
            // UserControlGerenciarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGerenciarProfessor);
            this.Controls.Add(this.btnRegistrarProfessor);
            this.Controls.Add(this.label1);
            this.Name = "UserControlGerenciarProfessor";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGerenciarProfessor;
        private System.Windows.Forms.Button btnRegistrarProfessor;
        private System.Windows.Forms.Label label1;
    }
}
