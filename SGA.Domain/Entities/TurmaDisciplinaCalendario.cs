using SGA.Domain.Entities.Core;
using System;

namespace SGA.Domain.Entities
{
    public class TurmaDisciplinaCalendario : BaseEntity
    {
        public string CdTurma { get; set; }
        public int CdDisciplina { get; set; }
        public DateTime Data { get; set; }
        public int? CdProfessor { get; set; }
        public DateTime? Datainclusao { get; set; }
        public int? Usuarioinclusao { get; set; }
        public DateTime? Dataalteracao { get; set; }
        public int? Usuarioalteracao { get; set; }
        public virtual Professor Professore { get; set; }
        public virtual TurmaDisciplina TurmaDisciplina { get; set; }
    }
}