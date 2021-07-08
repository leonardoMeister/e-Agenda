using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Data.SQLite;

namespace eAgenda.Controladores.Shared
{
    public static class GerenciadorAppConfig
    {
        /// <summary>
        /// Estabelece uma conexaoBanco com base no DBSelecionado do AppConfig
        /// </summary>
        /// <returns>Retorna uma conexao do Tipo DbConnection</returns>
        public static DbConnection EstabelecerConexaoDbSelecionado()
        {
            if (ConfigurationManager.AppSettings["DBSelecionado"] == "SqlServer")
            {
                return EstabelecerConexaoSQLServer();
            }
            else if (ConfigurationManager.AppSettings["DBSelecionado"] == "SqLite") return EstabelecerConexaoSQLite();

            return null;
        }
        /// <summary>
        /// Estabelece uma conexao com banco SQLServer do AppConfig
        /// </summary>
        /// <returns>Retorna um Obj DbConnection do tipo SqlConnection</returns>
        private static DbConnection EstabelecerConexaoSQLServer()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConfigurationManager.ConnectionStrings["DBeAgenda"].ConnectionString;
            return conexao;
        }
        /// <summary>
        /// Estabelece uma conexao com banco SqLite do AppConfig
        /// </summary>
        /// <returns>Retorna um Obj DbConnection do tipo SQLiteConnection</returns>
        private static DbConnection EstabelecerConexaoSQLite()
        {
            SQLiteConnection conexao = new SQLiteConnection();
            conexao.ConnectionString = ConfigurationManager.ConnectionStrings["asdasd"].ConnectionString;
            return conexao;
        }

        public static void GravarConfiguracao(string chave, string valor)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(chave);
            config.Save();
            config.AppSettings.Settings.Add(chave, valor);
            config.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// Obtem o banco selecionado do AppConfig DBSelecionado
        /// </summary>
        /// <returns>Retorna String que indica qual banco esta selecionado</returns>
        public static string BancoSelecionado()
        {
            if (ConfigurationManager.AppSettings["DBSelecionado"] == "SqlServer") return "SqlServer";
            else if (ConfigurationManager.AppSettings["DBSelecionado"] == "SqLite") return "SqLite";
            return "Erro";
        }
    }
}
