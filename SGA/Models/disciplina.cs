using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class disciplina
    {
        public disciplina()
        {
            this.turmasdisciplinas = new List<turmasdisciplina>();
        }

        public int cd_disciplina { get; set; }
        public string disciplina1 { get; set; }
        public Nullable<int> cargahoraria { get; set; }
        public Nullable<int> cd_professor { get; set; }
        public Nullable<System.DateTime> datainclusao { get; set; }
        public Nullable<int> usuarioinclusao { get; set; }
        public Nullable<System.DateTime> dataalteracao { get; set; }
        public Nullable<int> usuarioalteracao { get; set; }
        public virtual professore professore { get; set; }
        public virtual ICollection<turmasdisciplina> turmasdisciplinas { get; set; }
    }
}
