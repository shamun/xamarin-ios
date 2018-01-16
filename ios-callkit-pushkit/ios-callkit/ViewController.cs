using System;
using UIKit;

using CallKit;
using PushKit;

using Intents;
using Foundation;

namespace ioscallkit {
  
  public partial class ViewController : UIViewController {

    #region Constructors
    public ActiveCallManager CallManager { get; set; }
    public ProviderDelegate CallProviderDelegate { get; set; }
    #endregion

    #region Computed Properties
    public PKPushRegistry registry;
    #endregion

    protected ViewController(IntPtr handle) : base(handle) {
      
    }

    public override void ViewDidLoad() {
      base.ViewDidLoad();

      registry = new PKPushRegistry(null);
      registry.DesiredPushTypes = new NSSet(new string[] { PKPushType.Voip });
        
    }

    public override void DidReceiveMemoryWarning() {
      base.DidReceiveMemoryWarning();

    }
  }
}
