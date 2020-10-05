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

        }
    }

    public class numeColegi
    {   
        public string[] numeLista = {"Andrei","Pavel","Petru,Rares"};

    }
    //comentariu
}
