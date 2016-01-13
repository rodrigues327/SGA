using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class usuario
    {
        public int cd_usuario { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public Nullable<int> cd_grupo { get; set; }
        public virtual grupos grupos { get; set; }
    }
}
