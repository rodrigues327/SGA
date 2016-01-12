using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class turma
    {
        public turma()
        {
            this.alunosturmas = new List<alunosturma>();
        }

        public string cd_turma { get; set; }
        public string turma1 { get; set; }
        public Nullable<int> cd_instituicao { get; set; }
        public string cd_local { get; set; }
        public string cd_curso { get; set; }
        public int cd_formapagamento { get; set; }
        public Nullable<int> numparcelas { get; set; }
        public Nullable<decimal> mensalidade { get; set; }
        public Nullable<decimal> desconto { get; set; }
        public Nullable<System.DateTime> datainicial { get; set; }
        public Nullable<System.DateTime> datafinal { get; set; }
        public Nullable<int> cd_turno { get; set; }
        public Nullable<int> cd_parceiro { get; set; }
        public Nullable<decimal> parceiroperc { get; set; }
        public Nullable<System.DateTime> datainclusao { get; set; }
        public Nullable<int> usuarioinclusao { get; set; }
        public Nullable<System.DateTime> dataalteracao { get; set; }
        public Nullable<int> usuarioalteracao { get; set; }
        public virtual ICollection<alunosturma> alunosturmas { get; set; }
        public virtual curso curso { get; set; }
        public virtual formaspagamento formaspagamento { get; set; }
        public virtual locai locai { get; set; }
        public virtual parceiro parceiro { get; set; }
        public virtual turno turno { get; set; }
    }
}
