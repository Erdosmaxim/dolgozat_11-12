using System.Security.Cryptography;

namespace dolgozat_11_12
{
    internal class Program
    {
        static string[] huto = new string[10];
        static Random rand = new Random();
        static int Takarit()

        {
            string bekert=Convert.ToString(Console.ReadLine());
            while(bekert != "k")
            {
                Console.Write("Mit tennél bele (kilépés k-betűvel)?");
                for (int i = 0; i < huto.Length; i++)
                {
                    if (bekert == null)
                    {

                    }
                    huto[rand.Next(1,huto.Length - 1)]=bekert;
                }

            }
            string[] tmp=new string[huto.Length];
            int index = 0;
            //while (huto[index] == "")
            //{
            //    index++;
            //}
            huto.Sort();
            for(int i=0; i<huto.Length;i++)
            {
                Console.WriteLine(huto[i]);
            }
            for (int i = 0; i < huto.Length; i++)
            {
                if(huto[i] !="")
                {
                    tmp.Append(huto[i]);
                }
            }
            return tmp.Length;
        }
        static int Keresetel( string etel)
        {
            int index = 0;
            for(int i = 0;i<huto.Length;i++)
            {
                if (huto[i] == etel)
                {
                    index = i;
                }
            }
            return index;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("A hűtőben "+Takarit()+" mennyiségű étel van.");
            Console.WriteLine("Mit ennél? ");
            string etelneve = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Az ételed itt van:{Keresetel(etelneve)} ");
        }
    }
}
