using Foundation;
using UIKit;

namespace testing {

  public interface IEmptyInterface {
    int EmptyInterfaceMethod1();
  }

  [Register("AppDelegate")]
  public class AppDelegate : UIApplicationDelegate, IEmptyInterface {
    public override UIWindow Window {
      get;
      set;
    }
    public int EmptyInterfaceMethod1() { return 1; }

  }
}

