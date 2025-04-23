namespace Alunos.Infra;

public class AlunosContexto : DbContext // Define a classe AlunosContexto que herda de DbContext, usada para interagir com o banco de dados.
{
	public AlunosContexto(DbContextOptions options) : base(options) // Construtor que recebe as opções de configuração do DbContext.
	{
		// O construtor base inicializa o DbContext com as opções fornecidas.
	}

	public DbSet<Aluno> Alunos { get; set; } // Representa a tabela "Alunos" no banco de dados, permitindo operações CRUD.

	protected override void OnModelCreating(ModelBuilder modelBuilder) // Método para configurar o mapeamento das entidades.
	{
		base.OnModelCreating(modelBuilder); // Chama a implementação base para garantir que as configurações padrão sejam aplicadas.
		modelBuilder.ApplyConfiguration(new Mapeadores.AlunoMapeador()); // Aplica a configuração personalizada para a entidade Aluno.
	}
}
