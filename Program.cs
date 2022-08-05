// See https://aka.ms/new-console-template for more information
using System;
namespace System
{
    public class father
    {
        public string fathername()
        {
            return "Vikram";
        }

    }
    public class firstson : father
    {
        public string firstname()
        {
            return "Rolex";
        }

    }
    public class secondson : father
    {
        public string secondname()
        {
            return "Siva";
        }

    }
    class Jato
    {
        public static void Main(String[] args)
        {
            firstson first = new firstson();
            Console.WriteLine("My name is :"+ first.firstname() + Environment.NewLine+ "My father is :" + first.fathername()); //Environment.NewLine helps to get space b/w space/move to next line
            secondson second = new secondson();
            Console.WriteLine();//going to new line (giving space between to print statement
            Console.WriteLine("My name is :" + second.secondname() + Environment.NewLine +"My father is :" + first.fathername());
        }
    }
}