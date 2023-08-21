//Fibonacci series
public void FibonacciSeries(int number)   
{   
   int f_0 = 0;   
   int f_1 = 1;   
   int sum;   
   Console.Write("{0} {1} ", f_0, f_1);   
   for (int i = 2; i < number; i++)   
   {   
      sum = f_0 + f_1;   
      f_0 = f_1;   
      f_1 = sum;   
      int value = f_0 + f_1;   
      Console.Write("{0} ", value);   
   }   
}   
