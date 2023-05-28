using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoCLI
{
    public static class Exercises
    {
        public static string ReverseString(string str)
        {
            if(str == "")
            {
                return "";
            }
            var charArr = str.ToCharArray();
            var leftIdx = 0;
            var rightIdx = str.Length - 1;
            while(leftIdx < rightIdx)
            {
                char temp = charArr[leftIdx];
                charArr[leftIdx] = charArr[rightIdx];
                charArr[rightIdx] = temp;
                leftIdx++;
                rightIdx--;
            }
            return new string(charArr);
        }

        public static void IsEvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"El numero {num} es par");
            }
            else
            {
                Console.WriteLine($"El numero {num} es impar");
            }
        }

        public static bool PrintColorBasedTableWithIf(string color)
        {
            /*
             * Amarillo = La Tabla del 2. 
             * Morado = Tabla del 7
             * Rosa = Tabla del 9
             * Azul = Tabla del 6
             * Blanco = Tabla del 12
            */
            if(color == "Amarillo")
            {
                PrintMultiplicationTable(2);
            } else if(color == "Morado")
            {
                PrintMultiplicationTable(7);
            } else if(color == "Rosa")
            {
                PrintMultiplicationTable(9);
            } else if(color == "Azul")
            {
                PrintMultiplicationTable(6);
            } else if(color == "Blanco")
            {
                PrintMultiplicationTable(12);
            }
            else
            {
                return false;
            }
            return true;
        }

        public static bool PrintColorBasedTableWithSwitch(string color)
        {
            switch (color)
            {
                case "Amarillo":
                    PrintMultiplicationTable(2);
                    break;
                case "Morado":
                    PrintMultiplicationTable(7);
                    break;
                case "Rosa":
                    PrintMultiplicationTable(9);
                    break;
                case "Azul":
                    PrintMultiplicationTable(6);
                    break;
                case "Blanco":
                    PrintMultiplicationTable(12);
                    break;
                default:
                    return false;
            }
            return true;
        }
        
        public static void PrintMultiplicationTable(int n)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}
