using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trovato.dao;
using Trovato.model;

namespace Trovato.bo
{
    class ContatoBO
    {

        public void inserirContato(Contatos contato)
        {

            ContatoDAO contatoDAO = new ContatoDAO();

            contatoDAO.inserirContato(contato);

        }

        public IList<Contatos> selecionarContatos(string valorID)
        {
            IList<Contatos> listaDeContatos = new List<Contatos>();
            ContatoDAO contatoDAO = new ContatoDAO();

                listaDeContatos = contatoDAO.selecionarContatos(valorID);


            return listaDeContatos;
        }

        public void deletarContatos(int valorID)
        {
            ContatoDAO contatoDAO = new ContatoDAO();

            contatoDAO.deletarContatos(valorID);
               
        }

        public void deletarContato(int valorID)
        {
            ContatoDAO contatoDAO = new ContatoDAO();

            contatoDAO.deletarContato(valorID);

        }

        public Contatos selecionarContato(string valorID)
        {
            Contatos contato = null;
            ContatoDAO contatoDAO = new ContatoDAO();

            contato = new Contatos();
            contato = contatoDAO.selecionarContato(valorID);

            return contato;
        }

        public void alterarContato(Contatos contato)
        {
            ContatoDAO contatoDAO = new ContatoDAO();

            contatoDAO.alterarContato(contato);

        }

    }
}
