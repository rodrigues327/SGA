using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class vw_relcarne
    {
        public string cd_alunoexterno { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string cd_curso { get; set; }
        public string curso { get; set; }
        public int cd_mensalidade { get; set; }
        public Nullable<decimal> valor { get; set; }
        public Nullable<System.DateTime> datavencimento { get; set; }
    }
}
