using MyLibrary;
using NUnit.Framework;

namespace TestProject2
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
      new Class2().DoIt2();
      Assert.Pass();
    }
  }
}