using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace tellucare_supervision_example_app
{
    public partial class MainPage : ContentPage
    {
        public string urlToShow = "";
        public bool showUrl = false;
        public string UrlToShow
        {
            get { return urlToShow; }
            set
            {
                urlToShow = value;
                OnPropertyChanged(nameof(UrlToShow));
            }
        }
        public bool ShowUrl
        {
            get { return showUrl; }
            set
            {
                showUrl = value;
                OnPropertyChanged(nameof(ShowUrl));
            }
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            healthProvider.Text = "";
        }
        void OnButtonClicked(object sender, EventArgs args)
        {
            bool firstParam = true;
            Func<string, string, string> addDivider = (tag, value) => {
                if (String.IsNullOrEmpty(tag) || String.IsNullOrEmpty(value))
                {
                    return "";
                }
                string res = (firstParam ? "#" : "/") + tag + "=" + value;
                firstParam = false;
                return res;
            };
            if (String.IsNullOrEmpty(healthProvider.Text) || String.IsNullOrEmpty(patientId.Text))
            {
                return;
            }
            string urlStr = String.Format("https://tellucare-embedded-dev.tellucloud.com/{0}/viewPatient/{1}", healthProvider.Text, patientId.Text);
            // add token
            urlStr += addDivider("token", token.Text);
            // add color
            urlStr += addDivider("color", color.Text);
            // add autoPlay
            urlStr += addDivider("autoPlay", "true");
            // add hideControls
            urlStr += addDivider("hideControls", "true");
            // update label with url
            UrlToShow = urlStr;
            // update source attribute on webview component
            videoComp.Source = urlStr;
        }
    }
}
