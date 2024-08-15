// 1)10 adet tam sayı verisi alacak bir dizi tanımlıyorum.
int[] sayilar = new int[10];

Console.WriteLine("Tam sayı değerlerini giriniz:");

// 2)
for (int i = 0; i < sayilar.Length; i++)
{
    Console.Write($"Sayı {i + 1}: ");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("\nTam sayı dizileri:");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}

// 3) Diziye kullanıcıdan alınan yeni sayıyı ekliyoruz. Tam sayı dizisine giren 11. değer. 
Array.Resize(ref sayilar, sayilar.Length + 1); // Dizinin boyutunu artır
Console.Write("\nYeni bir değer giriniz: ");
sayilar[sayilar.Length - 1] = Convert.ToInt32(Console.ReadLine());

// 4) Bu diziyi büyükten küçüğe ekrana yazdırıyorum.
Array.Sort(sayilar); // Önce diziyi küçükten büyüğe sıralar
Array.Reverse(sayilar); // Sonra büyükten küçüğe çevirir

Console.WriteLine("\nDizinin büyükten küçüğe sıralanmış hali:");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}