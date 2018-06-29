using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trovato.model
{
    class Contatos
    {
        private int codigo;
        private string contato;
        private string sexo;
        private string telefone;
        private string celular;
        private string email;
        private Clientes cliente;

        public Contatos()
        {
            cliente = new Clientes();
        }

        public int Codigo {
            get => codigo;
            set => codigo = value;
        }
        public String Contato {
            get => contato;
            set => contato = value;
        }
        public string Sexo {
            get => sexo;
            set => sexo = value;
        }
        public string Telefone {
            get => telefone;
            set => telefone = value;
        }
        public string Celular {
            get => celular;
            set => celular = value;
        }
        public string Email {
            get => email;
            set => email = value;
        }
        internal Clientes Cliente {
            get => cliente;
            set => cliente = value;
        }
    }
}
