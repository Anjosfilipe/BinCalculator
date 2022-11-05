using System;

namespace Bincalculator
{

    internal class Program
    {
        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"

 .o88b.  .d8b.  db       .o88b. db    db db       .d8b.  d8888b.  .d88b.  d8888b.  .d8b.       d8888b. d888888b d8b   db  .d8b.  d8888b. d888888b  .d8b.  
d8P  Y8 d8' `8b 88      d8P  Y8 88    88 88      d8' `8b 88  `8D .8P  Y8. 88  `8D d8' `8b      88  `8D   `88'   888o  88 d8' `8b 88  `8D   `88'   d8' `8b 
8P      88ooo88 88      8P      88    88 88      88ooo88 88   88 88    88 88oobY' 88ooo88      88oooY'    88    88V8o 88 88ooo88 88oobY'    88    88ooo88 
8b      88~~~88 88      8b      88    88 88      88~~~88 88   88 88    88 88`8b   88~~~88      88~~~b.    88    88 V8o88 88~~~88 88`8b      88    88~~~88 
Y8b  d8 88   88 88booo. Y8b  d8 88b  d88 88booo. 88   88 88  .8D `8b  d8' 88 `88. 88   88      88   8D   .88.   88  V888 88   88 88 `88.   .88.   88   88 
 `Y88P' YP   YP Y88888P  `Y88P' ~Y8888P' Y88888P YP   YP Y8888D'  `Y88P'  88   YD YP   YP      Y8888P' Y888888P VP   V8P YP   YP 88   YD Y888888P YP   YP 
                                                                                                                                                          
");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t                        Infome a opção Desejada!                          ");
            Console.WriteLine("\t\t\t--------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t|                            [1] ADICAO                                  |");
            Console.WriteLine("\t\t\t|                            [2] SUBTRACAO                               |");
            Console.WriteLine("\t\t\t|                            [3] MULTIPLICACAO                           |");
            Console.WriteLine("\t\t\t|                            [4] DIVISAO                                 |");
            Console.WriteLine("\t\t\t|                            [5] HEXA for BIN                            |");
            Console.WriteLine("\t\t\t|                            [6] BIN for HEXA                            |");
            Console.WriteLine("\t\t\t|                            [0] SAIR                                    |");
            Console.WriteLine("\t\t\t--------------------------------------------------------------------------");

            Console.WriteLine(" - TECLE [ENTER] - ");
          
        }
        static string ConvertHexaforBin(string number)
        {
            string newNumber = Convert.ToString(Convert.ToInt32(number, 16), 2);
            return newNumber;
        }
        static string ConvertBinforHexa(string number)
        {
            return Convert.ToString(Convert.ToInt32(number, 2), 16);
        }
        static void Programin()
        {
            int opc;
            do
            {
                
                Console.Clear();
                Menu();
                string x = Console.ReadLine();
                 opc = int.Parse(x);

                switch (opc)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(@"

 .o88b.  .d8b.  db       .o88b. db    db db       .d8b.  d8888b.  .d88b.  d8888b.  .d8b.       d8888b. d888888b d8b   db  .d8b.  d8888b. d888888b  .d8b.  
d8P  Y8 d8' `8b 88      d8P  Y8 88    88 88      d8' `8b 88  `8D .8P  Y8. 88  `8D d8' `8b      88  `8D   `88'   888o  88 d8' `8b 88  `8D   `88'   d8' `8b 
8P      88ooo88 88      8P      88    88 88      88ooo88 88   88 88    88 88oobY' 88ooo88      88oooY'    88    88V8o 88 88ooo88 88oobY'    88    88ooo88 
8b      88~~~88 88      8b      88    88 88      88~~~88 88   88 88    88 88`8b   88~~~88      88~~~b.    88    88 V8o88 88~~~88 88`8b      88    88~~~88 
Y8b  d8 88   88 88booo. Y8b  d8 88b  d88 88booo. 88   88 88  .8D `8b  d8' 88 `88. 88   88      88   8D   .88.   88  V888 88   88 88 `88.   .88.   88   88 
 `Y88P' YP   YP Y88888P  `Y88P' ~Y8888P' Y88888P YP   YP Y8888D'  `Y88P'  88   YD YP   YP      Y8888P' Y888888P VP   V8P YP   YP 88   YD Y888888P YP   YP 
                                                                                                                                                          
");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Infome o 1º valor Desejado: \n");
                        string number1 = Console.ReadLine();
                        string newNumberBin1 = ConvertHexaforBin(number1);
                        Console.Write("Infome o 1º valor Desejado:  \n");
                        string number2 = Console.ReadLine();
                        string newNumberBin2 = ConvertHexaforBin(number2);

