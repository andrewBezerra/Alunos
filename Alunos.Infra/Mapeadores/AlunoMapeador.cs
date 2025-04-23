using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alunos.Infra.Mapeadores;

// Classe responsável por mapear a entidade Aluno para a tabela no banco de dados
public class AlunoMapeador : IEntityTypeConfiguration<Aluno>
{
	// Método para configurar o mapeamento da entidade Aluno
	public void Configure(EntityTypeBuilder<Aluno> builder)
	{
		// Define o nome da tabela no banco de dados
		builder.ToTable("Alunos");

		// Configura a chave primária da tabela
		builder.HasKey(a => a.Id);

		// Configura a propriedade Nome como obrigatória e com tamanho máximo de 120 caracteres
		builder.Property(a => a.Nome)
			.IsRequired()
			.HasMaxLength(120);

		// Configura a propriedade DataNascimento como obrigatória
		builder.Property(a => a.DataNascimento)
			.IsRequired();

		// Configura a propriedade Email como obrigatória e com tamanho máximo de 100 caracteres
		builder.Property(a => a.Email)
			.IsRequired()
			.HasMaxLength(100);

		// Configura a propriedade Telefone com tamanho máximo de 20 caracteres
		builder.Property(a => a.Telefone)
			.HasMaxLength(20);

		// Configura a propriedade Endereco com tamanho máximo de 250 caracteres
		builder.Property(a => a.Endereco)
			.HasMaxLength(250);
	}
}

