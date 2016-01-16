using SGA.Domain.Entities.Core;

namespace SGA.Domain.Entities
{
    public class Instituicao : BaseEntity
    {
        public int cd_instituicao { get; set; }
        public string instituicao { get; set; }
        public string razaosocial { get; set; }
        public string cnpj { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }
}