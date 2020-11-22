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
        public string Nome { get; set; }
        public char Quantidade { get; set; }
    }
}