                        var soma = int.Parse(newNumberBin1) + int.Parse(newNumberBin2);
                        Console.Write($"Resultado em binario: {soma}  \n");
                        Console.Write($"Resultado em Hezadecimal: {ConvertBinforHexa(soma.ToString())}  \n");
                        Console.WriteLine("\n\n\n - TECLE [ENTER] - ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(@"

 .o88b.  .d8b.  db       .o88b. db    db db       .d8b.  d8888b.  .d88b.  d8888b.  .d8b.       d8888b. d888888b d8b   db  .d8b.  d8888b. d888888b  .d8b.  
d8P  Y8 d8' `8b 88      d8P  Y8 88    88 88      d8' `8b 88  `8D .8P  Y8. 88  `8D d8' `8b      88  `8D   `88'   888o  88 d8' `8b 88  `8D   `88'   d8' `8b 
8P      88ooo88 88      8P      88    88 88      88ooo88 88   88 88    88 88oobY' 88ooo88      88oooY'    88    88V8o 88 88ooo88 88oobY'    88    88ooo88 
8b      88~~~88 88      8b      88    88 88      88~~~88 88   88 88    88 88`8b   88~~~88      88~~~b.    88    88 V8o88 88~~~88 88`8b      88    88~~~88 
Y8b  d8 88   88 88booo. Y8b  d8 88b  d88 88booo. 88   88 88  .8D `8b  d8' 88 `88. 88   88      88   8D   .88.   88  V888 88   88 88 `88.   .88.   88   88 
 `Y88P' YP   YP Y88888P  `Y88P' ~Y8888P' Y88888P YP   YP Y8888D'  `Y88P'  88   YD YP   YP      Y8888P' Y888888P VP   V8P YP   YP 88   YD Y888888P YP   YP 
                                                                                                                                                          
");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Infome o 1º valor Desejado: \n");
                        number1 = Console.ReadLine();
                        newNumberBin1 = ConvertHexaforBin(number1);
                        Console.Write("Infome o 1º valor Desejado:  \n");
                        number2 = Console.ReadLine();
                        newNumberBin2 = ConvertHexaforBin(number2);

                        var subtracao = int.Parse(newNumberBin1) - int.Parse(newNumberBin2);
                        Console.Write($"Resultado em binario: {subtracao}  \n");
                        Console.Write($"Resultado em Hezadecimal: {ConvertBinforHexa(subtracao.ToString())}  \n");
                        Console.WriteLine("\n\n\n - TECLE [ENTER] - ");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(@"

 .o88b.  .d8b.  db       .o88b. db    db db       .d8b.  d8888b.  .d88b.  d8888b.  .d8b.       d8888b. d888888b d8b   db  .d8b.  d8888b. d888888b  .d8b.  
d8P  Y8 d8' `8b 88      d8P  Y8 88    88 88      d8' `8b 88  `8D .8P  Y8. 88  `8D d8' `8b      88  `8D   `88'   888o  88 d8' `8b 88  `8D   `88'   d8' `8b 
8P      88ooo88 88      8P      88    88 88      88ooo88 88   88 88    88 88oobY' 88ooo88      88oooY'    88    88V8o 88 88ooo88 88oobY'    88    88ooo88 
8b      88~~~88 88      8b      88    88 88      88~~~88 88   88 88    88 88`8b   88~~~88      88~~~b.    88    88 V8o88 88~~~88 88`8b      88    88~~~88 
Y8b  d8 88   88 88booo. Y8b  d8 88b  d88 88booo. 88   88 88  .8D `8b  d8' 88 `88. 88   88      88   8D   .88.   88  V888 88   88 88 `88.   .88.   88   88 
 `Y88P' YP   YP Y88888P  `Y88P' ~Y8888P' Y88888P YP   YP Y8888D'  `Y88P'  88   YD YP   YP      Y8888P' Y888888P VP   V8P YP   YP 88   YD Y888888P YP   YP 
                                                                                                                                                          
");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Infome o 1º valor Desejado: \n");
                        number1 = Console.ReadLine();
                        newNumberBin1 = ConvertHexaforBin(number1);
                        Console.Write("Infome o 1º valor Desejado:  \n");
                        number2 = Console.ReadLine();
                        newNumberBin2 = ConvertHexaforBin(number2);

