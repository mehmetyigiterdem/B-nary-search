using System;

class Program
{
    static int BinarySearch(int[] dizi, int aranan, int baslangic, int bitis)
    {
        if (baslangic <= bitis)
        {
            int orta = (baslangic + bitis) / 2;

            if (dizi[orta] == aranan)
                return orta;

            if (dizi[orta] < aranan)
                return BinarySearch(dizi, aranan, orta + 1, bitis);

            if (dizi[orta] > aranan)
                return BinarySearch(dizi, aranan, baslangic, orta - 1);
        }

        return -1; 
    }

    static void Main()
    {
        int[] dizi = { 4, 8, 3, 84, 47, 76, 9, 24, 68 };

        Array.Sort(dizi); 

        Console.Write("Aranacak elemanı girin: ");
        int aranan = Convert.ToInt32(Console.ReadLine());

        int sonuc = BinarySearch(dizi, aranan, 0, dizi.Length - 1);

        if (sonuc != -1)
            Console.WriteLine("Aranan eleman dizide bulundu!");
        else
            Console.WriteLine("Aranan eleman dizide bulunamadı!");

        Console.ReadLine();
    }
}
