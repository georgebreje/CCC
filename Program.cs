using System;

namespace CCC
{
    class Program
    {
        static void Main(string[] args)
        {
            numeColegi nume = new numeColegi();
            foreach(string i in nume.numeLista)
                Console.WriteLine(i);
            Console.WriteLine("\nImi pare bine sa va cunosc pe toti!");

        }
    }

    public class numeColegi
    {   
        public string[] numeLista = {"Andrei","Pavel","Petru", "Andrei Kovacs"};

    }
    //comentariu
}
// vezi ca ai pus doar Program.cs, trebuie sa pui toate fisierele, cel mai important fiind cel sln
// -important- ca sa faci pull request trebuie sa dai la fork mai intai (si sa lucrezi pe versiunea forked)