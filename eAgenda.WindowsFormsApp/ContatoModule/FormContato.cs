using eAgenda.Controladores.ContatoModule;
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

namespace eAgenda.WindowsFormsApp.ContatoModule
{
    public partial class FormContato : Form
    {
        private ControladorContato controlador;

        public FormContato(Contato contato, ControladorContato controladorContato)
        {
            InitializeComponent();
            this.controlador = controladorContato;
            AtualizarCampos(contato);
            AtualizarLista(controlador.SelecionarTodos());
            Eventos();
        }
        public FormContato(ControladorContato controladorContato)
        {
            InitializeComponent();
            this.controlador = controladorContato;
            AtualizarLista(controlador.SelecionarTodos());
            Eventos();
        }

        #region EVENTOS CRUD
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
                Contato contato = GerarObjeto();
                string validacao = contato.Validar();
                if (validacao == "ESTA_VALIDO")
                {
                    controlador.Excluir(contato.Id);
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
                Contato contato = GerarObjeto();
                string validacao = contato.Validar();
                if (validacao == "ESTA_VALIDO")
                {
                    controlador.Editar(contato.Id, contato);
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
            Contato contato = GerarObjeto();
            string validacao = contato.Validar();
            if (validacao == "ESTA_VALIDO")
            {
                controlador.InserirNovo(contato);
                AtualizarLista(controlador.SelecionarTodos());
                LimparCampos();
                MessageBox.Show("Adicionado Com Sucesso!");
            }
            else MessageBox.Show(validacao);
        }
        #endregion

        private Contato GerarObjeto()
        {
            Contato contato = new Contato(txtNome.Text, txtEmail.Text, mkTelefone.Text, txtEmpresa.Text, txtCargo.Text);
            if (txtId.Text != "")
                contato.Id = Convert.ToInt32(txtId.Text);
            return contato;
        }

        private void AtualizarLista(List<Contato> lista)
        {
            listBoxObjetos.Items.Clear();
            foreach (var item in lista)
            {
                listBoxObjetos.Items.Add(item);
            }
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtId.Text = "";
            txtEmpresa.Text = "";
            mkTelefone.Text = "";
            txtCargo.Text = "";
        }

        private void AtualizarCampos(Contato contato)
        {
            txtNome.Text = contato.Nome;
            txtEmail.Text = contato.Email;
            txtId.Text = Convert.ToString(contato.Id);
            txtEmpresa.Text = contato.Empresa;
            mkTelefone.Text = contato.Telefone;
            txtCargo.Text = contato.Cargo;
        }

        private void listBoxObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox aux = ((ListBox)sender);

            if (!(aux.SelectedItem is null))
            {
                AtualizarCampos((Contato)aux.SelectedItem);
            }
        }

        #region BOTÕES DE FILTRO DE LISTA
        private void btnTodos_Click(object sender, EventArgs e)
        {
            AtualizarLista(controlador.SelecionarTodos());
        }
        #endregion
    }
}