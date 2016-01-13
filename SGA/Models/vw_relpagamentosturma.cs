using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class vw_relpagamentosturma
    {
        public string cd_alunoexterno { get; set; }
        public string nome { get; set; }
        public string cd_turma { get; set; }
        public string turma { get; set; }
        public Nullable<int> cd_mensalidade { get; set; }
        public Nullable<decimal> valorpago { get; set; }
        public Nullable<System.DateTime> datapagamento { get; set; }
        public Nullable<int> ativo { get; set; }
    }
}
