class TicketPrice
{
	public static void main(String args[])
	{
		int age;
		double price=0.00;
		
		System.out.print("How old are you? ");
		age = DummiesIO.getInt();
		
		if (age >= 12 && age < 65)
			price = 9.25;
		if (age < 12 || age > 65)
			price = 5.25;
			
		System.out.print("Please pay $");
		System.out.print(price);
		System.out.println(".  Enjoy the show!");
	}
}