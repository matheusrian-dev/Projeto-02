namespace Projeto_02
{
    partial class UserControlLancarPlanoAula
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
            this.btnAtualizarPlanoAula = new System.Windows.Forms.Button();
            this.btnLancarPlanoAula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAtualizarPlanoAula
            // 
            this.btnAtualizarPlanoAula.FlatAppearance.BorderSize = 2;
            this.btnAtualizarPlanoAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarPlanoAula.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarPlanoAula.Location = new System.Drawing.Point(423, 149);
            this.btnAtualizarPlanoAula.Name = "btnAtualizarPlanoAula";
            this.btnAtualizarPlanoAula.Size = new System.Drawing.Size(127, 68);
            this.btnAtualizarPlanoAula.TabIndex = 42;
            this.btnAtualizarPlanoAula.Text = "Atualizar Plano de Aula";
            this.btnAtualizarPlanoAula.UseVisualStyleBackColor = true;
            this.btnAtualizarPlanoAula.Click += new System.EventHandler(this.btnAtualizarPlanoAula_Click);
            // 
            // btnLancarPlanoAula
            // 
            this.btnLancarPlanoAula.FlatAppearance.BorderSize = 2;
            this.btnLancarPlanoAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancarPlanoAula.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancarPlanoAula.Location = new System.Drawing.Point(168, 149);
            this.btnLancarPlanoAula.Name = "btnLancarPlanoAula";
            this.btnLancarPlanoAula.Size = new System.Drawing.Size(127, 68);
            this.btnLancarPlanoAula.TabIndex = 41;
            this.btnLancarPlanoAula.Text = "Lançar Plano de Aula";
            this.btnLancarPlanoAula.UseVisualStyleBackColor = true;
            this.btnLancarPlanoAula.Click += new System.EventHandler(this.btnLancarPlanoAula_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 37);
            this.label1.TabIndex = 40;
            this.label1.Text = "Lançamento do Plano de Aula";
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
            // UserControlLancarPlanoAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btnAtualizarPlanoAula);
            this.Controls.Add(this.btnLancarPlanoAula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "UserControlLancarPlanoAula";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizarPlanoAula;
        private System.Windows.Forms.Button btnLancarPlanoAula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}
