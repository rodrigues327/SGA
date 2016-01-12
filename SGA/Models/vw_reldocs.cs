using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class vw_reldocs
    {
        public string cd_turma { get; set; }
        public string turma { get; set; }
        public string nome { get; set; }
        public string documento { get; set; }
        public string status { get; set; }
        public Nullable<int> ordem { get; set; }
        public Nullable<int> cd_tipocurso { get; set; }
    }
}
