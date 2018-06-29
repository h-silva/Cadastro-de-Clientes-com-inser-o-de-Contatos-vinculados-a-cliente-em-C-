using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trovato.model;
using System.Data.SQLite;

namespace Trovato.dao
{
    class CidadeDAO
    {

        public IList<string> selecionarCidades(IList<Cidade> listaDeCidades)
        {
            SQLiteCommand comandoSQL = new SQLiteCommand();

            comandoSQL.CommandText = "SELECT COD_CIDADE, NOME, COD_CIDADE || '-' || NOME as dados FROM CIDADE";

            SQLiteDataReader dr = Conexao.Select(comandoSQL);

            IList<string> ListaDeCidadesConc = new List<string>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string cidadeConc;
                    Cidade cidade = new Cidade();
                    cidade.Codigo = Convert.ToInt32(dr[0].ToString());
                    cidade.Nome = dr[1].ToString();
                    cidadeConc = dr[2].ToString();

                    ListaDeCidadesConc.Add(cidadeConc);
                    listaDeCidades.Add(cidade);
                }
            }
            return ListaDeCidadesConc;
        }
    }
}
