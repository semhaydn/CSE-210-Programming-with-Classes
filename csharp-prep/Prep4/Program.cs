using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        while (true)
        {
            

            Console.Write("What is the number that you want to add to the list ?(Write 0 if you want to quit)  ");
            string response = Console.ReadLine();


            if (response == "0")
            {
                break;
            }
            if (int.TryParse(response, out int userResponse))
            {
             //Parsing succedeed
                numbers.Add(userResponse);
            }
            else
            {
                Console.WriteLine("Invlid input.Please enter a valid number");    
            }
        }
        
        int sum = numbers.Sum();
        double avg = numbers.Average();
        int largestNumber = numbers.Max();
        int smallestNumber = numbers.Min();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The avarage is: {avg}");
        Console.WriteLine($"The Largest number is: {largestNumber}");
        Console.WriteLine($"The Smallest number is: {smallestNumber}");

        // Sort in ascending order
        numbers.Sort();
        // OR
        var sortedAscending = numbers.OrderBy(x => x).ToList();

        // Sort in descending order
        var sortedDescending = numbers.OrderByDescending(x => x).ToList();

        // Print the sorted lists
        Console.WriteLine("Sorted (Ascending): " + string.Join(", ", numbers));
        Console.WriteLine("Sorted (Descending): " + string.Join(", ", sortedDescending));

    }
}
