
using System;
using System.Collections.Generic;

class Ejemplo
{
   

    public static void Main()
    {
        Stack<string> personas = new Stack<string>();
        personas.Push("Jordy Enrique Rivas Castro");
        personas.Push("Wendy Lisseth Chacon Pineda");
        personas.Push("Manuel Humberto Lopez Castro");
        personas.Push("Ariel Edilberto Alas Rubio");
        personas.Push("Cristian Alexander Lopez Menjivar");
        personas.Push("Yacquelyn Alexandra Rivera Alfaro");

        foreach (string person in personas)
        {
            Console.WriteLine(person);
        }

        Console.WriteLine("\nPeek/El primer nombre a desapilar será : {0}",
            personas.Peek());
        Console.WriteLine("Popping/ Eliminando '{0}'", personas.Pop());
        Console.WriteLine("\nPeek/viendo en el siguiente item a desapilar: {0}",
            personas.Peek());
        Console.WriteLine("Popping/ Eliminando '{0}'", personas.Pop());

        Stack<string> Personas2 = new Stack<string>(personas.ToArray());

        Console.WriteLine("\nContenido de la primer copia:");
        foreach (string person in Personas2)
        {
            Console.WriteLine(person);
        }


        string[] array2 = new string[personas.Count * 2];
        personas.CopyTo(array2, personas.Count);

        Stack<string> Personas3 = new Stack<string>(array2);

        Console.WriteLine("\nContenido de la segunda copia, con duplicados y nulos:");
        foreach (string person in Personas3)
        {
            Console.WriteLine(person);
        }

        Console.WriteLine("\nVerificando si la pila # 2 contiene a la persona Yacquelyn Alexandra Rivera Alfaro ");
        Console.WriteLine("\nLa pila #2 contiene \"Yacquelyn Alexandra Rivera Alfaro\" = {0}",
        Personas2.Contains("Yacquelyn Alexandra Rivera Alfaro"));

        Console.WriteLine("\nLimpiando la pila #2");

        Console.WriteLine("\nPersonas2.Clear()");
        Personas2.Clear();
        Console.WriteLine("\nPersonas2.Count = {0}", Personas2.Count);



    }
}

