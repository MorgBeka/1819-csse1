using System;

namespace lesweek_6
{
    class Program
    {
        static void Main(string[] args)
        {

        string[,] menu = new string[ , ] { { "Plat water", "1" }, { "cola 25 cl", "1.5" },
                                        { "cola 33 cl", "2" }, {"witte wijn", "3"},
                                        {"pils", "2"}, {"toast", "5"}, {"kaasplank", "4"} };

        Console.WriteLine(menu[0, 0]);


                }
            }
}
