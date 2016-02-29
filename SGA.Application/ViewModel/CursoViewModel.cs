using SGA.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SGA.Application.ViewModel.Core
{
    public class CursoViewModel : BaseViewModel
    {
        public CursoViewModel()
        {
            turmas = new List<Turma>();
        }

        public string cd_curso { get; set; }
        public string curso1 { get; set; }
        public int? TipocursoId { get; set; }
        public int? numparcelas { get; set; }
        public int? repasse { get; set; }
        public decimal? mensalidade { get; set; }
        public DateTime? datainclusao { get; set; }
        public int? usuarioinclusao { get; set; }
        public DateTime? dataalteracao { get; set; }
        public int? usuarioalteracao { get; set; }
        public virtual TipoCurso tiposcurso { get; set; }
        public virtual ICollection<Turma> turmas { get; set; }
    }
}