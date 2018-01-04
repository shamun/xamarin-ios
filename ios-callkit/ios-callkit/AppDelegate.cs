using Foundation;
using UIKit;
using Intents;
using System;

namespace ioscallkit {

  [Register("AppDelegate")]
  public class AppDelegate : UIApplicationDelegate {

    #region Constructors
    public override UIWindow Window { get; set; }
    public ActiveCallManager CallManager { get; set; }
    public ProviderDelegate CallProviderDelegate { get; set; }
    #endregion

    #region Override Methods
    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions) {
      // Initialize the call handlers
      CallManager = new ActiveCallManager();
      CallProviderDelegate = new ProviderDelegate(CallManager);

      return true;
    }

    public override bool OpenUrl(UIApplication app, NSUrl url, NSDictionary options) {
      // Get handle from url
      var handle = StartCallRequest.CallHandleFromURL(url);

      // Found?
      if (handle == null) {
        // No, report to system
        Console.WriteLine("Unable to get call handle from URL: {0}", url);
        return false;
      }
      else {
        // Yes, start call and inform system
        CallManager.StartCall(handle);
        return true;
      }
    }

    public override bool ContinueUserActivity(UIApplication application, NSUserActivity userActivity, UIApplicationRestorationHandler completionHandler) {
      var handle = StartCallRequest.CallHandleFromActivity(userActivity);

      // Found?
      if (handle == null) {
        // No, report to system
        Console.WriteLine("Unable to get call handle from User Activity: {0}", userActivity);
        return false;
      }
      else {
        // Yes, start call and inform system
        CallManager.StartCall(handle);
        return true;
      }
    }
    #endregion



  }
}

