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
