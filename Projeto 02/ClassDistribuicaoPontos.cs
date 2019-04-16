using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_02
{
    class ClassDistribuicaoPontos
    {
        public int CodDistribuicaoPontos { get; set; }
        public string NomeInstrutor { get; set; }
        public int Turma_CodTurma { get; set; }
        public decimal ValorAtividade01 { get; set; }
        public decimal ValorAtividade02 { get; set; }
        public decimal ValorAtividade03 { get; set; }
        public decimal ValorAtividade04 { get; set; }
        public decimal ValorProvaInicial { get; set; }
        public decimal ValorProvaFinal { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool CadastrarDistribuicao()
        {
            try
            {
                //Conectar no Banco
                bd.Conectar();

                //Executar o Insert
                bd.ExecutarComandosSql(String.Format("INSERT INTO DistribuicaoPontos(nomeInstrutor, valorAtividade01, valorAtividade02, valorAtividade03, valorAtividade04, valorProvaInicial, valorProvaFinal, Turma_CodTurma)" +
                    " VALUES ('" + NomeInstrutor + "', " + ValorAtividade01 + ", '" + ValorAtividade02 + "', " + ValorAtividade03 + ", " + ValorAtividade04 + ", " + ValorProvaInicial + ", " + ValorProvaFinal + ", " + Turma_CodTurma + ")"));

                //Desconectar
                bd.Desconectar();
                MessageBox.Show("Distribuição Criada com Sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message +
                     "Erro ao inserir a Distribuição");

            }
        }

        public bool EditarDistribuicao()
        {
            try
            {
                //Conectar no Banco
                bd.Conectar();

                //Executar o Insert
                bd.ExecutarComandosSql(String.Format("Update DistribuicaoPontos SET " +
                    " nomeInstrutor = '" + NomeInstrutor + "', valorAtividade01 = " + ValorAtividade01 + ", valorAtividade02 = " + ValorAtividade02 + ", valorAtividade03 = " + ValorAtividade03 + ", valorAtividade04 = " + ValorAtividade04 + ", valorProvaInicial = " + ValorProvaInicial + ", valorProvaFinal = " + ValorProvaFinal + ", Turma_codTurma = " + Turma_CodTurma +
                    " WHERE codDistribuicaoPontos LIKE " + CodDistribuicaoPontos));

                //Desconectar
                bd.Desconectar();

                MessageBox.Show("Distribuição Atualizada com Sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message +
                     "Erro ao editar a Distribuição.");

            }
        }

        //public bool ExcluirDistribuicao(int codDistribuicaoPontos)
        //{
        //    try
        //    {
        //        bd.Conectar();
        //        bd.ExecutarComandosSql(String.Format("DELETE FROM DistribuicaoPontos" +
        //            " WHERE codDistribuicaoPontos = " + codDistribuicaoPontos + ""));



        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message +
        //        " Erro ao excluir a Distribuicao");

        //    }
        //}

        public DataTable MostrarDistribuicao()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM DistribuicaoPontos WHERE codDistribuicaoPontos = "+ CodDistribuicaoPontos +""));
            bd.Desconectar();
            return dt;
        }
    }
}
