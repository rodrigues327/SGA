using SGA.Domain.Entities.Core;
using System;

namespace SGA.Domain.Entities
{
    public class AlunoTurmaDisciplina : BaseEntity
    {
        public int cd_aluno { get; set; }
        public string cd_turma { get; set; }
        public int cd_disciplina { get; set; }
        public int? presenca { get; set; }
        public int? nota { get; set; }
        public DateTime? datainclusao { get; set; }
        public int? usuarioinclusao { get; set; }
        public DateTime? dataalteracao { get; set; }
        public int? usuarioalteracao { get; set; }
        public virtual Aluno aluno { get; set; }
        public virtual AlunoTurma alunosturma { get; set; }
        public virtual TurmaDisciplina TurmaDisciplina { get; set; }
    }
}