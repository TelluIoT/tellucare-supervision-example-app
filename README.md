# Getting started with Embedded video player

TelluCare Supervision supports playing videostreams for a patient in embedded video views for your web page or mobile apps. This is an example on how to implement TelluCare supvervision camera views in your Xamarin applications.

# Adding embedded camera view to your application

The Tellucare supervision embedded player can be included in your app by using a webview.

    <WebView Source="https://<ENVIRONMENT>/viewPatient/<PATIENT_ID>[<QUERRY_PARAMS>][#token=<AUTHENTICATION_TOKEN>]"/>
	
Format for the url in Source, see [Getting started with Embedded video player](https://calm-sky-0f8781003-1.westeurope.azurestaticapps.net/guide/embedded/embeddedVideoPlayer.html)

See code in MainPage.xaml and MainPage.xaml.cs.
