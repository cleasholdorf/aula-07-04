using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite seu peso");
            float peso = float.Parse(Console.ReadLine());
            Console.WriteLine("digitre sua altura");
            float altura = float.Parse(Console.ReadLine());
            float IMC = peso/(altura * altura) ;
            Console.WriteLine(IMC);

            switch (IMC)
            {
                case float numero when IMC < 18.5:
                    Console.WriteLine("ta seco");
                    break;
                case float numero when IMC >= 18.5 && numero< 25:
                    Console.WriteLine("de boa");
                    break;
                case float numero when IMC >= 25 && numero < 30:
                    Console.WriteLine("barriginha");
                    break;
                case float numero when IMC >= 30 && numero < 35:
                    Console.WriteLine("obeso");
                    break;
                case float numero when IMC >= 35 && numero < 40:
                    Console.WriteLine("bem obeso");
                    break;
                case float numero when IMC >= 40:
                    Console.WriteLine("como chegou a esse ponto?");
                    break;


            }
            
        }
    }
}
