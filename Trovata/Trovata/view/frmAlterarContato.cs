using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trovato.bo;
using Trovato.model;

namespace Trovato.view
{
    public partial class frmAlterarContato : Form
    {
      
        string sexo;
        string valorID;

        public frmAlterarContato(string valorID)
        {
            InitializeComponent();
            this.valorID = valorID;

            try
            {
                Contatos contato = new Contatos();
                ContatoBO contatoBO = new ContatoBO();
                contato = contatoBO.selecionarContato(valorID);

                if (contato.Sexo == "F")
                {
                    sexo = "Feminino";
                }
                else
                {
                    sexo = "Masculino";
                }


                txtContato.Text = contato.Contato;
                cbSexo.Text = sexo;
                mskCelular.Text = contato.Celular;
                mskTelefone.Text = contato.Telefone;
                txtEmail.Text = contato.Email;

            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Validacoes validacoes = new Validacoes();
            if(cbSexo.SelectedItem.ToString() == "Feminino")
            {
                sexo = "F";
            }
            else
            {
                sexo = "M";
            }
            if (!validacoes.validarContato(txtContato.Text))
            {
                MessageBox.Show("Por favor, digite Contato!", "Aviso",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContato.Focus();
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
                    if (!validacoes.validarTelefone(mskTelefone.Text))
                    {
                        MessageBox.Show("Por favor, digite um Telefone válido!!", "Aviso",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mskTelefone.Focus();
                    }
                    else
                    {
                        if (!validacoes.validarEmail(txtEmail.Text))
                        {
                            MessageBox.Show("Por favor, digite um Email válido!", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtEmail.Focus();
                        }
                        else
                        {
                            ContatoBO contatoBO = new ContatoBO();
                            Contatos contato = new Contatos();
                            contato.Contato = txtContato.Text;
                            contato.Sexo = sexo;
                            contato.Telefone = mskTelefone.Text;
                            contato.Celular = mskCelular.Text;
                            contato.Email = txtEmail.Text;
                            contato.Codigo = Convert.ToInt32(valorID);

                            try
                            {
                                contatoBO.alterarContato(contato);
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

        private void frmAlterarContato_Load(object sender, EventArgs e)
        {
           
        }
    }
}
