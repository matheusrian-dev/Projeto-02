using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_02
{
    class ClassDistribuicaoPontos
    {
        public int CodDistribuicaoPontos { get; set; }
        public string NomeAtividade { get; set; }
        public decimal Valor { get; set; }
        public string Materia { get; set; }
        public int Curso_CodCurso { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataEntrega { get; set; }
    }
}
