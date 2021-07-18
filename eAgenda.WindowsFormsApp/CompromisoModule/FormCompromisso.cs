using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsFormsApp.CompromisoModule
{
    public partial class FormCompromisso : Form
    {
        private ControladorCompromisso controlador;
        private ControladorContato controladorContato;
        public FormCompromisso(ControladorCompromisso controladorCompromisso, ControladorContato controladorContato)
        {
            InitializeComponent();
            this.controladorContato = controladorContato;
            this.controlador = controladorCompromisso;
            AtualizarLista(controlador.SelecionarTodos());
            AtualizarComboBoxContato();
            Eventos();
        }
        public FormCompromisso(Compromisso compromisso, ControladorCompromisso controladorCompromisso, ControladorContato controladorContato)
        {
            InitializeComponent();
            this.controladorContato = controladorContato;
            this.controlador = controladorCompromisso;
            AtualizarComboBoxContato();
            AtualizarCampos(compromisso);
            AtualizarLista(controlador.SelecionarTodos());
            Eventos();
        }

        #region BOTÕES EVENTOS CRUD
        private void Eventos()
        {
            userControlBtn.btnAdicionar.Click += BtnAdicionar_Click;
            userControlBtn.btnEditar.Click += BtnEditar_Click;
            userControlBtn.btnDeletar.Click += BtnDeletar_Click;
            userControlBtn.btnLimpar.Click += BtnLimpar_Click;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Compromisso compromisso = GerarObjeto();
                string validacao = compromisso.Validar();
                if (validacao == "ESTA_VALIDO")
                {
                    controlador.Excluir(compromisso.Id);
                    AtualizarLista(controlador.SelecionarTodos());
                    LimparCampos();
                    MessageBox.Show("Excluido Com Sucesso!");
                }
                else MessageBox.Show(validacao);
            }
            else MessageBox.Show("Não é possivel Deletar");
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Compromisso compromisso = GerarObjeto();
                string validacao = compromisso.Validar();
                if (validacao == "ESTA_VALIDO")
                {
                    controlador.Editar(compromisso.Id, compromisso);
                    AtualizarLista(controlador.SelecionarTodos());
                    LimparCampos();
                    MessageBox.Show("Salvo com sucesso!");
                }
                else MessageBox.Show(validacao);
            }
            else MessageBox.Show("Não é possivel editar");
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = GerarObjeto();
            string validacao = compromisso.Validar();
            if (validacao == "ESTA_VALIDO")
            {
                controlador.InserirNovo(compromisso);
                AtualizarLista(controlador.SelecionarTodos());
                LimparCampos();
                MessageBox.Show("Adicionado Com Sucesso!");
            }
            else MessageBox.Show(validacao);
        }
        #endregion

        private Compromisso GerarObjeto()
        {
            if (comboBoxContato.SelectedItem != null)
            {
                Compromisso compromisso = new Compromisso(txtAssunto.Text, txtLocal.Text, txtLink.Text, data.Value, horaInicio.Value.TimeOfDay, horaFim.Value.TimeOfDay, (Contato)comboBoxContato.SelectedItem);
                if (txtId.Text != "")
                    compromisso.Id = Convert.ToInt32(txtId.Text);
                return compromisso;
            }
            else
            {
                Compromisso compromisso = new Compromisso(txtAssunto.Text, txtLocal.Text, txtLink.Text, data.Value, horaInicio.Value.TimeOfDay, horaFim.Value.TimeOfDay, null);
                if (txtId.Text != "")
                    compromisso.Id = Convert.ToInt32(txtId.Text);
                return compromisso;
            }

        }
        private void AtualizarComboBoxContato()
        {
            comboBoxContato.Items.Clear();
            foreach (var item in controladorContato.SelecionarTodos())
            {
                comboBoxContato.Items.Add(item);
            }
        }
        private void AtualizarLista(List<Compromisso> lista)
        {
            if (lista.Count == 0) MessageBox.Show("Zero Registros Localizados.");
            listBoxObjetos.Items.Clear();
            foreach (var item in lista)
            {
                listBoxObjetos.Items.Add(item);
            }
        }
        private void LimparCampos()
        {
            txtAssunto.Text = "";
            txtId.Text = "";
            txtLink.Text = "";
            txtLocal.Text = "";
            data.Value = DateTime.Now;
            horaFim.Value = DateTime.Now.AddHours(1);
            horaInicio.Value = DateTime.Now;
            comboBoxContato.SelectedIndex = -1;
        }
        private void AtualizarCampos(Compromisso compromisso)
        {
            txtAssunto.Text = compromisso.Assunto;
            txtId.Text = Convert.ToString(compromisso.Id);
            txtLink.Text = compromisso.Link;
            txtLocal.Text = compromisso.Local;
            data.Value = compromisso.Data;
            horaFim.Value = Convert.ToDateTime(compromisso.HoraTermino.ToString());
            horaInicio.Value = Convert.ToDateTime(compromisso.HoraInicio.ToString());

            foreach (var item in comboBoxContato.Items)
            {
                if (compromisso.Contato != null)
                    if (((Contato)item).Id == compromisso.Contato.Id) comboBoxContato.SelectedItem = item;
            }
        }
        private void listBoxObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox aux = ((ListBox)sender);

            if (!(aux.SelectedItem is null))
            {
                AtualizarCampos((Compromisso)aux.SelectedItem);
            }
        }

        #region BOTÕES DE FILTROS DE LISTA
        private void btnHoje_Click(object sender, EventArgs e)
        {
            List<Compromisso> compromissos = controlador.SelecionarCompromissosFuturos(DateTime.Now, DateTime.Now.AddDays(1));
            AtualizarLista(compromissos);
        }
        private void btnFuturos_Click(object sender, EventArgs e)
        {
            List<Compromisso> compromissos = controlador.SelecionarCompromissosFuturos(DateTime.Now, DateTime.Now.AddYears(1));
            AtualizarLista(compromissos);
        }
        private void btnPassados_Click(object sender, EventArgs e)
        {
            List<Compromisso> compromissos = controlador.SelecionarCompromissosPassados(DateTime.Now);
            AtualizarLista(compromissos);
        }
        private void btnProximoMes_Click(object sender, EventArgs e)
        {
            List<Compromisso> compromissos = controlador.SelecionarCompromissosFuturos(DateTime.Now.Date, DateTime.Now.Date.AddMonths(1));
            AtualizarLista(compromissos);
        }
        private void btnProximaSemana_Click(object sender, EventArgs e)
        {
            List<Compromisso> compromissos = controlador.SelecionarCompromissosFuturos(DateTime.Now.Date, DateTime.Now.Date.AddDays(7));
            AtualizarLista(compromissos);
        }
        private void btnTodos_Click(object sender, EventArgs e)
        {
            AtualizarLista(controlador.SelecionarTodos());
        }
        #endregion

    }
}