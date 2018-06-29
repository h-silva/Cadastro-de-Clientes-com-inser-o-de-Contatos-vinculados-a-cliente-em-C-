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
    public partial class frmCadastroCliente : Form
    {
        string tipoPessoa;
        string situacao;
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            IList<Cidade> listaDeCidades = new List<Cidade>();
            IList<string> listaDeCidadesConc = new List<string>();
            CidadeBO cidade = new CidadeBO();

            listaDeCidadesConc = cidade.selecionarCidades(listaDeCidades);

            cbCidade.DataSource = listaDeCidadesConc;

            cbCidade.DisplayMember = "cidades";



        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cbTipo.SelectedItem) == "Júridica")
            {
                mskCPFCNPJ.Mask = "99,999,9/9999,99";
                mskRGIE.Mask = "";
                lblCPFCNPJ.Text = "CNPJ";
                lblRGIE.Text = "IE";
            }
            if (Convert.ToString(cbTipo.SelectedItem) == "Física")
            {
                mskCPFCNPJ.Mask = "999,999,999-99";
                mskRGIE.Mask = "99,999,999-9";
                lblCPFCNPJ.Text = "CPF";
                lblRGIE.Text = "RG";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cidade cidade = new Cidade();
            Validacoes validacoes = new Validacoes();

            int posicaoTraco = cbCidade.Text.IndexOf("-");
            int codigoCidade = Convert.ToInt32(cbCidade.Text.Substring(0, posicaoTraco));


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
                    if (cbTipo.Text == "")
                    {
                        MessageBox.Show("Por favor, selecione o Tipo de Cliente!", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbTipo.Focus();
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
                            if (((lblCPFCNPJ.Text == "CNPJ") && (!validacoes.validarCNPJ(mskCPFCNPJ.Text))) ||
                                ((lblCPFCNPJ.Text == "CPF") && (!validacoes.validarCPF(mskCPFCNPJ.Text))))
                            {
                                MessageBox.Show("Por favor, revise seus dados pessoais!", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                mskCPFCNPJ.Focus();

                            }
                            else
                            {
                                if (mskRGIE.Text == "")
                                {
                                    // preciso encontrar um validador de IE/RG
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

                                                                ClienteBO clienteBO = new ClienteBO();
                                                                try
                                                                {
                                                                    clienteBO.inserirCliente(cliente);
                                                                    MessageBox.Show("Cadastrado com Sucesso!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                                                    this.Close();
                                                                }
                                                                catch (Exception ex)
                                                                {
                                                                    MessageBox.Show("Erro ao cadastrar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        }

        private void mskTelefone_Click(object sender, EventArgs e)
        {
            mskTelefone.Select(0, 0);
        }

        private void mskCelular_Click(object sender, EventArgs e)
        {
            mskCelular.Select(0, 0);
        }

        private void mskCPFCNPJ_Enter(object sender, EventArgs e)
        {
            if (cbTipo.Text == "")
            {
                MessageBox.Show("Por favor, selecione o tipo de Cliente!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbTipo.Focus();
            }
            else
            {
                mskCPFCNPJ.Select(0, 0);
            }
        }

        private void mskRGIE_Enter(object sender, EventArgs e)
        {
            if (cbTipo.Text == "")
            {
                MessageBox.Show("Por favor, selecione o tipo de Cliente!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbTipo.Focus();
            }
            else
            {
                mskRGIE.Select(0, 0);
            }
        }

        private void mskCPFCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)8) &&
                !(e.KeyChar == (char)44))
            {
                e.Handled = true;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)8) &&
                !(e.KeyChar == (char)44))
            {
                e.Handled = true;
            }
        }
    }
}
