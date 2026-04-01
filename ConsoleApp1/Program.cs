using Voiture;

Reservoir r1 = new Reservoir(50);
r1.diminuer(20);
Console.WriteLine(r1.ToString());

VoiturePersonnel v1 = new VoiturePersonnel("1234AB56", 150, r1);
Console.WriteLine(v1.ToString());