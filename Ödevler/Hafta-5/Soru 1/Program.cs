// Soru kaynak görsel olarak eklenmiştir

Random random = new Random();
int[] sayilardizisi = new int[15];
int ilksayi = 0;
int ikincisayi = 0;
int ucuncusayi = 0;

Console.WriteLine("Üretilen matris:");
for (int i = 1; i <= 5; i++)
{
    

    int sayitoplamalar = 0;
    for (int j = 1; j <= 3; j++)
    {
        sayilardizisi[j] = random.Next(0,9);
        sayitoplamalar = sayitoplamalar + sayilardizisi[j];
    }

    ilksayi = sayilardizisi[1] + ilksayi;
    ikincisayi = sayilardizisi[2] + ikincisayi;
    ucuncusayi = sayilardizisi[3] + ucuncusayi;


    Console.Write("[" + sayilardizisi[1]+", " + sayilardizisi[2] + ", " + sayilardizisi[3]+"]");
    Console.Write("             Satır toplamı: " + sayitoplamalar);
    Console.WriteLine();

    
}
Console.WriteLine();
Console.WriteLine("1. sütun toplamı: "+ ilksayi);
Console.WriteLine("2. sütun toplamı: " + ikincisayi);
Console.WriteLine("3. sütun toplamı: " + ucuncusayi);

