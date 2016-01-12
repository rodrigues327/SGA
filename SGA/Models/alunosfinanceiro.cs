using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class alunosfinanceiro
    {
        public int cd_aluno { get; set; }
        public string cd_turma { get; set; }
        public int cd_mensalidade { get; set; }
        public int cd_formapagamento { get; set; }
        public Nullable<int> numdocumento { get; set; }
        public Nullable<System.DateTime> datavencimento { get; set; }
        public Nullable<decimal> valor { get; set; }
        public Nullable<decimal> desconto { get; set; }
        public Nullable<decimal> bolsa { get; set; }
        public Nullable<System.DateTime> datapagamento { get; set; }
        public Nullable<decimal> valorpago { get; set; }
        public string conta { get; set; }
        public Nullable<System.DateTime> datainclusao { get; set; }
        public Nullable<int> usuarioinclusao { get; set; }
        public Nullable<System.DateTime> dataalteracao { get; set; }
        public Nullable<int> usuarioalteracao { get; set; }
        public virtual alunosturma alunosturma { get; set; }
        public virtual formaspagamento formaspagamento { get; set; }
    }
}
