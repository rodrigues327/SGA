using SGA.Domain.Entities.Core;

namespace SGA.Domain.Entities
{
    public class Instituicao : BaseEntity
    {
        public int CdInstituicao { get; set; }
        public string Nome { get; set; }
        public string Razaosocial { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}