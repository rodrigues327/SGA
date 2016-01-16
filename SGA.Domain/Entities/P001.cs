using SGA.Domain.Entities.Core;

namespace SGA.Domain.Entities
{
    public class P001 : BaseEntity
    {
        public int cd_interface { get; set; }
        public string nome { get; set; }
        public string caminho { get; set; }
        public string tipo { get; set; }
    }
}