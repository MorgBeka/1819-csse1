using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
            3.1) (Abstract) Factory
            Gebruik voor het tekenen van objecten zoals een cirkel, vierkant, rechthoek, ruit, trapezium, parallellogram,... het factory ontwerppatroon.

            Je voorziet een interface met de naam Vorm waarin je een methode Teken gaat voorzien.
            Maakt een concrete klasse aan met de implementatie van de interface.
            Maak een factory aan voor het aanmaken van objecten van concrete klassen.
            Maak gebruik van factory voor het verkrijgen van objecten van concrete klassen.
                        
            
             */

             VormFactory vormFactory = new VormFactory();
             IVorm vormA = vormFactory.GetVorm("Cirkel");
             vormA.Teken();
        }

    }
}
