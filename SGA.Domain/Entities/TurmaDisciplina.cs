using SGA.Domain.Entities.Core;
using System;
using System.Collections.Generic;

namespace SGA.Domain.Entities
{
    public class TurmaDisciplina : BaseEntity
    {
        public TurmaDisciplina()
        {
            Alunosturmasdisciplinas = new List<AlunoTurmaDisciplina>();
            Turmasdisciplinascalendarios = new List<TurmaDisciplinaCalendario>();
        }

        public string CdTurma { get; set; }
        public int CdDisciplina { get; set; }
        public DateTime? Datainclusao { get; set; }
        public int? Usuarioinclusao { get; set; }
        public DateTime? Dataalteracao { get; set; }
        public int? Usuarioalteracao { get; set; }
        public virtual ICollection<AlunoTurmaDisciplina> Alunosturmasdisciplinas { get; set; }
        public virtual Disciplina Disciplina { get; set; }
        public virtual ICollection<TurmaDisciplinaCalendario> Turmasdisciplinascalendarios { get; set; }
    }
}