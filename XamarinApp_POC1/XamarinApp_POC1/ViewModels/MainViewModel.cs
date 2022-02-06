using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using XamarinApp_POC1.Models;

namespace XamarinApp_POC1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Places> _places;

        public ObservableCollection<Places> Places
        {
            get { return _places; }
            set
            {
                _places = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("args"));
            }
        }


        public MainViewModel()
        {
            _places = new ObservableCollection<Places>();
            AddData();
        }

        private void AddData()
        {
            _places.Add(new Places()
            {
                Country = "Norway",
                Title = "The beautiful lake",
                Id = 101,
                ImageSrc = ImageSource.FromResource("XamarinApp_POC1.Assets.Images.img1.png")
            });
            _places.Add(new Places()
            {
                Country = "Nepal",
                Title = "Adventure of snow",
                Id = 102,
                ImageSrc = ImageSource.FromResource("XamarinApp_POC1.Assets.Images.img1.png")
            });
            _places.Add(new Places()
            {
                Country = "Malaysia",
                Title = "Beach is where life is",
                Id = 103,
                ImageSrc = ImageSource.FromResource("XamarinApp_POC1.Assets.Images.img1.png")
            });
        }
    }
}
