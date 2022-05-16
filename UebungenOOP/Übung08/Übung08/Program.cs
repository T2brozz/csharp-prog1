using Übung08;

Console.WriteLine("_____________A____________");

//a
bruch b = new bruch(4, 5);
Console.WriteLine(b.CompareTo(null));
bruch[] arr = new[]
{
    new bruch(3, 5),
    new bruch(1, 8),
    new bruch(9, 7),
    new bruch(6, 6)
};
Array.Sort(arr);
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i].ToString());
}
Console.WriteLine("_____________B____________");

// b
randNum Nummer= new randNum(10);
foreach (int rand  in Nummer)
{
    Console.WriteLine(rand);
}
Console.WriteLine("_____________C____________");
// c
randNumNoYield num= new randNumNoYield(10);
foreach (int rand  in num)
{
    Console.WriteLine(rand);
}