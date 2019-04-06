using System;
using System.Windows.Input;
using ThreeSixPlayground.ViewModels.Base;
using ThreeSixPlayground.ViewModels.Visual;
using Xamarin.Forms;

namespace ThreeSixPlayground.ViewModels
{
    public class VisualViewModel : ViewModelBase
    {
        public ICommand VisualCommand => new Command<string>(ExecuteVisual);

        void ExecuteVisual(string parameter)
        {
            Type targeViewModel = typeof(ButtonViewModel);

            switch (parameter)
            {
                case "activityindicator": targeViewModel = typeof(ActivityIndicatorViewModel); break;
                case "button": targeViewModel = typeof(ButtonViewModel); break;
                case "card": targeViewModel = typeof(CardViewModel); break;
                case "editor": targeViewModel = typeof(EditorViewModel); break;
                case "entry": targeViewModel = typeof(EntryViewModel); break;
                case "picker": targeViewModel = typeof(PickerViewModel); break;
                case "progress": targeViewModel = typeof(ProgressViewModel); break;
                case "slider": targeViewModel = typeof(SliderViewModel); break;
                case "stepper": targeViewModel = typeof(StepperViewModel); break;
            }

            NavigationService.NavigateToAsync(targeViewModel);
        }
    }
}