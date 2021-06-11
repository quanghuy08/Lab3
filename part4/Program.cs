using System;

namespace part4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var atoms = new Atom[10];
            var currentIdex = 0;
            Console.WriteLine("Atomic Information");
            Console.WriteLine("==================");
            while (true)
            {
                if (currentIdex >= 10)
                {
                    break;
                }
                var atom = new Atom();
                var result = atom.Accept();

                if (result)
                {
                    atoms[currentIdex] = atom;
                    currentIdex++;
                }
                else if (atom.Number == 0)
                {
                    break;
                }
            }

            Console.WriteLine("No Sym Name Weight");
            Console.WriteLine("----------------------");
            for (int i = 0; i < currentIdex; i++)
            {
                atoms[i].Display();
            }
        }
    }
}