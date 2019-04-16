using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_02
{
    class ClassNota
    {
        public int CodNota { get; set; }
        public int Aluno_CodAluno { get; set; }
        public int DistribuicaoPontos_CodDistribuicaoPontos { get; set; }
        public decimal NotaAtividade01 { get; set; }
        public decimal NotaAtividade02 { get; set; }
        public decimal NotaAtividade03 { get; set; }
        public decimal NotaAtividade04 { get; set; }
        public decimal NotaProvaInicial { get; set; }
        public decimal NotaProvaFinal { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public void InserirNotas()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Nota WHERE Aluno_codAluno = "+Aluno_CodAluno+" AND DistribuicaoPontos_codDistribuicaoPontos = "+DistribuicaoPontos_CodDistribuicaoPontos+""));
            if (dt.Rows.Count == 0)
            {
                bd.ExecutarComandosSql(String.Format("INSERT INTO Nota VALUES " + NotaAtividade01 + "," + NotaAtividade02 + "," + NotaAtividade03 + ", " + NotaAtividade04 + ", " + NotaProvaInicial + ", " + NotaProvaFinal + ", " + Aluno_CodAluno + ", " + DistribuicaoPontos_CodDistribuicaoPontos + ""));
                MessageBox.Show("Nota Lançada com Sucesso!");
                bd.Desconectar();
            }
            else
            {
                bd.ExecutarComandosSql(String.Format(" UPDATE Nota SET " + " notaAtividade01 = " + NotaAtividade01 + ",  notaAtividade02 = " + NotaAtividade02 + ", notaAtividade03 = " + NotaAtividade03 + ", notaAtividade04 = " + NotaAtividade04 + ", notaProvaInicial = " + NotaProvaInicial + ",  notaProvaFinal = " + NotaProvaFinal + " Aluno_codAluno = " + Aluno_CodAluno + " WHERE Aluno_CodAluno = " + Aluno_CodAluno + " AND Distribuicao_codDistribuicao = " + DistribuicaoPontos_CodDistribuicaoPontos));
                MessageBox.Show("Nota Atualizada com Sucesso!");
                bd.Desconectar();
            }
                
                
        }


        //public bool EditarNotas()
        //{
        //    try
        //    {
        //        bd.Conectar();
        //        bd.ExecutarComandosSql(String.Format(" UPDATE Nota SET " + " Aluno_CodAluno = '" + Aluno_CodAluno + "', notaAtividade01 = '" + NotaAtividade01 + ",  notaAtividade02 = '" + NotaAtividade02 + ", notaAtividade03 = '" + NotaAtividade03 + ", notaAtividade04 = '" + NotaAtividade04 + ", notaProvaInicial = '" + NotaProvaInicial + ",  notaProvaFinal = '" + NotaProvaFinal + " Aluno_codAluno = '" + Aluno_CodAluno + ", Distribuicao_codDistribuicao = '" + DistribuicaoPontos_CodDistribuicaoPontos + "   WHERE codNota LIKE " + CodNota));
        //        bd.Desconectar();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public bool ExcluirNota()
        //{
        //    try
        //    {
        //        bd.Conectar();
        //        bd.ExecutarComandosSql(String.Format("DELETE FROM Nota WHERE  CodNota = " + CodNota + ""));
        //        bd.Desconectar();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}


        public bool GerarBoletim(int codAluno)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("SELECT * FROM Nota WHERE Aluno_codAluno = " + codAluno + ""));
                bd.Desconectar();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
