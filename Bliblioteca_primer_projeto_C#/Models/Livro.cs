using System;

namespace Biblioteca_primer_projeto_C_.Models
{
    public class Livro
    {
        private string _titulo = "";
        private string _autor = "";
        private string _isbn = "";
        private bool _disponivel;

        public string Titulo
        {
            get { return _titulo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "O título do livro não pode estar vazio.");
                }

                _titulo = value.Trim();
            }
        }

        public string Autor
        {
            get { return _autor; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "O autor do livro não pode estar vazio.");
                }

                _autor = value.Trim();
            }
        }

        public string ISBN
        {
            get { return _isbn; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "O ISBN do livro não pode estar vazio.");
                }

                _isbn = value.Trim();
            }
        }

        public bool Disponivel
        {
            get { return _disponivel; }
            set
            {
                _disponivel = value;
            }
        }

        public Livro(string titulo, string autor, string isbn)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            Disponivel = true;
        }
    }
}
