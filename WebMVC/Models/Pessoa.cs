using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Models
{
    public class Pessoa
    {
        [Key]
        public int PessoaID { get; set; }

        [RegularExpression(@"^[aA-zZ]+((\s[aA-zZ]+)+)?$"),StringLength(30, MinimumLength = 5),Required]
        public string Nome { get; set; }

        [StringLength(30, MinimumLength = 5), Required]
        public string Sobrenome { get; set; }

        [RegularExpression(@"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$"), Required]
        public string CPF { get; set; }

        [RegularExpression(@"^[0-9]+?(.|,[0-9]+)$"), StringLength(3), Required]
        public int Idade { get; set; }

        [StringLength(13, MinimumLength = 8), Required]
        public string Telefone { get; set; }
    }
}
