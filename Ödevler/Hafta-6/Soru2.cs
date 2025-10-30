Console.Write("Dizi uzunluğunu giriniz: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 0)
{

    int[] dizi = new int[a];
    Console.Write("Üretilen dizi: [");
    int b = 0;

    int c = 100;



    for (int i = 0; i < a; i++)

    {

        Random randomm = new Random();

        int random = randomm.Next(0, 100);



        dizi[i] = random;



        if (dizi[i] >= b)

        {

            b = 0;

            b = b + dizi[i];

        }
        if (dizi[i] < c)

        {

            c = dizi[i];

        }



        Console.Write(dizi[i]);

        Console.Write(", ");

    }

    Console.Write("]");

    Console.WriteLine();

    Console.WriteLine("Dizinin en büyük elemanı: " + b);

    Console.WriteLine();
    Console.WriteLine("Dizinin en küçük elemanı: " + c);



}

else

{

    Console.WriteLine("Dizi uzunluğu 0 ya da 0'dan küçük olamaz");

}