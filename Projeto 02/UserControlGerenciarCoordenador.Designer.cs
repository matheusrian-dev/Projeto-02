namespace Projeto_02
{
    partial class UserControlGerenciarCoordenador
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
            this.btnGerenciarCurso = new System.Windows.Forms.Button();
            this.btnRegistrarCUrso = new System.Windows.Forms.Button();
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
            this.label8.TabIndex = 10;
            this.label8.Text = "EF";
            // 
            // btnGerenciarCurso
            // 
            this.btnGerenciarCurso.FlatAppearance.BorderSize = 2;
            this.btnGerenciarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarCurso.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarCurso.Location = new System.Drawing.Point(412, 156);
            this.btnGerenciarCurso.Name = "btnGerenciarCurso";
            this.btnGerenciarCurso.Size = new System.Drawing.Size(139, 69);
            this.btnGerenciarCurso.TabIndex = 8;
            this.btnGerenciarCurso.Text = "Gerenciar Coordenador Existente";
            this.btnGerenciarCurso.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarCUrso
            // 
            this.btnRegistrarCUrso.FlatAppearance.BorderSize = 2;
            this.btnRegistrarCUrso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCUrso.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCUrso.Location = new System.Drawing.Point(204, 156);
            this.btnRegistrarCUrso.Name = "btnRegistrarCUrso";
            this.btnRegistrarCUrso.Size = new System.Drawing.Size(135, 69);
            this.btnRegistrarCUrso.TabIndex = 7;
            this.btnRegistrarCUrso.Text = "Registrar Coordenador(a)";
            this.btnRegistrarCUrso.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gerenciamento de Coordenadores";
            // 
            // UserControlCoordenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGerenciarCurso);
            this.Controls.Add(this.btnRegistrarCUrso);
            this.Controls.Add(this.label1);
            this.Name = "UserControlCoordenador";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGerenciarCurso;
        private System.Windows.Forms.Button btnRegistrarCUrso;
        private System.Windows.Forms.Label label1;
    }
}
