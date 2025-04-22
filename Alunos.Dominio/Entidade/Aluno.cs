namespace Alunos.Dominio.Entidade;
public class Aluno : Entidade
{
	public Aluno(string nome, string email, string telefone, string endereco, DateOnly dataNascimento)
	{
		Nome = nome;
		Email = email;
		Telefone = telefone;
		Endereco = endereco;
		DataNascimento = dataNascimento;		
	}

	public string Nome { get; private set; }
	public string Email { get; private set; }
	public string Telefone { get; private set; }
	public string Endereco { get; private set; }
	public DateOnly DataNascimento { get; private set; }

	public void AlterarEmail(string email)
	{
		if (string.IsNullOrWhiteSpace(email))
			throw new ArgumentException("E-mail inválido");

		var emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

		if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailRegex))
			throw new ArgumentException("E-mail inválido");

		Email = email;
		AtualizarDataModificacao();
	}
	public void AlterarTelefone(string telefone)
	{
		if (string.IsNullOrWhiteSpace(telefone))
			throw new ArgumentException("Telefone inválido");
		Telefone = telefone;
		AtualizarDataModificacao();
	}
	public void AlterarEndereco(string endereco)
	{
		if (string.IsNullOrWhiteSpace(endereco))
			throw new ArgumentException("Endereço inválido");
		Endereco = endereco;
		AtualizarDataModificacao();
	}

}


