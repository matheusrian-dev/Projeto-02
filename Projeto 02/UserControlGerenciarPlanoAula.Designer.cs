namespace Projeto_02
{
    partial class UserControlGerenciarPlanoAula
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
            this.btnGerenciarPlanoAula = new System.Windows.Forms.Button();
            this.btnRegistrarPlanoAula = new System.Windows.Forms.Button();
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
            this.label8.TabIndex = 30;
            this.label8.Text = "EF";
            // 
            // btnGerenciarPlanoAula
            // 
            this.btnGerenciarPlanoAula.FlatAppearance.BorderSize = 2;
            this.btnGerenciarPlanoAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarPlanoAula.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarPlanoAula.Location = new System.Drawing.Point(396, 161);
            this.btnGerenciarPlanoAula.Name = "btnGerenciarPlanoAula";
            this.btnGerenciarPlanoAula.Size = new System.Drawing.Size(127, 68);
            this.btnGerenciarPlanoAula.TabIndex = 28;
            this.btnGerenciarPlanoAula.Text = "Gerenciar Plano de Aula Existente";
            this.btnGerenciarPlanoAula.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarPlanoAula
            // 
            this.btnRegistrarPlanoAula.FlatAppearance.BorderSize = 2;
            this.btnRegistrarPlanoAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPlanoAula.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPlanoAula.Location = new System.Drawing.Point(188, 161);
            this.btnRegistrarPlanoAula.Name = "btnRegistrarPlanoAula";
            this.btnRegistrarPlanoAula.Size = new System.Drawing.Size(127, 68);
            this.btnRegistrarPlanoAula.TabIndex = 27;
            this.btnRegistrarPlanoAula.Text = "Registrar Plano de Aula";
            this.btnRegistrarPlanoAula.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 74);
            this.label1.TabIndex = 29;
            this.label1.Text = "Gerenciamento do Plano \r\nde Aula";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlGerenciarPlanoAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGerenciarPlanoAula);
            this.Controls.Add(this.btnRegistrarPlanoAula);
            this.Controls.Add(this.label1);
            this.Name = "UserControlGerenciarPlanoAula";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGerenciarPlanoAula;
        private System.Windows.Forms.Button btnRegistrarPlanoAula;
        private System.Windows.Forms.Label label1;
    }
}
