using System;

namespace calculator{
    class Program{
        static void Main(string[] args){
            Console.Title = "Aplikasi Kalkulator!";
            Console.Write("Inputkan Nilai A = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Inputkan Nilai B = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Hasil Penambahan "+a+"+"+b+" = "+Penambahan(a,b));
            Console.WriteLine("Hasil Pengurangan "+a+"-"+b+" = "+Pengurangan(a,b));
            Console.WriteLine("Hasil Perkalian "+a+"*"+b+" = "+Perkalian(a,b));
            Console.WriteLine("Hasil Pembagian "+a+"/"+b+" = "+Pembagian(a,b));
        }
        
        static int Penambahan(int a, int b){
            return a+b;
        }

        static int Pengurangan(int a, int b){
            return a-b;
        }

        static int Pembagian(int a, int b){
            return a/b;
        }

        static int Perkalian(int a, int b){
            return a*b;
        }
    }
}
