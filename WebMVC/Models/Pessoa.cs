/*
 * Marcelino Criação e Implementação do arquivo
 */

using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class Pessoa
    {
        /// <summary>
        /// ID da Pessoa
        /// </summary>
        [Key]
        public int PessoaID { get; set; }
        /// <summary>
        /// Nome da Pessoa
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Sobrenome da Pessoa
        /// </summary>
        public string Sobrenome { get; set; }
        /// <summary>
        /// CPF da Pessoa
        /// </summary>
        public string CPF { get; set; }
        /// <summary>
        /// Idade da Pessoa
        /// </summary>
        public int Idade { get; set; }
        /// <summary>
        /// Telefone da Pessoa
        /// </summary>
        public string Telefone { get; set; }
    }
}
