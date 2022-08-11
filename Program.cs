//hierarchical inheritance
using System;
namespace System
{
    public class father   //base class
    {
        public string fathername()
        {
            return "Vikram";
        }

    }
    public class firstson : father   // first child class
    {
        public string firstname()
        {
            return "Rolex";
        }

    }
    public class secondson : father  //second child class
    {
        public string secondname()
        {
            return "Siva";
        }

    }
    class Jato   //main class
    {
        public static void Main(String[] args)  //from the extecution begins(stores datas here)
        {
            firstson first = new firstson();
            Console.WriteLine("My name is :"+ first.firstname() + Environment.NewLine+ "My father is :" + first.fathername()); //Environment.NewLine helps to get space b/w space/move to next line
            secondson second = new secondson();
            Console.WriteLine();//going to new line (giving space between to print statement
            Console.WriteLine("My name is :" + second.secondname() + Environment.NewLine +"My father is :" + first.fathername());
        }
    }
}