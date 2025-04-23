using Alunos.Dominio.Entidade;
using Alunos.Dominio.Interfaces;

namespace Alunos.Windows
{
	public partial class Form1 : Form
	{
		private readonly IAlunoRepositorio _repositorio;
		public Form1(IAlunoRepositorio repositorio)
		{
			InitializeComponent();
			_repositorio = repositorio;

		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			await AtualizaGrid();
		}

		private async void GridAlunos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var id = GridAlunos.Rows[e.RowIndex].Cells[0].Value.ToString();

			await CarregarDetalhes(Guid.Parse(id!));
		}

		private async Task CarregarDetalhes(Guid id)
		{
			var aluno = await _repositorio.ObterPorId(id);
			lblId.Text = aluno.Id.ToString();
			txtNome.Text = aluno.Nome;
			txtEmail.Text = aluno.Email;
			txtTelefone.Text = aluno.Telefone;
			txtEndereco.Text = aluno.Endereco;
			dtpDataNascimento.Text = aluno.DataNascimento.ToString();
		}

		private async void btnSalvar_Click(object sender, EventArgs e)
		{
			var id = lblId.Text;
			await Salvar(Guid.Parse(id));
		}
		private async Task AtualizaGrid()
		{
			alunoBindingSource.DataSource = await _repositorio.ObterTodos();
		}

		private async Task Salvar(Guid id)
		{
			var aluno = await _repositorio.ObterPorId(id);
			try
			{
				aluno.AlterarEmail(txtEmail.Text);
				aluno.AlterarEndereco(txtEndereco.Text);
				aluno.AlterarTelefone(txtTelefone.Text);

				await _repositorio.Atualizar(aluno);
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			finally
			{
				await AtualizaGrid();
			}

		}
	}
}
