using CalculadoraPropinas.Maui.ViewModels;

namespace CalculadoraPropinas.Maui.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
 
        }
    }
}