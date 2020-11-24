using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Source
{
    public static class ExpressoesRegulares
    {
        public const string cpf = @"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$";

        public const string nome = @"^[aA-zZ]+((\s[aA-zZ]+)+)?$";

        public const string url = @"^((http)|(https)|(ftp)):\/\/([\- \w]+\.)+\w{2,3}(\/[%\-\w]+(\.\w{2,})?)*$";

        public const string cep = @"^\d{5}\-?\d{3}$";

        public const string data = @"^((0[1-9]|[12]\d)\/(0[1-9]|1[0-2])|30\/(0[13-9]|1[0-2])|31\/(0[13578]|1[02]))\/\d{4}$";

        public const string cnpj = @"^\d{3}.?\d{3}.?\d{3}/?\d{3}-?\d{2}$";

        public const string telefone = @"^\d{2}-\d{4}-\d{4}$";

        public const string email = @"^([\w\-]+\.)*[\w\- ]+@([\w\- ]+\.)+([\w\-]{2,3})$";

        public const string numeroReal = @"^\d+?(.|,\d+)$";
    }
}
