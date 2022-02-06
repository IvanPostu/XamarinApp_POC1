using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp_POC1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            //CarouselImage1.Source = ImageSource.FromResource("XamarinApp_POC1.Assets.Images.img1.png");
            //HeaderTargetImage1.Source = ImageSource.FromResource("XamarinApp_POC1.Assets.Images.icon1.png");
            //MapTargetImage1.Source = ImageSource.FromResource("XamarinApp_POC1.Assets.Images.icon2.png");



            //CarouselImage1.Source = ImageSource.FromStream(() =>
            //{
            //    Assembly assembly = GetType().GetTypeInfo().Assembly;
            //    Stream stream = assembly.GetManifestResourceStream("XamarinApp_POC1.Assets.Images.img4.png");

            //    return stream;
            //});

            //Image1.Source = ImageSource.FromUri(new Uri("google.com/smeimage"));
            //Image1.Source = new UriImageSource
            //{
            //    Uri = new Uri("google.com/smeimage"),
            //    CachingEnabled = true,
            //    CacheValidity = new TimeSpan(0, 5, 0)
            //};
        }
    }
}
