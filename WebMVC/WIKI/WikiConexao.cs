using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.WIKI
{
    public class WikiConexao
    {
        ///Para Criar a conexão precisa-se seguir os próximos passos
        // criar a classe Contexto.cs no Models
        // Deve se Herdar de :DbContext do EntityFrameworkCore
        //e criar o construtor
        // public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes){}
        ///
        //No arquivo Startup.cs Adicionar a conexao com o Sql( obs: pode optar por mysql basta usar no gerenciador de pacotes).
        // services.AddDbContext<Contexto>(opcoes => opcoes.UseSqlServer(Configuration.GetConnectionString("ConexaoBD")));
        ///
        // no arquivo appsettings.json criar a string de conexao com o banco
        //"ConnectionStrings": {
        //"ConexaoBD": "Server=LAPTOP-D2CCMIVK\\SQLEXPRESS;Database=SystemMRN;Trusted_Connection=True;"
        //},
        ///
    }
}
