namespace Biblioteca_primer_projeto_C_.Models
{
    public class Biblioteca
    {
        public List<Livro> Livros { get; set; }

        public List<Utilizador> Utilizadores { get; set; }

        public List<Reserva> Reservas { get; set; }

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
                throw new ArgumentException("O livro tem de ser válido.");
            }

            Livros.Add(livro);
        }

        public void AdicionarUtilizador(Utilizador utilizador)
        {
            if (utilizador == null)
            {
                throw new ArgumentException("O utilizador tem de ser válido.");
            }

            Utilizadores.Add(utilizador);
        }

        public void ReservarLivro(Livro livro, Utilizador utilizador)
        {
            if (livro == null)
            {
                throw new ArgumentException("O livro tem de ser válido.");
            }

            if (utilizador == null)
            {
                throw new ArgumentException("O utilizador tem de ser válido.");
            }

            if (!livro.Disponivel)
            {
                throw new InvalidOperationException("O livro não está disponível.");
            }

            Reserva reserva = new Reserva(livro, utilizador);

            Reservas.Add(reserva);

            livro.Disponivel = false;
        }

        public void DevolverLivro(Livro livro)
        {
            if (livro == null)
            {
                throw new ArgumentException("O livro tem de ser válido.");
            }

            if (livro.Disponivel)
            {
                throw new InvalidOperationException("O livro já está disponível.");
            }

            livro.Disponivel = true;
        }
    }
}