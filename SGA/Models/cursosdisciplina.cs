using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class cursosdisciplina
    {
        public string cd_curso { get; set; }
        public int cd_disciplina { get; set; }
        public Nullable<System.DateTime> datainclusao { get; set; }
        public Nullable<int> usuarioinclusao { get; set; }
        public Nullable<System.DateTime> dataalteracao { get; set; }
        public Nullable<int> usuarioalteracao { get; set; }
    }
}
