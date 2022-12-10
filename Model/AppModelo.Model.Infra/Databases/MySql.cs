namespace AppModelo.Model.Infra.Databases
{
    public static class MySql
    {
        /// <summary>
        /// Conecta o banco de dados com o programa.
        /// </summary>
        /// <returns>Retorna a requisição de conexão com o banco</returns>
        /// 

        public static string ConnectionString()
        {
            var conn = "server=mysql.wwonline.com.br;database=wwonline08;uid=wwonline08;password=aluno22senai;";
            return conn;
        }
    }
}

