using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace ThreeSixPlayground.Models
{
    public class Place : BindableObject
    {
        Position _position;

        public string Address { get; }

        public string Description { get; }

        public Position Position
        {
            get => _position;
            set
            {
                if (!_position.Equals(value))
                {
                    _position = value;
                    OnPropertyChanged();
                }
            }
        }

        public Place(string address, string description, Position position)
        {
            Address = address;
            Description = description;
            Position = position;
        }
    }
}