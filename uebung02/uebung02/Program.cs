// See https://aka.ms/new-console-template for more information

using System;

Console.WriteLine("Studentenanzahl");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Mindestprozentzahl:");
double prozent = Convert.ToDouble(Console.ReadLine());

Studenten[] studis = new Studenten[count];
for (int i = 0; i < count; i++)
{
    Console.WriteLine("Name");
    string name=Console.ReadLine();
    Console.WriteLine("Zensur");
    double zensur =Convert.ToDouble(Console.ReadLine());
    studis[i] = new Studenten(name, zensur);
}

for (int i = 0; i < count; i++)
{
    Console.WriteLine(studis[i].ToString());
}