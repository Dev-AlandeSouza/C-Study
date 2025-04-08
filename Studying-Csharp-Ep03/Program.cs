namespace Aula03;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("---------Cadastro de Usuários---------");
        Console.WriteLine("Digite o nome do usuário:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o e-mail do usuário:");
        string email = Console.ReadLine();
        Console.WriteLine("Digite a senha do usuário:");
        string senha = Console.ReadLine();
        Console.WriteLine("Digite sua idade:");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Seu usuário é {nome}, seu e-mail é {email}, sua senha é {senha} e sua idade é {idade} anos.");

        Console.WriteLine("Para confirmar o cadastro digite: 'confirmar'");
        string confirmar = Console.ReadLine();
        if (confirmar == "confirmar" || confirmar == "Confirmar" || confirmar == "CONFIRMAR")
        {
            Console.WriteLine("Cadastro confirmado!");
        }
        else if (confirmar == "cancelar" || confirmar == "Cancelar" || confirmar == "CANCELAR")
        {
            Console.WriteLine("Cadastro cancelado!");
        }
        else if (confirmar == "sair" || confirmar == "Sair" || confirmar == "SAIR")
        {
            Console.WriteLine("Saindo do cadastro...");
        }
        else if (confirmar == "sim" || confirmar == "Sim" || confirmar == "SIM")
        {
            Console.WriteLine("Cadastro confirmado!");
        }
        else if (confirmar == "não" || confirmar == "Não" || confirmar == "NÃO")
        {
            Console.WriteLine("Cadastro cancelado!");
        }
        else
        {
            Console.WriteLine("Opção inválida!");
        }

    }

}