using MyLibrary;
using NUnit.Framework;

namespace TestProject1
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
      new Class1().DoIt1();
      Assert.Pass();
    }
  }
}