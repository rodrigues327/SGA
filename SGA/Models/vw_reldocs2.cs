using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class vw_reldocs2
    {
        public int cd_documento { get; set; }
        public string documento { get; set; }
        public Nullable<int> cd_tipocurso { get; set; }
        public Nullable<int> ordem { get; set; }
        public int cd_aluno { get; set; }
        public string cd_turma { get; set; }
        public Nullable<System.DateTime> datamatricula { get; set; }
        public string cd_alunoexterno { get; set; }
        public Nullable<decimal> matricula { get; set; }
        public Nullable<decimal> bolsa { get; set; }
        public string obsfinanceiro { get; set; }
        public string obsdocs { get; set; }
        public Nullable<System.DateTime> datainclusao { get; set; }
        public Nullable<int> usuarioinclusao { get; set; }
        public Nullable<System.DateTime> dataalteracao { get; set; }
        public Nullable<int> usuarioalteracao { get; set; }
    }
}
