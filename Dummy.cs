using System;

namespace Jvu.Test.SharedLibrary.NoDeps
{
  public class Dummy
  {
    public Dummy() { }
    public Dummy(bool isDummy) { IsDummy = isDummy; }

    private readonly string _testValue = "Hello Dummy!";

    public bool IsDummy { get; set; } = true;

    public string GetTestValue()
    {
      return _testValue;
    }
  }
}
