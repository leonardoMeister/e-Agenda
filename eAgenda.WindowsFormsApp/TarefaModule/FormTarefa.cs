using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsFormsApp.TarefaModule
{
    public partial class FormTarefa : Form
    {
        ControladorTarefa controlador;
        public FormTarefa(ControladorTarefa controladorTarefa)
        {
            InitializeComponent();
            this.controlador = controladorTarefa;
            AtualizarLista(controlador.SelecionarTodos());
            Eventos();
        }
        public FormTarefa(Tarefa tarefa, ControladorTarefa controladorTarefa)
        {
            InitializeComponent();
            this.controlador = controladorTarefa;
            AtualizarLista(controlador.SelecionarTodos());
            AtualizarCampos(tarefa);
            Eventos();
        }

        #region EVENTOS CRUD
        private void Eventos()
        {
            userControlBtn.btnAdicionar.Click += BtnAdicionar_Click;
            userControlBtn.btnDeletar.Click += BtnDeletar_Click;
            userControlBtn.btnEditar.Click += BtnEditar_Click;
            userControlBtn.btnLimpar.Click += BtnLimpar_Click;

            txtPercentual.Leave += new EventHandler(CampoSaiu);
            txtId.Leave += new EventHandler(CampoSaiu);
            txtTitulo.Leave += new EventHandler(CampoSaiu);

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Tarefa tarefa = GerarObjeto();
                string validacao = tarefa.Validar();
                if (validacao == "ESTA_VALIDO")
                {
                    controlador.Editar(tarefa.Id, tarefa);
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
            Tarefa tarefa = GerarObjeto();
            string validacao = tarefa.Validar();
            if (validacao == "ESTA_VALIDO")
            {
                controlador.InserirNovo(tarefa);
                AtualizarLista(controlador.SelecionarTodos());
                LimparCampos();
                MessageBox.Show("Adicionado Com Sucesso!");
            }
            else MessageBox.Show(validacao);
        }
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Tarefa tarefa = GerarObjeto();
                string validacao = tarefa.Validar();
                if (validacao == "ESTA_VALIDO")
                {
                    controlador.Excluir(tarefa.Id);
                    AtualizarLista(controlador.SelecionarTodos());
                    LimparCampos();
                    MessageBox.Show("Excluido Com Sucesso!");
                }
                else MessageBox.Show(validacao);
            }
            else MessageBox.Show("Não é possivel Deletar");
        }
        #endregion

        public void CampoSaiu(object sender, EventArgs e)
        {
            if (sender is TextBoxBase txt) //MaskedTextBox, TextBox
            {
                if (txt.TextLength == 0)
                {
                    MessageBox.Show("Incorreto");
                    txt.BackColor = Color.Red;

                }
                else txt.BackColor = Color.Green;
            }
        }
        private Tarefa GerarObjeto()
        {
            int prioridade = comboBoxPrioridade.SelectedIndex;

            Tarefa tarefa = new Tarefa(txtTitulo.Text, DateTime.Now, (PrioridadeEnum)prioridade);
            if (txtId.Text != "")
                tarefa.Id = Convert.ToInt32(txtId.Text);
            if (txtPercentual.Text != "")
                tarefa.AtualizarPercentual(Convert.ToInt32(txtPercentual.Text), DateTime.Now);
            else MessageBox.Show("Percentual Inválido para mudança");
            return tarefa;
        }
        private void AtualizarCampos(Tarefa tarefa)
        {
            txtId.Text = Convert.ToString(tarefa.Id);
            txtPercentual.Text = Convert.ToString(tarefa.Percentual);

            foreach (var item in comboBoxPrioridade.Items)
            {
                if (item.ToString() == tarefa.Prioridade.ToString())
                {
                    comboBoxPrioridade.SelectedItem = item;
                }
            }
            comboBoxPrioridade.Text = tarefa.Prioridade.ToString();
            txtTitulo.Text = tarefa.Titulo;
        }
        private void LimparCampos()
        {
            txtId.Text = "";
            txtPercentual.Text = "";
            comboBoxPrioridade.Text = "";
            txtTitulo.Text = "";

        }
        private void AtualizarLista(List<Tarefa> lista)
        {
            listBoxObjetos.Items.Clear();
            foreach (var item in lista)
            {
                listBoxObjetos.Items.Add(item);
            }
        }
        private void listBoxObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox aux = ((ListBox)sender);

            if (!(aux.SelectedItem is null))
            {
                AtualizarCampos((Tarefa)aux.SelectedItem);
            }
        }
        private List<Tarefa> FiltroPrioridade(List<Tarefa> lista, int prioridade)
        {
            List<Tarefa> novaLista = new List<Tarefa>();
            foreach (var item in lista)
            {
                if (item.Prioridade.Chave == prioridade) novaLista.Add(item);
            }
            return novaLista;
        }

        #region BOTÕES DE FILTRO DE LISTA
        private void btnSemConcluir_Click(object sender, EventArgs e)
        {
            AtualizarLista(controlador.SelecionarTodasTarefasPendentes());
        }
        private void btnPriori3_Click(object sender, EventArgs e)
        {
            AtualizarLista(FiltroPrioridade(controlador.SelecionarTodos(), 2));
        }
        private void btnPriori1_Click(object sender, EventArgs e)
        {
            AtualizarLista(FiltroPrioridade(controlador.SelecionarTodos(), 0));
        }
        private void btnConcluida_Click(object sender, EventArgs e)
        {
            AtualizarLista(controlador.SelecionarTodasTarefasConcluidas());
        }
        private void btnPriori2_Click(object sender, EventArgs e)
        {
            AtualizarLista(FiltroPrioridade(controlador.SelecionarTodos(), 1));
        }
        private void btnTodos_Click(object sender, EventArgs e)
        {
            AtualizarLista(controlador.SelecionarTodos());
        }
        #endregion

    }
}