/*
 * Marcelino Criação e Implementação do arquivo
 */

using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
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
        [RegularExpression(@"^[aA-zZ]+((\s[aA-zZ]+)+)?$"), StringLength(30, MinimumLength = 5), Required]
        public string Nome { get; set; }
        /// <summary>
        /// Quantidade do produto
        /// </summary>
        [RegularExpression(@"^[0-9]+?(.|,[0-9]+)$"), StringLength(6), Required]
        public int Quantidade { get; set; }
    }
}
