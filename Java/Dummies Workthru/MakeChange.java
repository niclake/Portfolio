class MakeChange
{
	public static void main(String args[])
	{
		int quarters, dimes, nickels, pennies;
		int whatsLeft, total;
		
		System.out.print("How many cents do you have? ");
		total = DummiesIO.getInt();
		
		quarters = total/25;
		whatsLeft = total%25;
		
		dimes = whatsLeft/10;
		whatsLeft = whatsLeft%10;
		
		nickels = whatsLeft/5;
		whatsLeft = whatsLeft%5;
		
		pennies = whatsLeft;
		
		System.out.println();
		System.out.println("From " + total + " cents you get");
		
		System.out.println(quarters + " quarters");
		System.out.println(dimes + " dimes");
		System.out.println(nickels + " nickels");
		System.out.println(pennies + " pennies");
	}
}