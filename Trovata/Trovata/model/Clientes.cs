using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trovato.model
{
    class Clientes
    {
        private int codigo;
        private string razaoSocial;
        private string nomeFantasia;
        private string cpf_cnpj;
        private string rg_ie;
        private string tipoPessoa;
        private string situacao;
        private string telefone;
        private string celular;
        private string email;
        private string endereco;
        private int numEndereco;
        private string bairro;
        private DateTime dataCadastro;
        private Cidade cidade;

        public Clientes()
        {
            cidade = new Cidade();
        }

        public int Codigo
        {
            get => codigo;
            set => codigo = value;
        }
        public string RazaoSocial
        {
            get => razaoSocial;
            set => razaoSocial = value;
        }
        public string NomeFantasia
        {
            get => nomeFantasia;
            set => nomeFantasia = value;
        }
        public string CPF_CNPJ
        {
            get => cpf_cnpj;
            set => cpf_cnpj = value;
        }
        public string RG_IE
        {
            get => rg_ie;
            set => rg_ie = value;
        }
        public string TipoPessoa
        {
            get => tipoPessoa;
            set => tipoPessoa = value;
        }
        public string Situacao
        {
            get => situacao;
            set => situacao = value;
        }
        public string Telefone
        {
            get => telefone;
            set => telefone = value;
        }
        public string Celular
        {
            get => celular;
            set => celular = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Endereco
        {
            get => endereco;
            set => endereco = value;
        }
        public int NumEndereco
        {
            get => numEndereco;
            set => numEndereco = value;
        }
        public string Bairro
        {
            get => bairro;
            set => bairro = value;
        }
        public DateTime DataCadastro
        {
            get => dataCadastro;
            set => dataCadastro = value;
        }
        internal Cidade Cidade
        {
            get => cidade;
            set => cidade = value;
        }
    }
}
