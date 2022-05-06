using System;

namespace Algoritmo_di_Luhl
{
    class Program
    {
        static void Main(string[] args)
        {
            int tot = 0;
            int n = 0;

            Console.WriteLine("Inserisci un PAN a caso:");
            string risposta = Console.ReadLine();
            n = risposta.Length;
            for (int i = risposta.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}", Convert.ToString(Convert.ToInt32(Char.GetNumericValue(risposta[i]))));
                if (Char.GetNumericValue(risposta[i]) == -1)
                {
                    n--;
                }
                else if ((i + n) % 2 == 0)
                {

                    tot += Convert.ToInt32(Char.GetNumericValue(risposta[i])) * 2;
                }
                else
                {
                    tot += Convert.ToInt32(Char.GetNumericValue(risposta[i]));
                }
            }

            Console.WriteLine("Il totale e': {0}", tot);
            if (tot % 10 == 0 && n == 16)
            {
                Console.WriteLine("Il Pan e' accettabile");
            }
            else
            {
                Console.WriteLine("Non accettabile");
            }
            int[] Pan_Generated = Generate_Pan();
            string Pan_Tot = "";
            for(int i = 0; i < Pan_Generated.Length; i++)
            {
                Pan_Tot += Convert.ToString(Pan_Generated[i]);
                if((i+1) % 4 == 0 && i != 0)
                {
                    Pan_Tot += " "; 
                }
            }
            Console.WriteLine("Ïl Pan generato e': {0}", Pan_Tot);
        }
        public static int[] Generate_Pan()
        {
            int[] Pan= new int[16];
            int tot = 0;
            bool control;
            do
            {
                tot = 0;
                control = false;
                for (int i = (Pan.Length -1); i >+ 0; i--)
                {
                    Pan[i] = GenerateNumber();
                    if (i % 2 == 0)
                    {
                        tot += Pan[i] * 2;
                    }
                    else
                    {
                        tot += Pan[i];
                    }
                }

                if (tot % 10 != 0)
                {
                    control = true;
                }
            }while(control);
            return Pan;

        }
        public static int GenerateNumber()
        {
            int num;
            Random random = new();
            num = random.Next(1, 10);
            Console.WriteLine(num.ToString());
            return num;
        }
    } 
}

