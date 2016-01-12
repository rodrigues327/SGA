using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class parceiro
    {
        public parceiro()
        {
            this.turmas = new List<turma>();
        }

        public int cd_parceiro { get; set; }
        public string parceiro1 { get; set; }
        public Nullable<System.DateTime> datainclusao { get; set; }
        public Nullable<int> usuarioinclusao { get; set; }
        public Nullable<System.DateTime> dataalteracao { get; set; }
        public Nullable<int> usuarioalteracao { get; set; }
        public virtual ICollection<turma> turmas { get; set; }
    }
}
