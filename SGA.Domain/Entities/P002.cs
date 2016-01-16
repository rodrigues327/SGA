using SGA.Domain.Entities.Core;
using System.Collections.Generic;

namespace SGA.Domain.Entities
{
    public class P002 : BaseEntity
    {
        public P002()
        {
            Alunosturmasdocumentos = new List<AlunoTurmaDocumento>();
        }

        public int CdDocumento { get; set; }
        public string Documento { get; set; }
        public int? CdTipocurso { get; set; }
        public int? Ordem { get; set; }
        public virtual ICollection<AlunoTurmaDocumento> Alunosturmasdocumentos { get; set; }
        public virtual TipoCurso Tiposcurso { get; set; }
    }
}