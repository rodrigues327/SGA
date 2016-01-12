using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class grupos
    {
        public grupos()
        {
            this.gruposmenus = new List<gruposmenu>();
            this.usuarios = new List<usuario>();
        }

        public int cd_grupo { get; set; }
        public string grupo { get; set; }
        public virtual ICollection<gruposmenu> gruposmenus { get; set; }
        public virtual ICollection<usuario> usuarios { get; set; }
    }
}
