using AppModelo.Model.Domain.Wrappers;
using AppModelo.Model.Infra.Services;

namespace AppModelo.Controller.External
{
    public class ViaCepController
    {

        /// <summary>
        /// Obtem o cep da classe ViaCepWrapper.
        /// Obtêm o cep da classe ViaCepWrapper.
        /// </summary>
        /// <param name="cep"></param>
        /// <returns>Retorna a requisição feita para obter o cep da classe ViaCepServices</returns>
        /// 

        //Retorna a classe ViaCepWrapper
        public ViaCepWrapper Obter(string cep)
        {
            var service = new ViaCepService();
            var viaCep = service.ObterDaApi(cep);
            return viaCep;
        }
    }
}
