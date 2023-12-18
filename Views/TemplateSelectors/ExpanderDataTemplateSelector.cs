using MauiExpander.ViewModels;

namespace MauiExpander.Views.TemplateSelectors
{
    public class ExpanderDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate StepOne { get; set; }
        public DataTemplate StepTwo { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            ExpanderViewStep myStep = (ExpanderViewStep)(short)item;

            switch (myStep)
            {
                case ExpanderViewStep.StepOne: return StepOne;               
                case ExpanderViewStep.StepTwo: return StepTwo;
                default: return null;
            }
        }
    }
}
