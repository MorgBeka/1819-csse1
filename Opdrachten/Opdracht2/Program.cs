using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            fibonacci();
            faculteit();
            vermenigvuldiging();
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

    int firstNum = 0;
    int sum = 1; 

    for (int fibonacci=0; fibonacci <10; fibonacci++){
        sum = firstNum + sum;

        Console.WriteLine(firstNum);
        Console.WriteLine(sum);
        firstNum = firstNum + sum;
            }   
            
        }

 //Tafels van vermenigvuldiging 

 static void vermenigvuldiging()
        {
        for (int firstNum = 0; firstNum<11; firstNum++){
            
        Console.WriteLine(" De teller is nu " + firstNum);

            for (int secondNum = 0; secondNum<11; secondNum++){
                Console.WriteLine(firstNum + " x " + secondNum + " = " + firstNum * secondNum );
            }
        }
        }

}
}


        


