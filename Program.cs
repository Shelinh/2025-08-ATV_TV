// See https://aka.ms/new-console-template for more information
Console.WriteLine("follow,ME!");

Televisao tv = new Televisao(55f);
Console.WriteLine($"A tv tem o tamanho {tv.Tamanho}");

tv.Volume = -35;
Console.WriteLine($"Volume {tv.Volume}");

tv.Volume = 120;
Console.WriteLine($"Volume {tv.Volume}");

tv.AumentarVolume();
Console.WriteLine($"Volume {tv.Volume}");
