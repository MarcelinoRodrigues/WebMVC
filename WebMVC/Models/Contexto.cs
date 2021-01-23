//*********************************************
// Marcelino Criação e Implementação do arquivo
//********************************************* 

using Microsoft.EntityFrameworkCore;
using WebMVC.Models.ViewModels;

namespace WebMVC.Models
{
    /// <summary>
    /// Classe de conexao
    /// </summary>
    public class Contexto : DbContext
    {
        /// <summary>
        /// Conexão com a tabela Users
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="opcoes"></param>
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes){}

    }
}
