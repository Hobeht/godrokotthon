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
        static (int,int) elejevege(int hely, List<int> melysegek) {
            int i = hely;
            int j = hely;
            int kezdoi;
            int vegei;
            while (melysegek[i] != 0 && i > 0)
            {
                i--;

            }


            if (i!=0)
            {

            kezdoi = i + 1;
            }
            else
            {
                kezdoi = i;
            }
            Console.WriteLine("A godor kezdete " + kezdoi);
            while (melysegek[j] != 0 && j < melysegek.Count - 1)
            {
                j++;

            }
            if (j!=melysegek.Count-1)
            {

            vegei = j - 1;
            }
            else
            {
                vegei = j;
            }
            return(kezdoi, vegei);
        }
        static (int,int) legmelyebb_pont(int hely,List<int >melysegek) { int max = melysegek[hely];int maxhely = hely;
            
            for (int i = elejevege(hely, melysegek).Item1; i < elejevege(hely,melysegek).Item2-elejevege(hely,melysegek).Item1; i++)
            {
                if (melysegek[i] < max)
                {
                    max = melysegek[i];
                    maxhely = i;

                }
            }




 return (max,maxhely);
        }//feltetelezzuk hogy godrot t ad mega felhasznalo
        static bool monoton(int hely, List<int> melysegek) { bool vege = true;

            for (int i = elejevege(hely,melysegek).Item1+1; i < (legmelyebb_pont(hely,melysegek).Item2-elejevege(hely, melysegek).Item1)-1; i++)
            {
                if (!(melysegek[i] > melysegek[i-1]))
                {
                    vege = false;
                }
            }
            for (int i = legmelyebb_pont(hely, melysegek).Item2 + 1; i < (elejevege(hely, melysegek).Item1-legmelyebb_pont(hely, melysegek).Item2)-1; i++)
            {
                if (!(melysegek[i] <melysegek[i - 1]))
                {
                    vege = false;
                }
            }


            return vege;
        }
        static int godorterfogat(int hely, List<int> melysegek)
        {
            int vege = 0; for (int i = elejevege(hely, melysegek).Item1; i < elejevege(hely,melysegek).Item2- elejevege(hely, melysegek).Item1; i++)
            {
                vege = vege + (melysegek[i] * 10);
            } return vege;
        }
        static int vizbefogadas(int hely, List<int> melysegek) { int vege = 0;

            for (int i = elejevege(hely, melysegek).Item1; i < elejevege(hely, melysegek).Item2 - elejevege(hely, melysegek).Item1; i++)
            {
                if (melysegek[i]>1)
                {
                    vege = vege + ((melysegek[i] - 1) * 10);
                }
            }







                return vege; }
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
                while (melysegek[j]!=0&&j<melysegek.Count-1)
                {
                    j++;

                }
                vegei = j-1; Console.WriteLine("A godor vege: "+vegei);
            }
            Console.WriteLine("A godor legmelyebb pontja"+legmelyebb_pont(hely,melysegek));




            Console.ReadKey();







            }
        }
    }

