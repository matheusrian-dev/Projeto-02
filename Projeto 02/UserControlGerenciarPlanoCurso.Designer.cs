namespace Projeto_02
{
    partial class UserControlGerenciarPlanoCurso
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
            this.btnGerenciarPlanoCurso = new System.Windows.Forms.Button();
            this.btnRegistrarPlanoCurso = new System.Windows.Forms.Button();
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
            this.label8.TabIndex = 26;
            this.label8.Text = "EF";
            // 
            // btnGerenciarPlanoCurso
            // 
            this.btnGerenciarPlanoCurso.FlatAppearance.BorderSize = 2;
            this.btnGerenciarPlanoCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarPlanoCurso.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarPlanoCurso.Location = new System.Drawing.Point(396, 160);
            this.btnGerenciarPlanoCurso.Name = "btnGerenciarPlanoCurso";
            this.btnGerenciarPlanoCurso.Size = new System.Drawing.Size(127, 68);
            this.btnGerenciarPlanoCurso.TabIndex = 24;
            this.btnGerenciarPlanoCurso.Text = "Gerenciar Plano do Curso Existente";
            this.btnGerenciarPlanoCurso.UseVisualStyleBackColor = true;
            this.btnGerenciarPlanoCurso.Click += new System.EventHandler(this.btnGerenciarPlanoCurso_Click);
            // 
            // btnRegistrarPlanoCurso
            // 
            this.btnRegistrarPlanoCurso.FlatAppearance.BorderSize = 2;
            this.btnRegistrarPlanoCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPlanoCurso.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPlanoCurso.Location = new System.Drawing.Point(188, 160);
            this.btnRegistrarPlanoCurso.Name = "btnRegistrarPlanoCurso";
            this.btnRegistrarPlanoCurso.Size = new System.Drawing.Size(127, 68);
            this.btnRegistrarPlanoCurso.TabIndex = 23;
            this.btnRegistrarPlanoCurso.Text = "Registrar Plano do Curso";
            this.btnRegistrarPlanoCurso.UseVisualStyleBackColor = true;
            this.btnRegistrarPlanoCurso.Click += new System.EventHandler(this.btnRegistrarPlanoCurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 74);
            this.label1.TabIndex = 25;
            this.label1.Text = "Gerenciamento do Plano \r\ndo Curso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlGerenciarPlanoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGerenciarPlanoCurso);
            this.Controls.Add(this.btnRegistrarPlanoCurso);
            this.Controls.Add(this.label1);
            this.Name = "UserControlGerenciarPlanoCurso";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGerenciarPlanoCurso;
        private System.Windows.Forms.Button btnRegistrarPlanoCurso;
        private System.Windows.Forms.Label label1;
    }
}