                        var multi = int.Parse(newNumberBin1) * int.Parse(newNumberBin2);
                        Console.Write($"Resultado em binario: {multi}  \n");
                        Console.Write($"Resultado em Hezadecimal: {ConvertBinforHexa(multi.ToString())}  \n");
                        Console.WriteLine("\n\n\n - TECLE [ENTER] - ");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(@"

 .o88b.  .d8b.  db       .o88b. db    db db       .d8b.  d8888b.  .d88b.  d8888b.  .d8b.       d8888b. d888888b d8b   db  .d8b.  d8888b. d888888b  .d8b.  
d8P  Y8 d8' `8b 88      d8P  Y8 88    88 88      d8' `8b 88  `8D .8P  Y8. 88  `8D d8' `8b      88  `8D   `88'   888o  88 d8' `8b 88  `8D   `88'   d8' `8b 
8P      88ooo88 88      8P      88    88 88      88ooo88 88   88 88    88 88oobY' 88ooo88      88oooY'    88    88V8o 88 88ooo88 88oobY'    88    88ooo88 
8b      88~~~88 88      8b      88    88 88      88~~~88 88   88 88    88 88`8b   88~~~88      88~~~b.    88    88 V8o88 88~~~88 88`8b      88    88~~~88 
Y8b  d8 88   88 88booo. Y8b  d8 88b  d88 88booo. 88   88 88  .8D `8b  d8' 88 `88. 88   88      88   8D   .88.   88  V888 88   88 88 `88.   .88.   88   88 
 `Y88P' YP   YP Y88888P  `Y88P' ~Y8888P' Y88888P YP   YP Y8888D'  `Y88P'  88   YD YP   YP      Y8888P' Y888888P VP   V8P YP   YP 88   YD Y888888P YP   YP 
                                                                                                                                                          
");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Infome o 1º valor Desejado: \n");
                        number1 = Console.ReadLine();
                        newNumberBin1 = ConvertHexaforBin(number1);
                        Console.Write("Infome o 1º valor Desejado:  \n");
                        number2 = Console.ReadLine();
                        newNumberBin2 = ConvertHexaforBin(number2);

                        var div = int.Parse(newNumberBin1) / int.Parse(newNumberBin2);
                        Console.Write($"Resultado em binario: {div}  \n");
                        Console.Write($"Resultado em Hezadecimal: {ConvertBinforHexa(div.ToString())}  \n");
                        Console.WriteLine("\n\n\n - TECLE [ENTER] - ");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(@"

 .o88b.  .d8b.  db       .o88b. db    db db       .d8b.  d8888b.  .d88b.  d8888b.  .d8b.       d8888b. d888888b d8b   db  .d8b.  d8888b. d888888b  .d8b.  
d8P  Y8 d8' `8b 88      d8P  Y8 88    88 88      d8' `8b 88  `8D .8P  Y8. 88  `8D d8' `8b      88  `8D   `88'   888o  88 d8' `8b 88  `8D   `88'   d8' `8b 
8P      88ooo88 88      8P      88    88 88      88ooo88 88   88 88    88 88oobY' 88ooo88      88oooY'    88    88V8o 88 88ooo88 88oobY'    88    88ooo88 
8b      88~~~88 88      8b      88    88 88      88~~~88 88   88 88    88 88`8b   88~~~88      88~~~b.    88    88 V8o88 88~~~88 88`8b      88    88~~~88 
Y8b  d8 88   88 88booo. Y8b  d8 88b  d88 88booo. 88   88 88  .8D `8b  d8' 88 `88. 88   88      88   8D   .88.   88  V888 88   88 88 `88.   .88.   88   88 
 `Y88P' YP   YP Y88888P  `Y88P' ~Y8888P' Y88888P YP   YP Y8888D'  `Y88P'  88   YD YP   YP      Y8888P' Y888888P VP   V8P YP   YP 88   YD Y888888P YP   YP 
                                                                                                                                                          
");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Infome o valor Desejado: \n");
                        number1 = Console.ReadLine();
                        newNumberBin1 = ConvertHexaforBin(number1);
                        Console.Write($"O valor Desejado em BINARIO: {newNumberBin1}\n");
                        Console.WriteLine("\n\n\n - TECLE [ENTER] - ");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(@"

 .o88b.  .d8b.  db       .o88b. db    db db       .d8b.  d8888b.  .d88b.  d8888b.  .d8b.       d8888b. d888888b d8b   db  .d8b.  d8888b. d888888b  .d8b.  
d8P  Y8 d8' `8b 88      d8P  Y8 88    88 88      d8' `8b 88  `8D .8P  Y8. 88  `8D d8' `8b      88  `8D   `88'   888o  88 d8' `8b 88  `8D   `88'   d8' `8b 
8P      88ooo88 88      8P      88    88 88      88ooo88 88   88 88    88 88oobY' 88ooo88      88oooY'    88    88V8o 88 88ooo88 88oobY'    88    88ooo88 
8b      88~~~88 88      8b      88    88 88      88~~~88 88   88 88    88 88`8b   88~~~88      88~~~b.    88    88 V8o88 88~~~88 88`8b      88    88~~~88 
Y8b  d8 88   88 88booo. Y8b  d8 88b  d88 88booo. 88   88 88  .8D `8b  d8' 88 `88. 88   88      88   8D   .88.   88  V888 88   88 88 `88.   .88.   88   88 
 `Y88P' YP   YP Y88888P  `Y88P' ~Y8888P' Y88888P YP   YP Y8888D'  `Y88P'  88   YD YP   YP      Y8888P' Y888888P VP   V8P YP   YP 88   YD Y888888P YP   YP 
                                                                                                                                                          
");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Infome o valor Desejado: \n");
                        number1 = Console.ReadLine();
                        Console.Write($"O valor Desejado em Hezadecimal: {ConvertBinforHexa(number1.ToString())}  \n");
                        Console.WriteLine("\n\n\n - TECLE [ENTER] - ");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcao desejada INVALIDA! - TECLE [ENTER]!");
                        Console.ReadKey();
                        break;
                }
            } while (opc != 0);
        }
        static void Main(string[] args)
        {
            Programin();
        }
    }
}
