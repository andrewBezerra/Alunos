using Alunos.Dominio.Entidade;

namespace Alunos.Dominio.Interfaces;

public interface IAlunoRepositorio
{
	Task<Aluno> ObterPorId(Guid id);
	Task<IEnumerable<Aluno>> ObterTodos();
	Task Adicionar(Aluno aluno);
	Task<Aluno> Atualizar(Aluno aluno);
	Task Remover(Guid id);
	Task<bool> Existe(Guid id);
}
