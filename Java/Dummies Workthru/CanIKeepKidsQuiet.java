class CanIKeepKidsQuiet
{
	public static void main(String args[])
	{
		int gumballs;
		int kids;
		int gumballsPerKid;
		boolean eachKidGetsTen;
		
		gumballs = 140;
		kids = 15;
		gumballsPerKid = gumballs/kids;
		
		System.out.println("We have " + gumballs + " gumballs.");
		System.out.println("We have " + kids + " kids.");
		System.out.print("True or false? ");
		System.out.println("Each kid gets 10 gumballs.");
		eachKidGetsTen = gumballsPerKid>=10;
		System.out.println(eachKidGetsTen);
	}
}