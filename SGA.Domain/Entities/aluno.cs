using SGA.Domain.Entities.Core;
using System;
using System.Collections.Generic;

namespace SGA.Domain.Entities
{
    public class Aluno : BaseEntity
    {
        public Aluno()
        {
            Alunosturmas = new List<AlunoTurma>();
            Alunosturmasdisciplinas = new List<AlunoTurmaDisciplina>();
        }

        public int CdAluno { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Identidade { get; set; }
        public string Identidadeorgao { get; set; }
        public DateTime? Datanascimento { get; set; }
        public string Sexo { get; set; }
        public string Estadocivil { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Filiacaopai { get; set; }
        public string Filiacaomae { get; set; }
        public string Naturalidade { get; set; }
        public string Nacionalidade { get; set; }
        public string Graduacaocurso { get; set; }
        public string Graduacaoinstituicao { get; set; }
        public string Graduacaoano { get; set; }
        public string Empresa { get; set; }
        public string Empresatelefone { get; set; }
        public string Empresaramal { get; set; }
        public string Cargo { get; set; }
        public int? Emancipado { get; set; }
        public DateTime? Datainclusao { get; set; }
        public int? Usuarioinclusao { get; set; }
        public DateTime? Dataalteracao { get; set; }
        public int? Usuarioalteracao { get; set; }
        public virtual ICollection<AlunoTurma> Alunosturmas { get; set; }
        public virtual ICollection<AlunoTurmaDisciplina> Alunosturmasdisciplinas { get; set; }
    }
}