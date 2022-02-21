using System;
using System.Collections;
public class EjemploQueue
{

    public static void Main()
    {

        Queue miQ = new Queue();
        miQ.Enqueue("Cuatro");
        miQ.Enqueue("Ocho");
        miQ.Enqueue("Doce");
        miQ.Enqueue("Dieciseis");

        Console.WriteLine("\nElementos guardados en la cola de nombre miQ");

        Console.WriteLine(" ");

        Console.WriteLine("\nConteo de la cantidad de elementos en la cola {0}");
        Console.WriteLine(miQ.Count);
        Console.Write("\nValores dentro de la cola:");
        PrintValues(miQ);


        Console.WriteLine(" ");

        Console.WriteLine("Removiendo un elemento (Dequeue){0}");
        Console.WriteLine("{0}", miQ.Dequeue());

        Console.Write("\nMostrando valores de Queue:");
        PrintValues(miQ);


        Console.WriteLine("");


        Console.WriteLine("Removiendo otro  (Dequeue)");
        Console.WriteLine(" {0}", miQ.Dequeue());


        Console.WriteLine("");

        Console.Write("\nMostrando valores de la Queue:");
        PrintValues(miQ);


        Console.WriteLine("");

        Console.WriteLine("Mostrando primer elemento sin removerlos (Peek)");

        Console.WriteLine("{0}", miQ.Peek());

        Console.WriteLine("");

        Console.Write("\nMostrando los valores de la Queue:");
        PrintValues(miQ);

        Console.WriteLine("");


        Console.WriteLine("\nCount/ Conteo de los valores: {0}");
        Console.WriteLine(miQ.Count);


        Console.WriteLine("");

        Console.Write("\nValores en la cola:");
        PrintValues(miQ);
    }

    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
            Console.Write("\t {0}", obj);
        Console.WriteLine();
    }


}
