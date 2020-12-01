/*
 * Marcelino Criação e Implementação do arquivo
 */
using Microsoft.EntityFrameworkCore;

namespace WebMVC.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        /// <param name="opcoes"></param>
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
    }
}
