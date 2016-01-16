using SGA.Domain.Entities.Core;
using System;
using System.Collections.Generic;

namespace SGA.Domain.Entities
{
    public class AlunoTurma : BaseEntity
    {
        public AlunoTurma()
        {
            alunosfinanceiroes = new List<AlunoFinanceiro>();
            alunosturmasdisciplinas = new List<AlunoTurmaDisciplina>();
            alunosturmasdocumentos = new List<AlunoTurmaDocumento>();
        }

        public int cd_aluno { get; set; }
        public string cd_turma { get; set; }
        public DateTime? datamatricula { get; set; }
        public string cd_alunoexterno { get; set; }
        public decimal? matricula { get; set; }
        public decimal? bolsa { get; set; }
        public string obsfinanceiro { get; set; }
        public string obsdocs { get; set; }
        public int? ativo { get; set; }
        public DateTime? datainclusao { get; set; }
        public int? usuarioinclusao { get; set; }
        public DateTime? dataalteracao { get; set; }
        public int? usuarioalteracao { get; set; }
        public virtual Aluno aluno { get; set; }
        public virtual ICollection<AlunoFinanceiro> alunosfinanceiroes { get; set; }
        public virtual Turma turma { get; set; }
        public virtual ICollection<AlunoTurmaDisciplina> alunosturmasdisciplinas { get; set; }
        public virtual ICollection<AlunoTurmaDocumento> alunosturmasdocumentos { get; set; }
    }
}