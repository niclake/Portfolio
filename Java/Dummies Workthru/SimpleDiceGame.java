class SimpleDiceGame
{
	public static void main(String args[])
	{
		int die1=0, die2=0;
		
		while(die1+die2 != 7 && die1+die2 != 11)
		{
			die1 = DummiesRandom.getInt(6);
			die2 = DummiesRandom.getInt(6);
			
			System.out.println(die1 + " " + die2);
		}
		
		System.out.print("Rolled ");
		System.out.println(die1 + die2);
	}
}