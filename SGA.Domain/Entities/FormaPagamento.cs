using SGA.Domain.Entities.Core;
using System.Collections.Generic;

namespace SGA.Domain.Entities
{
    public class FormaPagamento : BaseEntity
    {
        public FormaPagamento()
        {
            alunosfinanceiroes = new List<AlunoFinanceiro>();
            turmas = new List<Turma>();
        }

        public int cd_formapagamento { get; set; }
        public string formapagamento { get; set; }
        public virtual ICollection<AlunoFinanceiro> alunosfinanceiroes { get; set; }
        public virtual ICollection<Turma> turmas { get; set; }
    }
}