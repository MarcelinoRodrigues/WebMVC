using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class Pessoa
    {
        [Key]
        public int PessoaID { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string CPF { get; set; }

        public int Idade { get; set; }

        public string Telefone { get; set; }
    }
}
