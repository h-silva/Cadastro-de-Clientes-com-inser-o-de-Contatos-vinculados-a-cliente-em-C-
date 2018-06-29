using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trovato.model
{
    class Pais
    {   
        private int codigo;
        private string nome;
        private string sigla;


        public Pais() {

        }

        public int Codigo
        {
            get => codigo;
            set => codigo = value;
        }
        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public string Sigla
        {
            get => sigla;
            set => sigla = value;
        }
    }
}
