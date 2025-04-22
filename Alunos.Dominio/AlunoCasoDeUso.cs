using Alunos.Dominio.Entidade;
using Alunos.Dominio.Interfaces;

namespace Alunos.Dominio;

public class AlunoCasoDeUso
{
	private readonly IAlunoRepositorio _alunoRepositorio;
	public AlunoCasoDeUso(IAlunoRepositorio alunoRepositorio)
	{
		_alunoRepositorio = alunoRepositorio;
	}
	public async Task<Aluno> ObterPorId(Guid id)
	{
		return await _alunoRepositorio.ObterPorId(id);
	}
	public async Task<IEnumerable<Aluno>> ObterTodos()
	{
		return await _alunoRepositorio.ObterTodos();
	}
	public async Task Adicionar(Aluno aluno)
	{
		await _alunoRepositorio.Adicionar(aluno);
	}
	public async Task Atualizar(Aluno aluno)
	{
		await _alunoRepositorio.Atualizar(aluno);
	}
	public async Task Remover(Guid id)
	{
		await _alunoRepositorio.Remover(id);
	}
	public async Task<bool> Existe(Guid id)
	{
		return await _alunoRepositorio.Existe(id);
	}
}



