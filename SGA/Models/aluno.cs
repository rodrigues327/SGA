using System;
using System.Collections.Generic;

namespace SGA.Models
{
    public partial class aluno
    {
        public aluno()
        {
            this.alunosturmas = new List<alunosturma>();
            this.alunosturmasdisciplinas = new List<alunosturmasdisciplina>();
        }

        public int cd_aluno { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string identidade { get; set; }
        public string identidadeorgao { get; set; }
        public Nullable<System.DateTime> datanascimento { get; set; }
        public string sexo { get; set; }
        public string estadocivil { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string cep { get; set; }
        public string estado { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string filiacaopai { get; set; }
        public string filiacaomae { get; set; }
        public string naturalidade { get; set; }
        public string nacionalidade { get; set; }
        public string graduacaocurso { get; set; }
        public string graduacaoinstituicao { get; set; }
        public string graduacaoano { get; set; }
        public string empresa { get; set; }
        public string empresatelefone { get; set; }
        public string empresaramal { get; set; }
        public string cargo { get; set; }
        public Nullable<int> emancipado { get; set; }
        public Nullable<System.DateTime> datainclusao { get; set; }
        public Nullable<int> usuarioinclusao { get; set; }
        public Nullable<System.DateTime> dataalteracao { get; set; }
        public Nullable<int> usuarioalteracao { get; set; }
        public virtual ICollection<alunosturma> alunosturmas { get; set; }
        public virtual ICollection<alunosturmasdisciplina> alunosturmasdisciplinas { get; set; }
    }
}
