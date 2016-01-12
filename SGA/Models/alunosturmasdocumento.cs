using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class alunosturmasdocumento
    {
        public int cd_aluno { get; set; }
        public string cd_turma { get; set; }
        public int cd_documento { get; set; }
        public Nullable<System.DateTime> data { get; set; }
        public virtual alunosturma alunosturma { get; set; }
        public virtual p002 p002 { get; set; }
    }
}
