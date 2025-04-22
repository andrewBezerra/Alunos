namespace Alunos.Dominio.Entidade;
public class Entidade
{
	public Entidade()
	{
		Id = Guid.NewGuid();
	}
	public Guid Id { get; private set; }
	public DateTime DataCriacao { get; private set; } = DateTime.Now;
	public DateTime DataModificacao { get; private set; }

	public void AtualizarDataModificacao()
	{
		DataModificacao = DateTime.Now;
	}
}
