using Alunos.Dominio.Interfaces;
using Alunos.Infra;
using Alunos.Infra.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Alunos.Windows
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			var host = CreateHostBuilder().Build();


			ApplicationConfiguration.Initialize();
			var mainForm = host.Services.GetRequiredService<Form1>();

			var dbcontext = host.Services.GetRequiredService<AlunosContexto>();
			dbcontext.Database.Migrate();

			Application.Run(mainForm);

			
		}

		static IHostBuilder CreateHostBuilder()
		{
			return Host.CreateDefaultBuilder()
				.ConfigureServices((context, services) =>
				{
					// Register application services here
					services.AddTransient<Form1>();
					services.AddSingleton<IAlunoRepositorio, AlunoRepositorioSqlServer>();
					services.AddDbContext<AlunosContexto>(options =>
						options.UseSqlServer("Server=localhost;Database=AlunosDB;User Id=sa;Password=ABC123teste;TrustServerCertificate=True;"));					
				});
		}

	}
}