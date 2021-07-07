using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class ControladorCompromissoTest
    {
        [TestClass]
        public class ControladorTarefaTest
        {
            ControladorCompromisso controlador = null;
            ControladorContato controladorContato = null;

            public ControladorTarefaTest()
            {
                controlador = new ControladorCompromisso();
                controladorContato = new ControladorContato();
                Db.Update("DELETE FROM [TBCOMPROMISSO]; "); //DBCC CHECKIDENT ('[TBCOMPROMISSO]', RESEED, 0);
                Db.Update("DELETE FROM [TBCONTATO]; "); //DBCC CHECKIDENT ('[TBCONTATO]', RESEED, 0);
            }

            [TestMethod]
            public void DeveNaoEditar_CompromissoComMesmoHora()
            {
                //arrange
                Compromisso compromisso = new Compromisso("assunto", "Casa", "link", DateTime.Now.Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), null);

                //action
                controlador.InserirNovo(compromisso);

                bool existeCompromissoComEssaHora = controlador.VerificarDataHoraJaExistentes(DateTime.Now.Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00));

                //assert
                existeCompromissoComEssaHora.Should().BeTrue();
            }

            [TestMethod]
            public void DeveExistir_CompromissoComEsseId()
            {
                //arrange
                Compromisso compromisso = new Compromisso("assunto", "Casa", "link", DateTime.Now.Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), null);

                //action
                controlador.InserirNovo(compromisso);

                bool existeCompromissoComEsteId = controlador.Existe(compromisso.Id);

                //assert
                existeCompromissoComEsteId.Should().BeTrue();
            }

            [TestMethod]
            public void DeveEditar_ContatoECompromisso()
            {
                //arrange
                Compromisso compromisso = new Compromisso("assunto", "Casa", "link", DateTime.Now.Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), null);
                Contato contato = new Contato("Leonardo", "leozinhomm1@gmail.com", "47 993384314", "ndd-tech", "Estagio");

                //action
                controlador.InserirNovo(compromisso);
                controladorContato.InserirNovo(contato);

                Compromisso novoCompromisso = new Compromisso("assuntonovo", "Casanova", "linknovo", DateTime.Now.Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), contato);
                controlador.Editar(compromisso.Id, novoCompromisso);

                Compromisso selecaoBanco = controlador.SelecionarPorId(compromisso.Id);

                //assert
                selecaoBanco.Assunto.Should().Be(novoCompromisso.Assunto);
                selecaoBanco.Contato.Nome.Should().Be(contato.Nome);
            }

            [TestMethod]
            public void DeveExistir_CompromissoComEssaHora()
            {
                //arrange
                Compromisso compromisso = new Compromisso("assunto", "Casa", "link", DateTime.Now.Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), null);

                //action
                controlador.InserirNovo(compromisso);

                //assert
                bool encontrouCompromisso = controlador.VerificarDataHoraJaExistentes(DateTime.Now.Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00));

                encontrouCompromisso.Should().BeTrue();
            }

            [TestMethod]
            public void DeveInserir_CompromissoComContato()
            {
                //arrange
                Contato contato = new Contato("Leonardo", "leozinhomm1@gmail.com", "47 993384314", "ndd-tech", "Estagio");
                Compromisso compromisso = new Compromisso("assunto", "Casa", "link", DateTime.Now.Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), contato);

                //action
                controladorContato.InserirNovo(contato);
                controlador.InserirNovo(compromisso);

                //assert
                Compromisso compromissoEncontrado = controlador.SelecionarPorId(compromisso.Id);
                compromissoEncontrado.Should().Be(compromisso);
            }

            [TestMethod]
            public void DeveInserir_CompromissoSemContato()
            {
                //arrange
                Contato contato = null;
                Compromisso compromisso = new Compromisso("assunto", "Casa", "link", DateTime.Now.Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), contato);

                //action
                controlador.InserirNovo(compromisso);

                //assert
                Compromisso compromissoEncontrado = controlador.SelecionarPorId(compromisso.Id);
                compromissoEncontrado.Should().Be(compromisso);
            }
            [TestMethod]
            public void DeveNaoInserir_CompromissoHorarioOcupado()
            {
                //arrange
                Contato contato = null;
                Compromisso compromisso = new Compromisso("assunto", "Casa", "link", DateTime.Now.Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), contato);
                Compromisso compromissoHorarioOcupado = new Compromisso("ocupado", "ocupado", "ocupado", DateTime.Now.Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), contato);

                //action
                controlador.InserirNovo(compromisso);
                controlador.InserirNovo(compromissoHorarioOcupado); //não pode inserir mesmo horario
                //assert
                Compromisso compromissoEncontrado = controlador.SelecionarPorId(compromissoHorarioOcupado.Id);
                compromissoEncontrado.Should().Be(compromissoHorarioOcupado);
            }

            [TestMethod]
            public void DeveRetornar_CompromissoFuturos()
            {
                //arrange
                Compromisso compromisso = new Compromisso("assunto", "Casa", "link", DateTime.Now.Date.AddDays(2), new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), null);
                //action
                controlador.InserirNovo(compromisso);
                List<Compromisso> listaCompromisso = controlador.SelecionarCompromissosFuturos(DateTime.Now.Date, DateTime.Now.Date.AddDays(7));
                //assert
                listaCompromisso.Count.Should().Be(1);
            }

            [TestMethod]
            public void DeveRetornar_CompromissoPassado()
            {
                //arrange
                Compromisso compromisso = new Compromisso("assunto", "Casa", "link", new DateTime(2021,05,01).Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), null);
                //action
                controlador.InserirNovo(compromisso);
                List<Compromisso> listaCompromisso = controlador.SelecionarCompromissosPassados(DateTime.Now.Date);
                //assert
                listaCompromisso.Count.Should().Be(1);
            }
            [TestMethod]
            public void DeveRetornar_CompromissoTodos()
            {
                //arrange
                Compromisso compromisso = new Compromisso("assunto", "Casa", "link", new DateTime(2021, 05, 01).Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), null);
                Compromisso compromisso2 = new Compromisso("assunto2", "Casa2", "link2", new DateTime(2021, 05, 11).Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), null);
                Compromisso compromisso3 = new Compromisso("assunto3", "Casa3", "link3", new DateTime(2021, 05, 21).Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), null);
                //action
                controlador.InserirNovo(compromisso);
                controlador.InserirNovo(compromisso2);
                controlador.InserirNovo(compromisso3);

                List<Compromisso> listaCompromisso = controlador.SelecionarTodos();
                //assert
                listaCompromisso.Count.Should().Be(3);
            }

            [TestMethod]
            public void DeveRetornar_CompromissoPorId()
            {
                //arrange
                Compromisso compromisso = new Compromisso("assunto", "Casa", "link", new DateTime(2021, 05, 01).Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), null);
                Compromisso compromisso2 = new Compromisso("assunto2", "Casa2", "link2", new DateTime(2021, 05, 11).Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), null);
                Compromisso compromisso3 = new Compromisso("assunto3", "Casa3", "link3", new DateTime(2021, 05, 21).Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), null);
                //action
                controlador.InserirNovo(compromisso);
                controlador.InserirNovo(compromisso2);
                controlador.InserirNovo(compromisso3);

                Compromisso compromissoSelecionado = controlador.SelecionarPorId(compromisso2.Id);
                //assert
                compromissoSelecionado.Id.Should().Be(compromisso2.Id);
            }

            [TestMethod]
            public void DeveExcluir_CompromissoPorId()
            {
                //arrange
                Compromisso compromisso = new Compromisso("assunto", "Casa", "link", new DateTime(2021, 05, 01).Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), null);
                Compromisso compromisso2 = new Compromisso("assunto2", "Casa2", "link2", new DateTime(2021, 05, 11).Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), null);
                Compromisso compromisso3 = new Compromisso("assunto3", "Casa3", "link3", new DateTime(2021, 05, 21).Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), null);
                //action
                controlador.InserirNovo(compromisso);
                controlador.InserirNovo(compromisso2);
                controlador.InserirNovo(compromisso3);

                bool resultadoExclusao = controlador.Excluir(compromisso2.Id);
                Compromisso compromissoSelecionado = controlador.SelecionarPorId(compromisso2.Id);

                //assert
                resultadoExclusao.Should().BeTrue();
                compromissoSelecionado.Should().Be(null);
            }

            [TestMethod]
            public void DeveExcluir_ContatoDeCompromisso()
            {
                //arrange
                Contato contato = new Contato("Leonardo", "leozinhomm1@gmail.com", "47 993384314", "ndd-tech", "Estagio");
                controladorContato.InserirNovo(contato);
                Db.Update("DELETE FROM [TBCOMPROMISSO] ; ");

                Compromisso compromisso = new Compromisso("assunto2", "Casa2", "link2", new DateTime(2021, 05, 11).Date, new TimeSpan(13, 40, 33), new TimeSpan(15, 10, 00), contato);
                //action


                controlador.InserirNovo(compromisso);

                Compromisso compromissoSelecionado = controlador.SelecionarPorId(compromisso.Id);   //ERRO TA AQUI


                bool resultadoExclusao = controlador.Excluir(compromisso.Id);

                //assert
                resultadoExclusao.Should().BeTrue();
                compromissoSelecionado.Id.Should().Be(compromisso.Id);
            }

        }
    }
}
