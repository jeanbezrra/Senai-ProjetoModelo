using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System.Collections;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NacionalidadeController
    {
        /// <summary>
        /// 
        /// Valida a nacionalidade antes de cadatrar.
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns></returns>
        /// <returns>Retorna a requisição feita de validação ao cadastrar uma nova nacionalidade</returns>



        public bool Cadastrar(string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Inserir(descricao);
            return resposta;
        }

        /// <summary>
        /// 
        /// Atualiza a nacionalidade.
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <returns>Retorna a requsisição feita para atualizar a nacionalidade pela descrição e id</returns>


        public List<NacionalidadeEntity> ObterTodasNacionalidades()
        {

            /// <summary>
            /// 
            /// Obtêm todas as nacionalidades do banco de dados.
            /// </summary>
            /// <returns></returns>
            /// <returns>Retorna a requisição feita para a obter todas as nacionalidades</returns>



            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NacionalidadeEntity>)resposta;
        }

        public bool AtualizarDado(int id, string descricao)
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="descricao"></param>
            /// <param name="id"></param>
            /// <returns></returns>
            /// 

            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Atualizar(id, descricao);
            return resposta;
        }

        /// <summary>
        /// 
        /// Remove a nacionalidade.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <returns>Retorna a requsisição feita para remover a nacionalidade pelo id</returns>


        public bool Deletar(int id)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Remover(id);
            return resposta;
        }
    }
}
