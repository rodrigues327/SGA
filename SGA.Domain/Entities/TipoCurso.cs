using SGA.Domain.Entities.Core;
using System.Collections.Generic;

namespace SGA.Domain.Entities
{
    public class TipoCurso : BaseEntity
    {
        public TipoCurso()
        {
            cursos = new List<Curso>();
            p002 = new List<P002>();
        }

        public int cd_tipocurso { get; set; }
        public string tipocurso { get; set; }
        public virtual ICollection<Curso> cursos { get; set; }
        public virtual ICollection<P002> p002 { get; set; }
    }
}