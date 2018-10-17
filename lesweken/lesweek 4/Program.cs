using System;

namespace lesweek_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rekenen");

            int a= 100;
            int b= 7;
            int c= a + b;
            int d= 3;
            int e= c * d;


            int f= 5;
            int g= 406;
            int h= 7367;
            int i= 69;
            int j= g + h;
            int k= j / i;
            int l= k * f;

            int m= 73;
            int n= 41;
            int o= 39;
            int p= m * n;
            int q= p - o;

            int r= 7;
            int s= 8;
            int t= 19;
            int u= r * s;
            int v= u - t;

            int w= e + l + q + v;
            
            Console.WriteLine("Het resultaat is: " + w);

//een kortere manier dan hierboven --> we moeten minder regels heben 

            int resultaat1 = optellen(100,7);
            int resultaat2 = vermenigvuldigen(resultaat1, 3);

            int resultaat3 = optellen(406, 7367);
            int resultaat4 = deling(resultaat3, 69);
            int resultaat5 = vermenigvuldigen(resultaat4, 5);

            int resultaat6 = vermenigvuldigen(73, 41);
            int resultaat7 = aftrekken(resultaat6, 39);

            int resultaat8 = vermenigvuldigen(7, 8);
            int resultaat9 = aftrekken(resultaat8, 19);

            int resultaat10 = optellen( resultaat2, resultaat5);
            int resultaat11 = optellen( resultaat7, resultaat9);

            int totaal2 = optellen ( resultaat10, resultaat11);

            Console.WriteLine("Het resultaat (kortere berekening) is: " + totaal2);


//Nog een kortere methode dan hierboven 

          
            int resultaata1 = vermenigvuldigen(optellen(100,7), 3);
           
            int resultaata2= vermenigvuldigen(deling(optellen(406,7367), 69), 5);

            int resultaata3 = aftrekken(vermenigvuldigen(73, 41), 39);

            int resultaata4= aftrekken(vermenigvuldigen(7, 8), 19);

            
            int totaal3 = resultaata1 + resultaata2 + resultaata3 + resultaata4;

            
            Console.WriteLine("Het resultaat (kortere berekening 2) is: " + totaal3);


            int totaal4 = vermenigvuldigen(optellen(100,7), 3) + vermenigvuldigen(deling(optellen(406,7367), 69), 5) + aftrekken(vermenigvuldigen(73, 41), 39) + aftrekken(vermenigvuldigen(7, 8), 19);

            Console.WriteLine("Het resultaat (kortere berekening 3) is: " + totaal4);


            //TUSSENSTAP voor totaal7//int totaal5 = optellen(vermenigvuldigen(optellen(100,7), 3),vermenigvuldigen(deling(optellen(406,7367), 69), 5));
           //TUSSENSTAP voor totaal7 //int totaal6 = optellen(aftrekken(vermenigvuldigen(73, 41), 39), aftrekken(vermenigvuldigen(7, 8), 19) );

            //reduceren (korter maken) op correcte manier!!! 
           //Kortste versie 
            // Dit is een sequentie/opeenvolging. Eerst dit, ten tweede dat, .... 
        int totaal7= optellen(optellen(vermenigvuldigen(optellen(100,7), 3),vermenigvuldigen(deling(optellen(406,7367), 69), 5)),optellen(aftrekken(vermenigvuldigen(73, 41), 39), aftrekken(vermenigvuldigen(7, 8), 19) ) );
         Console.WriteLine("Het resultaat (kortere berekening 4 -- correcte antwoord en correcte code) is: " + totaal7);



        //if-statement
        totaal7++;              //dit is om het totale resultaat te verhogen, zo kan je je if-statement controleren (totaal7--;)

        if(totaal7 == 3872){
            Console.WriteLine("Het resultaat is perfect!");
        }
        else if(totaal7 > 3872) {
            Console.WriteLine("Het resultaat is te hoog");
        }
        else{
            Console.WriteLine("Het resultaat is fout");
        }
        }
    static int optellen(int a,int b) {
        return a+b;
    }

    static int vermenigvuldigen(int a, int b) {
        return a * b; 
    }

    static int aftrekken(int a, int b) {
        return a - b; 
    }

    static int deling (int a, int b) {
        return a / b;
    }



    }
}

