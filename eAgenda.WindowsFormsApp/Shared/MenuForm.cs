using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.Shared;
using eAgenda.Dominio.TarefaModule;
using eAgenda.WindowsFormsApp.CompromisoModule;
using eAgenda.WindowsFormsApp.ContatoModule;
using eAgenda.WindowsFormsApp.TarefaModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.CompromissoModule;

namespace eAgenda.WindowsFormsApp.Shared
{
    public partial class MenuForm : Form
    {
        Form formSelecionado;
        ControladorCompromisso controladorCompromisso;
        ControladorContato controladorContato;
        ControladorTarefa controladorTarefa;

        public MenuForm()
        {
            InitializeComponent();
            controladorCompromisso = new ControladorCompromisso();
            controladorContato = new ControladorContato();
            controladorTarefa = new ControladorTarefa();
        }
        private void AtualizarLista(List<EntidadeBase> aux)
        {
            listBoxObjetos.Items.Clear();
            foreach (var item in aux)
            {
                listBoxObjetos.Items.Add(item);
            }
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            formSelecionado = new FormTarefa(controladorTarefa);

            List<EntidadeBase> aux = controladorTarefa.SelecionarTodos().Select(t => (EntidadeBase)t).ToList();
            AtualizarLista(aux);
        }

        private void btnContato_Click(object sender, EventArgs e)
        {
            formSelecionado = new FormContato(controladorContato);

            List<EntidadeBase> aux = controladorContato.SelecionarTodos().Select(t => (EntidadeBase)t).ToList();
            AtualizarLista(aux);
        }

        private void btnCompromisso_Click(object sender, EventArgs e)
        {
            formSelecionado = new FormCompromisso(controladorCompromisso,controladorContato);

            List<EntidadeBase> aux = controladorCompromisso.SelecionarTodos().Select(t => (EntidadeBase)t).ToList();
            AtualizarLista(aux);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (formSelecionado != null)
                formSelecionado.ShowDialog();
            else MessageBox.Show("Selecione um Item Primeiro");
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("As Configurações Foram Ajustadas com sucesso :-)");
        }
        private void CarregarFormulario(EntidadeBase itemSelecionadoList)
        {
            if (formSelecionado is FormContato) formSelecionado = new FormContato((Contato)itemSelecionadoList, controladorContato);
            if (formSelecionado is FormCompromisso) formSelecionado = new FormCompromisso((Compromisso)itemSelecionadoList, controladorCompromisso,controladorContato);
            if (formSelecionado is FormTarefa) formSelecionado = new FormTarefa((Tarefa)itemSelecionadoList,controladorTarefa);

            formSelecionado.ShowDialog();
            AtualizarLista(new List<EntidadeBase>());
        }

        private void listBoxObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox aux = ((ListBox)sender);

            if (!(aux.SelectedItem is null))
            {
                CarregarFormulario((EntidadeBase)aux.SelectedItem);
            }
        }
    }
}
