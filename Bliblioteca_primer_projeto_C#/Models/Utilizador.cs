using System;

namespace Biblioteca_primer_projeto_C_.Models
{
    public class Utilizador
    {
        private string _nome = "";
        private string _telefone = "";
        private string _email = "";
        private int _numeroUtilizador;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "O nome do utilizador não pode estar vazio.");
                }

                _nome = value.Trim();
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "O email do utilizador não pode estar vazio.");
                }

                if (!value.Contains("@"))
                {
                    throw new ArgumentException(
                        "O email do utilizador não é válido. Deve conter '@'.");
                }

                _email = value.Trim();
            }
        }

        public int NumeroUtilizador
        {
            get { return _numeroUtilizador; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "O número do utilizador deve ser maior que zero.");
                }

                _numeroUtilizador = value;
            }
        }

        public string Telefone
        {
            get { return _telefone; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "O telefone do utilizador não pode estar vazio.");
                }

                _telefone = value.Trim();
            }
        }

        public Utilizador(
            string nome,
            string email,
            int numeroUtilizador,
            string telefone)
        {
            Nome = nome;
            Email = email;
            NumeroUtilizador = numeroUtilizador;
            Telefone = telefone;
        }
    }
}