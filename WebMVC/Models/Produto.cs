/*
 * Marcelino Criação e Implementação do arquivo
 */

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebMVC.Negocio;

namespace WebMVC.Models
{
    /// <summary>
    /// Produto
    /// </summary>
    [Table("Produtos")]
    public class Produto
    {
        /// <summary>
        /// Id Do Produto
        /// </summary>
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// Nome do produto
        /// </summary>
        [RegularExpression(ExpressoesRegulares.nome), StringLength(30, MinimumLength = 5), Required]
        public string Nome { get; set; }
        /// <summary>
        /// Quantidade do produto
        /// </summary>
        [RegularExpression(ExpressoesRegulares.numeroReal), StringLength(6), Required]
        public int Quantidade { get; set; }
    }
}
