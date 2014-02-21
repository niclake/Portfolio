class KeepingMoreKidsQuiet
{
	public static void main(String args[])
	{
		int gumballs;
		int kids;
		int gumballsPerKid;
		
		System.out.print("How many gumballs? ");
		gumballs = DummiesIO.getInt();
		
		System.out.print("How many kids? ");
		kids = DummiesIO.getInt();
		
		gumballsPerKid = gumballs/kids;
		
		System.out.print("Each kid gets ");
		System.out.print(gumballsPerKid);
		System.out.println(" gumballs.");
	}
}