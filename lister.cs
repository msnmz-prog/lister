using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- TO DO APP ---");
            Console.WriteLine("1 - Görev ekle");
            Console.WriteLine("2 - Görevleri göster");
            Console.WriteLine("3 - Görev sil");
            Console.WriteLine("4 - Çıkış");

            Console.Write("Seçim: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Görev gir: ");
                string task = Console.ReadLine();
                tasks.Add(task);
            }
            else if (choice == "2")
            {
                Console.WriteLine("\n--- Görevler ---");

                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + tasks[i]);
                }
            }
            else if (choice == "3")
            {
                Console.Write("Silinecek görev numarası: ");
                int index = int.Parse(Console.ReadLine());

                if (index > 0 && index <= tasks.Count)
                {
                    tasks.RemoveAt(index - 1);
                }
                else
                {
                    Console.WriteLine("Geçersiz numara!");
                }
            }
            else if (choice == "4")
            {
                running = false;
            }
        }
    }
}










