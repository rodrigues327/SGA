using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class vw_relpagamentos
    {
        public string cd_alunoexterno { get; set; }
        public string nome { get; set; }
        public string cd_turma { get; set; }
        public string turma { get; set; }
        public string local { get; set; }
        public int cd_mensalidade { get; set; }
        public Nullable<int> numdocumento { get; set; }
        public Nullable<System.DateTime> datavencimento { get; set; }
        public Nullable<decimal> valor { get; set; }
        public Nullable<decimal> desconto { get; set; }
        public Nullable<System.DateTime> datapagamento { get; set; }
        public Nullable<decimal> valorpago { get; set; }
        public string formapagamento { get; set; }
    }
}
