using SGA.Domain.Entities.Core;
using System;
using System.Collections.Generic;

namespace SGA.Domain.Entities
{
    public class Local : BaseEntity
    {
        public Local()
        {
            turmas = new List<Turma>();
        }

        public string cd_local { get; set; }
        public string local { get; set; }
        public string estado { get; set; }
        public DateTime? datainclusao { get; set; }
        public int? usuarioinclusao { get; set; }
        public DateTime? dataalteracao { get; set; }
        public int? usuarioalteracao { get; set; }
        public virtual ICollection<Turma> turmas { get; set; }
    }
}