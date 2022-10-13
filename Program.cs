using System;

namespace tp7_ejr_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string opc = " ", entrada ;
            int numd,nume,num,resul;
            numd =150;
            nume= 180;
            num=0;
            resul=0;


            while (opc != "x")
            {
                Console.WriteLine ("e-para conversion de euro");
                Console.WriteLine ("d-para conversion de dolar");
                Console.WriteLine ("x-para salir");
                opc = Console.ReadLine();

                switch (opc){
                case "d":
                Console.WriteLine ("Escriba la cantidad de dolares que quiere convertir");
                entrada=Console.ReadLine();
                num=Convert.ToInt32(entrada);
                Console.Clear();
                resul= num*nume;
                Console.WriteLine (" la cantidad de pesos que tiene es {0} ", resul);
                Console.ReadKey();
                break;
                case "e":

                Console.WriteLine ("Escriba la cantidad de euros que quiere convertir");
                entrada=Console.ReadLine();
                num=Convert.ToInt32(entrada);
                Console.Clear();
                resul= num*numd;

                Console.WriteLine ("la cantidad de pesos que tiene es {0}", resul);
                Console.ReadKey();
                break;
                case "x":
                Console.WriteLine ("saliste");
                break;
                }
            }
        }
    }
}
