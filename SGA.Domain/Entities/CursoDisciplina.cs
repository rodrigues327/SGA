using SGA.Domain.Entities.Core;
using System;

namespace SGA.Domain.Entities
{
    public class CursoDisciplina : BaseEntity
    {
        public string cd_curso { get; set; }
        public int cd_disciplina { get; set; }
        public DateTime? datainclusao { get; set; }
        public int? usuarioinclusao { get; set; }
        public DateTime? dataalteracao { get; set; }
        public int? usuarioalteracao { get; set; }
    }
}