﻿/*
 * Marcelino Criação e Implementação do arquivo
 */

namespace WebMVC.Negocio
{
    public static class ExpressoesRegulares
    {
        /// <summary>
        /// Validador cpf
        /// </summary>
        public const string cpf = @"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$";

        /// <summary>
        /// Validador Nome
        /// </summary>
        public const string nome = @"^[aA-zZ]+((\s[aA-zZ]+)+)?$";

        /// <summary>
        /// Validador URL
        /// </summary>
        public const string url = @"^((http)|(https)|(ftp)):\/\/([\- \w]+\.)+\w{2,3}(\/[%\-\w]+(\.\w{2,})?)*$";

        /// <summary>
        /// Validador Cep
        /// </summary>
        public const string cep = @"^\d{5}\-?\d{3}$";

        /// <summary>
        /// Validador Data
        /// </summary>
        public const string data = @"^((0[1-9]|[12]\d)\/(0[1-9]|1[0-2])|30\/(0[13-9]|1[0-2])|31\/(0[13578]|1[02]))\/\d{4}$";

        /// <summary>
        /// Validador CNPJ
        /// </summary>
        public const string cnpj = @"^\d{3}.?\d{3}.?\d{3}/?\d{3}-?\d{2}$";

        /// <summary>
        /// Validador Telefone
        /// </summary>
        public const string telefone = @"^\d{2}-\d{4}-\d{4}$";

        /// <summary>
        /// Validador Email
        /// </summary>
        public const string email = @"^([\w\-]+\.)*[\w\- ]+@([\w\- ]+\.)+([\w\-]{2,3})$";

        /// <summary>
        /// Validador Numero Real
        /// </summary>
        public const string numeroReal = @"^\d+?(.|,\d+)$";
    }
}
