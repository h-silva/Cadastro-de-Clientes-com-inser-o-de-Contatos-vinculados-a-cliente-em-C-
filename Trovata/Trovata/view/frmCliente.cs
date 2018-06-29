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
    
    public partial class frmCliente : Form
    {
        string valorID;
        public frmCliente()
        {
            InitializeComponent();

            dgvClientes.Rows.Clear();

            dgvClientes.ColumnCount = 16;

            dgvClientes.Columns[0].Width = 50;
            dgvClientes.Columns[0].Name = "ID";

            dgvClientes.Columns[1].Width = 150;
            dgvClientes.Columns[1].Name = "Razão Social";

            dgvClientes.Columns[2].Width = 150;
            dgvClientes.Columns[2].Name = "Nome Fantasia";

            dgvClientes.Columns[3].Width = 150;
            dgvClientes.Columns[3].Name = "CPF/CNPJ";

            dgvClientes.Columns[4].Width = 150;
            dgvClientes.Columns[4].Name = "RG/IE";

            dgvClientes.Columns[5].Width = 80;
            dgvClientes.Columns[5].Name = "Situação";

            dgvClientes.Columns[6].Width = 80;
            dgvClientes.Columns[6].Name = "Tipo";

            dgvClientes.Columns[7].Width = 150;
            dgvClientes.Columns[7].Name = "Telefone";

            dgvClientes.Columns[8].Width = 150;
            dgvClientes.Columns[8].Name = "Celular";

            dgvClientes.Columns[9].Width = 200;
            dgvClientes.Columns[9].Name = "Email";

            dgvClientes.Columns[10].Width = 150;
            dgvClientes.Columns[10].Name = "Endereço";

            dgvClientes.Columns[11].Width = 80;
            dgvClientes.Columns[11].Name = "Número";

            dgvClientes.Columns[12].Width = 100;
            dgvClientes.Columns[12].Name = "Bairro";

            dgvClientes.Columns[13].Width = 135;
            dgvClientes.Columns[13].Name = "Cidade";

            dgvClientes.Columns[14].Width = 80;
            dgvClientes.Columns[14].Name = "Estado";

            dgvClientes.Columns[15].Width = 80;
            dgvClientes.Columns[15].Name = "País";

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            IList<Clientes> listaDeClientes = new List<Clientes>();
            IList<Contatos> listaDeContatos = new List<Contatos>();
            IList<Cidade> listaDeCidades = new List<Cidade>();
            IList<UF> listaDeEstados = new List<UF>();
            IList<Pais> listadePaises = new List<Pais>();


            ClienteBO clienteBO = new ClienteBO();

            listaDeClientes = clienteBO.selecionarClientes(listaDeCidades,listaDeEstados,listadePaises);
            string[] linha;
            

            dgvClientes.Rows.Clear();

            for(int i = 0; i < listaDeClientes.Count;i++)
            {
                if (listaDeClientes[i].TipoPessoa == "J")
                {
                    listaDeClientes[i].TipoPessoa = "Júridica";
                }
                else
                {
                    listaDeClientes[i].TipoPessoa = "Física";
                }

                if (listaDeClientes[i].Situacao == "A")
                {
                    listaDeClientes[i].Situacao = "Ativo";
                }
                else
                {
                    listaDeClientes[i].Situacao = "Inativo";
                }
                linha = new string[]
                    {

                      listaDeClientes[i].Codigo.ToString(),
                      listaDeClientes[i].RazaoSocial.ToString(),
                      listaDeClientes[i].NomeFantasia.ToString(),
                      listaDeClientes[i].CPF_CNPJ.ToString(),
                      listaDeClientes[i].RG_IE.ToString(),
                      listaDeClientes[i].Situacao.ToString(),
                      listaDeClientes[i].TipoPessoa.ToString(),
                      listaDeClientes[i].Telefone.ToString(),
                      listaDeClientes[i].Celular.ToString(),
                      listaDeClientes[i].Email.ToString(),
                      listaDeClientes[i].Endereco.ToString(),
                      listaDeClientes[i].NumEndereco.ToString(),
                      listaDeClientes[i].Bairro.ToString(),
                      listaDeCidades[i].Nome.ToString(),
                      listaDeEstados[i].Nome.ToString(),
                      listadePaises[i].Nome.ToString()                     
                    };
                dgvClientes.Rows.Add(linha);
            }
            dgvClientes.ClearSelection();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frmCadastroCliente = new frmCadastroCliente();
            this.Hide();
            this.ShowInTaskbar = false;
            frmCadastroCliente.ShowDialog();
            this.Show();
            this.ShowInTaskbar = true;
            frmCliente_Load(sender, e);
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valorID = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ClienteBO clienteBO = new ClienteBO();
            if (valorID != null)
            {
                if(MessageBox.Show("Deseja excluir este cadastro? Isto apagará todos seus contatos", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    try
                    {
                        if (clienteBO.excluirCliente(Convert.ToInt32(valorID)))
                        {
                            ContatoBO contato = new ContatoBO();
                            contato.deletarContatos(Convert.ToInt32(valorID));
                            MessageBox.Show("Excluido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmCliente_Load(sender, e);
                            valorID = null;
                        }
                       
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Não excluiu \n {ex.ToString()}");
                    }
                }
            
            }
            else
            {
                MessageBox.Show("Selecione um cliente para excluir!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ClienteBO clienteBO = new ClienteBO();
            if (valorID != null)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                frmAlterarCliente frmAlterar = new frmAlterarCliente(valorID);
                frmAlterar.ShowDialog();
                this.Show();
                this.ShowInTaskbar = true;
                frmCliente_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Selecione um cliente para Alterar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvClientes_Enter(object sender, EventArgs e)
        {
            try
            {
                valorID = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valorID = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                valorID = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            if (valorID != null)
            {
                frmContato contatos = new frmContato(valorID);
                this.Hide();
                this.ShowInTaskbar = false;
                contatos.ShowDialog();
                this.Show();
                this.ShowInTaskbar = true;
            }
            else
            {
                MessageBox.Show("Selecione um cliente para ver os Contatos!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
