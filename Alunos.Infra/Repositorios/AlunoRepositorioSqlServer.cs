using Alunos.Dominio.Entidade;
using Alunos.Dominio.Interfaces;

namespace Alunos.Infra.Repositorios
{
	public class AlunoRepositorioSqlServer : IAlunoRepositorio
	{
		private readonly AlunosContexto _contexto;

		public AlunoRepositorioSqlServer(AlunosContexto contexto)
		{
			_contexto = contexto;
		}

		public async Task Adicionar(Aluno aluno)
		{
			await _contexto.AddAsync(aluno);
		}

		public async Task<Aluno> Atualizar(Aluno aluno)
		{
			return await Task.Run(() => _contexto.Update(aluno).Entity);
		}

		public async Task<bool> Existe(Guid id)
		{
			return await _contexto.Alunos.AnyAsync(x => x.Id == id);
		}

		public async Task<Aluno> ObterPorId(Guid id)
		{
			return await _contexto.Alunos.Where(x => x.Id == id).FirstAsync();
		}

		public async Task<IEnumerable<Aluno>> ObterTodos()
		{
			return await _contexto.Alunos.ToListAsync();
		}

		public Task Remover(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}
