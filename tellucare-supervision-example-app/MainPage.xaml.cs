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
                OnPropertyChanged(nameof(UrlToShow));
            }
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            url.Text = "";
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
            videoComp.Source = urlStr;
        }
    }
}
