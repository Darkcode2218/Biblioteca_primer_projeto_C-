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

    Reserva? reserva = Reservas.FirstOrDefault(r => r.Livro == livro);

    if (reserva != null)
    {
        Reservas.Remove(reserva);
    }

    livro.Disponivel = true;
}