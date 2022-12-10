using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace AppModelo.Model.Infra.Repositories
{

    /// <summary>
    /// Responsavel pela conexão do banco de dados com o programa.
    /// </summary>
    /// 

    public class NaturalidadeRepository
    {
        7/// <summary>
        /// Inseri uma naturalidade no banco de dados.
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="status"></param>
        /// <returns>Retorna a requisição feita de inserir a naturalidade pela descrição e seu status</returns>
      


        public bool Inserir(string descricao, bool status)
        {
            var agora = DateTime.Now.ToString("u");
            var sql = $"INSERT INTO naturalidades (descricao, dataCriacao, dataAlteracao, ativo) VALUES ('{descricao}', '{agora}', '{agora}', {status})";          
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

        public IEnumerable<NaturalidadeEntity> ObterTodasNaturalidades()
        {
            var sql = "SELECT id, descricao, dataCriacao, dataAlteracao, ativo FROM naturalidades";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());          
            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);
            return resultado;
        }

        public NaturalidadeEntity ObterPorDescricao(string descricao, bool status)
        {
            var sql = $"SELECT descricao FROM naturalidades WHERE descricao = '{descricao}'";         
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            var resultado = conexaoBd.QuerySingleOrDefault<NaturalidadeEntity>(sql);
            return resultado;
        }

        public bool Atualizar(int id, string descricao)
        {

            /// <summary>
            /// Atualiza uma naturalidade existente no banco de dados pelo id.
            /// </summary>
            /// <param name="descricao"></param>
            /// <param name="id"></param>
            /// <returns>Retorna a requisição feita de atualizar a descrição pelo id</returns>



            var sql = $"UPDATE naturalidades SET descricao = '{descricao}' WHERE id = {id}";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

        public bool Deletar(int id)
        {
            /// <summary>
            /// Remove uma naturalidade existente no banco de dados pelo id.
            /// </summary>
            /// <param name="id"></param>
            /// <returns>Retorna a requisição feita de deletar a naturalidade pelo id</returns>


            var sql = $"DELETE FROM naturalidades WHERE id = '{id}'";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
    }
}
