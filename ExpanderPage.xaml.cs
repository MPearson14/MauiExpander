using MauiExpander.ViewModels;

namespace MauiExpander
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpanderPage : ContentPage
    {
        public ExpanderPage()
        {
            InitializeComponent();
            BindingContext = new ExpanderViewModel();
        }
    }
}