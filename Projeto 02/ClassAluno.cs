using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_02
{
    class ClassAluno
    {
        public int CodAluno { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NomeResponsavel { get; set; }
        public string TelefoneContato { get; set; }
        public string Endereco { get; set; }
        public string Turma_CodTurma { get; set; }
        public string Sexo { get; set; }
        public string GrauEscolaridade { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();


        public bool CadastrarAluno()
        {
            try
            {
                //Conectar no Banco
                bd.Conectar();
                string dataNascAlunoShow = DataNascimento.ToString("yyyy-MM-dd");

                //Executar o Insert
                bd.ExecutarComandosSql(String.Format("INSERT INTO Aluno(nomeAluno, dataNascAluno, nomeResponsavel, telefoneAluno, sexoAluno, enderecoAluno, serie)" +
                    " VALUES ('" + Nome + "', '" + dataNascAlunoShow + "', '" + NomeResponsavel + "', '" + TelefoneContato + "', '" + Sexo + "', '" + Endereco + "', '" + GrauEscolaridade + "' )"));

                //Desconectar
                bd.Desconectar();
                MessageBox.Show("Aluno Cadastrado com Sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message +
                     "Erro ao inserir o Aluno.");

            }
        }

        public bool EditarAluno(int codAluno)
        {
            try
            {
                //Conectar no Banco
                bd.Conectar();
                string dataNascAlunoShow = DataNascimento.ToString("yyyy-MM-dd");

                //Executar o Insert
                bd.ExecutarComandosSql(String.Format("Update Aluno SET " +
                    " nomeAluno = '" + Nome + "', dataNascAluno = '" + dataNascAlunoShow + "', nomeResponsavel = '" + NomeResponsavel + "', telefoneAluno = '" + TelefoneContato + "', sexoAluno = '" + Sexo + "', enderecoAluno = '" + Endereco + "', serie = '" + GrauEscolaridade + "', Turma_codTurma = " + Turma_CodTurma + "" +
                    " WHERE codAluno LIKE " + codAluno));

                //Desconectar
                bd.Desconectar();
                MessageBox.Show("Cadastro do Aluno Atualizado com Sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message +
                     "Erro ao inserir o Aluno.");

            }
        }

        public bool EnturmarAluno(int codAluno)
        {
            try
            {
                //Conectar no Banco
                bd.Conectar();


                //Executar o Insert
                bd.ExecutarComandosSql(String.Format("Update Aluno SET " +
                    " Turma_codTurma = " + Turma_CodTurma + "" +
                    " WHERE codAluno LIKE " + codAluno));
                MessageBox.Show("Aluno Inserido na Turma com Sucesso!");
                //Desconectar
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message +
                     "Erro ao enturmar o Aluno.");

            }
        }

        public bool ExcluirAluno(int codAluno)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM Aluno" +
                    " WHERE codAluno = " + codAluno + ""));
                
                MessageBox.Show("Aluno Excluido com Sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message +
                " Erro ao excluir o Aluno");

            }
        }

        public DataTable MostrarAlunos()
        {
                bd.Conectar();
                DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno"));
                bd.Desconectar();
                return dt;
        }
    }
}
