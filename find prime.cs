//primeornot
public string PrimeOrNot(int num)   
{   
   int i = 0;   
   for (i = 3; i < num; i++)   
   {   
      if (num % i == 0)   
      {   
         Console.WriteLine("{0} is not a prime number", num);   
         break;   
      }   
   }   
   if (i == num)   
   {   
      Console.Writeline("{0} is a prime Number", num);   
   }   
   }