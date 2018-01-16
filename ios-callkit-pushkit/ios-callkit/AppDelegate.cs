using Foundation;
using UIKit;
using Intents;
using System;

namespace ioscallkit {

  [Register("AppDelegate")]
  public class AppDelegate : UIApplicationDelegate {

    #region Constructors
    public override UIWindow Window { get; set; }
    #endregion

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions) {
      return true;
    }
  }
}

