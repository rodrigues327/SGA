using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class professore
    {
        public professore()
        {
            this.disciplinas = new List<disciplina>();
            this.turmasdisciplinascalendarios = new List<turmasdisciplinascalendario>();
        }

        public int cd_professor { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public string telefone1 { get; set; }
        public string telefone2 { get; set; }
        public string telefone3 { get; set; }
        public string email1 { get; set; }
        public string email2 { get; set; }
        public string email3 { get; set; }
        public Nullable<int> titulacao { get; set; }
        public string area { get; set; }
        public string instituicao { get; set; }
        public Nullable<int> ano { get; set; }
        public string banco { get; set; }
        public string agencia { get; set; }
        public string conta { get; set; }
        public string favorecido { get; set; }
        public Nullable<System.DateTime> datanascimento { get; set; }
        public string pis { get; set; }
        public string cpf { get; set; }
        public Nullable<System.DateTime> datainclusao { get; set; }
        public Nullable<int> usuarioinclusao { get; set; }
        public Nullable<System.DateTime> dataalteracao { get; set; }
        public Nullable<int> usuarioalteracao { get; set; }
        public virtual ICollection<disciplina> disciplinas { get; set; }
        public virtual ICollection<turmasdisciplinascalendario> turmasdisciplinascalendarios { get; set; }
    }
}
