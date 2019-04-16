using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_02
{
    class ClassTurma
    {
        public int CodTurma { get; set; }
        public string Nome { get; set; }
        public int Curso_CodCurso { get; set; }
        public string NomeInstrutor { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public void InserirTurmas()
        {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Turma(nomeTurma, nomeInstrutor, Curso_codCurso) VALUES ('"+Nome+"','"+NomeInstrutor+ "', " + Curso_CodCurso + ")"));
                bd.Desconectar();
                MessageBox.Show("Turma Cadastrada com Sucesso!");
            
        }


        public void EditarTurma()
        {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format(" UPDATE Turma SET " + " nomeTurma = '" + Nome + "', nomeInstrutor = '" + NomeInstrutor + "', Curso_codCurso = " + Curso_CodCurso + " WHERE codTurma LIKE " + CodTurma));
                bd.Desconectar();
                MessageBox.Show("Turma Atualizada com Sucesso!");
            
        }

        public void ExcluirTurma(int codTurma)
        {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM Turma WHERE codTurma = " + codTurma + ""));
                bd.Desconectar();
                MessageBox.Show("Turma Excluida com Sucesso!");
            
        }

        public DataTable MostrarTurma()
        {
                bd.Conectar();
                DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Turma"));
                bd.Desconectar();
                return dt;
        }
    }
}
