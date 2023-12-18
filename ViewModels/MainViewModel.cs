using System.Windows.Input;

namespace MauiExpander.ViewModels
{
    public class MainViewModel : MvvmHelpers.BaseViewModel
    {
        public MainViewModel() { }
        
        public ICommand ExpanderButtonCommand => new MvvmHelpers.Commands.AsyncCommand(ExpanderButtonAsync);

        private async Task ExpanderButtonAsync()
        {
            await Shell.Current.GoToAsync($"/{nameof(ExpanderPage)}");
        }
    }
}
