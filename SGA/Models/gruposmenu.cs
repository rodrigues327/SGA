using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class gruposmenu
    {
        public int cd_grupo { get; set; }
        public int cd_menu { get; set; }
        public Nullable<bool> criar { get; set; }
        public Nullable<bool> exibir { get; set; }
        public Nullable<bool> alterar { get; set; }
        public Nullable<bool> excluir { get; set; }
        public Nullable<bool> baixar { get; set; }
        public virtual grupos grupos { get; set; }
        public virtual menu menu { get; set; }
    }
}
