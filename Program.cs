using static DecoCLI.Exercises;

bool exit = false;
while (!exit)
{
    Console.WriteLine("Seleccione una opcion");
    Console.WriteLine("1. Invertir un string");
    Console.WriteLine("2. Revisar si un numero es par o impar");
    Console.WriteLine("3. Imprimir tabla de multiplicacion dependiendo del color (if else)");
    Console.WriteLine("4. Imprimir tabla de multiplicacion dependiendo del color (switch)");
    Console.WriteLine("5. Salir");
    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("Ingresa un string");
            string str = Console.ReadLine();
            str = ReverseString(str);
            Console.WriteLine(str);
            break;
        case "2":
            Console.WriteLine("Ingresa un numero");
            bool isNum = false;
            while (!isNum)
            {
                isNum = int.TryParse(Console.ReadLine(), out int n);
                if (!isNum)
                {
                    Console.WriteLine("Ingresa un numero");
                }
                else
                {
                    IsEvenOrOdd(n);
                }
            }
            break;
            
        case "3":
            Console.WriteLine("Ingresa un color");
            bool validColor = false;
            while (!validColor)
            {
                var res = PrintColorBasedTableWithIf(Console.ReadLine());
                validColor = res;
                if (!validColor)
                {
                    Console.WriteLine("Ingresa un color valido");
                    Console.WriteLine("* Amarillo = La Tabla del 2. \r\n* Morado = Tabla del 7\r\n* Rosa = Tabla del 9\r\n* Azul = Tabla del 6\r\n* Blanco = Tabla del 12");
                }
            }
            break;
        case "4":
            Console.WriteLine("Ingresa un color");
            bool validColorS = false;
            while (!validColorS)
            {
                var res = PrintColorBasedTableWithSwitch(Console.ReadLine());
                validColorS = res;
                if (!validColorS)
                {
                    Console.WriteLine("Ingresa un color valido");
                }
            }
            break;
        case "5":
            exit = true;
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
}

