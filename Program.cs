using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa una cadena de caracteres: ");
        string cadena = Console.ReadLine();

        cadena = cadena.ToLower().Replace(" ", "");

        char[] arrayInverso = cadena.ToCharArray();
        Array.Reverse(arrayInverso);

        string cadenaInversa = new string(arrayInverso);
        
        if (cadena.Equals(cadenaInversa))
        {
            Console.WriteLine("La cadena es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La cadena no es un palíndromo.");
        }
    }
}
