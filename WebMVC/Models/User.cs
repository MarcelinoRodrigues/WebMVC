﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebMVC.Negocio;

namespace WebMVC.Models
{
    /// <summary>
    /// Usuario
    /// </summary>
    [Table("User")]
    public class User
    {
        /// <summary>
        /// ID da Pessoa
        /// </summary>
        [Key]
        public int PessoaID { get; set; }
        /// <summary>
        /// Nome da Pessoa
        /// </summary>
        [RegularExpression(ExpressoesRegulares.nome), StringLength(30, MinimumLength = 5), Required]
        public string Nome { get; set; }
        /// <summary>
        /// Sobrenome da Pessoa
        /// </summary>
        [RegularExpression(ExpressoesRegulares.nome), StringLength(30, MinimumLength = 5)]
        public string Sobrenome { get; set; }
        /// <summary>
        /// CPF da Pessoa
        /// </summary>
        [RegularExpression(ExpressoesRegulares.cpf), StringLength(11, MinimumLength = 11), Required]
        public string CPF { get; set; }

        /// <summary>
        /// Idade da Pessoa
        /// </summary>
        [RegularExpression(ExpressoesRegulares.numeroReal), Required]
        public int Idade { get; set; }

        /// <summary>
        /// Telefone da Pessoa
        /// </summary>
        ///[RegularExpression(ExpressoesRegulares.telefone)]
        [Required]
        public string Telefone { get; set; }
    }
}