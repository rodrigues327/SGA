using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class tiposcurso
    {
        public tiposcurso()
        {
            this.cursos = new List<curso>();
            this.p002 = new List<p002>();
        }

        public int cd_tipocurso { get; set; }
        public string tipocurso { get; set; }
        public virtual ICollection<curso> cursos { get; set; }
        public virtual ICollection<p002> p002 { get; set; }
    }
}
