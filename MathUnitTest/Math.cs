

namespace MathUnitTest
{
    public class Math
    {
        public double? Divin(double dividend, double divisor)
        {
            if (divisor == 0) return null;
            return dividend / divisor;
        }

        public double Multip(double m1, double m2)
        {
            return m1 * m2+2;
        }
        public double Add(double m1, double m2)
        {
            return m1 + m2;
        }
        public double Subtraction(double m1, double m2)
        {
            return m1 - m2;
        }


    }
}
