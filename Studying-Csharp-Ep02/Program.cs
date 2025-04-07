namespace StudyingCsharpEp02;
public class Program
{
    public static void Main(string[] args)
    {
        // This is a comment

        /*
        This is a multi-line comment
        It can span multiple lines
        */

        string myName = "Alan de Souza"; // String variable
        int myAge = 21; // Integer variable
        double myHeight = 1.73; // Double variable
        bool student = true; // Boolean variable
        char myInitial = 'A'; // Character variable

        Console.WriteLine("Meu nome é " + myName + ", tenho " + myAge + " anos, minha altura é " + myHeight + "m, sou estudante: " + student + ", minha inicial é " + myInitial);
        // String interpolation (C# 6.0 and later)
    }
}