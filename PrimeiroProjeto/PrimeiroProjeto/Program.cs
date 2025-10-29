namespace PrimeiroProjeto;

enum Direcao 
{
    Norte,
    Sul,
    Leste,
    Oeste
}
public class Program
{
    static void Main(string[] args)
    {
        // camelCase para parametros em func
        // PascalCase para nome de metds e classes
        // const string nome, constante no C#
        Console.WriteLine("Escreva seu nome:");
        string Nome = Console.ReadLine();
        
        if (string.IsNullOrEmpty(Nome.Trim()))
        {
            Console.WriteLine("o nome está vazio");
        }
        else 
        {
            Console.WriteLine("Boa tarde " + Nome);
        }
    }
}

