# Getting started with Embedded video player

TelluCare Supervision supports playing videostreams for a patient in embedded video views for your web page or mobile apps. This is an example on how to implement TelluCare supvervision camera views in your Xamarin applications.

# Android settings

In order to embed a room in Android, add these permissions to the manifest:
```xml
<uses-permission android:name="android.permission.INTERNET" />
```

# Adding embedded camera view to your application

The Tellucare supervision embedded player can be included in your app by using the [WebView](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.webview?view=xamarin-forms) class.

```xml
<WebView Source="https://<ENVIRONMENT>/viewPatient/<PATIENT_ID>[<QUERRY_PARAMS>][#token=<AUTHENTICATION_TOKEN>]"/>
```
	
Format for the url in Source, see [Getting started with Embedded video player](https://telluiot.github.io/tellucloud/embedded/embeddedVideoPlayer.html)

See code in MainPage.xaml and MainPage.xaml.cs.
