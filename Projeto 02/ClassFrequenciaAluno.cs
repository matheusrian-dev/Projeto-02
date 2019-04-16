using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_02
{
    class ClassFrequenciaAluno
    {
        public int CodFrequencia { get; set; }
        public DateTime DataAula { get; set; }
        public int CodAluno { get; set; }
        public string StatusFrequencia { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public void InserirFrequencia()
        {
            bd.Conectar();
            string dataAulaHoje = DataAula.ToString("yyyy-MM-dd");
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Frequencia WHERE Aluno_codAluno = " + CodAluno + " AND dataAula = '" + dataAulaHoje + "'"));
            if (dt.Rows.Count == 0)
            {
                bd.ExecutarComandosSql(String.Format("INSERT INTO Frequencia VALUES " + CodAluno + ",'" + dataAulaHoje + "', '" + StatusFrequencia + "'"));
                MessageBox.Show("Frequência Lançada com Sucesso!");
                bd.Desconectar();
            }
            else
            {
                bd.ExecutarComandosSql(String.Format(" UPDATE Nota SET statusFrequencia" + StatusFrequencia + "' WHERE Aluno_codAluno = "+CodAluno+" AND dataAula = '"+dataAulaHoje+"'"));
                MessageBox.Show("Frequencia Atualizada com Sucesso!");
                bd.Desconectar();
            }


        }
    }
}
