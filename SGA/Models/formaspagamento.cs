using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class formaspagamento
    {
        public formaspagamento()
        {
            this.alunosfinanceiroes = new List<alunosfinanceiro>();
            this.turmas = new List<turma>();
        }

        public int cd_formapagamento { get; set; }
        public string formapagamento { get; set; }
        public virtual ICollection<alunosfinanceiro> alunosfinanceiroes { get; set; }
        public virtual ICollection<turma> turmas { get; set; }
    }
}
