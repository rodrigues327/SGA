using SGA.Domain.Entities.Core;
using System;
using System.Collections.Generic;

namespace SGA.Domain.Entities
{
    public class Turma : BaseEntity
    {
        public Turma()
        {
            Alunosturmas = new List<AlunoTurma>();
        }

        public string CdTurma { get; set; }
        public string Turma1 { get; set; }
        public int? CdInstituicao { get; set; }
        public string CdLocal { get; set; }
        public string CdCurso { get; set; }
        public int CdFormapagamento { get; set; }
        public int? Numparcelas { get; set; }
        public decimal? Mensalidade { get; set; }
        public decimal? Desconto { get; set; }
        public DateTime? Datainicial { get; set; }
        public DateTime? Datafinal { get; set; }
        public int? CdTurno { get; set; }
        public int? CdParceiro { get; set; }
        public decimal? Parceiroperc { get; set; }
        public DateTime? Datainclusao { get; set; }
        public int? Usuarioinclusao { get; set; }
        public DateTime? Dataalteracao { get; set; }
        public int? Usuarioalteracao { get; set; }
        public virtual ICollection<AlunoTurma> Alunosturmas { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual FormaPagamento Formaspagamento { get; set; }
        public virtual Local Locai { get; set; }
        public virtual Parceiro Parceiro { get; set; }
        public virtual Turno Turno { get; set; }
    }
}