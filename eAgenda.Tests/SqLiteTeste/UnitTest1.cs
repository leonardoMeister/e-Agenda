using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Web.UI.MobileControls;

namespace eAgenda.Tests.SqLiteTeste
{
    [TestClass]
    public class UnitTest1
    {
        /*
        [TestMethod]
        public void TestMethod2()
        {
            DbGenerico generico = new DbGenerico();

            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", 12);

            generico.LeDados1<SQLiteConnection>("select * from TBCOMPROMISSO where ");
        }

        [TestMethod]
        public void TestMethod3()
        {
            DbGenerico generico = new DbGenerico();

            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", 12);

            generico.LeDados1<SqlConnection>("select * from TBCOMPROMISSO", parametros);
        }*/
        /*
        [TestMethod]
        public void TestMethod1()
        {
            string stringAcessoBD = ConfigurationManager.ConnectionStrings["asdasd"].ConnectionString;

            var conexao = new SQLiteConnection(stringAcessoBD);

            var comand = new SQLiteCommand("select * from TBCOMPROMISSO", conexao);
            conexao.Open();
            
            //SqlCommand command = new SqlCommand("select * from TBCOMPROMISSO", conexao);

            //command.SetParameters(parameters);

            
            var reader = comand.ExecuteReader();

            foreach (var item in reader)
            {
                var assunto = Convert.ToString(reader["ASSUNTO"]);
                var local = Convert.ToString(reader["LOCAL"]);
                var link = Convert.ToString(reader["LINK"]);
                var dataDoCompromisso = Convert.ToDateTime(reader["DATA"]);
                var horaInicio = TimeSpan.FromTicks(Convert.ToInt64(reader["HORAINICIO"]));
                var horaTermino = TimeSpan.FromTicks(Convert.ToInt64(reader["HORATERMINO"]));

                Compromisso compromisso = new Compromisso(assunto, local, link, dataDoCompromisso, horaInicio, horaTermino, null);
                compromisso.Id = Convert.ToInt32(reader["ID"]);
                compromisso.Id.Should().Be(compromisso.Id);
            }

            conexao.Close();
        }
       */
    }
}
