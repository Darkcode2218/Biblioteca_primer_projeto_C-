using System;

namespace Biblioteca_primer_projeto_C_.Models
{
    public class Reserva
    {
        public Livro Livro { get; set; }

        public Utilizador Utilizador { get; set; }

        public DateTime DataReserva { get; set; }

        public Reserva(Livro livro, Utilizador utilizador)
        {
            Livro = livro;
            Utilizador = utilizador;
            DataReserva = DateTime.Now;
        }
    }
}