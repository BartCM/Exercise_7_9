using System;
public class Average
{
	public static void Main()
	{
		double a=0, b, c=0, d;
		string s;
		Console.Write("Insert a mark: ");
		
		// we read the mark as string to check the word "end"
		s=Console.ReadLine();
		 
		  // if the mark isn't an end then we pass it to double to work with it
		while(s!="end")
		{
			b=Convert.ToDouble(s);
			c++;   //counter of numbers
			a+=b;  // sum of all the notes
			Console.Write("Insert a mark: ");
			s=Console.ReadLine();
		}
		
		 //calculate the average
		if(c!=0)
		{
			d=a/c; 
			Console.WriteLine("The average is {0}.",d);
		}
	}
}
