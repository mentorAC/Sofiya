using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
namespace MobileApp4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //image.Rotation = e.NewValue;
            image.RotationY = e.NewValue;

        }

        private async void Button_Clicked_start(object sender, EventArgs e)
        {
            //установка якоря
            //image.AnchorX = 1;
            //image.AnchorY = 1;
            //увеличение относительно якоря
            //await image.ScaleTo(2, 2000);
            //await image.ScaleTo(1, 2000);

            //круговорот тносительно якоря (нижний центр картинки)
            //double radius = Math.Min(DeviceDisplay.MainDisplayInfo.Width, DeviceDisplay.MainDisplayInfo.Height)/2;
            //image.AnchorY = radius/2 / image.Height;
            //await image.RotateTo(360, 2000);

            //движение нашей картинки по х, у
            //await image.TranslateTo(0, -50, 1000);
            //await image.TranslateTo(-50, 0, 1000);
            //await image.TranslateTo(0, 100, 1000);
            //await image.TranslateTo(100, 0, 1000);
            //await image.TranslateTo(0, -100, 1000);
            //await image.TranslateTo(-50, 0, 1000);
            //await image.TranslateTo(0, 50, 1000);

            //появление картинки 
            //image.Opacity = 0;
            //await image.FadeTo(0, 4000);

            //віполнения нескольких анимаций одновременно
            //await Task.WhenAny<bool>
            //    (
            //        image.RotateTo(360, 4000),
            //        image.ScaleTo(2, 2000)
            //    ) ;
            //await image.ScaleTo(1, 2000);

            //промежуток времени
            uint duration = 10 * 60 * 1000;

            //віполнения кручение верчение картинки
            await Task.WhenAll(
              image.RotateTo(307 * 360, duration),
              image.RotateXTo(251 * 360, duration),
              image.RotateYTo(199 * 360, duration)
            );

            //Anchor
            image.Rotation = 0;
        }
        //ViewExtensions
        private void Button_Clicked_end(object sender, EventArgs e)
        {
            //отмена анимации 
            image.CancelAnimations();
        }
    }
}
