using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace ThreeSixPlayground.Views
{
    public partial class PinsSourceView : ContentPage
    {
        readonly Position StartPosition = new Position(39.8283459, -98.5794797);

        public PinsSourceView()
        {
            InitializeComponent();

            PinsSourceMap.MoveToRegion(MapSpan.FromCenterAndRadius(StartPosition, Distance.FromMiles(1000)));
        }
    }
}
