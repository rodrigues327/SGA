using SGA.Domain.Entities.Core;
using System;
using System.Collections.Generic;

namespace SGA.Domain.Entities
{
    public class Disciplina : BaseEntity
    {
        public Disciplina()
        {
            turmasdisciplinas = new List<TurmaDisciplina>();
        }

        public int cd_disciplina { get; set; }
        public string disciplina1 { get; set; }
        public int? cargahoraria { get; set; }
        public int? cd_professor { get; set; }
        public DateTime? datainclusao { get; set; }
        public int? usuarioinclusao { get; set; }
        public DateTime? dataalteracao { get; set; }
        public int? usuarioalteracao { get; set; }
        public virtual Professor professore { get; set; }
        public virtual ICollection<TurmaDisciplina> turmasdisciplinas { get; set; }
    }
}