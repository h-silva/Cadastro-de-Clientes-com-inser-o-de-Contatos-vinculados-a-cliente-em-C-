using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trovato.bo
{
    class Validacoes
    {
        public bool validarCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        public  bool validarCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        int quantidadeNumeros;
        public bool validarTelefone(string telefone)
        {
            quantidadeNumeros = 0;
            for (int item = 0; item < telefone.Length; item++)
            {
                if (Char.IsNumber(telefone[item]))
                {
                    quantidadeNumeros++;
                }
            }
            if (quantidadeNumeros == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validarEmail(string email)
        {
            if ((email.Length < 5) || ((!email.Contains("@") && (!email.Contains(".")))))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validarNomeFantasia(string nomeFantasia)
        {
            if(nomeFantasia.Length < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validarRazaoSocial(string razaoSocial)
        {
            if (razaoSocial.Length < 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool validarEndereco(string endereco)
        {
            if (endereco.Length < 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validarContato(string contato)
        {
            if (contato.Length < 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validarBairro(string bairro)
        {
            if (bairro.Length < 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validarNumero(string numero)
        {
            if (numero.Length < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
