using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        int prevNumber = 0;
        int sumNumber;
        
        List<int> numbers = new List<int>();

        do{
            Console.Write("Enter number: ");
            string userInput= Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0)
            {
                numbers.Add(number);
                sumNumber = prevNumber + number;
                prevNumber = sumNumber;
            }

        } while (number != 0);

        float totalSum = prevNumber;
        Console.WriteLine($"the sum is: {totalSum}");
        Console.WriteLine($"the mean is: {totalSum / numbers.Count}");
        int largestNumber = numbers.Max();
        Console.WriteLine($"largest number: {largestNumber}");
        int smallestNumber = numbers.Where(x => x >= 0).Min();
        Console.WriteLine($"smallest positive number: {smallestNumber}");
        Console.WriteLine("The sorted list is: ");
        IEnumerable<int> query = from num in numbers
                            orderby num
                            select num;

        foreach (int num in query)
        {
            Console.WriteLine(num);
        }
    }
}