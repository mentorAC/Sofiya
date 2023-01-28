using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp6
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        bool isContinue = false;
        public MainPage()
        {
            InitializeComponent();

            //Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
            
        }

        private bool StartTimer()
        {
            label.Text = $"{count++}";
            return isContinue;
        }
        //private bool OnTimerTick()
        //{
        //    label.Text = $"{DateTime.Now}";

        //    return true;
        //}

        #region Display Alert
        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    DisplayAlert("Info first", "This is display alert!", "‼️");
        //}

        //private async void Button_Clicked_1(object sender, EventArgs e)
        //{
        //    string res = await DisplayActionSheet("Share", "cancel", "ok", "Telegram", "Twitter", "facebook");
        //    label.Text = res;
        //}

        //private async void Button_Clicked_2(object sender, EventArgs e)
        //{
        //    //bool res = await DisplayAlert("Info second", "This is display alert!", "ok", "cancel");
        //    //if (res == true)
        //    //{
        //    //    label.Text = "Yes";
        //    //}
        //    //else{
        //    //    label.Text = "No";
        //    //}
        //    bool result = await DisplayAlert("Choice", "Do you want to delete an item", "yes", "no");
        //    await DisplayAlert(((result ==true)?"Yes": "NO"),$"You have chosen: {((result == true)?"DELETE":"CANSEL")}" , "ok");

        //    //if (result == true)
        //    //{
        //    //    await DisplayAlert("yes", "You have chosen: DELETE","ok");
        //    //}
        //    //else
        //    //{
        //    //    await DisplayAlert("NO", "You have chosen: CANSEL", "ok");
        //    //}

        //    //Вы хотите удвлить элемент? (да, нет)
        //    //да->вы выбрали: УДАЛИТЬ (да)
        //    //нет-> вы выбрали: Отменить (да)
        //}
        #endregion

        private void Button_Clicked(object sender, EventArgs e)
        {
            isContinue = true;
            Device.StartTimer(TimeSpan.FromSeconds(1), StartTimer);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            isContinue= false;
        }
    }
}
