using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamAppPreference
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            App.Current.Properties.Add("first_name", "John");
            App.Current.SavePropertiesAsync();

            GetPreference();
        }

        private void GetPreference()
        {
            var val = App.Current.Properties["first_name"]; 

        }
    }
}
