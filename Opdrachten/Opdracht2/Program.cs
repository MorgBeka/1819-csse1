using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            fibonacci();
            faculteit();
        }

static void faculteit()
        {

int a = 1; 
for( int b = 1; b < 16; b++){
    int c = a * b;
    a = c;

    Console.WriteLine("faculteit van natuurlijk getal is " + a);
}
    
}
 static void fibonacci()
        {

    int d = 0;
    int e = 1; 

    for (int fibonacci=0; fibonacci <10; fibonacci++){
        e = d + e;

        Console.WriteLine(d);
        Console.WriteLine(e);
        d = d + e;
            }   
            
        }
}
}


        


