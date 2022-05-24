// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the length of the array");
int length;

while (!int.TryParse(Console.ReadLine(), out length)) ;
double[] array = new Double[length];

Console.WriteLine(length);

int input = -1;
int j = 0;
while (input != 0)
{
    Console.WriteLine("Enter the number");

    while (!int.TryParse(Console.ReadLine(), out input)) ;
    try
    {
        array[j] = input;
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Index out of range");
        input = 0;
    }

    j++;
}

Console.WriteLine("Enter prefix");
int prefix;
while (!int.TryParse(Console.ReadLine(), out prefix)) ;
for (int i = 0; i < prefix; i++)
{
    try
    {
        array[i] = Math.Sqrt(array[i]);
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Index out of range");
        break;
    }
    catch (Exception )
    {
        throw new InvalidSqrtException();
    }
}


Console.WriteLine(string.Join(", ", array));

public class InvalidSqrtException : Exception
{
}