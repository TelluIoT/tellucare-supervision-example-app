using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Webkit;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using tellucare_supervision_example_app.Droid;

[assembly: ExportRenderer(typeof(Xamarin.Forms.WebView), typeof(DroidWebRenderer))]
namespace tellucare_supervision_example_app.Droid
{
    /**
     * Custom Renderer for the WebView, to enable remote debugging
     * and set other options.
     * 
     * @author Lars Thomas Boye, Tellu
     */
    public class DroidWebRenderer : WebViewRenderer
    {
        Activity mContext;

        public DroidWebRenderer(Context context) : base(context)
        {
            mContext = context as Activity;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.WebView> e)
        {
            base.OnElementChanged(e);

            //Configure Android WebView:
            //view settings currently used in the LMO app
            Control.Settings.JavaScriptEnabled = true;
            Control.Settings.JavaScriptCanOpenWindowsAutomatically = true;
            Control.Settings.SetSupportMultipleWindows(true);
            Control.SetWebChromeClient(new WebChromeClient());
            Control.SetWebViewClient(new WebViewClient());
            //Control.Settings.DomStorageEnabled = false by default

            //Enable remote debugging?
            Android.Webkit.WebView.SetWebContentsDebuggingEnabled(true);
        }
    }
}