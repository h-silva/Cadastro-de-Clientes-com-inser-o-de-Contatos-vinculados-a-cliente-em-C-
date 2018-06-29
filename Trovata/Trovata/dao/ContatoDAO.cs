using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Trovato.model;

namespace Trovato.dao
{
    class ContatoDAO
    {
        public void inserirContato(Contatos contato)
        {
            SQLiteCommand comandoSQL = new SQLiteCommand();

            comandoSQL.CommandText = "INSERT INTO CONTATO (COD_CLIENTE, COD_CONTATO, CONTATO, SEXO, TELEFONE, CELULAR, E_MAIL) VALUES " +
                "(@cliente, null, @contato, @sexo, @telefone, @celular, @email)";
            comandoSQL.Parameters.AddWithValue("@cliente", Convert.ToInt32(contato.Cliente.Codigo));
            comandoSQL.Parameters.AddWithValue("@contato", contato.Contato);
            comandoSQL.Parameters.AddWithValue("@sexo", contato.Sexo);
            comandoSQL.Parameters.AddWithValue("@telefone", contato.Telefone);
            comandoSQL.Parameters.AddWithValue("@celular", contato.Celular);
            comandoSQL.Parameters.AddWithValue("@email", contato.Email);


            try
            {
                Conexao.CRUD(comandoSQL);

            }
            catch (SQLiteException ex)
            {

            }

        }

        public IList<Contatos> selecionarContatos(string valorID)
        {
            SQLiteCommand comandoSQL = new SQLiteCommand();
            comandoSQL.CommandText = "SELECT COD_CONTATO, CONTATO, SEXO, E_MAIL, TELEFONE," +
                " CELULAR FROM CONTATO WHERE COD_CLIENTE = @cliente";

            int codigo = Convert.ToInt32(valorID);

            comandoSQL.Parameters.AddWithValue("@cliente", codigo);

            SQLiteDataReader dr = null;

            IList<Contatos> listaDeContatos = new List<Contatos>();

            try
            {
                dr = Conexao.Select(comandoSQL);
                try
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Contatos contato = new Contatos();
                            contato.Codigo = Convert.ToInt32(dr[0].ToString());
                            contato.Contato = dr[1].ToString();
                            contato.Sexo = dr[2].ToString();
                            contato.Email = dr[3].ToString();
                            contato.Telefone = dr[4].ToString();
                            contato.Celular = dr[5].ToString();

                            listaDeContatos.Add(contato);

                        }
                        return listaDeContatos;
                    }
                }
                catch(NullReferenceException ex)
                {
                    System.Windows.Forms.MessageBox.Show("Erro com a comunicação de dados");
                }
            }
            catch (SQLiteException ex)
            {

            }
            return null;
        }

        public void deletarContatos(int valorID)
        {
            try
            {
                SQLiteCommand comandoSQL = new SQLiteCommand();
                comandoSQL.CommandText = "DELETE FROM CONTATO WHERE COD_CLIENTE = @cliente";
                comandoSQL.Parameters.AddWithValue("@cliente", valorID);

                Conexao.CRUD(comandoSQL);

            }
            catch (SQLiteException ex)
            {

            }
        }

        public void deletarContato(int valorID)
        {
            try
            {
                SQLiteCommand comandoSQL = new SQLiteCommand();
                comandoSQL.CommandText = "DELETE FROM CONTATO WHERE COD_CONTATO = @contato";
                comandoSQL.Parameters.AddWithValue("@contato", valorID);

                Conexao.CRUD(comandoSQL);

            }
            catch (SQLiteException ex)
            {
                System.Windows.Forms.MessageBox.Show("Deu erro no DELETE");

            }
        }

        public Contatos selecionarContato(string valorID)
        {
            Contatos contato = null;
            SQLiteDataReader dr = null;
            try
            {
                SQLiteCommand comandoSQL = new SQLiteCommand();
                comandoSQL.CommandText = "SELECT * FROM CONTATO WHERE COD_CONTATO = @contato";
                comandoSQL.Parameters.AddWithValue("@contato", Convert.ToInt32(valorID));

                dr = Conexao.Select(comandoSQL);
                try
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            contato = new Contatos();
                            contato.Codigo = Convert.ToInt32(valorID);
                            contato.Contato = dr["CONTATO"].ToString();
                            contato.Sexo = dr["SEXO"].ToString();
                            contato.Telefone = dr["TELEFONE"].ToString();
                            contato.Celular = dr["CELULAR"].ToString();
                            contato.Email = dr["E_MAIL"].ToString();
                        }
                    }
                }
                catch(NullReferenceException ex)
                {
                    System.Windows.Forms.MessageBox.Show("Erro com a comunicação de dados");
                }
                return contato;
            }
            catch (SQLiteException ex)
            {
                return contato;
            }
        }

        public bool alterarContato(Contatos contato)
        {
            SQLiteCommand comandoSQL = new SQLiteCommand();

            comandoSQL.CommandText = "UPDATE CONTATO SET CONTATO = @contato, SEXO = @sexo, TELEFONE = @telefone, CELULAR = @celular, E_MAIL = @email WHERE COD_CONTATO = @codigo";
            comandoSQL.Parameters.AddWithValue("@contato", contato.Contato);
            comandoSQL.Parameters.AddWithValue("@sexo", contato.Sexo);
            comandoSQL.Parameters.AddWithValue("@telefone", contato.Telefone);
            comandoSQL.Parameters.AddWithValue("@celular", contato.Celular);
            comandoSQL.Parameters.AddWithValue("@email", contato.Email);
            comandoSQL.Parameters.AddWithValue("@codigo", contato.Codigo);

            try
            {
                Conexao.CRUD(comandoSQL);

                return true;
            }
            catch (SQLiteException ex)
            {
                return false;
            }

        }

    }
}
