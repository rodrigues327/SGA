using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class locai
    {
        public locai()
        {
            this.turmas = new List<turma>();
        }

        public string cd_local { get; set; }
        public string local { get; set; }
        public string estado { get; set; }
        public Nullable<System.DateTime> datainclusao { get; set; }
        public Nullable<int> usuarioinclusao { get; set; }
        public Nullable<System.DateTime> dataalteracao { get; set; }
        public Nullable<int> usuarioalteracao { get; set; }
        public virtual ICollection<turma> turmas { get; set; }
    }
}
