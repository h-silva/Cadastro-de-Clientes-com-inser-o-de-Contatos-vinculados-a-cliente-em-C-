using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trovato.model;
using Trovato.dao;

namespace Trovato.bo
{
    class ClienteBO
    {
        public string mensagem = "";
            public bool verifica = false;
        public void inserirCliente(Clientes cliente)
        {
            ClienteDAO clienteDAO = new ClienteDAO();

            clienteDAO.InserirCliente(cliente);

        }
        public IList<Clientes> selecionarClientes(IList<Cidade> listaDeCidades, IList<UF> listaDeEstados,
             IList<Pais> listadePaises)
        {
            IList<Clientes> listaDeClientes = new List<Clientes>();

            ClienteDAO clienteDAO = new ClienteDAO();


           listaDeClientes = clienteDAO.SelecionarClientes(listaDeCidades, listaDeEstados, listadePaises);

            for(int i =0; i < listaDeCidades.Count; i++)
            {
                listaDeClientes[i].Cidade = listaDeCidades[i];
                listaDeCidades[i].Uf = listaDeEstados[i];
                listaDeEstados[i].Pais = listadePaises[i];
            }
            return listaDeClientes;
        }

        public bool excluirCliente(int valorID)
        {
            ClienteDAO clienteDAO = new ClienteDAO();

            try
            {
                if (clienteDAO.excluirCliente(valorID))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public bool alterarCliente(Clientes cliente)
        {
            ClienteDAO clienteDAO = new ClienteDAO();

            try
            {
                clienteDAO.alterarCliente(cliente);
                return true;
            }
            catch(Exception ex)
            {

            }

            return false;
        }

        public string  selecionarCliente(Clientes cliente, string valorID,String cidadeConc, Cidade cidade)
        {
            ClienteDAO clienteDAO = new ClienteDAO();

            cidadeConc = clienteDAO.selecionarCliente(cliente, valorID, cidadeConc, cidade);

            cliente.Cidade = cidade;

            return cidadeConc;
        }
    }
}
