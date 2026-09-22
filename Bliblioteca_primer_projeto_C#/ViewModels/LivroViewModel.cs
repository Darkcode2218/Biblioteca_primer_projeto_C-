using System.ComponentModel;
using System.Runtime.CompilerServices;
using Biblioteca_primer_projeto_C_.Models;

namespace Biblioteca_primer_projeto_C_.ViewModels;

public class LivroViewModel : INotifyPropertyChanged
{
    private string _titulo = "";
    private string _autor = "";
    private string _isbn = "";
    private string _mensagem = "";

    public string Titulo
    {
        get => _titulo;
        set
        {
            _titulo = value;
            OnPropertyChanged();
        }
    }

    public string Autor
    {
        get => _autor;
        set
        {
            _autor = value;
            OnPropertyChanged();
        }
    }

    public string ISBN
    {
        get => _isbn;
        set
        {
            _isbn = value;
            OnPropertyChanged();
        }
    }

    public string Mensagem
    {
        get => _mensagem;
        private set
        {
            _mensagem = value;
            OnPropertyChanged();
        }
    }

    public void RegistarLivro()
    {
        Livro livro = new Livro(Titulo, Autor, ISBN);

        Mensagem = $"Livro registado: {livro.Titulo} - {livro.Autor}";
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged(
        [CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(
            this,
            new PropertyChangedEventArgs(propertyName));
    }
}
