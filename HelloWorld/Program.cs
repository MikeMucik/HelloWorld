using System;

namespace HelloWorld
{
    //PascalCase używamy do: klas, nazw plików, nazwy metod, names space
    public class ProgramThatMakesDiffrentThings
    {
        public static void Main(string[] args)
            {
                //camelCase używamy do: lokalnych zmiennych, elementów programu które są prywatne
                string firstAndLastName  = "Michał";

                //UPPER_CASE
                const double PI_NUMBER = 3.14;
                Console.WriteLine("Hello, World:");
                Console.WriteLine("Nazywam się Michał Mucik");
                if (PI_NUMBER > 2) 
                {
                }
            }
        // {} zasięg namespace, zasięg klasy, zasięg metod, przy zapisie instrukcji warunkowych lub pętli, stosujemy je zawsze w oddzielnej linii
        // jedna linia gdy zaczynamy nowa metodę lub instrukcję
        
        private string WritePiNumber(double pi) // pisanie za każdym razem modyfikatora dostępu nawet jeżeli nie jest wymagany, zazwyczaj jest private lub interna
        {
            return ("3.14");
        }
    }
    public interface IProgram
    {

    }
}
// w nowym pliku powinna znajdować się tylko jedna klasa
// Tylko interface używamy literki I do oznaczenia specyficznej danej
    