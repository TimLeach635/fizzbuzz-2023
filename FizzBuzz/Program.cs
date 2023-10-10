public static class Program
{
    public static void Main()
    {
        for (int i = 1; i <= 105; i++)
        {
            string result = "";

            if (IsDivisibleBy(i, 3))
            {
                result += "Fizz";
            }

            if (IsDivisibleBy(i, 5))
            {
                result += "Buzz";
            }

            if (IsDivisibleBy(i, 7))
            {
                result += "Bang";
            }

            if (IsDivisibleBy(i, 11))
            {
                result = "Bong";
            }

            if (result == "")
            {
                result = i.ToString();
            }

            Console.WriteLine(result);
        }
    }

    private static bool IsDivisibleBy(int numerator, int denominator)
    {
        return numerator % denominator == 0;
    }
}
