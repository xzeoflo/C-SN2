EtreVivant vladymir = new EtreVivant ();
EtreVivant simba = new EtreVivant (new DateTime (2003,11,28));
Console.WriteLine($"vladymir : {vladymir.DateNaissance}");
Console.WriteLine($"simba : {simba.DateNaissance}");
Console.WriteLine($"simba : {simba.GetAge()}");


