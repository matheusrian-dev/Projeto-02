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

        public bool InserirTurmas()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Turma VALUES '"+Nome+"', "+Curso_CodCurso+",'"+NomeInstrutor+"'"));
                bd.Desconectar();
                MessageBox.Show("Turma Cadastrada com Sucesso!");
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool EditarTurma()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format(" UPDATE Turma SET " + " Nome = '" + Nome + "', Curso_codCurso = "+ Curso_CodCurso + ", nomeInstrutor = '" + NomeInstrutor + " WHERE codTurma LIKE " + CodTurma));
                bd.Desconectar();
                MessageBox.Show("Turma Atualizada com Sucesso!");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ExcluirTurma()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM Turma WHERE  CodTurma = " + CodTurma + ""));
                bd.Desconectar();
                MessageBox.Show("Turma Excluida com Sucesso!");
                return true;
            }
            catch
            {
                return false;
            }
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
