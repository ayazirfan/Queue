//sesli harflerin listesi oluşturulacak.
// kullanıcıya sesli harfleri listeye eklenmesini isteyip istemediğisorulacak
// cevap sadece 'E' ve 'H' olacak

internal class Program
{
    private static void Main(string[] args)
    {
        var sesliHarfler = new List<char>()
{'a','e','ı','i','u','ü','o','ö'};

        ConsoleKeyInfo secim;
        var kuyruk = new Queue<char>();
        foreach (char k in sesliHarfler)
        {
            Console.WriteLine($"{k} Kuyruğa eklensinmi?[e/h]");
            secim = Console.ReadKey();
            Console.WriteLine();
            if (secim.Key == ConsoleKey.E)
            {
                kuyruk.Enqueue(k);
                Console.WriteLine($"\n{k} kuyruğa eklendi.");
                Console.WriteLine($"Kuyruktaki eleman sayısı {kuyruk.Count}");
                Console.WriteLine();
            }
        }

        System.Console.WriteLine();
        System.Console.WriteLine("Kuyruktan elemanların kaldırılması işlemi için Esc tuşuna basınız.");
        secim = Console.ReadKey();
           
        System.Console.WriteLine();

    if (secim.Key== ConsoleKey.Escape)
    {
        System.Console.WriteLine();

        while (kuyruk.Count>0)
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"{kuyruk.Peek()}  kuyruktan çıkarılıyor");
            System.Console.WriteLine($"{kuyruk.Dequeue()} kuyruktan çıkarıldı");
            System.Console.WriteLine($"kuyruktaki eleman sayısı: {kuyruk.Count}");
            System.Console.WriteLine();
        }
        System.Console.WriteLine("\nKuyruktan eleman çıkarma işlemi tamamlandı.");


    }
    System.Console.WriteLine("program bitti.");




        static void KuyrukTemelleriOrnegi()
        {
            //Queue
            //Tanımlama

            var karakterKuyruğu = new Queue<char>();

            //ekleme 

            karakterKuyruğu.Enqueue('a');
            karakterKuyruğu.Enqueue('e');
            Console.WriteLine(karakterKuyruğu.Count);

            //Diziye atama
            var dizi = karakterKuyruğu.ToArray();

            //Çıkarma 
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyruğu.Peek()}");
            Console.WriteLine($"{karakterKuyruğu.Dequeue()} kuyruktan çıkartıldı.");
            Console.WriteLine($" Eleman sıyısı: {karakterKuyruğu.Count}");
            Console.WriteLine($"Kuyruğun Başındaki eleman: {karakterKuyruğu.Peek()}");
        }
    }
}