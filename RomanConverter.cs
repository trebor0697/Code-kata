using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class RomnaConverter
    {
        //I=1, V=5, X=10, L=50, C=100, D=500, M=1000

        private static void Main()
        {
            Console.WriteLine(ConvertNumerals("XIX"));
        }

        public static int ConvertNumerals(string number)
        {
            number = number.ToUpper();
            for (int i =0; i < number.Length; i++)
            {
                char character = number[i];
            }
            return 0;


        }

        public static int GetNumberValue(char val)
        {
            switch(val)
            {
                case 'I':
                    return numberNumerals.I;
            }
        }
    }
}
enum RomanNumerals
{
    I = 1,
    V = 5,
    X = 10,
    L = 50,
    C = 100,
    D = 500,
    M = 1000

}
