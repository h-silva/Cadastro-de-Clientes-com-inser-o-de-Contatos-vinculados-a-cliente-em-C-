using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Trovato.model;
using Trovato.dao;

namespace Trovato.bo
{
    class CidadeBO
    {
        public IList<string> selecionarCidades(IList<Cidade> listaDeCidades)
        {

            CidadeDAO cidadeDAO = new CidadeDAO();
            IList<String> listaDeCidadesConc = new List<string>();

            listaDeCidadesConc = cidadeDAO.selecionarCidades(listaDeCidades);



            return listaDeCidadesConc;

        }

    }
}
