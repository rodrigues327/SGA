using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class curso
    {
        public curso()
        {
            this.turmas = new List<turma>();
        }

        public string cd_curso { get; set; }
        public string curso1 { get; set; }
        public Nullable<int> cd_tipocurso { get; set; }
        public Nullable<int> numparcelas { get; set; }
        public Nullable<int> repasse { get; set; }
        public Nullable<decimal> mensalidade { get; set; }
        public Nullable<System.DateTime> datainclusao { get; set; }
        public Nullable<int> usuarioinclusao { get; set; }
        public Nullable<System.DateTime> dataalteracao { get; set; }
        public Nullable<int> usuarioalteracao { get; set; }
        public virtual tiposcurso tiposcurso { get; set; }
        public virtual ICollection<turma> turmas { get; set; }
    }
}
