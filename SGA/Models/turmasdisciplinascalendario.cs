using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class turmasdisciplinascalendario
    {
        public string cd_turma { get; set; }
        public int cd_disciplina { get; set; }
        public System.DateTime data { get; set; }
        public Nullable<int> cd_professor { get; set; }
        public Nullable<System.DateTime> datainclusao { get; set; }
        public Nullable<int> usuarioinclusao { get; set; }
        public Nullable<System.DateTime> dataalteracao { get; set; }
        public Nullable<int> usuarioalteracao { get; set; }
        public virtual professore professore { get; set; }
        public virtual turmasdisciplina turmasdisciplina { get; set; }
    }
}
