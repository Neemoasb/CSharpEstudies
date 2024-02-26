using System;
using System.Text;

namespace Aula1App
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ex 1 biblioteca math

            // ============================ UTILIZAÇÃO DA BIBLIOTECA MATH ============================ 
            double v1, v2, result;
            v1 = 10;
            v2 = 3;
            var teste = Math.Sqrt(2);

            Console.WriteLine($"Resultado da raiz de {10} é igual a: {Math.Sqrt(10)}");

            Console.WriteLine($"{v1} elevado a {v2} é igual a: {Math.Pow(v1,v2)}");

            Console.WriteLine($"{v2} elevado a {v1} é igual a: {Math.Pow(v2, v1)}");

            #endregion


            #region ESPAÇO

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            #endregion


            #region UTILIZACAO DE STRING

            // ============================= UTILIZAÇÃO DE STRINGS ============================= 

            string nome, sobrenome;

            nome = "Neemias";
            sobrenome = "Borges";

            StringBuilder completo = new StringBuilder();

            completo.AppendLine($"{nome} {sobrenome}");
            Console.WriteLine($"O Nome {completo} possui {completo.ToString().Length} Caracteres");
            Console.WriteLine($"O Primeiro nome: {nome} possui {nome.Length} Caracteres");
            Console.WriteLine($"O Sobrenome: {sobrenome} possui {sobrenome.Length} Caracteres");
            Console.WriteLine($"O Sobrenome: {sobrenome} Em maisculo: {sobrenome.ToUpper()}");
            Console.WriteLine($"O Sobrenome: {sobrenome} Em minusculo: {sobrenome.ToLower()}");

            if (!sobrenome.Equals(nome))
                Console.WriteLine($"O Sobrenome: {sobrenome} não é igual ao {nome}");

            if (sobrenome.Equals(sobrenome))
                Console.WriteLine($"O Sobrenome: {sobrenome} é igual ao {sobrenome}");

            #endregion

        }
    }
}
