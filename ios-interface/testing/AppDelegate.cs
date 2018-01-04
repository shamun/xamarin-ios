using Foundation;
using UIKit;

namespace testing {

  [Register("AppDelegate")]

  public interface EmptyInterface {

    int EmptyInterfaceMethod1();

  }

  public class AppDelegate : UIApplicationDelegate, EmptyInterface {

    public override UIWindow Window {
      get;
      set;
    }

    public override void EmptyInterfaceMethod1() { 
    }

  }
}

