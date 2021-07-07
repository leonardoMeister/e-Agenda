using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.TarefaModule;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;

namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class CompromissoTest
    {
        [TestMethod]
        public void DeveCriar_CompromissoContato()
        {
            //action
            Contato contato = new Contato("Leonardo","leozinhomm1@gmail.com", "47 993384314","ndd-tech","Estagio");
            Compromisso compromisso = new Compromisso("assunto","Casa","link",DateTime.Now.Date, new TimeSpan(13,40,33), new TimeSpan(15, 10, 00),contato);

            //assert
            compromisso.Contato.Should().Be(contato);
            compromisso.Assunto.Should().Be("assunto");
            compromisso.Data.Should().Be(DateTime.Now.Date);
            compromisso.HoraInicio.Should().Be(new TimeSpan(13, 40, 33));
            compromisso.HoraTermino.Should().Be(new TimeSpan(15, 10, 00));
            compromisso.Local.Should().Be("Casa");
            compromisso.Link.Should().Be("link");
        }


        [TestMethod]
        public void DeveRegistrarDataConclusao()
        {
            //arrange
            Tarefa tarefa = new Tarefa("Preparar aula", DateTime.Now, PrioridadeEnum.Baixa);

            //action
            tarefa.AtualizarPercentual(100, DateTime.Today);

            //assert
            tarefa.Percentual.Should().Be(100);
            tarefa.DataConclusao.Should().Be(DateTime.Today);
        }

        [TestMethod]
        public void DeveRetornar_TarefaValida()
        {
            //arrange
            Tarefa tarefa = new Tarefa("Preparar aula", DateTime.Now, PrioridadeEnum.Baixa);
            tarefa.AtualizarPercentual(100, DateTime.Today);

            //action
            var resultado = tarefa.Validar();

            //assert
            resultado.Should().Be("ESTA_VALIDO");
        }

        [TestMethod]
        public void DeveValidar_DataCriacao()
        {
            //arrange
            var tarefa = new Tarefa("Preparar Aula", DateTime.MinValue, PrioridadeEnum.Baixa);

            //action
            var resultado = tarefa.Validar();

            //assert
            resultado.Should().Be("O campo Data de Criação é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Titulo()
        {
            //arrange
            var tarefa = new Tarefa("", DateTime.Today, PrioridadeEnum.Baixa);

            //action
            var resultado = tarefa.Validar();

            //assert
            resultado.Should().Be("O campo Título é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_QuebraDeLinha_Titulo_DataCriacao()
        {
            //arrange
            var tarefa = new Tarefa("", DateTime.MinValue, PrioridadeEnum.Baixa);

            //action
            var resultado = tarefa.Validar();

            //assert
            var resultadoEsperado =
                "O campo Título é obrigatório"
                + Environment.NewLine
                + "O campo Data de Criação é obrigatório";

            resultado.Should().Be(resultadoEsperado);
        }
    }
}
