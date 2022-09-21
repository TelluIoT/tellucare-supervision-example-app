using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace tellucare_supervision_example_app
{
    public partial class MainPage : ContentPage
    {
        public string urlToShow = "";
        public bool showUrl = false;
        public bool showOptions = false;
        public bool showControls = true;
        public bool showAutoPlay = true;
        public List<Server> servers = new List<Server>(){
            new Server(){ Name = "dev", Url = "https://tellucare-embedded-dev.tellucloud.com/{0}/viewPatient/{1}" }
        };
        Server selectedServer;
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
        public List<Server> Servers
        {
            get { return servers; }
            set
            {
                servers = value;
                OnPropertyChanged(nameof(Servers));
            }
        }
        public Server SelectedServer
        {
            get { return selectedServer; }
            set
            {
                if (selectedServer != value)
                {
                    selectedServer = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool ShowControls
        {
            get { return showControls; }
            set
            {
                showControls = value;
                OnPropertyChanged(nameof(ShowControls));
            }
        }
        public bool ShowAutoPlay
        {
            get { return showAutoPlay; }
            set
            {
                showAutoPlay = value;
                OnPropertyChanged(nameof(ShowAutoPlay));
            }
        }
        public bool ShowOptions
        {
            get { return showOptions; }
            set
            {
                showOptions = value;
                OnPropertyChanged(nameof(ShowOptions));
            }
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            healthProvider.Text = "";
            SelectedServer = Servers.First();
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
            string urlStr = String.Format(SelectedServer.Url, healthProvider.Text, patientId.Text);
            // add token
            urlStr += addDivider("token", token.Text);
            // add color
            urlStr += addDivider("color", color.Text);
            // add autoPlay
            urlStr += addDivider("autoPlay", ShowAutoPlay ? "true" : "false");
            // add hideControls
            urlStr += addDivider("hideControls", !ShowControls ? "true" : "false");
            // update label with url
            UrlToShow = urlStr;
            // update source attribute on webview component
            videoComp.Source = urlStr;
        }
    }
}
