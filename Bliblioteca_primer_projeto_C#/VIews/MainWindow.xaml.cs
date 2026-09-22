using Microsoft.UI.Xaml;
using Biblioteca_primer_projeto_C_.ViewModels;

namespace Biblioteca_primer_projeto_C_.Views;

public sealed partial class MainWindow : Window
{
    public LivroViewModel LivroViewModel { get; } = new LivroViewModel();

    public UtilizadorViewModel UtilizadorViewModel { get; } = new UtilizadorViewModel();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnRegistarLivro_Click(object sender, RoutedEventArgs e)
    {
        LivroViewModel.RegistarLivro();
    }

    private void btnRegistarUtilizador_Click(object sender, RoutedEventArgs e)
    {
        UtilizadorViewModel.RegistarUtilizador();
    }
}