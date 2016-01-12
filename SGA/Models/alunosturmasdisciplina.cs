using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class alunosturmasdisciplina
    {
        public int cd_aluno { get; set; }
        public string cd_turma { get; set; }
        public int cd_disciplina { get; set; }
        public Nullable<int> presenca { get; set; }
        public Nullable<int> nota { get; set; }
        public Nullable<System.DateTime> datainclusao { get; set; }
        public Nullable<int> usuarioinclusao { get; set; }
        public Nullable<System.DateTime> dataalteracao { get; set; }
        public Nullable<int> usuarioalteracao { get; set; }
        public virtual aluno aluno { get; set; }
        public virtual alunosturma alunosturma { get; set; }
        public virtual turmasdisciplina turmasdisciplina { get; set; }
    }
}
