using MauiExpander.ViewModels;

namespace MauiExpander
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
