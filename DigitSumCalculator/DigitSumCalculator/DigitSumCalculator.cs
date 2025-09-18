using System;

class DigitSumCalculator
{
    private int number;

    public void ReadNumber()
    {
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
    }

    public void CalculateAndDisplaySum()
    {
        int sum = 0;
        int temp = Math.Abs(number);

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += digit;
            temp /= 10;
        }

        Console.WriteLine($"Sum of digits of {number} is: {sum}");
    }
}
