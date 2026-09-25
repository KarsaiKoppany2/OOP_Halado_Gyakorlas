using _02_AdatvedelemEsKonstruktorok;

Bankszamla Anna = new Bankszamla("100");
Bankszamla Bela = new Bankszamla("200", 100000, 50000);

Anna.Befizetes(100000);
Bela.Kivetel(20000);

Console.WriteLine($"Anna számláján {Anna.Egyenleg} Ft és {Anna.HitelKeret} Ft hitelkeret van.");
Console.WriteLine($"Béla számláján {Bela.Egyenleg} Ft és {Bela.HitelKeret} Ft hitelkeret van.");