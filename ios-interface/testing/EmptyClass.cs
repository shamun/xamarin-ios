using System;
namespace testing {
  public class EmptyClass : EmptyInterface {
    public EmptyClass() {      
    }

    public void EmptyInterfaceMethod1() {
      Console.WriteLine(">> EmptyClass >> EmptyInterfaceMethod1 >> Hello?");
    }
  }
}
