using System;
using Triangle.Tracker;

namespace Triangle
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("main works!");
      TriangleChecker newTriangleChecker = new TriangleChecker(2, 3, 5);

      Console.WriteLine("I am a" + newTriangleChecker.type);

      newTriangleChecker.Test();
    }
  }
}