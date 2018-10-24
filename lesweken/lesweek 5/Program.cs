using System;

namespace lesweek_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string tekst = "Dit is een testje!";                    //    String tekst = "Dit is een testje!" --> mag/kan niet want string moet zonder hoofdletter
            int lengte = tekst.Length;     

            for (int i = 0; i < lengte; i++)    
            {
                // Console.WriteLine(i);
                Console.WriteLine(tekst[i]);
                // console.WriteLine(tekst.Substring(i,1));
            }     

            string[] woorden = tekst.Split( ' ');
            foreach ( var woord in woorden){
                Console.WriteLine(woord);
            }

            Console.WriteLine(tekst.ToLower());
            Console.WriteLine(tekst.ToUpper());
            char[] spatie = {' '};
            Console.WriteLine(tekst.Trim(spatie));
/*
          Random rondaomGetal = new Random();
          int getal1 = randomGetal.Next(0,20);
          Console.WriteLine(getal1);
          int getal2 = randomGetal.Next(0,20);
          Console.WriteLine(getal2);
          int getal3 = randomGetal.Next(0,20);
          Console.WriteLine(getal3);
          int getal4 = randomGetal.Next(0,20);
          Console.WriteLine(getal4);

          for (int i = 0; i <50; i++){
              Console.WriteLine(randomGetal.next(0,20)
              );
          }
*/          
        
        char[] chars = new char[8];
        chars[0] = ' ';
        chars[1] = 'G';
        chars[2] = (char)78;
        //Char aanroepen met behulp van integer waarde 
        chars[3] = '\u002E';
        // Char aanroepen doormiddel van de unicode van het karakter 
        chars[4] = 'f';
        chars[5] = 'a';
        chars[6] = 'i';
        chars[7] = (char)85;

        foreach (char c in chars)
        {
            Console.Write(c);
        }
/*
        char[] campus = ('M', 'A', 'R');

      */                 


    string[] menu1 = new string[3];
    menu1 [0] = "broodje martino";          
    menu1 [1] = "broodje ham";      
    menu1[2] = "broodje kaas";      
    
      foreach (var item in menu1)
    {
        Console.WriteLine(item);
    }


    string[] menu2 = new string [ ] {"broodje scampi", "broodje brie", "broodje boulet"};

    foreach (var item in menu2)
    {
        Console.WriteLine(item);
    }
Console.WriteLine("for loop");


    for (int i = 0; i< menu2.Length; i++)
        Console.WriteLine(menu2[i]);

string[,] menu3 = new string [ , ] {{"broodje scampi","4"},{"broodje brie","5"}, {"broodje boulet","3"}};
foreach (var item in menu3)
    {
        Console.WriteLine(item);
    }


        }
    }
}


