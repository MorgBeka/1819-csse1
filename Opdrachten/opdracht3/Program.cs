using System;
using System.Collections;
using System.Collections.Generic;

namespace opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
        
            //     string[,] menu = new string[ , ] { { "Plat water", "1" }, { "cola 25 cl", "1.5" },
            //                                     { "cola 33 cl", "2" }, {"witte wijn", "3"},
            //                                     {"pils", "2"}, {"toast", "5"}, {"kaasplank", "4"} };

            //    // Console.WriteLine(menu[0, 0] + " " +menu[0,1]+ "euro");

            //     int row = menu.GetLength(0);

            //     for(int i=0; i < row; i++){
            //         Console.Write(menu[i, 0]+ " "+ menu[i,1]);
            // }

            //      string[] drank = new string[ , ] { { "Plat water", "1" }, { "cola 25 cl", "1.5" },
            //                                     { "cola 33 cl", "2" }, {"witte wijn", "3"},
            //                                     {"pils", "2"}, {"toast", "5"}, {"kaasplank", "4"} };

            //     string[] prijs= new string[]{"1", "1,5","2", "3", "2", "5", "4"};

            //     Array.Sort(drank, prijs);

//menu tonen 

    Dictionary<string, double> menu = new Dictionary<string, double>();

            menu.Add("Plat water", 1);
            menu.Add("Cola 25 cl", 1.5);
            menu.Add("Cola", 2);
            menu.Add("Witte wijn", 3);
            menu.Add("Pils", 2);
            menu.Add("Toast", 5);
            menu.Add("Kaasplank", 4);

    Console.Write("de menu");
      foreach( var menulist in menu )
        {
            Console.WriteLine(menulist.Key + "\t " + menulist.Value); 
                
        }

//sorteren

     SortedDictionary<string, double> sortedMenu = new SortedDictionary<string, double>();

            sortedMenu.Add("Plat water", 1);
            sortedMenu.Add("Cola 25 cl", 1.5);
            sortedMenu.Add("Cola", 2);
            sortedMenu.Add("Witte wijn", 3);
            sortedMenu.Add("Pils", 2);
            sortedMenu.Add("Toast", 5);
            sortedMenu.Add("Kaasplank", 4);

    Console.Write("gesorteerde menu " );
    
      foreach( var menulist in sortedMenu )
        {
            Console.WriteLine(menulist.Key + "\t" + menulist.Value);  
                
        }
                        
//kiezen

    Console.Write("Kies je bestelling");
    string bestelling = Console.ReadLine();
    Console.WriteLine("je koos voor " + bestelling);
    Console.WriteLine("dit product kost " + sortedMenu[bestelling]+ " euro");
    Console.WriteLine();




    //kiezen datatype Queue 

    Console.WriteLine("Lijst van niet bediende klanten");
    Queue list = new Queue();
        list.Enqueue("Eva");
        list.Enqueue("Marie");
        list.Enqueue("Lotte");
        list.Enqueue("Charlotte");
        list.Enqueue("Stephanie");
        list.Enqueue("Renée");
        list.Enqueue("Lore");



    //verwijderen 

WeergevenNamen(namen);

Console.WriteLine("Dequeue)\t{0}", namen.Dequeue());

Console.WriteLine("Dequeue)\t{0}", namen.Dequeue());

WeergevenNamen(namen);

Console.WriteLine("Dequeue)\t{0}", namen.Dequeue());
Console.WriteLine("Dequeue)\t{0}", namen.Dequeue());

WeergevenNamen(namen);

Console.WriteLine("Dequeue)\t{0}", namen.Dequeue());
Console.WriteLine("Dequeue)\t{0}", namen.Dequeue());

WeergevenNamen(namen);
Console.WriteLine("Dequeue)\t{0}", namen.Dequeue());
Console.WriteLine("Dequeue)\t{0}", namen.Dequeue());

WeergevenNamen(namen);

Console.WriteLine("Dequeue)\t{0}", namen.Dequeue());


Static void WeergevenNamen(Queue list)
{   
    if(list.count >= 1 )
    {
        Console.WriteLine("Lijst van niet bediende klanten");
        foreach(Object obj in list)
            Console.WriteLine("Item: {0}", obj);

    }
    else
            Console.WriteLine("Geen namen meer");
        
 
}



         }
     }
}

