using System.Windows.Input;
using ThreeSixPlayground.ViewModels.Base;
using Xamarin.Forms;

namespace ThreeSixPlayground.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand FontIconSourceCommand => new Command(ExecuteFontIconSource);
        public ICommand PinsSourceCommand => new Command(PinsSourceExecute);
        public ICommand ReadOnlyEntryCommand => new Command(ExecuteReadOnlyEntry);
        public ICommand VisualCommand => new Command(ExecuteVisual);

        void ExecuteFontIconSource()
        {
            NavigationService.NavigateToAsync<FontIconSourceViewModel>();
        }

        void PinsSourceExecute()
        {
            NavigationService.NavigateToAsync<PinsSourceViewModel>();
        }

        void ExecuteReadOnlyEntry()
        {
            NavigationService.NavigateToAsync<ReadOnlyEntryViewModel>();
        }

        void ExecuteVisual()
        {
            NavigationService.NavigateToAsync<VisualViewModel>();
        }
    }
}