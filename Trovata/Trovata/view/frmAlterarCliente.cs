using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trovato.model;
using Trovato.bo;

namespace Trovato.view
{
    public partial class frmAlterarCliente : Form
    {
        Clientes cliente = new Clientes();
        Cidade cidade = new Cidade();
        ClienteBO clienteBO = new ClienteBO();
        CidadeBO cidades = new CidadeBO();
        IList<Cidade> listaDeCidades = new List<Cidade>();

        string tipoPessoa;
        string situacao;

        string cidadeConc = "";
        IList<string> cidadesConc;
        string valorID;
        public frmAlterarCliente(string valorID)
        {
            this.valorID = valorID;
            InitializeComponent();



            cidadesConc = new List<string>();
            cidadesConc = cidades.selecionarCidades(listaDeCidades);

            cbCidade.DataSource = cidadesConc;

            cbCidade.DisplayMember = "cidades";

            try
            {

                cidadeConc = clienteBO.selecionarCliente(cliente, valorID, cidadeConc, cidade);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (cliente.TipoPessoa == "J")
            {
                cliente.TipoPessoa = "Júridica";
            }
            else
            {
                cliente.TipoPessoa = "Física";
            }

            if (cliente.Situacao == "A")
            {
                cliente.Situacao = "Ativo";
            }
            else
            {
                cliente.Situacao = "Inativo";
            }
            txtRazaoSocial.Text = cliente.RazaoSocial;
            txtNomeFantasia.Text = cliente.NomeFantasia;
            mskCPFCNPJ.Text = cliente.CPF_CNPJ;
            mskRGIE.Text = cliente.RG_IE;
            txtEmail.Text = cliente.Email;
            mskTelefone.Text = cliente.Telefone;
            mskCelular.Text = cliente.Celular;
            txtEndereco.Text = cliente.Endereco;
            txtNumero.Text = cliente.NumEndereco.ToString();
            txtBairro.Text = cliente.Bairro;
            cbTipo.Text = cliente.TipoPessoa;
            cbSituacao.Text = cliente.Situacao;
            cbCidade.Text = cidadeConc;
            cliente.Codigo = Convert.ToInt32(valorID);
        }

        private void frmAlterarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int posicaoTraco = cbCidade.Text.IndexOf("-");
            int codigoCidade = Convert.ToInt32(cbCidade.Text.Substring(0, posicaoTraco));
            Validacoes validacoes = new Validacoes();
            cidade.Codigo = codigoCidade;

            if (!validacoes.validarRazaoSocial(txtRazaoSocial.Text))
            {
                MessageBox.Show("Por favor, digite sua Razão Social!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRazaoSocial.Focus();
            }
            else
            {
                if (!validacoes.validarNomeFantasia(txtNomeFantasia.Text))
                {
                    MessageBox.Show("Por favor, digite seu Nome Fantasia!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomeFantasia.Focus();
                }
                else
                {
                    if (cbSituacao.Text == "")
                    {
                        MessageBox.Show("Por favor, selecione o Situação de Cliente!", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbSituacao.Focus();
                    }
                    else
                    {
                        if (!validacoes.validarEmail(txtEmail.Text))
                        {
                            MessageBox.Show("Por favor, digite um E-mail válido!", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtEmail.Focus();
                        }
                        else
                        {
                            if (!validacoes.validarTelefone(mskTelefone.Text))
                            {
                                MessageBox.Show("Por favor, digite um telefone válido!", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                mskTelefone.Focus();

                            }
                            else
                            {
                                if (!validacoes.validarTelefone(mskCelular.Text))
                                {
                                    MessageBox.Show("Por favor, digite um Celular válido!", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    mskCelular.Focus();
                                }
                                else
                                {
                                    if (!validacoes.validarEndereco(txtEndereco.Text))
                                    {
                                        MessageBox.Show("Por favor, digite um Endereço válido!", "Aviso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtEndereco.Focus();
                                    }
                                    else
                                    {
                                        if (!validacoes.validarNumero(txtNumero.Text))
                                        {
                                            MessageBox.Show("Por favor, digite um Número válido!", "Aviso",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            txtNumero.Focus();
                                        }
                                        else
                                        {
                                            if (!validacoes.validarBairro(txtBairro.Text))
                                            {
                                                MessageBox.Show("Por favor, digite um Bairro válido!", "Aviso",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                txtBairro.Focus();
                                            }
                                            else
                                            {
                                                if (cbCidade.Text == "")
                                                {
                                                    MessageBox.Show("Por favor, selecione uma Cidade!", "Aviso",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    cbCidade.Focus();
                                                }
                                                else
                                                {
                                                    if (cbTipo.Text == "Júridico")
                                                    {
                                                        tipoPessoa = "J";
                                                    }
                                                    else
                                                    {
                                                        tipoPessoa = "F";
                                                    }



                                                    if (cbSituacao.Text == "Ativo")
                                                    {
                                                        situacao = "A";
                                                    }
                                                    else
                                                    {
                                                        situacao = "I";
                                                    }

                                                    Clientes cliente = new Clientes();
                                                    cliente.RazaoSocial = txtRazaoSocial.Text;
                                                    cliente.NomeFantasia = txtNomeFantasia.Text;
                                                    cliente.CPF_CNPJ = mskCPFCNPJ.Text;
                                                    cliente.RG_IE = mskRGIE.Text;
                                                    cliente.TipoPessoa = tipoPessoa;
                                                    cliente.Situacao = situacao;
                                                    cliente.Telefone = mskTelefone.Text;
                                                    cliente.Celular = mskCelular.Text;
                                                    cliente.Email = txtEmail.Text;
                                                    cliente.Endereco = txtEndereco.Text;
                                                    cliente.NumEndereco = Convert.ToInt32(txtNumero.Text);
                                                    cliente.Bairro = txtBairro.Text;
                                                    cliente.Cidade = cidade;
                                                    cliente.Codigo = Convert.ToInt32(valorID);

                                                    ClienteBO clienteBO = new ClienteBO();

                                                    try
                                                    {
                                                        clienteBO.alterarCliente(cliente);
                                                        MessageBox.Show("Alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        this.Close();
                                                    }
                                                    catch(Exception ex)
                                                    {
                                                        MessageBox.Show("Erro ao alterar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

