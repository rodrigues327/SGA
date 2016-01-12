using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class vw_relcalendario
    {
        public string cd_turma { get; set; }
        public string turma { get; set; }
        public string disciplina { get; set; }
        public string nome { get; set; }
        public System.DateTime data { get; set; }
    }
}
