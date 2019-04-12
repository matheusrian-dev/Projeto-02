namespace Projeto_02
{
    partial class UserControlRelatorioFrequenciaProfessor
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
            this.btnEmitirRelatorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeProfessorDesejado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.label8.TabIndex = 34;
            this.label8.Text = "EF";
            // 
            // btnEmitirRelatorio
            // 
            this.btnEmitirRelatorio.FlatAppearance.BorderSize = 2;
            this.btnEmitirRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitirRelatorio.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitirRelatorio.Location = new System.Drawing.Point(480, 268);
            this.btnEmitirRelatorio.Name = "btnEmitirRelatorio";
            this.btnEmitirRelatorio.Size = new System.Drawing.Size(89, 51);
            this.btnEmitirRelatorio.TabIndex = 31;
            this.btnEmitirRelatorio.Text = "Emitir Relatório";
            this.btnEmitirRelatorio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "Relatório de Frequência do Professor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomeProfessorDesejado
            // 
            this.txtNomeProfessorDesejado.Location = new System.Drawing.Point(146, 284);
            this.txtNomeProfessorDesejado.Name = "txtNomeProfessorDesejado";
            this.txtNomeProfessorDesejado.Size = new System.Drawing.Size(291, 20);
            this.txtNomeProfessorDesejado.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nome do(a) Professor(a):";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(3, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(704, 212);
            this.reportViewer1.TabIndex = 53;
            // 
            // UserControlRelatorioFrequenciaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeProfessorDesejado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEmitirRelatorio);
            this.Controls.Add(this.label1);
            this.Name = "UserControlRelatorioFrequenciaProfessor";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEmitirRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeProfessorDesejado;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
