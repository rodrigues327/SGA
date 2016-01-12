using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SGA.Models.Mapping;

namespace SGA.Models
{
    public partial class sgaContext : DbContext
    {
        static sgaContext()
        {
            Database.SetInitializer<sgaContext>(null);
        }

        public sgaContext()
            : base("Name=sgaContext")
        {
        }

        public DbSet<aluno> alunos { get; set; }
        public DbSet<alunosfinanceiro> alunosfinanceiroes { get; set; }
        public DbSet<alunosturma> alunosturmas { get; set; }
        public DbSet<alunosturmasdisciplina> alunosturmasdisciplinas { get; set; }
        public DbSet<alunosturmasdocumento> alunosturmasdocumentos { get; set; }
        public DbSet<curso> cursos { get; set; }
        public DbSet<cursosdisciplina> cursosdisciplinas { get; set; }
        public DbSet<disciplina> disciplinas { get; set; }
        public DbSet<dtproperty> dtproperties { get; set; }
        public DbSet<formaspagamento> formaspagamentos { get; set; }
        public DbSet<grupos> grupos { get; set; }
        public DbSet<gruposmenu> gruposmenus { get; set; }
        public DbSet<instituico> instituicoes { get; set; }
        public DbSet<locai> locais { get; set; }
        public DbSet<menu> menus { get; set; }
        public DbSet<p001> p001 { get; set; }
        public DbSet<p002> p002 { get; set; }
        public DbSet<parceiro> parceiros { get; set; }
        public DbSet<professore> professores { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<tiposcurso> tiposcursos { get; set; }
        public DbSet<turma> turmas { get; set; }
        public DbSet<turmasdisciplina> turmasdisciplinas { get; set; }
        public DbSet<turmasdisciplinascalendario> turmasdisciplinascalendarios { get; set; }
        public DbSet<turno> turnos { get; set; }
        public DbSet<usuario> usuarios { get; set; }
        public DbSet<vw_capaturma> vw_capaturma { get; set; }
        public DbSet<vw_contrato> vw_contrato { get; set; }
        public DbSet<vw_relcalendario> vw_relcalendario { get; set; }
        public DbSet<vw_relcarne> vw_relcarne { get; set; }
        public DbSet<vw_reldiario> vw_reldiario { get; set; }
        public DbSet<vw_reldocs> vw_reldocs { get; set; }
        public DbSet<vw_reldocs2> vw_reldocs2 { get; set; }
        public DbSet<vw_relpagamentos> vw_relpagamentos { get; set; }
        public DbSet<vw_relpagamentosturma> vw_relpagamentosturma { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new alunoMap());
            modelBuilder.Configurations.Add(new alunosfinanceiroMap());
            modelBuilder.Configurations.Add(new alunosturmaMap());
            modelBuilder.Configurations.Add(new alunosturmasdisciplinaMap());
            modelBuilder.Configurations.Add(new alunosturmasdocumentoMap());
            modelBuilder.Configurations.Add(new cursoMap());
            modelBuilder.Configurations.Add(new cursosdisciplinaMap());
            modelBuilder.Configurations.Add(new disciplinaMap());
            modelBuilder.Configurations.Add(new dtpropertyMap());
            modelBuilder.Configurations.Add(new formaspagamentoMap());
            modelBuilder.Configurations.Add(new gruposMap());
            modelBuilder.Configurations.Add(new gruposmenuMap());
            modelBuilder.Configurations.Add(new instituicoMap());
            modelBuilder.Configurations.Add(new locaiMap());
            modelBuilder.Configurations.Add(new menuMap());
            modelBuilder.Configurations.Add(new p001Map());
            modelBuilder.Configurations.Add(new p002Map());
            modelBuilder.Configurations.Add(new parceiroMap());
            modelBuilder.Configurations.Add(new professoreMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new tiposcursoMap());
            modelBuilder.Configurations.Add(new turmaMap());
            modelBuilder.Configurations.Add(new turmasdisciplinaMap());
            modelBuilder.Configurations.Add(new turmasdisciplinascalendarioMap());
            modelBuilder.Configurations.Add(new turnoMap());
            modelBuilder.Configurations.Add(new usuarioMap());
            modelBuilder.Configurations.Add(new vw_capaturmaMap());
            modelBuilder.Configurations.Add(new vw_contratoMap());
            modelBuilder.Configurations.Add(new vw_relcalendarioMap());
            modelBuilder.Configurations.Add(new vw_relcarneMap());
            modelBuilder.Configurations.Add(new vw_reldiarioMap());
            modelBuilder.Configurations.Add(new vw_reldocsMap());
            modelBuilder.Configurations.Add(new vw_reldocs2Map());
            modelBuilder.Configurations.Add(new vw_relpagamentosMap());
            modelBuilder.Configurations.Add(new vw_relpagamentosturmaMap());
        }
    }
}
