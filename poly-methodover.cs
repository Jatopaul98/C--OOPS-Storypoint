using System;
class methodoverloading
{

	// adding two integer values.
	public void Add(int a, int b)
	{
		Console.WriteLine( a + b);
	}

	// adding three integer values.
	public void Add(int a, int b, int c)
	{
		Console.WriteLine( a + b + c);

	}

	// Main Method
	public static void Main(String[] args)
	{

		// Creating Object
		methodoverloading ob = new methodoverloading();
		ob.Add(1, 2);
		ob.Add(1, 2, 3);
	}
}




// C# program to demonstrate the function
// overloading by changing the Number
//// of parameters
//using System;
//class GFG
//{

//	// adding two integer values.
//	public int Add(int a, int b)
//	{
//		int sum = a + b;
//		return sum;        //this is returning the additon method to the line 60
//	}

//	// adding three integer values.
//	public int Add(int a, int b, int c)
//	{
//		int sum = a + b + c;
//		return sum;   //this is returning the additon method to the line 65
//	}

//	// Main Method
//	public static void Main(String[] args)
//	{

//		// Creating Object
//		GFG ob = new GFG();

//		int sum1 = ob.Add(1, 2);    //In this we are creating a new variable to store the data from the line 43 
//		
//		Console.WriteLine("sum of the two "
//						+ "integer value : " + sum1);

//		int sum2 = ob.Add(1, 2, 3);   // //In this we are creating a new variable to store the data from the line 50
//		Console.WriteLine("sum of the three "
//						+ "integer value : " + sum2);
//	}
//}
