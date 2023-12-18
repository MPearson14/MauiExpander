using System.Windows.Input;
using TelerikMauiApp;

namespace MauiExpander.ViewModels
{
    public enum ExpanderViewStep
    {
        None = 0,
        StepOne = 1,
        StepTwo = 2
    }

    public class ExpanderViewModel : MvvmHelpers.BaseViewModel
    {
        public ExpanderViewModel() { }

        private IEnumerable<short> _CarouselData = new List<short> { (short)ExpanderViewStep.StepOne, (short)ExpanderViewStep.StepTwo };

        private string _Entry1Error = string.Empty;

        private bool _IsEntry1ErrorVisible = false;

        public IEnumerable<short> CarouselData
        {
            get => _CarouselData;
            set => SetProperty(ref _CarouselData, value);
        }

        public string Entry1Error
        {
            get => _Entry1Error;
            set => SetProperty(ref _Entry1Error, value);
        }

        public bool IsEntry1ErrorVisible
        {
            get => _IsEntry1ErrorVisible;
            set => SetProperty(ref _IsEntry1ErrorVisible, value);
        }

        public ICommand CarouselItemChangedCommand => new Command((item) => CarouselItemChanged(item));

        private void CarouselItemChanged(object item)
        {
            if (item == null)
            { return; }

            ExpanderViewStep myStep = (ExpanderViewStep)item.ToInt();

            switch (myStep)
            {
                case ExpanderViewStep.StepOne: break;
                case ExpanderViewStep.StepTwo: ConfigureExpanderStepTwo(); break;
                default: break;
            }
        }

        private void ConfigureExpanderStepTwo()
        {
            Entry1Error = string.IsNullOrEmpty(Entry1Error) ? "This is invalid!" : string.Empty;
            IsEntry1ErrorVisible = !IsEntry1ErrorVisible;
        }
    }    
}
