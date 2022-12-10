using System.Text.RegularExpressions;

namespace AppModelo.Model.Domain.Validators
{
    public static partial class Validadores
    {
        public static bool EmailEValido(string inputEmail)
        {

            /// <summary>
            /// Validação genérica do email digitado.
            /// </summary>
            /// <param name="inputEmail"></param>
            /// <returns>Retorna se o email é válido através de um regex de validação</returns>
            /// 

            var strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            var re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
    }
}
