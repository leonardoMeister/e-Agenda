using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace eAgenda.Controladores.Shared
{
    public delegate T ConverterDelegate<T>(IDataReader reader);

    public static class Db
    {

        static Db() { }

        /// <summary>
        /// Insere dados no banco
        /// </summary>
        /// <param name="sql">Query para inserir</param>
        /// <param name="parameters">Parametros para a query</param>
        /// <returns>Retorna o Id Da Inserção</returns>
        public static int Insert(string sql, Dictionary<string, object> parameters)
        {
            using (var connection = GerenciadorAppConfig.EstabelecerConexaoDbSelecionado())
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql.AppendSelectIdentity();

                    command.SetParameters(parameters);

                    //connection.Close();

                    connection.Open();

                    int id = Convert.ToInt32(command.ExecuteScalar());

                    return id;
                }
            }
        }

        /// <summary>
        /// Atualiza o Banco com base na query e parametros
        /// </summary>
        /// <param name="sql">Query para atualizar</param>
        /// <param name="parameters">Parametros da query</param>
        public static void Update(string sql, Dictionary<string, object> parameters = null) //ESSE AQUI
        {
            using (var connection = GerenciadorAppConfig.EstabelecerConexaoDbSelecionado())
            {

                using (var command = connection.CreateCommand())
                {

                    //command.Connection = connection;
                    command.CommandText = sql; //"DELETE FROM [TBCOMPROMISSO] \r\n                WHERE [ID] = @ID"
                    //"DELETE FROM [TBCOMPROMISSO]; "
                    command.SetParameters(parameters);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Deleta no banco
        /// </summary>
        /// <param name="sql">Query para deletar</param>
        /// <param name="parameters">Parametros com Id para deletar</param>
        public static void Delete(string sql, Dictionary<string, object> parameters)
        {
            Update(sql, parameters);
        }

        /// <summary>
        /// Pega no banco todos registros, ou Pega com base nos Parametros(Data)
        /// </summary>
        /// <typeparam name="T">Objeto Dominio Generico</typeparam>
        /// <param name="sql">Query de banco para selecionar Todos ou Selecionar base em datas</param>
        /// <param name="convert">Delegate Para converter sua leituraBanco em Obj T</param>
        /// <param name="parameters">Dicionario com o parametros usados na query</param>
        /// <returns>Retorna uma Lista<T> DominioBase</returns>
        public static List<T> GetAll<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters = null)
        {
            DbConnection connection = GerenciadorAppConfig.EstabelecerConexaoDbSelecionado();

            DbCommand command = connection.CreateCommand();

            command.Connection = connection;
            command.CommandText = sql;

            command.SetParameters(parameters);

            connection.Open();

            var list = new List<T>();

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var obj = convert(reader);
                list.Add(obj);
            }

            connection.Close();
            return list;
        }
        /// <summary>
        /// Pega no banco um item com base no parametro passado(ID)
        /// </summary>
        /// <typeparam name="T">Objeto Dominio Generico</typeparam>
        /// <param name="sql">Query de banco para selecionar com base no id</param>
        /// <param name="convert">Delegate Para converter sua leituraBanco em Obj T</param>
        /// <param name="parameters">Dicionario com o parametros usados na query</param>
        /// <returns>Retorna um Obj Generico T</returns>
        public static T Get<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters)
        {
            using (var connection = GerenciadorAppConfig.EstabelecerConexaoDbSelecionado())
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;

                    command.SetParameters(parameters);

                    connection.Open();

                    T t = default;

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                            t = convert(reader);
                        connection.Close();
                        return t;
                    }
                }
            }
        }

        /// <summary>
        /// Verifica a existencia no bando do item com o Id passado
        /// </summary>
        /// <param name="sql">Query Select count(*) quando id for igual ao passado por parametro</param>
        /// <param name="parameters">Dicionario com Id como parametro</param>
        /// <returns>Retorna True caso exista registro com Id selecionado no banco</returns>
        public static bool Exists(string sql, Dictionary<string, object> parameters)
        {
            DbConnection connection = GerenciadorAppConfig.EstabelecerConexaoDbSelecionado();
            DbCommand command = connection.CreateCommand();

            command.Connection = connection;
            command.CommandText = sql;

            command.SetParameters(parameters);

            connection.Open();

            int numberRows = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

            return numberRows > 0;
        }

        /// <summary>
        /// Recebe SQLComand e popula seus parametros com o dicionario recebido
        /// </summary>
        /// <param name="command">Obj SqlComando para preenchimento de parametros</param>
        /// <param name="parameters">Dicionario com valores para inserir nos parametros do comando</param>
        private static void SetParameters(this DbCommand command, Dictionary<string, object> parameters)
        {
            if (parameters == null || parameters.Count == 0)
                return;

            foreach (var parameter in parameters)
            {
                string name = parameter.Key;

                object value = parameter.Value.IsNullOrEmpty() ? DBNull.Value : parameter.Value;

                var dbParameter = command.CreateParameter();

                dbParameter.ParameterName = name;
                dbParameter.Value = value;

                command.Parameters.Add(dbParameter);
            }
        }

        /// <summary>
        /// Extension metodo String, Concatena query para selecionar ultimo id inserido
        /// </summary>
        /// <param name="sql">String que vai receber a concatenação</param>
        /// <returns>Retorna a string passada com concatenação</returns>
        private static string AppendSelectIdentity(this string sql)
        {
            if (GerenciadorAppConfig.BancoSelecionado() == "SqlServer") return sql + ";SELECT SCOPE_IDENTITY()";
            else if (GerenciadorAppConfig.BancoSelecionado() == "SqLite") return sql + ";SELECT LAST_INSERT_ROWID()";
            return null;
        }

        public static bool IsNullOrEmpty(this object value)
        {
            return (value is string && string.IsNullOrEmpty((string)value)) ||
                    value == null;
        }

    }
}
