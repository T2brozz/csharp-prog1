using Praktikum2._3;

MyList<Vehicle> mylist = new MyList<Vehicle>();
mylist.Add(new Car(Color.Black, new DateTime(2016, 5, 27)));
mylist.Add(new Motorbike(Color.Red, new DateTime(2018, 7, 1)));
mylist.Add(new Motorbike(Color.Black, new DateTime(2005, 12, 30)));
mylist.Add(new Car(Color.Green, new DateTime(2017, 8, 25)));
mylist.Add(new Car(Color.Black, new DateTime(2020, 1, 30)));
mylist.Add(new Motorbike(Color.Blue, new DateTime(2013, 11, 26)));
mylist.Add(new Motorbike(Color.Black, new DateTime(2019, 10, 2)));
mylist.Add(new Car(Color.Black, new DateTime(2016, 6, 2)));
foreach (string s in mylist)
{
    Console.WriteLine(s);
}

Console.Write("Removing black vehicles. ");
int i = mylist.Remove(Color.Black);
Console.WriteLine("Deleted " + i + " vehicles:");
foreach (string s in mylist)
{
    Console.WriteLine(s);
}