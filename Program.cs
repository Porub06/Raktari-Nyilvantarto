using Raktari_Nyilvantarto;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

List<Termek> termekek = new List<Termek>();
int hibasSorokSzama = 0;

//Beolvasas


foreach (string sor in File.ReadAllLines("termekek.txt").Skip(1))
{
    string[] adatok = sor.Split('|');

    if (adatok.Length != 4)
    {
        hibasSorokSzama++;
        continue;
    }

    if ((adatok[0]!= "S" && adatok[0] != "G") || string.IsNullOrWhiteSpace(adatok[1]))
    {
        hibasSorokSzama++;
        continue;
    }

    if (!int.TryParse(adatok[2], out int Alapar) || !int.TryParse(adatok[3], out int GaranciaEvek)){
        hibasSorokSzama++;
        continue;
    }

   

    //Peldanyositas

    if (adatok[0] == "S")
    {
        Termek aktualistermek = new Termek(adatok[1], Alapar);
        termekek.Add(aktualistermek);
    }

    if (adatok[0] == "G")
    {
        Termek tartosTermek = new TartosTermek(adatok[1], Alapar, GaranciaEvek);
    }


}
    Console.WriteLine("-----ADATOK KIIRASA-----");
Console.WriteLine($"SIKERES TERMEKEK KIIRASA: {termekek.Count}");
Console.WriteLine($"HIBAS SOROK SZAMA: {hibasSorokSzama}");
Console.WriteLine();
Console.WriteLine("TERMÉKEK:");
foreach (Termek termek in termekek)
{
    Console.WriteLine(termek);
}
Console.WriteLine();
int teljesertek = termekek.Sum(t => t.ErtekSzamitas(10));
Console.WriteLine($"A teljes raktárkészlet összértéke: {teljesertek}");

Console.WriteLine($"\nÖsszes termék száma: {Termek.OsszesTermekekSzama} db");