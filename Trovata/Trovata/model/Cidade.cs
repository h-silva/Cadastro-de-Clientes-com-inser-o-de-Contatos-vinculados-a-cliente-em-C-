using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trovato.model
{
    class Cidade
    {
        private int codigo;
        private UF uf;
        private string nome;


        public Cidade()
        {
            uf = new UF();
        }

        public int Codigo {
            get => codigo;
            set => codigo = value;
        }
        public string Nome {
            get => nome;
            set => nome = value;
        }
        internal UF Uf {
            get => uf;
            set => uf = value;
        }
    }
}
