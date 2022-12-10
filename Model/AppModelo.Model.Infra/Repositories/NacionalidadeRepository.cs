using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    /// <summary>
    /// permite que o programa interaja com dados persistentes e execute operações como armazenamento e recuperação de informações.
    /// 
    /// </summary>
    public class NacionalidadeRepository
    {

        /// <summary>
        /// Inseri uma nacionalidade no banco de dados pela sua descrição.
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Retorna a requisição feita de inserir a nacionalidades pela descrição</returns>
        /// 

        //CRUD - create - read - update - delete
        public bool Inserir(string descricao) 
        {
            //string interpolation
            var sql = $"INSERT INTO nacionalidades(descricao) VALUES('{descricao}')";
            
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;


        }
        public bool Atualizar(int id, string descricao) 
        {

            /// <summary>
            /// Atualiza a nacionalidade existente no banco de dados pelo seu id.
            /// </summary>
            /// <param name="descricao"></param>
            /// <param name="id"></param>
            /// <returns>Retorna a requisição feita de atualizar a descrição pelo id</returns>
            /// 

            var sql = $"UPDATE nacionalidades SET descricao = '{descricao}' WHERE id = {id}";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        public bool Remover(int id) 
        {

            /// <summary>
            /// Remove uma nacionalidade existente no banco de dados pelo seu id.
            /// </summary>
            /// <param name="id"></param>
            /// <returns>Retorna a requisição de deletar a nacionalidade pelo id</returns>
            /// 

            var sql = $"DELETE FROM nacionalidades WHERE id = '{id}'";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;         
        }
        public IEnumerable<NacionalidadeEntity> ObterTodos()
        {

            /// <summary>
            /// Obtêm todas nacionalidades existentes no banco de dados.
            /// </summary>
            /// <returns>Retorna a requisição feita de selecionar todos os dados existentes no banco referente a nacionalidade</returns>



            var sql = "SELECT id, descricao FROM nacionalidades ORDER by descricao ASC";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());

            var resultado = conexaoBd.Query<NacionalidadeEntity>(sql);

            return resultado;
        }
        public NacionalidadeEntity ObterPorId() 
        {
            return new NacionalidadeEntity();
        }
    }                               
}                                   
                                    