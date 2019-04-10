namespace Projeto_02
{
    partial class UserControlGerenciarSecretario
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
            this.btnGerenciarPedagogo = new System.Windows.Forms.Button();
            this.btnRegistrarSecretario = new System.Windows.Forms.Button();
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
            // btnGerenciarPedagogo
            // 
            this.btnGerenciarPedagogo.FlatAppearance.BorderSize = 2;
            this.btnGerenciarPedagogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarPedagogo.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarPedagogo.Location = new System.Drawing.Point(412, 156);
            this.btnGerenciarPedagogo.Name = "btnGerenciarPedagogo";
            this.btnGerenciarPedagogo.Size = new System.Drawing.Size(127, 68);
            this.btnGerenciarPedagogo.TabIndex = 12;
            this.btnGerenciarPedagogo.Text = "Gerenciar Secretário(a) Existente";
            this.btnGerenciarPedagogo.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarSecretario
            // 
            this.btnRegistrarSecretario.FlatAppearance.BorderSize = 2;
            this.btnRegistrarSecretario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarSecretario.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarSecretario.Location = new System.Drawing.Point(204, 156);
            this.btnRegistrarSecretario.Name = "btnRegistrarSecretario";
            this.btnRegistrarSecretario.Size = new System.Drawing.Size(127, 68);
            this.btnRegistrarSecretario.TabIndex = 11;
            this.btnRegistrarSecretario.Text = "Registrar Secretário(a)";
            this.btnRegistrarSecretario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gerenciamento de Secretários";
            // 
            // UserControlGerenciarSecretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGerenciarPedagogo);
            this.Controls.Add(this.btnRegistrarSecretario);
            this.Controls.Add(this.label1);
            this.Name = "UserControlGerenciarSecretario";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGerenciarPedagogo;
        private System.Windows.Forms.Button btnRegistrarSecretario;
        private System.Windows.Forms.Label label1;
    }
}
