using Microsoft.Extensions.DependencyInjection;
using TicTacTow25.Views;

namespace TicTacTow25
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AuthPage());
        }
    }
}