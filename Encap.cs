using System;

namespace RectangleApplication
{
    class Rectangle    
    {
        //member variables
        public double length; //if we put private here then we can only access the data member/ member function inside that class only
        public double width;

        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle

    class ExecuteRectangle //main class
    {
      static void Main(string[] args)  //main method it fetch the data from the two derived class as wwell from the base class
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            //Console.ReadLine(); //if we entered this code it will select as enter to the next line
        }
    }
}
