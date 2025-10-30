Console.Write("Birinci yolcunun adını giriniz: ");
string isim1 = Console.ReadLine();
Console.Write(isim1 + "'in koltuk numarasını giriniz: ");
int ilkkoltuk = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("İkinci yolcunun adını giriniz: ");
string isim2 = Console.ReadLine();
Console.Write(isim2 + "'in koltuk numarasını giriniz: ");
int ikincikoltuk = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Değişimden önce:");
Console.WriteLine(isim1 + " - Koltuk " + ilkkoltuk);
Console.WriteLine(isim2 + " - Koltuk " + ikincikoltuk);
Console.WriteLine();

Console.WriteLine("Değişimden sonra:");
Console.WriteLine(isim1 + " - Koltuk " + ikincikoltuk);
Console.WriteLine(isim2 + " - Koltuk " + ilkkoltuk);
