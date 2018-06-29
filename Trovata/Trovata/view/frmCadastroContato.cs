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
    public partial class frmCadastroContato : Form
    {
        string valorID;
        string sexo;
        Clientes cliente = new Clientes();
        public frmCadastroContato(string valorID)
        {
            InitializeComponent();
            this.valorID = valorID;
        }

        private void mskCelular_Click(object sender, EventArgs e)
        {
            mskCelular.Select(0, 0);
        }

        private void mskTelefone_Click(object sender, EventArgs e)
        {
            mskTelefone.Select(0, 0);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cliente.Codigo = Convert.ToInt32(valorID);
            Validacoes validacoes = new Validacoes();
            Contatos contato = new Contatos();
            ContatoBO contatoBO = new ContatoBO();
            if (!validacoes.validarContato(txtContato.Text))
            {
                MessageBox.Show("Por favor, digite um Contato válido!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContato.Focus();
            }
            else
            {
                if(cbSexo.Text == "")
                {
                    MessageBox.Show("Por favor, selecione o Sexo!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbSexo.Focus();
                }
                else
                {
                    if (!validacoes.validarEmail(txtEmail.Text))
                    {
                        MessageBox.Show("Por favor, digite um Email váido!!", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Focus();
                    }
                    else
                    {
                        if (!validacoes.validarTelefone(mskTelefone.Text))
                        {
                            MessageBox.Show("Por favor, digite um Telefone válido!", "Aviso",
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
                                if (cbSexo.SelectedItem.ToString() == "Feminino")
                                {
                                    sexo = "F";
                                }
                                else
                                {
                                    sexo = "M";
                                }
                                contato.Contato = txtContato.Text;
                                contato.Sexo = sexo;
                                contato.Telefone = mskTelefone.Text;
                                contato.Celular = mskCelular.Text;
                                contato.Email = txtEmail.Text;
                                contato.Cliente = cliente;
                                try
                                {
                                    contatoBO.inserirContato(contato);
                                    MessageBox.Show("Cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                catch(Exception ex)
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
