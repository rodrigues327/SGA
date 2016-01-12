using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class turmasdisciplina
    {
        public turmasdisciplina()
        {
            this.alunosturmasdisciplinas = new List<alunosturmasdisciplina>();
            this.turmasdisciplinascalendarios = new List<turmasdisciplinascalendario>();
        }

        public string cd_turma { get; set; }
        public int cd_disciplina { get; set; }
        public Nullable<System.DateTime> datainclusao { get; set; }
        public Nullable<int> usuarioinclusao { get; set; }
        public Nullable<System.DateTime> dataalteracao { get; set; }
        public Nullable<int> usuarioalteracao { get; set; }
        public virtual ICollection<alunosturmasdisciplina> alunosturmasdisciplinas { get; set; }
        public virtual disciplina disciplina { get; set; }
        public virtual ICollection<turmasdisciplinascalendario> turmasdisciplinascalendarios { get; set; }
    }
}
