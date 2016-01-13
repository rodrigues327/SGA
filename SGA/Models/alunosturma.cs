using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class alunosturma
    {
        public alunosturma()
        {
            this.alunosfinanceiroes = new List<alunosfinanceiro>();
            this.alunosturmasdisciplinas = new List<alunosturmasdisciplina>();
            this.alunosturmasdocumentos = new List<alunosturmasdocumento>();
        }

        public int cd_aluno { get; set; }
        public string cd_turma { get; set; }
        public Nullable<System.DateTime> datamatricula { get; set; }
        public string cd_alunoexterno { get; set; }
        public Nullable<decimal> matricula { get; set; }
        public Nullable<decimal> bolsa { get; set; }
        public string obsfinanceiro { get; set; }
        public string obsdocs { get; set; }
        public Nullable<int> ativo { get; set; }
        public Nullable<System.DateTime> datainclusao { get; set; }
        public Nullable<int> usuarioinclusao { get; set; }
        public Nullable<System.DateTime> dataalteracao { get; set; }
        public Nullable<int> usuarioalteracao { get; set; }
        public virtual aluno aluno { get; set; }
        public virtual ICollection<alunosfinanceiro> alunosfinanceiroes { get; set; }
        public virtual turma turma { get; set; }
        public virtual ICollection<alunosturmasdisciplina> alunosturmasdisciplinas { get; set; }
        public virtual ICollection<alunosturmasdocumento> alunosturmasdocumentos { get; set; }
    }
}
