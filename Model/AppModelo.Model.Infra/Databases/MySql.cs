namespace AppModelo.Model.Infra.Databases
{
    public static class MySql
    {
        public static string ConnectionString()
        {
            var conn = "server=mysql.wwonline.com.br;database=wwonline08;uid=wwonline08;password=aluno22senai;";
            return conn;
        }
    }
}

