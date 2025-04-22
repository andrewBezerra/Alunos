using Alunos.Dominio.Entidade;
using Alunos.Dominio.Interfaces;

namespace Alunos.Infra.Repositorios
{
	public class AlunoRepositorioSqlServer : IAlunoRepositorio
	{
		public Task Adicionar(Aluno aluno)
		{
			throw new NotImplementedException();
		}

		public Task Atualizar(Aluno aluno)
		{
			throw new NotImplementedException();
		}

		public Task<bool> Existe(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<Aluno> ObterPorId(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Aluno>> ObterTodos()
		{
			throw new NotImplementedException();
		}

		public Task Remover(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}
