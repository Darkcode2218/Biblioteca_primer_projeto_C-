using Microsoft.UI.Xaml;
using Biblioteca_primer_projeto_C_.Views;

namespace Biblioteca_primer_projeto_C_
{
    public partial class App : Application
    {
        private Window? _window;

        public App()
        {
            InitializeComponent();
        }

        protected override void OnLaunched(
            Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            _window = new MainWindow();
            _window.Activate();
        }
    }
}
