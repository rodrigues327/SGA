using SGA.Domain.Entities.Core;
using System;

namespace SGA.Domain.Entities
{
    public class AlunoFinanceiro : BaseEntity
    {
        public int cd_aluno { get; set; }
        public string cd_turma { get; set; }
        public int cd_mensalidade { get; set; }
        public int cd_formapagamento { get; set; }
        public int? numdocumento { get; set; }
        public DateTime? datavencimento { get; set; }
        public decimal? valor { get; set; }
        public decimal? desconto { get; set; }
        public decimal? bolsa { get; set; }
        public DateTime? datapagamento { get; set; }
        public decimal? valorpago { get; set; }
        public string conta { get; set; }
        public DateTime? datainclusao { get; set; }
        public int? usuarioinclusao { get; set; }
        public DateTime? dataalteracao { get; set; }
        public int? usuarioalteracao { get; set; }
        public virtual AlunoTurma alunosturma { get; set; }
        public virtual FormaPagamento formaspagamento { get; set; }
    }
}