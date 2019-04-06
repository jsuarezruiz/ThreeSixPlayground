using ThreeSixPlayground.ViewModels.Base;

namespace ThreeSixPlayground.ViewModels
{
    public class FontIconSourceViewModel : ViewModelBase
    {
        public FontIconSourceViewModel()
        {
            Glyph = "\uf30c";
        }

        public string Glyph { get; set; }
    }
}