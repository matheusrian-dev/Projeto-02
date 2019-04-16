using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_02
{
    public partial class UserControlLancarFrequenciaAluno : UserControl
    {
        ClassFrequenciaAluno frequencia = new ClassFrequenciaAluno();
        ClassAluno aluno = new ClassAluno();

        public UserControlLancarFrequenciaAluno()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            aluno.Turma_CodTurma = int.Parse(txtCodTurma.Text);
            dataGridView1.DataSource = aluno.MostrarAlunosTurma();
        }

        private void btnLancarFrequenciaAluno_Click(object sender, EventArgs e)
        {
            frequencia.CodAluno = int.Parse(txtCodAluno.Text);
            frequencia.DataAula = DateTime.Parse(dtpDataHoje.Text);
            frequencia.StatusFrequencia = cboStatus.Text;
            frequencia.InserirFrequencia();
        }
    }
}
