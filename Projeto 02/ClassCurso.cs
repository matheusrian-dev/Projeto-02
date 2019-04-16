using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_02
{
    class ClassCurso
    {
        public int CodCurso { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool CadastrarCurso()
        {
            try
            {
                //Conectar no Banco
                bd.Conectar();

                //Executar o Insert
                bd.ExecutarComandosSql(String.Format("INSERT INTO Curso(nomeCurso, cargaHoraria)" +
                    " VALUES ('" + Nome + "', " + CargaHoraria + ")"));

                //Desconectar
                bd.Desconectar();
                MessageBox.Show("Curso Cadastrado com Sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message +
                     "Erro ao inserir o Curso.");

            }
        }

        public bool EditarCurso(int codCurso)
        {
            try
            {
                //Conectar no Banco
                bd.Conectar();

                //Executar o Insert
                bd.ExecutarComandosSql(String.Format("Update Curso SET " +
                    " nomeCurso = '" + Nome + "', cargaHoraria = " + CargaHoraria + " " +
                    " WHERE codCurso LIKE " + codCurso));

                //Desconectar
                bd.Desconectar();
                MessageBox.Show("Curso Atualizado com Sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message +
                     "Erro ao editar o Curso");

            }
        }

        public bool ExcluirCurso(int codCurso)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM Curso" +
                    " WHERE codCurso = " + codCurso + ""));
                MessageBox.Show("Curso Excluido com Sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message +
                " Erro ao excluir o Curso");

            }
        }

        public DataTable MostrarCursos()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Cursos"));
            bd.Desconectar();
            return dt;
        }
    }
}
