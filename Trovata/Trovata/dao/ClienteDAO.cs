using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trovato.model;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Trovato.dao
{
    class ClienteDAO
    {
        String cidadeConc;
        public string mensagem = "";
        public bool verifica = false;
        public void InserirCliente(Clientes cliente)
        {
            SQLiteCommand comandoSQL = new SQLiteCommand();

            comandoSQL.CommandText = "INSERT INTO CLIENTE VALUES (null," +
                "@razaoSocial, @nomefantasia, @cpfcnpj, @rgie, @tipopessoa, @situacao," +
                "@telefone, @celular, @email, @endereco, @numendereco, @bairro, @cidade, @data)";

            comandoSQL.Parameters.AddWithValue("@razaoSocial", cliente.RazaoSocial);
            comandoSQL.Parameters.AddWithValue("@nomefantasia", cliente.NomeFantasia);
            comandoSQL.Parameters.AddWithValue("@cpfcnpj", cliente.CPF_CNPJ);
            comandoSQL.Parameters.AddWithValue("@rgie", cliente.RG_IE);
            comandoSQL.Parameters.AddWithValue("@tipopessoa", cliente.TipoPessoa);
            comandoSQL.Parameters.AddWithValue("@situacao", cliente.Situacao);
            comandoSQL.Parameters.AddWithValue("@telefone", cliente.Telefone);
            comandoSQL.Parameters.AddWithValue("@celular", cliente.Celular);
            comandoSQL.Parameters.AddWithValue("@email", cliente.Email);
            comandoSQL.Parameters.AddWithValue("@endereco", cliente.Endereco);
            comandoSQL.Parameters.AddWithValue("@numendereco", cliente.NumEndereco);
            comandoSQL.Parameters.AddWithValue("@bairro", cliente.Bairro);
            comandoSQL.Parameters.AddWithValue("@cidade", cliente.Cidade.Codigo);
            comandoSQL.Parameters.AddWithValue("@data", DateTime.Now);

            try{
                Conexao.CRUD(comandoSQL);
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show($"Erro ao inserir, contate um admin", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public IList<Clientes> SelecionarClientes(IList<Cidade> listaDeCidades, IList<UF> listaDeEstados,
             IList<Pais> listadePaises)
        {
            
            List<Clientes> listaDeClientes = new List<Clientes>();

            SQLiteCommand comandoSQL = new SQLiteCommand();

            comandoSQL.CommandText = "SELECT C.COD_CLIENTE, C.RAZAO_SOCIAL, C.NOME_FANTASIA, " +
                "C.CPF_CNPJ, C.RG_IE, C.TIPO_PESSOA, C.SITUACAO, C.TELEFONE, C.CELULAR, " +
                "C.E_MAIL, C.ENDERECO, C.NUM_ENDERECO, C.BAIRRO, I.COD_CIDADE, I.NOME, I.UF, " +
                "E.COD_UF, E.NOME, E.SIGLA, E.PAIS, P.COD_PAIS, P.NOME, P.SIGLA FROM CLIENTE C " +
                "INNER JOIN CIDADE I ON C.CIDADE = I.COD_CIDADE INNER JOIN UF E ON I.UF = E.COD_UF" +
                " INNER JOIN PAIS P ON E.PAIS = P.COD_PAIS";

            SQLiteDataReader dr;

            try
            {
                dr = Conexao.Select(comandoSQL);

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Pais pais = new Pais();
                        pais.Codigo = Convert.ToInt32(dr[20].ToString());
                        pais.Nome = dr[21].ToString();
                        pais.Sigla = dr[22].ToString();

                        UF estado = new UF();
                        estado.Codigo = Convert.ToInt32(dr[16].ToString());
                        estado.Nome = dr[17].ToString();
                        estado.Sigla = dr[18].ToString();

                        Cidade cidade = new Cidade();
                        cidade.Codigo = Convert.ToInt32(dr[13].ToString());
                        cidade.Nome = dr[14].ToString();

                        Clientes cliente = new Clientes();
                        cliente.Codigo = Convert.ToInt32(dr[0].ToString());
                        cliente.RazaoSocial = dr[1].ToString();
                        cliente.NomeFantasia = dr[2].ToString();
                        cliente.CPF_CNPJ = dr[3].ToString();
                        cliente.RG_IE = dr[4].ToString();
                        cliente.TipoPessoa = dr[5].ToString();
                        cliente.Situacao = dr[6].ToString();
                        cliente.Telefone = dr[7].ToString();
                        cliente.Celular = dr[8].ToString();
                        cliente.Email = dr[9].ToString();
                        cliente.Endereco = dr[10].ToString();
                        cliente.NumEndereco = Convert.ToInt32(dr[11].ToString());
                        cliente.Bairro = dr[12].ToString();
                        listaDeCidades.Add(cidade);
                        listaDeEstados.Add(estado);
                        listadePaises.Add(pais);
                        listaDeClientes.Add(cliente);
                    }
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Erro com a comunicação de dados");
            }
            return listaDeClientes;
        }

        public bool excluirCliente(int valorID)
        {
            SQLiteCommand comandoSQL = new SQLiteCommand();
            comandoSQL.CommandText = "DELETE FROM CLIENTE WHERE COD_CLIENTE = @codigo";
            comandoSQL.Parameters.AddWithValue("@codigo", valorID);


            try
            {
                Conexao.CRUD(comandoSQL);
                return true;
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show($"Erro ao excluir, contate um admin","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }           
        }

        public bool alterarCliente(Clientes cliente)
        {
            SQLiteCommand comandoSQL = new SQLiteCommand();

            comandoSQL.CommandText = "UPDATE CLIENTE SET RAZAO_SOCIAL = @razaoSocial, NOME_FANTASIA = @nomefantasia, " +
                "CPF_CNPJ = @cpfcnpj, RG_IE = @rgie, TIPO_PESSOA = @tipopessoa, SITUACAO = @situacao, " +
                "TELEFONE = @telefone, CELULAR = @celular, E_MAIL = @email, ENDERECO = @endereco, " +
                "NUM_ENDERECO = @numendereco, BAIRRO = @bairro, CIDADE = @cidade WHERE COD_CLIENTE = @codigo";

            comandoSQL.Parameters.AddWithValue("@razaoSocial", cliente.RazaoSocial);
            comandoSQL.Parameters.AddWithValue("@nomefantasia", cliente.NomeFantasia);
            comandoSQL.Parameters.AddWithValue("@cpfcnpj", cliente.CPF_CNPJ);
            comandoSQL.Parameters.AddWithValue("@rgie", cliente.RG_IE);
            comandoSQL.Parameters.AddWithValue("@tipopessoa", cliente.TipoPessoa);
            comandoSQL.Parameters.AddWithValue("@situacao", cliente.Situacao);
            comandoSQL.Parameters.AddWithValue("@telefone", cliente.Telefone);
            comandoSQL.Parameters.AddWithValue("@celular", cliente.Celular);
            comandoSQL.Parameters.AddWithValue("@email", cliente.Email);
            comandoSQL.Parameters.AddWithValue("@endereco", cliente.Endereco);
            comandoSQL.Parameters.AddWithValue("@numendereco", cliente.NumEndereco);
            comandoSQL.Parameters.AddWithValue("@bairro", cliente.Bairro);
            comandoSQL.Parameters.AddWithValue("@cidade", cliente.Cidade.Codigo);
            comandoSQL.Parameters.AddWithValue("@codigo", cliente.Codigo);


            try
            {
                Conexao.CRUD(comandoSQL);
                return true;
                
            }
            catch(SQLiteException ex)
            {
            }
            return false;
        }

        public string selecionarCliente(Clientes cliente, string valorID,String cidadeConc, Cidade cidade)
        {

            SQLiteCommand comandoSQL = new SQLiteCommand();

            comandoSQL.CommandText = "SELECT C.RAZAO_SOCIAL, C.NOME_FANTASIA, " +
                "C.CPF_CNPJ, C.RG_IE, C.TIPO_PESSOA, C.SITUACAO, C.TELEFONE, C.CELULAR, " +
                "C.E_MAIL, C.ENDERECO, C.NUM_ENDERECO, C.BAIRRO, I.COD_CIDADE, I.NOME, I.COD_CIDADE || '-' || I.NOME as dados FROM " +
                "CLIENTE C INNER JOIN CIDADE I ON C.CIDADE = I.COD_CIDADE WHERE C.COD_CLIENTE = @codigo";

            comandoSQL.Parameters.AddWithValue("@codigo", valorID);


            SQLiteDataReader dr = null;

            try
            {
                dr = Conexao.Select(comandoSQL);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cliente.Codigo = Convert.ToInt32(valorID);
                        cliente.RazaoSocial = dr[0].ToString();
                        cliente.NomeFantasia = dr[1].ToString();
                        cliente.CPF_CNPJ = dr[2].ToString();
                        cliente.RG_IE = dr[3].ToString();
                        cliente.TipoPessoa = dr[4].ToString();
                        cliente.Situacao = dr[5].ToString();
                        cliente.Telefone = dr[6].ToString();
                        cliente.Celular = dr[7].ToString();
                        cliente.Email = dr[8].ToString();
                        cliente.Endereco = dr[9].ToString();
                        cliente.NumEndereco = Convert.ToInt32(dr[10].ToString());
                        cliente.Bairro = dr[11].ToString();
                        cidade.Codigo = Convert.ToInt32(dr[12].ToString());
                        cidade.Nome = dr[13].ToString();
                        this.cidadeConc = dr[14].ToString();
                        cidadeConc = this.cidadeConc;
                    }
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Erro com a comunicação de dados");
            }
            return cidadeConc;
        }

    }
}
