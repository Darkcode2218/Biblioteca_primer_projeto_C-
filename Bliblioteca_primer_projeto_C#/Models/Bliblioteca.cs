using System;
using System.Collections.Generic;

namespace Biblioteca_primer_projeto_C_.Models
{
    public class Biblioteca
    {
        private List<Livro> _livros;
        private List<Utilizador> _utilizadores;
        private List<Reserva> _reservas;

        public List<Livro> Livros
        {
            get { return _livros; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException(
                        "A lista de livros não pode ser nula.");
                }

                _livros = value;
            }
        }

        public List<Utilizador> Utilizadores
        {
            get { return _utilizadores; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException(
                        "A lista de utilizadores não pode ser nula.");
                }

                _utilizadores = value;
            }
        }

        public List<Reserva> Reservas
        {
            get { return _reservas; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException(
                        "A lista de reservas não pode ser nula.");
                }

                _reservas = value;
            }
        }

        public Biblioteca()
        {
            Livros = new List<Livro>();
            Utilizadores = new List<Utilizador>();
            Reservas = new List<Reserva>();
        }

        public void AdicionarLivro(Livro livro)
        {
            if (livro == null)
            {
                throw new ArgumentException(
                    "O livro tem de ser válido.");
            }

            Livros.Add(livro);
        }

        public void AdicionarUtilizador(Utilizador utilizador)
        {
            if (utilizador == null)
            {
                throw new ArgumentException(
                    "O utilizador tem de ser válido.");
            }

            Utilizadores.Add(utilizador);
        }

        public void ReservarLivro(Livro livro, Utilizador utilizador)
        {
            if (livro == null)
            {
                throw new ArgumentException(
                    "O livro tem de ser válido.");
            }

            if (utilizador == null)
            {
                throw new ArgumentException(
                    "O utilizador tem de ser válido.");
            }

            if (!livro.Disponivel)
            {
                throw new InvalidOperationException(
                    "O livro não está disponível.");
            }

            Reserva reserva = new Reserva(livro, utilizador);

            Reservas.Add(reserva);

            livro.Disponivel = false;
        }

        public void DevolverLivro(Livro livro)
        {
            if (livro == null)
            {
                throw new ArgumentException(
                    "O livro tem de ser válido.");
            }

            if (livro.Disponivel)
            {
                throw new InvalidOperationException(
                    "O livro já está disponível.");
            }

            livro.Disponivel = true;
        }
    }
}