using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Model;
using static System.Windows.Forms.ListViewItem;

namespace SistemaGrupoEstudos
{

    public partial class Form1 : Form
    {

        private int id_editando = 0;

        public Form1()
        {
            InitializeComponent();
            listaAlunos.View = View.Details;
            listaAlunos.GridLines = true;
            listaAlunos.Columns.Add("ID", 50);
            listaAlunos.Columns.Add("Nome", 300);
            listaAlunos.Columns.Add("Telefone", 100);
            listaAlunos.FullRowSelect = true;
            this.ListarAlunos();
        }

        protected void label1_Click()
        {

        }

        protected void button1_Click()
        { 
        }

        private void ButtonInserir_Click(object sender, EventArgs e)
        {
            String nome = NomeAluno.Text;
            String telefone = TelefoneAluno.Text;
            AlunoController controller = new AlunoController();
            this.ListarAlunos();
            if (this.id_editando > 0) // Editando item
            {
                controller.atualizar(this.id_editando, nome, telefone);
                this.id_editando = 0;
                this.VisibilityBotaoAcao();
            } else // Inserindo item
            {
                controller.Inserir(nome, telefone);
            }
            NomeAluno.Text = string.Empty;
            TelefoneAluno.Text = string.Empty;
            this.ListarAlunos();
        }

        private void listaAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.VisibilityBotaoAcao();
        }

        private void VisibilityBotaoAcao()
        {
            botaoExcluir.Visible = listaAlunos.SelectedItems.Count > 0 && listaAlunos.ContainsFocus;
            BotaoEditar.Visible = listaAlunos.SelectedItems.Count > 0 && listaAlunos.ContainsFocus;
            BotaoCancelar.Visible = this.id_editando > 0;
        }

        private void ListarAlunos()
        {
            listaAlunos.Items.Clear();
            AlunoController controller = new AlunoController();
            List<Alunos> a = controller.getLista();
            foreach (Alunos aluno in a)
            {
                ListViewItem item = new ListViewItem();
                ListViewSubItem nome = new ListViewSubItem();
                ListViewSubItem telefone = new ListViewSubItem();
                item.Text = aluno.Id.ToString();
                nome.Text = aluno.Nome;
                telefone.Text = aluno.Telefone;
                item.SubItems.Add(nome);
                item.SubItems.Add(telefone);
                listaAlunos.Items.Add(item);
            }
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            if (listaAlunos.SelectedItems.Count > 0)
            {
                ListViewItem aluno_excluir = listaAlunos.SelectedItems[0];
                int id_aluno = int.Parse(aluno_excluir.Text);
                AlunoController controller = new AlunoController();
                controller.excluir(id_aluno);
                this.ListarAlunos();
            }
            this.VisibilityBotaoAcao();
        }

        private void listaAlunos_Leave(object sender, EventArgs e)
        {
            if (!botaoExcluir.ContainsFocus && !BotaoEditar.ContainsFocus)
            {
                this.VisibilityBotaoAcao();
            }
        }

        private void BotaoEditar_Click(object sender, EventArgs e)
        {
            if (listaAlunos.SelectedItems.Count > 0)
            {
                ListViewItem aluno_editar = listaAlunos.SelectedItems[0];
                int id_aluno = int.Parse(aluno_editar.Text);
                AlunoController controller = new AlunoController();
                Alunos aluno = controller.get(id_aluno);
                NomeAluno.Text = aluno.Nome;
                TelefoneAluno.Text = aluno.Telefone;
                BotaoCancelar.Visible = true;
                NomeAluno.Focus();
                this.id_editando = aluno.Id;
            }
            this.VisibilityBotaoAcao();
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            BotaoCancelar.Visible = false;
            NomeAluno.Text = string.Empty;
            TelefoneAluno.Text = string.Empty;
            this.ListarAlunos();
            this.id_editando = 0;
        }
    }
}
