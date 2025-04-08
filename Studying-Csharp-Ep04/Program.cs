namespace Aula04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string operation = "";
            do
            {
                Console.WriteLine("-------------Calculadora-------------");
                Console.WriteLine("Bem-vindo à calculadora!");
                Console.WriteLine("Você pode realizar operações de adição, subtração, multiplicação e divisão.");
                Console.WriteLine("Para sair, digite 'sair' a qualquer momento.");
                Console.WriteLine("-------------------------------------");

                
                Console.WriteLine();

               
                double number1;
                double number2;

               
                Console.WriteLine("Digite o primeiro número: ");
                string input1 = Console.ReadLine() ?? "";  

              
                while (!double.TryParse(input1, out number1))
                {
                    Console.WriteLine("Entrada inválida. Digite um número válido: ");
                    input1 = Console.ReadLine() ?? ""; 
                }

                
                Console.WriteLine("Digite o segundo número: ");
                string input2 = Console.ReadLine() ?? "";  

                
                while (!double.TryParse(input2, out number2))
                {
                    Console.WriteLine("Entrada inválida. Digite um número válido: ");
                    input2 = Console.ReadLine() ?? "";  
                }

                Console.WriteLine("Qual operação você deseja realizar?");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("Digite o número da operação desejada (ou 'sair' para encerrar): ");
                
              
                Console.WriteLine(); 

                operation = Console.ReadLine() ?? "";  

                if (operation == "sair")
                {
                    break;
                }

                switch (operation)
                {
                    case "1":
                        Console.WriteLine($"Resultado: {number1 + number2}");
                        break;
                    case "2":
                        Console.WriteLine($"Resultado: {number1 - number2}");
                        break;
                    case "3":
                        Console.WriteLine($"Resultado: {number1 * number2}");
                        break;
                    case "4":
                        if (number2 != 0)
                        {
                            Console.WriteLine($"Resultado: {number1 / number2}");
                        }
                        else
                        {
                            Console.WriteLine("Divisão por zero não é permitida.");
                        }
                        break;
                    default:
                        Console.WriteLine("Operação inválida.");
                        break;
                }

                

                Console.WriteLine();

            } while (operation != "sair");

            
            Console.WriteLine(); 
            Console.WriteLine("Você saiu da calculadora.");
        }
    }
}
