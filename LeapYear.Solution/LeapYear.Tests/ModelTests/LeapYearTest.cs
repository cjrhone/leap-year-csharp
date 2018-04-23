using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeapYear;
// using Microsoft.VisualStudio.TestTools.UnitTesting imports the MSTest framework for us to Use
//using LeapYear; imports the LeapYear namespace from the LeapYear project for use in our tests.

namespace LeapYear.Tests
{
  [TestClass]
  //[TestClass] tells MSTest that the following class contains tests to be run.
  public class LeapYearTest
  {
    [TestMethod]
    //[TestMethod] tells the compiler that the following code block is an individual test that should be run by MSTest.
    public void IsLeapYear_NumberDivisibleByFour_True()
    {
      // public void IsLeapYear_NumberDivisibleByFour_True is the test, because MSTest tests are actually methods. They should always start with public void.
      // testing naming convention: MethodToBeTested_BehaviorToBeTested_ExpectedResultOfTest
      // eventually your testing code will go here
    }
  }
}
