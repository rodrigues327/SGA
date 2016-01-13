using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class p002
    {
        public p002()
        {
            this.alunosturmasdocumentos = new List<alunosturmasdocumento>();
        }

        public int cd_documento { get; set; }
        public string documento { get; set; }
        public Nullable<int> cd_tipocurso { get; set; }
        public Nullable<int> ordem { get; set; }
        public virtual ICollection<alunosturmasdocumento> alunosturmasdocumentos { get; set; }
        public virtual tiposcurso tiposcurso { get; set; }
    }
}
