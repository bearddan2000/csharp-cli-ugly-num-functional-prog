// C# program to find nth ugly number
using System;

class Ugly {


      /*This function divides a by greatest divisible power of b*/
      static  int maxDivide( int a,  int b)
      {
          if(a%b != 0) return a;
          return maxDivide(a/b, b);
      }

      /* Function to check if a number is ugly or not */
      static  int isUgly( int no)
      {
           int a = maxDivide(no, 2);
           int b = maxDivide(a, 3);
           int c = maxDivide(b, 5);

          return (c == 1)? 1 : 0;
      }

      /* Function to get the nth ugly number*/
      static  int getNthUglyNo( int n,  int i,  int count /* ugly number count */)
      {
          /*Check for all integers untill ugly count becomes n*/
          if (n < count) return i-1;
          if (isUgly(i) == 1) return getNthUglyNo(n, i+1, count+1);
          else return getNthUglyNo(n, i+1, count);
      }

  	/* Driver program to test above
  	functions */
  	public static void Main()
  	{
  		 int input = 10;
  		Console.WriteLine("[INPUT] "+ input);
  		 int output = getNthUglyNo(input,1,1);
  		Console.WriteLine("[OUTPUT] "+ output);
  	}
}
