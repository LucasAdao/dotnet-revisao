using Microsoft.VisualBasic;

namespace basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Console.WriteLine("Digite seu nome:");
            //string nome = Console.ReadLine();

            //Console.WriteLine($"Você é um bom dev e vai se tornar ainda melhor {nome}!!");

            //Console.WriteLine("Qual sua idade?");
            //short idade = short.Parse(Console.ReadLine());

            //if (idade > 30)
            //{
            //    Console.WriteLine($"Você é um cara experiente em? Posso apostar que não é seu primeiro contato com tecnologia!");
            //}
            //else if (idade > 20)
            //{
            //    Console.WriteLine($"Você tem {idade} anos? Legal, imagino que já sabe que a jornada será longa mas tá aqui uma ótima oportunidade para ser um bom desenvolvedor backend");
            //}
            //else
            //{
            //    Console.WriteLine($"Você é bem jovem com {idade} anos, o futuro é todo seu!!");
            //}

            //DateTime dataAtual = DateTime.Now;

            //Console.WriteLine($"Hoje é dia {dataAtual.Day}/{dataAtual.Month}/{dataAtual.Year} e você está iniciando sua jornada no .NET! Bons estudos {nome}!");

            //Console.WriteLine("Diga 6 frutas que você gosta muito:");
            //List<string> frutas = new List<string>();

            //for (int i = 0; i < 6; i++) 
            //{
            //    Console.WriteLine($"Fruta {i + 1}:");
            //    string fruta = Console.ReadLine();
            //    frutas.Add(fruta);
            //}

            //Console.WriteLine("Você gosta muito das seguintes frutas:");

            //foreach (string fruta in frutas)
            //{
            //    Console.WriteLine(fruta);
            //}

            //Console.WriteLine("Quanto você tem de altura?");
            //double altura = double.Parse(Console.ReadLine());

            //Console.WriteLine($"Você tem {altura} metros de altura, legal!");

            //Console.WriteLine("Hora atual:");
            //DateTime horaAtual = DateTime.Now;
            //Console.WriteLine(horaAtual.ToString("HH:mm:ss"));

            //Console.WriteLine("Esse é o valor para armazenar dados financeiros em C#");
            //decimal valorMonetario = 25.99m;
            //Console.WriteLine($"{valorMonetario} R$");

            Console.WriteLine("Essa é uma função lambda no C#");
            Func<int, int, int, int> soma = (a, b, c) => a + b + c;
            int resultado = soma(5, 10, 7);
            Console.WriteLine($"O resultado da soma é: {resultado}");

            Func<int, int, int> multiplicacao = (x, y) => x * y;
            int resultadoMultiplicacao = multiplicacao(4, 6);
            Console.WriteLine($"O resultado da multiplicação é: {resultadoMultiplicacao}");


        }

        public class Pessoa
        {

        }
    }
}
