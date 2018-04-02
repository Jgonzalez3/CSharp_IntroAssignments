using System;

namespace Human
{
    class Program
    {   
        static void Main(string[] args){
            Human Javier = new Human("Javier");
            Human Beto = new Human("Beto");
            Console.WriteLine(Javier);
            // Prints the fields and values of object below:
            foreach (var prop in Javier.GetType().GetFields()){
                Console.WriteLine(prop.Name + ": " + prop.GetValue(Javier));
            }
            Beto.Attack(Javier);
            foreach (var prop in Beto.GetType().GetFields()){
                Console.WriteLine(prop.Name + ": " + prop.GetValue(Beto));
            }
        }
    }
}
