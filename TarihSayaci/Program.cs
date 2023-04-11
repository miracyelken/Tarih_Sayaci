DateTime tarih = new DateTime(2024, 1, 1);
DateTime Bugun = DateTime.Now;

double fark = tarih.Subtract(Bugun).Days;

if (fark >= 1)
{
    Console.WriteLine("-----------------------");

    Console.WriteLine($"{fark} gün kaldı");

    Console.WriteLine("-----------------------");
}
else
{
    Console.WriteLine("Yarın!");
}
