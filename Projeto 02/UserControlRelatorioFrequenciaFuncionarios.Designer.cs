namespace Projeto_02
{
    partial class UserControlRelatorioFrequenciaFuncionarios
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
            this.btnEmitirFrequenciaFuncionario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(664, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "EF";
            // 
            // btnEmitirFrequenciaFuncionario
            // 
            this.btnEmitirFrequenciaFuncionario.FlatAppearance.BorderSize = 2;
            this.btnEmitirFrequenciaFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitirFrequenciaFuncionario.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitirFrequenciaFuncionario.Location = new System.Drawing.Point(292, 289);
            this.btnEmitirFrequenciaFuncionario.Name = "btnEmitirFrequenciaFuncionario";
            this.btnEmitirFrequenciaFuncionario.Size = new System.Drawing.Size(127, 57);
            this.btnEmitirFrequenciaFuncionario.TabIndex = 24;
            this.btnEmitirFrequenciaFuncionario.Text = "Emitir Frequência dos Funcionários";
            this.btnEmitirFrequenciaFuncionario.UseVisualStyleBackColor = true;
            this.btnEmitirFrequenciaFuncionario.Click += new System.EventHandler(this.btnRegistrarAuxiliar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "Relatório de Frequência dos Funcionários";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(3, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(704, 233);
            this.reportViewer1.TabIndex = 53;
            // 
            // UserControlRelatorioFrequenciaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmitirFrequenciaFuncionario);
            this.Controls.Add(this.label8);
            this.Name = "UserControlRelatorioFrequenciaFuncionarios";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEmitirFrequenciaFuncionario;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
