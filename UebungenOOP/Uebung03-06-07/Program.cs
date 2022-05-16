// See https://aka.ms/new-console-template for more information

using UebungenOOP;

Zeitangabe zeit1 = new Zeitangabe(12, 12, 20,42);
Zeitangabe zeit2 = new Zeitangabe(3, 15, 45,8);
// addiere die 
Console.WriteLine((zeit1 +zeit2).ToString());
Console.WriteLine((zeit1 -zeit2).ToString());
Console.WriteLine((zeit1++).ToString());


warenkorb korb = new warenkorb();

korb.add(new buch(23, 34.5f, "author", "super toller titel", "fsin"));
korb.add(new video(24,50.5f, "author", "super toller titel", true));
Console.WriteLine(korb.calcPreis());
korb.print();