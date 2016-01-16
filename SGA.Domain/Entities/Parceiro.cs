using SGA.Domain.Entities.Core;
using System;
using System.Collections.Generic;

namespace SGA.Domain.Entities
{
    public class Parceiro : BaseEntity
    {
        public Parceiro()
        {
            turmas = new List<Turma>();
        }

        public int cd_parceiro { get; set; }
        public string parceiro1 { get; set; }
        public DateTime? datainclusao { get; set; }
        public int? usuarioinclusao { get; set; }
        public DateTime? dataalteracao { get; set; }
        public int? usuarioalteracao { get; set; }
        public virtual ICollection<Turma> turmas { get; set; }
    }
}