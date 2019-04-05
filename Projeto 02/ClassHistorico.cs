using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_02
{
    class ClassHistorico
    {
        public int CodHistorico { get; set; }
        public int Aluno_CodAluno { get; set; }
        public DateTime FrequenciaAluno_DataAula { get; set; }
        public string FrequenciaAluno_StatusFrequencia { get; set; }
        public string DistribuicoesDePontos_NomeAtividade { get; set; }
        public int DistribuicoesDePontos_Pontos { get; set; }
    }
}
