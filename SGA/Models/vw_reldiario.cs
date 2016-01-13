using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class vw_reldiario
    {
        public string curso { get; set; }
        public string disciplina { get; set; }
        public string professor { get; set; }
        public string aluno { get; set; }
        public System.DateTime data { get; set; }
        public string turma { get; set; }
        public string cd_turma { get; set; }
        public int cd_disciplina { get; set; }
    }
}
