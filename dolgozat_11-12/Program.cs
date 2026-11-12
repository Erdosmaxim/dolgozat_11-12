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
        static int Keresetel(string etelneve)
        {

                int index =Array.IndexOf(huto, etelneve);
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
            
            for (int i = 0; i < szamok.Length; i++)
            {
                int random_szam;
                bool bennevan = false;
                
                do
                {
                    random_szam = rand.Next(min, max);
                   
                    bennevan = false;
                    foreach (var item in szamok)
                    {
                        if (random_szam == item)
                        {
                            bennevan= true;
                        }
                    }
                    
                } while (bennevan);
                szamok[i] = random_szam;


            }
            foreach(var item in szamok)
            {
                Console.WriteLine(item);
            }

        }
        //static void LeghosszabbNovekvo()
        //{
        //    int[] uj = new int[szamok.Length];
        //    for(int i = 0; i < szamok.Length; i++)
        //    {
        //        if (szamok[i] < szamok[])
        //    }
        //}
        static void AtlagAlattiDuplazas()
        {
            int sum = 0;
            for(int i=0;i<szamok.Length;i++)
            {
                sum += szamok[i];
            }
            int atlag=sum/szamok.Length;
            for(int i=0; i < szamok.Length; i++)
            {
                if(szamok[i] < atlag)
                {
                    szamok[i] = szamok[i] * 2;
                }
                Console.WriteLine(szamok[i]);
            }
        }




        static void Main(string[] args)
        {
            //Console.WriteLine("A hűtőben " + Takarit() + " mennyiségű étel van.");
            //Console.WriteLine("Mit ennél? ");
            //string etelneve = Convert.ToString(Console.ReadLine());
            //Console.WriteLine($"Az ételed itt van:{Keresetel(etelneve)} ");
            //maganh();
            Console.WriteLine("Mi legyen a min? ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mi legyen a max? ");
            int max = Convert.ToInt32(Console.ReadLine());
            FeltoltEgyediekkel(min, max);
            AtlagAlattiDuplazas();

        }
    }
}
