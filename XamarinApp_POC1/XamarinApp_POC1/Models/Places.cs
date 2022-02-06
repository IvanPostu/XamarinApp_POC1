
using Xamarin.Forms;

namespace XamarinApp_POC1.Models
{
    public class Places
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Country { get; set; }

        public ImageSource ImageSrc { get; set; }

        public ImageSource HeaderTargetImage
        {
            get
            {
                return ImageSource.FromResource("XamarinApp_POC1.Assets.Images.icon1.png");
            }
        }

        public ImageSource MapTargetImage
        {
            get
            {
                return ImageSource.FromResource("XamarinApp_POC1.Assets.Images.icon2.png");
            }
        }
        

    }
}
