# Getting started with Embedded video player

TelluCare Supervision supports playing videostreams for a patient in embedded video views for your web page or mobile apps. This is an example on how to implement TelluCare supvervision camera views in your Xamarin applications.

# Documentation

General documentation about the player, , see [Getting started with Embedded video player](https://telluiot.github.io/tellucloud/embedded/embeddedIndex.html)

# Example application

## Android settings

In order to embed a room in Android, add these permissions to the manifest:
```xml
<uses-permission android:name="android.permission.INTERNET" />
```

## Implementation

The Tellucare supervision embedded player can be included in your app by using the [WebView](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.webview?view=xamarin-forms) class.

Example
```xml
<WebView Source="https://<ENVIRONMENT>/<REALM>/viewPatient/<PATIENT_ID>[#][token=<AUTHENTICATION_TOKEN>][<QUERRY_PARAMS>]"/>
```
	
Format for the url in Source, see [Adding embedded camera view to your web application](https://telluiot.github.io/tellucloud/embedded/embeddedVideoPlayer.html)

See code in MainPage.xaml and MainPage.xaml.cs.

