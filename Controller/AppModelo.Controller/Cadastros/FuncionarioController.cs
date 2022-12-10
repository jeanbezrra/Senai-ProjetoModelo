﻿using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.Cadastros
{
    public class FuncionarioController
    {
        /// <summary>
        /// 
        /// Cadastra o funcioário no banco de dados.
        /// </summary>
        /// <param name="naturalidade"></param>
        /// <param name="nacionalidade"></param>
@@ -26,17 +26,17 @@ public class FuncionarioController
        /// <param name="bairro"></param>
        /// <param name="municipio"></param>
        /// <param name="uf"></param>
        /// <returns></returns>
        /// <returns>Retorna a requisição feita para inserir os dados dos funcionários cadastrados</returns>
        /// 
        public bool Cadastrar(string nome, DateTime dataNascimento, bool sexo, string email, string telefone, string telefoneContato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, int nacionalidade, int naturalidade, string cpf)
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Inserir(nome, dataNascimento, sexo, email, telefone, telefoneContato, cep, logradouro, numero, complemento, bairro, municipio, uf, nacionalidade, naturalidade, cpf);
            return resposta;
        }

        public IEnumerable<FuncionarioEntity> ObterTodos()
        {
            /// <summary>
            /// 
            /// Obtêm todos os funcionários cadastrados no banco de dados.
            /// </summary>
            /// <returns></returns>
            /// <returns>Retorna a requisição feita para listar todos os funcionários existentes no banco de dados</returns>
            /// 
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.ObterTodos();
            return resposta;
        }
    }
}
