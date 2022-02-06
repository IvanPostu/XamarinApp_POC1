using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
            Image1.Source = ImageSource.FromResource("XamarinApp_POC1.Assets.Images.img1.png");

            Image1.Aspect = Aspect.AspectFill;
        }
    }
}
