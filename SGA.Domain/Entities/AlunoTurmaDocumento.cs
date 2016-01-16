using SGA.Domain.Entities.Core;
using System;

namespace SGA.Domain.Entities
{
    public class AlunoTurmaDocumento : BaseEntity
    {
        public int cd_aluno { get; set; }
        public string cd_turma { get; set; }
        public int cd_documento { get; set; }
        public DateTime? data { get; set; }
        public virtual AlunoTurma alunosturma { get; set; }
        public virtual P002 p002 { get; set; }
    }
}