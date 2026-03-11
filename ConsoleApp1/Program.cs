using Voiture;

Reservoir r1 = new Reservoir(50);
r1.diminuer(20);
Console.WriteLine(r1.ToString());

voiture v1 = new voiture("1234AB56", 150, r1);
Console.WriteLine(v1.ToString());