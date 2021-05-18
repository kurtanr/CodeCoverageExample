using MyLibrary;
using NUnit.Framework;

namespace TestProject3
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
      new Class3().DoIt3();
      Assert.Pass();
    }
  }
}