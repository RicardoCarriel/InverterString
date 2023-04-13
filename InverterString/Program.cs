using System;

class Program
{
    static void Main()
    {
        string str = "exemplo"; // Definindo a string a ser invertida

        char[] chars = str.ToCharArray(); // Convertendo a string em um array de caracteres

        for (int i = 0, j = str.Length - 1; i < j; i++, j--)
        {
            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
        }

        string invertedStr = new string(chars); // Convertendo o array de caracteres de volta para uma string
        Console.WriteLine(invertedStr); // Imprimindo a string invertida
    }
}