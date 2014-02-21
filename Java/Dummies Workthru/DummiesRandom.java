import java.util.Random;

public class DummiesRandom extends Random
{
   private static DummiesRandom rand = new DummiesRandom();

   public static int getInt()
   {
      return myNextInt(10)+1;
   }


   public static int getInt(int n)
   {
      return myNextInt(n)+1;
   }


   //Borrowed from the JDK 1.4 docs:
   private static int myNextInt(int n)
   {
      if (n<=0)
         throw new IllegalArgumentException("n must be positive");

      if ((n & -n) == n)  // i.e., n is a power of 2
         return (int)((n * (long)rand.next(31)) >> 31);

      int bits, val;
      do
      {
         bits = rand.next(31);
         val = bits % n;
      }
      while(bits - val + (n-1) < 0);
      return val;
   }

}