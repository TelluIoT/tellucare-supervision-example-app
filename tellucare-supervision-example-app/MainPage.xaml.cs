using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace tellucare_supervision_example_app
{
    public partial class MainPage : ContentPage
    {
        public string urlToShow = "";
        public string UrlToShow
        {
            get { return urlToShow; }
            set
            {
                urlToShow = value;
                OnPropertyChanged(nameof(UrlToShow)); // Notify that there was a change on this property
            }
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            url.Text = "https://tellucare-embedded-dev.tellucloud.com/tilsyn-dev/viewPatient/SrT6vvyNHFFmZ0UiSWcb0q";
        }
        void OnButtonClicked(object sender, EventArgs args)
        {
            string urlStr = url.Text + "?autoPlay=true&hideControls=true";
            if(!String.IsNullOrEmpty(color.Text))
            {
                urlStr += "&color=" + color.Text;
            }
            if (!String.IsNullOrEmpty(token.Text))
            {
                urlStr += "#token=" + token.Text;
            }
            UrlToShow = urlStr;
            // videoComp.Source = "https://tellucare-embedded-dev.tellucloud.com/tilsyn-dev/viewPatient/SrT6vvyNHFFmZ0UiSWcb0q";
            videoComp.Source = urlStr;
            // await label.RelRotateTo(360, 1000);
        }
    }
}
