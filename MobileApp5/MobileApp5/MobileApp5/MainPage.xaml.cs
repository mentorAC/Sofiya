using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //разные анимации
        #region Animation
        //private async void Shake_Clicked(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < 15; i++)
        //    {
        //        await bShake.TranslateTo(10, 10, 100);
        //        await bShake.TranslateTo(-10, -10,100);
        //    }

        //        await bShake.TranslateTo(0, 0,100);

        //}

        //private void xMovement_Clicked(object sender, EventArgs e)
        //{

        //}
        //private void yMovement_Clicked(object sender, EventArgs e)
        //{

        //}

        //private async void smaller_Clicked(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        await smaller.ScaleTo(0.5,750);
        //       smaller.Scale = 1;
        //    }

        //}

        //private async void bigger_Clicked(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //       await bigger.ScaleTo(4, 750);
        //        bigger.Scale = 1;
        //    }
        //}

        //private async void rotation_Clicked(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < 6; i++)
        //    {
        //        await rotation.RotateTo(45, 500);
        //        await rotation.RotateTo(-45, 500);
        //    }
        //    rotation.Rotation = 0;
        //}

        //async Task<bool> Mix()
        //{
        //    bool r = false;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        await bMix.TranslateTo(10, 10, 150);
        //        await bMix.TranslateTo(-10, -10, 150);
        //    }
        //    r = await bMix.TranslateTo(0, 0, 150);
        //    return r;
        //}

        //private async void bMix_Clicked(object sender, EventArgs e)
        //{
        //    await Task.WhenAny<bool>(
        //        bMix.ScaleTo(4,4000),
        //        Mix()

        //        );
        //   await bMix.ScaleTo(1, 1000);
        //}
        #endregion

        //все возможные плавности анимации
        #region Easing
        //private async void bNormal_Clicked(object sender, EventArgs e)
        //{
        //    await bNormal.TranslateTo(200, 0, 500);
        //    await bNormal.TranslateTo(0, 0, 5);

        //}
        //private async void bBounceIn_Clicked(object sender, EventArgs e)
        //{
        //    await bBounceIn.TranslateTo(200, 0, 1500, Easing.BounceIn);
        //    await bBounceIn.TranslateTo(0, 0, 5);

        //}

        //private async void bBounceOut_Clicked(object sender, EventArgs e)
        //{
        //    await bBounceOut.TranslateTo(200, 0, 1500, Easing.BounceOut);
        //    await bBounceOut.TranslateTo(0, 0, 5);
        //}

        //private async void bCubicIn_Clicked(object sender, EventArgs e)
        //{
        //    await bCubicIn.TranslateTo(300, 0, 1500, Easing.CubicIn);
        //    await bCubicIn.TranslateTo(0, 0, 5);
        //}

        //private async void bCubicOut_Clicked(object sender, EventArgs e)
        //{
        //    await bCubicOut.TranslateTo(300, 0, 1500, Easing.CubicOut);
        //    await bCubicOut.TranslateTo(0, 0, 5);
        //}
        ////Linear
        //private async void bCubicInOut_Clicked(object sender, EventArgs e)
        //{
        //    await bCubicInOut.TranslateTo(300, 0, 3000, Easing.CubicInOut);
        //    await bCubicInOut.TranslateTo(0, 0, 5);
        //}

        //private async void bSinIn_Clicked(object sender, EventArgs e)
        //{
        //    await bSinIn.TranslateTo(300,0,1500,Easing.SinIn);
        //    await bSinIn.TranslateTo(0, 0, 5);
        //}

        //private async void bSinOut_Clicked(object sender, EventArgs e)
        //{
        //    await bSinOut.TranslateTo(300, 0, 1500, Easing.SinOut);
        //    await bSinOut.TranslateTo(0, 0, 5);
        //}

        //private async void bSinInOut_Clicked(object sender, EventArgs e)
        //{
        //    await bSinInOut.TranslateTo(300, 0, 1500, Easing.SinInOut);
        //    await bSinInOut.TranslateTo(0, 0, 5);
        //}

        //private async void bSpringIn_Clicked(object sender, EventArgs e)
        //{
        //    await bSpringIn.TranslateTo(300,0,1500,Easing.SpringIn);
        //    await bSpringIn.TranslateTo(0, 0, 5);
        //}

        //private async void bSpringOut_Clicked(object sender, EventArgs e)
        //{
        //    await bSpringOut.TranslateTo(300, 0, 1500, Easing.SpringOut);
        //    await bSpringOut.TranslateTo(0, 0, 5);
        //}
        #endregion

        #region Animation #2
        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    await img.TranslateTo(0, 200, 2000, Easing.CubicIn);
        //    await img.ScaleTo(2, 2000, Easing.CubicIn);
        //    await img.RotateTo(360, 2000, Easing.SinInOut);
        //    await img.ScaleTo(1, 2000, Easing.CubicOut);
        //    await img.TranslateTo(0, 0, 2000, Easing.BounceOut);
        //}
        #endregion

        private void Button_Clicked(object sender, EventArgs e)
        {
            //открываем ссылку, которую указали в энтри
            webView.Source = new UrlWebViewSource { Url = url.Text };

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            //создания собственной странички сайта
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"
                <h1>Xamarin</h1>
                <p></p>
                <h3>hello HTML!</h3>
            ";

            webView.Source = htmlSource;
        }
    }
}
