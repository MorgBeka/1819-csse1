using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            fibonacci();
            

        Program program = new Program();
        Console.WriteLine("Geef je getal in waar je de vermenigvuldig van wilt ");
        int tafelVan = Convert.ToInt32(Console.ReadLine());
        program.Tafel(tafelVan);


        Console.WriteLine("Geef je getal in waar je de faculteit van wilt ");
           int getal1 = Convert.ToInt32(Console.ReadLine());
           program.faculteit(getal1);
        }

//faculteit
    void faculteit(int facNum)
        {

            int a = 1; 
            for( int b = 1; b < facNum+1; b++){
                int c = a * b;
                a = c;
            }
        Console.WriteLine("faculteit van natuurlijk getal is " + a);
        }

//fibonacci
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

  void Tafel(int firstNum) 
        {
     //   for (int firstNum = 0; firstNum<11; firstNum++){
            
            for (int secondNum = 0; secondNum<11; secondNum++){
                Console.WriteLine(secondNum + " x " + firstNum + " = " + secondNum * firstNum );
            }
       // }
        }

}
}


        


