using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            #region Image
            //string uri = "https://media.cnn.com/api/v1/images/stellar/prod/220818142713-dogs-tears-emotions-wellness-stock.jpg?";
            //image1.Source = new UriImageSource()
            //{
            //    Uri = new Uri(uri)
            //};
            //image2.Source = new UriImageSource()
            //{
            //    Uri = new Uri(uri)
            //};
            //image3.Source = new UriImageSource()
            //{
            //    Uri = new Uri(uri)
            //};
            #endregion
        }

        #region DataPicker_TimePicker
        //private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        //{
        //    label.Text = datePicker.Date.ToString();
        //}

        //private void TimePicker_PropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    if (e.PropertyName == "Time")
        //    {
        //        label.Text = timePicker.Time.ToString();
        //    }
        //}
        #endregion

        private void Button_Clicked(object sender, EventArgs e)
        {
            picker.Items.Add(enteredItem.Text);
            enteredItem.Text = String.Empty;
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            label.Text = $"You have picked: {picker.SelectedItem}";
        }
    }
}
