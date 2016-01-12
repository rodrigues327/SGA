using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class menu
    {
        public menu()
        {
            this.gruposmenus = new List<gruposmenu>();
        }

        public int cd_menu { get; set; }
        public string menu1 { get; set; }
        public string submenu { get; set; }
        public string link { get; set; }
        public string tipo { get; set; }
        public Nullable<int> ordem { get; set; }
        public virtual ICollection<gruposmenu> gruposmenus { get; set; }
    }
}
