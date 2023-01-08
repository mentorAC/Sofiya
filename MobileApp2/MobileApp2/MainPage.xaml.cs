using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //++editor.FontSize;
            //editor.FontAttributes = FontAttributes.Bold;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            image.Source = new UriImageSource()
            {
                Uri = new Uri(entry.Text)
            };
        }
    }
}
