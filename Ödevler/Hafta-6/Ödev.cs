/*
    Kamil Eray Özaydın | Hafta 6 Ödevi
*/

Console.Write("N giriniz: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] dizi = new int[n, n];
Random rnd = new Random();
Console.WriteLine();
for (int i = 0; i < n; i++) 
{
    for (int j = 0; j < n; j++) 
    {
        int randomic = rnd.Next(-9, 9);
        dizi[i, j] = randomic;
    }
}

Console.WriteLine("Dizi Değerleri: ");
int negatifsaydiadedi = 0;
for (int i = 0; i < n; i++) 
{
    for (int j = 0; j < n; j++)
    {
        int deger = dizi[i, j];

        
        if (deger < 0)
        {
            Console.Write(deger + "   ");
            negatifsaydiadedi++;
        }
        else
        {
            Console.Write(" " + deger + "   ");
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();

// ana köşegen toplamı
int toplama = 0;
Console.Write("Ana köşegen toplamı: ");
for (int k = 0; k < n; k++)
{
    toplama = toplama + dizi[k,k];
    Console.Write(dizi[k,k]+ " + ");
}
Console.Write("="+" "+toplama);
//
Console.WriteLine();
//
// yardımcı köşegen çarpımı
int carpim = 1;
Console.Write("Yardımcı köşegen çarpımı: ");

for (int m = 0; m < n; m++)
{
    int deger = dizi[m, (n - 1 - m)];

    carpim = carpim * deger;
    Console.Write(deger);
    if (m < n - 1)
    {
        Console.Write(" x ");
    }
}
Console.Write(" =" + " " + carpim);
//
//negatif sayı yazdırma
Console.WriteLine();
Console.WriteLine("Negatif sayı adedi: "+negatifsaydiadedi);
//
// tekrar eden değer bulma 

int[] sayacDizisi = new int[18];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        int deger = dizi[i, j];

        int index = deger + 9;

        sayacDizisi[index]++;
    }
}

int enBuyukSayac = -1;
int enCokTekrarEdenDeger = 0;

for (int index = 0; index < sayacDizisi.Length; index++)
{
    int mevcutSayac = sayacDizisi[index];

    if (mevcutSayac > enBuyukSayac)
    {
        enBuyukSayac = mevcutSayac;
        enCokTekrarEdenDeger = index - 9;
    }
}

Console.WriteLine("En sık tekrar eden değer: "+enCokTekrarEdenDeger);
//
// asal sayıların ortalaması

double asaldeger = 0;
double asalsayisi = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (dizi[i, j] == 2 || dizi[i, j] == 3 || dizi[i, j] == 5 || dizi[i, j] == 7)
        {
            asaldeger = asaldeger + dizi[i,j];
            asalsayisi++;
        }
    }
}
if(asalsayisi > 0)
{
    Console.WriteLine("Asal sayı ortalaması = " + asaldeger / asalsayisi);
}
else
{
    Console.WriteLine("Asal sayı yok..");
}

//
//
Console.WriteLine();
Console.WriteLine("Saat yönünde 90 derece döndürülmüş hali:");


int[,] dondurulmusDizi = new int[n, n];


for (int i = 0; i < n; i++) 
{
    for (int j = 0; j < n; j++)
    {
        dondurulmusDizi[i, j] = dizi[(n - 1) - j, i]; // döndürme formülü
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        int deger = dondurulmusDizi[i, j]; //

        if (deger < 0)
        {
            Console.Write(deger + "    "); 
        }
        else
        {
            Console.Write(" " + deger + "    ");
        }
    }
    Console.WriteLine();
}