using System.ComponentModel;
using System.Runtime.CompilerServices;
using Biblioteca_primer_projeto_C_.Models;

namespace Biblioteca_primer_projeto_C_.ViewModels;

public class UtilizadorViewModel : INotifyPropertyChanged
{
    private string _nome = "";
    private string _email = "";
    private string _telefone = "";
    private int _numeroUtilizador = 1;
    private string _mensagem = "";

    public string Nome
    {
        get => _nome;
        set
        {
            _nome = value;
            OnPropertyChanged();
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            _email = value;
            OnPropertyChanged();
        }
    }

    public string Telefone
    {
        get => _telefone;
        set
        {
            _telefone = value;
            OnPropertyChanged();
        }
    }

    public int NumeroUtilizador
    {
        get => _numeroUtilizador;
        set
        {
            _numeroUtilizador = value;
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

    public void RegistarUtilizador()
    {
        Utilizador utilizador = new Utilizador(
            Nome,
            Email,
            NumeroUtilizador,
            Telefone
        );

        Mensagem = $"Utilizador registado: {utilizador.Nome} - {utilizador.Email}";
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
