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
    public partial class frmContato : Form
    {
        string sexo;
        string valorID;
        string valorContato;
        public frmContato(string valorID)
        {
            InitializeComponent();
            this.valorID = valorID;

            dgvContatos.ColumnCount = 6;

            dgvContatos.ClearSelection();

            dgvContatos.Columns[0].Width = 50;
            dgvContatos.Columns[0].Name = "ID";

            dgvContatos.Columns[1].Width = 150;
            dgvContatos.Columns[1].Name = "Contato";

            dgvContatos.Columns[2].Width = 100;
            dgvContatos.Columns[2].Name = "Sexo";

            dgvContatos.Columns[3].Width = 150;
            dgvContatos.Columns[3].Name = "Telefone";

            dgvContatos.Columns[4].Width = 150;
            dgvContatos.Columns[4].Name = "Celular";

            dgvContatos.Columns[5].Width = 200;
            dgvContatos.Columns[5].Name = "Email";

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            frmCadastroContato CadastroContato = new frmCadastroContato(valorID);
            this.Hide();
            this.ShowInTaskbar = false;
            CadastroContato.ShowDialog();

            frmContato_Load(sender, e);
            this.Show();
            this.ShowInTaskbar = true;
            
        }

        private void frmContato_Load(object sender, EventArgs e)
        {
            

            string[] linha;

            dgvContatos.Rows.Clear();

            IList<Contatos> listaDeContatos = new List<Contatos>();
            ContatoBO contatoBO = new ContatoBO();

            listaDeContatos = contatoBO.selecionarContatos(valorID);

            if (listaDeContatos != null)
            {
                for (int i = 0; i < listaDeContatos.Count; i++)
                {

                    if (listaDeContatos[i].Sexo == "F")
                    {
                        sexo = "Feminino";
                    }
                    else
                    {
                        sexo = "Masculino";
                    }
                    linha = new string[]
                    {
                    listaDeContatos[i].Codigo.ToString(),
                    listaDeContatos[i].Contato.ToString(),
                    listaDeContatos[i].Sexo = sexo.ToString(),
                    listaDeContatos[i].Telefone.ToString(),
                    listaDeContatos[i].Celular.ToString(),
                    listaDeContatos[i].Email.ToString()
                    };
                    dgvContatos.Rows.Add(linha);
                }
                dgvContatos.ClearSelection();
            }
        }

        private void dgvContatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valorContato = dgvContatos.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valorContato = dgvContatos.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvContatos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                valorContato = dgvContatos.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(valorContato != null)
            {
                frmAlterarContato alterarContato = new frmAlterarContato(valorContato);
                this.Hide();
                this.ShowInTaskbar = false;
                alterarContato.ShowDialog();
                this.Show();
                this.ShowInTaskbar = true;
                valorContato = null;
            }
            else
            {
                MessageBox.Show("Selecione Contato para Alterar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if(valorContato != null)
            {
                ContatoBO contatoBO = new ContatoBO();
                if (MessageBox.Show("Deseja excluir este contato?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        contatoBO.deletarContato(Convert.ToInt32(valorContato));                      
                            MessageBox.Show("Excluido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmContato_Load(sender, e);
                            valorContato = null;                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para Deletar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
