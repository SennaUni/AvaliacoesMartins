using Prova_Programação__Colections___Orientação_de_Objetos_.Communs;
using Prova_Programação__Colections___Orientação_de_Objetos_.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_Programação__Colections___Orientação_de_Objetos_
{
    public partial class Form1 : Form
    {
        private List<Produto> listaProdutos = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
            AllInvisible();
            lblCadastrados.Text = ContagemList(listaProdutos) + " Protudos Inseridos!";
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllInvisible();
            lblCadastrados.Visible = true;
            lblCadastrados.Text = ContagemList(listaProdutos) + " Produtos Inseridos!";
        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllInvisible();
            Formularios();
            btnCadastrar.Visible = true;
        }

        private void editarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllInvisible();
            Formularios();
            FormularioId();
            btnEditar.Visible = true;
        }

        private void removerProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllInvisible();
            FormularioId();
            btnRemover.Visible = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto cadProdutos = GetProduto();
                listaProdutos.Add(cadProdutos);
                Listar();
                LimpaCampo();
                MessageBox.Show("Produto Inserido com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Favor Inserir Valores Validos!");
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarProduto(listaProdutos);
            Listar();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Remover(listaProdutos);
            Listar();
        }

        private Produto GetProduto()
        {
            Produto cadProdutos = new Produto();

            cadProdutos.Nome = tBoxNome.Text;
            cadProdutos.Tipo = Convert.ToString(cBoxCategoria.SelectedItem);
            cadProdutos.Valor = Conversao.ConvertFloat(tBoxValor.Text);
            cadProdutos.Data = Conversao.ConvertDate(mTBoxData.Text);

            return cadProdutos; //<analizar esse satanas
        }

        private void Listar()
        {
            dataGVListar.DataSource = null;
            dataGVListar.DataSource = listaProdutos;
        }

        private int ContagemList(List<Produto> listaProdutos)
        {
            int contagem = listaProdutos.Count();
            return contagem;
        }

        private bool EditarProduto(List<Produto> listaProdutos)
        {
            if (ContagemList(listaProdutos) == 0)
            {
                MessageBox.Show("Nenhuma Produto Cadastrado!"); 
            }
            else
            {
                foreach (var cadastros in listaProdutos)
                {
                    if (cadastros.Nome == tBoxNomeProcurar.Text)
                    {
                        cadastros.Nome = tBoxNome.Text;
                        cadastros.Tipo = cBoxCategoria.Text;
                        cadastros.Valor = Conversao.ConvertFloat(tBoxValor.Text);
                        cadastros.Data = Conversao.ConvertDate(mTBoxData.Text);
                        MessageBox.Show("Edição Realizada!");
                        return true;
                    }    
                }
                MessageBox.Show("Favor Inserir um Nome Válido!");
            }
            return false;
        }

        private bool Remover(List<Produto> listaProdutos)
        {
            if (ContagemList(listaProdutos) == 0)
            {
                MessageBox.Show("Nenhuma Produto Cadastrado!");
            }
            else
            {
                foreach (var cadastros in listaProdutos)
                {
                    if (cadastros.Nome == tBoxNomeProcurar.Text)
                    {
                        if (MessageBox.Show("Deseja Realmente Remover?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            MessageBox.Show("Cadastro Removido com Sucesso!");
                            listaProdutos.Remove(cadastros);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Cadastro Não Removido!");
                            return false;
                        }
                    }
                }
                MessageBox.Show("Favor Inserir um Nome Válido!");
            }
            return false;
        }

        private void Formularios()
        {
            lblCategoria.Visible = true;
            lblData.Visible = true;
            lblNome.Visible = true;
            lblValor.Visible = true;
            tBoxNome.Visible = true;
            tBoxValor.Visible = true;
            mTBoxData.Visible = true;
            cBoxCategoria.Visible = true;
            lblCadastrados.Visible = false;
            dataGVListar.Visible = true;
        }

        private void FormularioId()
        {
            lblNomeEditar.Visible = true;
            tBoxNomeProcurar.Visible = true;
            dataGVListar.Visible = true;
        }

        private void AllInvisible()
        {
            lblCategoria.Visible = false;
            lblData.Visible = false;
            lblNome.Visible = false;
            lblNomeEditar.Visible = false;
            lblValor.Visible = false;
            tBoxNome.Visible = false;
            tBoxNomeProcurar.Visible = false;
            tBoxValor.Visible = false;
            mTBoxData.Visible = false;
            cBoxCategoria.Visible = false;
            btnCadastrar.Visible = false;
            btnEditar.Visible = false;
            btnRemover.Visible = false;
            dataGVListar.Visible = false;
        }
        private void LimpaCampo()
        {
            tBoxNome.Clear();
            cBoxCategoria.SelectedIndex = -1;
            mTBoxData.Clear();
            tBoxValor.Clear();
        }
    }
}
