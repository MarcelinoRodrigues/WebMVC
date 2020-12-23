//*********************************************
// Marcelino Criação e Implementação do arquivo
//********************************************* 

using Microsoft.EntityFrameworkCore;

namespace WebMVC.Models
{
    public class Contexto : DbContext
    {
        /// <summary>
        /// Conexão com a tabela Pessoa
        /// </summary>
        public DbSet<Pessoa> Pessoas { get; set; }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="opcoes"></param>
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes){}
    }
}
