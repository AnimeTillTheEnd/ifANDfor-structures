using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_for_egyes_fel
{
    class Program
    {
        static void Main(string[] args)
        {   
            //A feladat, hogy csináljon egy programot, ami 100 és 1100 közötti számokban  17-tel oszthatókat szortírozza ki.
            //(Addig a számíg, amit a felhasználó beírt).

            Console.WriteLine("Kérem írjon be egy számot 100 és 1100 között!");
            int szambekeres = int.Parse(Console.ReadLine());
            int osztas = 17;
            if (szambekeres >= 100 && szambekeres<=1000)
            {
                Console.WriteLine("Ezek a 17-tel osztható számok az Ön beírt száma és 100 között: ");

                for (int i = 100; i <= 1100; i++)
                   
                    if(szambekeres > 99 &&szambekeres< 1101)
                    {
                        if(i%osztas==0 && i<=szambekeres)
                            Console.Write(i+ ", ");
                    }

            }
            //sdf

            else
            {
                Console.WriteLine("A beírt szám nem tartozik 100-1100 közé, próbálja újra!");
            }






            Console.WriteLine(" ");
            Console.ReadLine();
        }
    }
}
