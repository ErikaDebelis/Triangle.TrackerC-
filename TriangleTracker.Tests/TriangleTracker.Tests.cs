using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle.Tracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleCheckerTests
  {
    [TestMethod]
    public void Constructor_InitializesValuesCorrectly()
    {
      TriangleChecker triangle = new TriangleChecker(3, 4, 5);

      Assert.AreEqual(triangle.side1, 3);
      Assert.AreEqual(triangle.side2, 4);
      Assert.AreEqual(triangle.side3, 5);
    }

    [TestMethod]
    public void IsEquilateral_ChecksForAnEquilateralTriangle_ReturnsTrueWhenSidesEqual()
    {
      TriangleChecker triangle = new TriangleChecker(10, 10, 10);
      Assert.AreEqual(triangle.IsEquilateral(), true);
    }

    [TestMethod]
    public void IsEquilateral_ChecksForNotAnEquilateralTriangle_ReturnsFalseWhenSidesNotEqual()
    {
      TriangleChecker triangle = new TriangleChecker(10, 11, 10);
      Assert.AreEqual(triangle.IsEquilateral(), false);
    }
  }
}