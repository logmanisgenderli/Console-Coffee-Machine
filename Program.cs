using System.Reflection.Metadata;
bool davamedilsin = true;
while (davamedilsin)
{
    Console.WriteLine("1 - espresso - 3");
    Console.WriteLine("2 - americano - 5 AZN");
    Console.WriteLine("3 - latte - 7 AZN");
    Console.WriteLine("4 - cappucino - 8 AZN");
    Console.Write("Hansi kofeden isteyirsiniz?");
    string nov = Console.ReadLine();
    Console.Write("Nece stekan?");
    string say = Console.ReadLine();
    Console.WriteLine("1 - kicik");
    Console.WriteLine("2 - orta + 1 AZN");
    Console.WriteLine("3 - boyuk + 2 AZN");
    Console.Write("hansi olcu?");
    string olcu = Console.ReadLine();
    Console.Write("Seker isteyirsiniz?");
    string seker = Console.ReadLine();
    int kofenovu = 0;
    int kofeolcu = 0;
    switch (nov)
    {
        case "1":
            kofenovu = 3;
            break;
        case "2":
            kofenovu = 5;
            break;
        case "3":
            kofenovu = 7;
            break;
        case "4":
            kofenovu = 8;
            break;
        default:
            Console.Write("Bele bir secim yoxdur.");
            continue;
    }
    switch (olcu)
    {
        case "1":
            kofeolcu = 0;
            break;
        case "2":
            kofeolcu = 1;
            break;
        case "3":
            kofeolcu = 2;
            break;
        default:
            Console.Write("bele bir olcu yoxdur");
            break;
    }
    int kofesayi = Convert.ToInt32(say);
    int kofeqiymeti = (kofenovu + kofeolcu);
    int kofeyekunqiymet = (kofeqiymeti * kofesayi);
    Console.WriteLine($"Siz {kofesayi} stekan secdiniz");
    Console.WriteLine($"sizin kofenizde seker {seker}");
    Console.WriteLine($"Yekun odenilecek mebleg: {kofeyekunqiymet} AZN");

    Console.Write("Yeni sifaris vermek isteyirsiniz?");
    string cavab = Console.ReadLine();
    if (cavab.ToLower() == "xeyr" || cavab.ToLower() == "yox")
    {
        davamedilsin = false;
        Console.WriteLine("Sifarisiniz ucun tesekkur edirik!");
    }
}