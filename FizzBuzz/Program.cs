// See https://aka.ms/new-console-template for more information
static void FizzBuzz(int endNumber)
{
    for (int i = 1; i < endNumber + 1; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}

FizzBuzz(30);