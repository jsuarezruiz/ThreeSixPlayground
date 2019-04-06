using System.Threading.Tasks;
using ThreeSixPlayground.Services.Navigation;
using ThreeSixPlayground.ViewModels;
using ThreeSixPlayground.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ThreeSixPlayground
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            InitNavigation();
        }

        private Task InitNavigation()
        {
            var navigationService = Locator.Instance.Resolve<INavigationService>();
            return navigationService.NavigateToAsync<MainViewModel>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
