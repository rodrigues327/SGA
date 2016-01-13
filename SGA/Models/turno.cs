using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class turno
    {
        public turno()
        {
            this.turmas = new List<turma>();
        }

        public int cd_turno { get; set; }
        public string turno1 { get; set; }
        public virtual ICollection<turma> turmas { get; set; }
    }
}
