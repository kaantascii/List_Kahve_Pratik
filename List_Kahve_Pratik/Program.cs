using System;
//girilmesi gereken kütüphaneler
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        //kahve isimlerini tutacak bir liste oluştur
        List<string> coffeeList = new List<string>();

        //Kullanıcıdan kahve isimlerini al
        Console.WriteLine("Lütfen 5 Kahve ismi giriniz:");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Kahve {i}: ");
            string coffeeName = Console.ReadLine();
            coffeeList.Add(coffeeName);
        }
        //Kahve isimlerini ekrana yazdır
        Console.WriteLine("\nGirdiğiniz Kahve İsimleri:");

        int index = 1; // Başlangıç indeksi
        // Listeyi döngü ile yazdır 
        foreach (string coffee in coffeeList)
        {
            Console.WriteLine($"{index}. {coffee}");
            index++;
        } 

    }
}