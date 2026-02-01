using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace godrokotthon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fájl = File.ReadAllLines("melyseg.txt");
            List<int> melysegek = new List<int>();
            for (int i = 0; i < fájl.Length; i++)
            {
                melysegek.Add(int.Parse(fájl[i]));

            }
            Console.WriteLine("1. feladat");
            Console.WriteLine(melysegek.Count);
            Console.WriteLine("2. Adj meg egy pontot"); int hely = int.Parse(Console.ReadLine());
            Console.WriteLine(melysegek[hely]);
            Console.WriteLine("3. ");
            int erintetlen = 0;
            for (int i = 0; i < melysegek.Count; i++)
            {
                if (melysegek[i] == 0)
                {
                    erintetlen++;
                }
            }
            int erintetlenszazalek = erintetlen / (melysegek.Count / 100);
            Console.WriteLine(erintetlenszazalek + "%");
            Console.WriteLine("4.");
            //using (StreamWriter iro = new StreamWriter("godrok.txt", Encoding="UTF-8")) { }
            int darab = 0;
            if (melysegek[0] > 0) { darab++; }
            for (int i = 0; i < melysegek.Count; i++)
            {
                
                if (melysegek[i] > 0 && (melysegek[i - 1]) == 0 && i > 0)
                {
                    Console.WriteLine();
                    darab++;
                }
                if(melysegek[i] != 0) { Console.Write(melysegek[i]); }
            }
            Console.WriteLine("5. Godrok szama: "+darab);
            Console.WriteLine("6. ");
            if (melysegek[hely]==0)
            {
                Console.WriteLine(  "Az adott helyen nincsen gödör!");
            }
            else
            { int i = hely;
                int j = hely;
                int kezdoi;
                int vegei;
                while (melysegek[i]!=0&&i>0)
                {
                    i--;

                }kezdoi = i+1;
                Console.WriteLine("A godor kezdete "+kezdoi);
                while (melysegek[j]!=0)
                {
                    j++;

                }
                vegei = j; Console.WriteLine("A godor vege: "+vegei);
            }
            Console.WriteLine();



            Console.ReadKey();







            }
        }
    }

