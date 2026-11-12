using System.Security.Cryptography;

namespace dolgozat_11_12
{
    internal class Program
    {
        static string[] huto = { "tej", "", "hus", "", "avaj", "", "" };
        static string[] seged = new string[huto.Length];
        static Random rand = new Random();

        static int[] szamok = new int[10];
        static int Takarit()
        {
            int index = 0;
            int szamol = 0;
            for(int i = 0; i < huto.Length; i++)
            {
                if (huto[i] != "")
                {
                     seged[index] = huto[i];
                     index++;
                    szamol++;
                }
                
            }
            for(int i = 0; i < huto.Length; i++)
            {
                if (seged[i] == null)
                {
                    seged[i] = "";
                }
            }
            huto = seged;
            for(int i = 0;i < huto.Length; i++)
            {
                Console.WriteLine(huto[i]);
            }
            return szamol;
        
        }
        static int Keresetel(string etel)
        {
            int index = 0;
            for (int i = 0; i < huto.Length; i++)
            {
                if (huto[i] == etel)
                {
                    index = i;
                }
                else
                {
                    index = 0;
                }
            }
            return index;
        }
        static void maganh()
        {
            string magan = "aáiíoóőúüűeé";
            for (int i = 0; i < huto.Length; i++)
            {
                if (huto[i]!= "" && magan.Contains(huto[i][0]))
                {
                    Console.WriteLine(huto[i]);
                }
            }


        }

        //2
        static void FeltoltEgyediekkel(int min, int max)
        {
            int random_szam = rand.Next(min, max);
            int k = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = random_szam;
                for (int j = 0; j < szamok.Length; j++)
                {
                    if (szamok[j] == szamok[i])
                    {
                        random_szam = rand.Next(min, max);
                        szamok[i] = random_szam;
                    }
                }


                Console.WriteLine(szamok[i]);
            }

        }





        static void Main(string[] args)
        {
            Console.WriteLine("A hűtőben " + Takarit() + " mennyiségű étel van.");
            Console.WriteLine("Mit ennél? ");
            string etelneve = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Az ételed itt van:{Keresetel(etelneve)} ");
            maganh();
            Console.WriteLine("Mi legyen a min? ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mi legyen a max? ");
            int max = Convert.ToInt32(Console.ReadLine());
            FeltoltEgyediekkel(min, max);

        }
    }
}
