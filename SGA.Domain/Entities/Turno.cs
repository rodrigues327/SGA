using SGA.Domain.Entities.Core;
using System.Collections.Generic;

namespace SGA.Domain.Entities
{
    public class Turno : BaseEntity
    {
        public Turno()
        {
            Turmas = new List<Turma>();
        }

        public int CdTurno { get; set; }
        public string Turno1 { get; set; }
        public virtual ICollection<Turma> Turmas { get; set; }
    }
}