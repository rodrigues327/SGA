using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class vw_contrato
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string cd_alunoexterno { get; set; }
        public string curso { get; set; }
        public Nullable<System.DateTime> datainicial { get; set; }
        public Nullable<System.DateTime> datafinal { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<int> numparcelas { get; set; }
        public decimal matricula { get; set; }
        public Nullable<decimal> valor { get; set; }
        public Nullable<int> dia { get; set; }
        public Nullable<System.DateTime> vencimento { get; set; }
        public Nullable<decimal> desconto { get; set; }
        public string instituicao { get; set; }
        public string razaosocial { get; set; }
        public string cnpj { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }
}
