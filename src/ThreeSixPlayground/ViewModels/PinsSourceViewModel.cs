using System.Collections.ObjectModel;
using System.Windows.Input;
using ThreeSixPlayground.Models;
using ThreeSixPlayground.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace ThreeSixPlayground.ViewModels
{
    public class PinsSourceViewModel : ViewModelBase
    {
        private ObservableCollection<Place> _places;

        public PinsSourceViewModel()
        {
            LoadPlaces();
        }

        public ObservableCollection<Place> Places
        {
            get { return _places; }
            set
            { 
                _places = value;
                OnPropertyChanged();
            }
        }

        private void LoadPlaces()
        {
            Places = new ObservableCollection<Place>
             {
                new Place("New York, USA", "The City That Never Sleeps", new Position(40.67, -73.94)),
                new Place("Los Angeles, USA", "City of Angels", new Position(34.11, -118.41))
            };
        }
    }
}