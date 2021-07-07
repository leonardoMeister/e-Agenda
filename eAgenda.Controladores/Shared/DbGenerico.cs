using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System.Configuration;
using System.Data.Common;

namespace eAgenda.Controladores.Shared
{
    public class DbGenerico
    {
        public delegate T ConverterDelegate<T>(IDataReader reader);
        string stringConexao;

        public DbGenerico()
        {
            stringConexao = ConfigurationManager.ConnectionStrings["asdasd"].ConnectionString;
        }

        public DataTable LeDados<T>(string query, Dictionary<string, object> parameters = null) where T : IDbConnection, new()
        {
            using (var conn = new T())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Connection.ConnectionString = stringConexao;
                    cmd.Connection.Open();

                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            var parametro = cmd.CreateParameter();
                            parametro.ParameterName = $"@{item.Key}";
                            parametro.Value = item.Value;
                            cmd.Parameters.Add(parametro);
                        }
                    }

                    var table = new DataTable();
                    table.Load(cmd.ExecuteReader());

                    cmd.Connection.Close();
                    return table;
                }
            }
        }
    }
}
