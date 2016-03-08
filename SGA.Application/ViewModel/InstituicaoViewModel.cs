using SGA.Application.ViewModel.Core;
using System.ComponentModel.DataAnnotations;

namespace SGA.Application.ViewModel
{
    public class InstituicaoViewModel : BaseViewModel
    {
        [Key]
        public int CdInstituicao { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Razão Social")]
        public string Razaosocial { get; set; }

        [Required]
        [Display(Name = "Cnpj")]
        public string Cnpj { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; }
    }
}