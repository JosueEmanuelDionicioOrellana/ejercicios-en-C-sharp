using System;
namespace Cadenas_y_strings
{
    class Program
    {
        static void Main(string[] args)
        {
        int op=0;
        int num1=0;
        int num2=0;
        int res=0;
        do{
            System.Console.WriteLine("+---------------------------+");
            System.Console.WriteLine("|       Calculadora         |");
            System.Console.WriteLine("|escoja una de las opciones:|");
            System.Console.WriteLine("|[1]. Suma                  |");
            System.Console.WriteLine("|[2]. Resta                 |");
            System.Console.WriteLine("|[3]. Multiplicacion        |");
            System.Console.WriteLine("|[4]. Division              |");
            System.Console.WriteLine("|[5]. Modulo                |");
            System.Console.WriteLine("|[6]. Salir                 |");
            System.Console.WriteLine("+---------------------------+");
            op=Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (op)
            {
                case 1:
                    System.Console.WriteLine("+---------------------------+");
                    System.Console.WriteLine("|          Suma             |");
                    System.Console.WriteLine("|Escriba el primer digito   |");
                    num1=Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("|Escriba el segundo digito  |");
                    num2=Convert.ToInt32(Console.ReadLine());
                    res= num1+num2;
                    System.Console.WriteLine("|resultado es: " + num1 + " + "+ num2 +" = "+ res +"|");
                    System.Console.WriteLine("+---------------------------+");
                    System.Console.WriteLine("presione enter para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    System.Console.WriteLine("+---------------------------+");
                    System.Console.WriteLine("|         Resta             |");
                    System.Console.WriteLine("|Escriba el primer digito   |");
                    num1=Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("|escriba el segundo digito  |");
                    num2=Convert.ToInt32(Console.ReadLine());
                    res= num1-num2;
                    System.Console.WriteLine("|resultado es: " + num1 + " - "+ num2 +" = "+ res+"|");
                    System.Console.WriteLine("+---------------------------+");
                    System.Console.WriteLine("presione enter para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    System.Console.WriteLine("+---------------------------+");
                    System.Console.WriteLine("|      Multiplicación       |");
                    System.Console.WriteLine("|escriba el primer digito   |");
                    num1=Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("|escriba el segundo digito  |");
                    num2=Convert.ToInt32(Console.ReadLine());
                    res= num1*num2;
                    System.Console.WriteLine("|resultado es: " + num1 + " * "+ num2 +" = "+ res+"|");
                    System.Console.WriteLine("+---------------------------+");
                    System.Console.WriteLine("presione enter para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    System.Console.WriteLine("+---------------------------+");
                    System.Console.WriteLine("|        Division           |");
                    System.Console.WriteLine("|Escriba el primer digito   |");
                    num1=Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("|escriba el segundo digito  |");
                    System.Console.WriteLine("");
                    System.Console.WriteLine("");
                    num2=Convert.ToInt32(Console.ReadLine());
                    if (num2==0)
                    {   
                        System.Console.WriteLine("+-----------------------------+");
                        System.Console.WriteLine("|Error matematico             |");
                        System.Console.WriteLine("|presione enter para continuar|");
                        System.Console.WriteLine("+-----------------------------+");
                        System.Console.WriteLine("presione enter para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    res= num1/num2;
                    
                    System.Console.WriteLine("|resultado es: " + num1 + " / "+ num2 +" = "+ res+"|");
                    System.Console.WriteLine("+---------------------------+");
                    System.Console.WriteLine("presione enter para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    System.Console.WriteLine("+---------------------------+");
                    System.Console.WriteLine("|           Modulo          |");
                    System.Console.WriteLine("|Escriba el primer digito   |");
                    num1=Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("|escriba el segundo digito  |");
                    num2=Convert.ToInt32(Console.ReadLine());
                    if (num2==0)
                    {
                        System.Console.WriteLine("+-----------------------------+");
                        System.Console.WriteLine("|Error matematico             |");
                        System.Console.WriteLine("|presione enter para continuar|");
                        System.Console.WriteLine("+-----------------------------+");
                        System.Console.WriteLine("presione enter para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    res= num1%num2;
                    System.Console.WriteLine("|resultado es: " + num1 + " % "+ num2 +" = "+ res+"|");
                    System.Console.WriteLine("+-----------------------------+");
                    System.Console.WriteLine("presione enter para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    System.Console.WriteLine("+-------------------------------------+");
                    System.Console.WriteLine("|Gracias por utilizar nuestro programa|");
                    System.Console.WriteLine("+-------------------------------------+");
                    System.Console.WriteLine("presione enter para continuar...");
                    Console.ReadKey();
                    Console.Clear();

                    break;
                default:
                    System.Console.WriteLine("+-------------------------------------+");
                    System.Console.WriteLine("|Error, Escoja una de las opciones    |");
                    System.Console.WriteLine("+-------------------------------------+");
                    System.Console.WriteLine("presione enter para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }while(op!=6);
        }
    }
}