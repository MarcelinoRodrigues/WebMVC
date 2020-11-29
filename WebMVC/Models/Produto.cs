using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Models
{
    public class Produto
    {
        [Key]
        public int ID { get; set; }

        [RegularExpression(@"^[aA-zZ]+((\s[aA-zZ]+)+)?$"), StringLength(30, MinimumLength = 5), Required]
        public string Nome { get; set; }

        [RegularExpression(@"^[0-9]+?(.|,[0-9]+)$"), StringLength(6), Required]
        public int Quantidade { get; set; }
    }
}
