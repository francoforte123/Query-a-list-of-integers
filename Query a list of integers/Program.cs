﻿List<int> ListOfNumbersRandom=new List<int>();
Random RandomNumbers=new Random();

for(int i = 0; i < 1001; i++)
{
    ListOfNumbersRandom.Add(RandomNumbers.Next(0, 70));
}

Console.WriteLine("sto stampando i numeri presenti nella lista:");

foreach (int x in ListOfNumbersRandom)
{
    Console.WriteLine(x);
}

Console.WriteLine("-------------------------------------------------");
Console.WriteLine("sto stampando i numeri dispari presente nella lista");
List<int> ListOfNumersOdd = (from number in ListOfNumbersRandom where number % 2 != 0 select number).ToList();

foreach (int x in ListOfNumersOdd)
{
    Console.WriteLine(x);
}







