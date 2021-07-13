using System;

// what if we passed all the sides in to the constructor
// and then we made a function for every possible triangle type
// and returns true or false

namespace Triangle.Tracker
{
    public class TriangleChecker
    {
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }

        public TriangleChecker (int input1, int input2, int input3)
        {
            side1 = input1;
            side2 = input2;
            side3 = input3;
        }
        public void Test()
        {
            Console.WriteLine("Triangle works!");
        }
        public bool IsEquilateral()
        {
            return (side1 == side2 && side2 == side3);
        }
        public bool IsIsosceles()
        {
            if (IsEquilateral()) return false;
            return (side1 == side2 || side1 == side3 || side2 == side3);
        }
    }
}
