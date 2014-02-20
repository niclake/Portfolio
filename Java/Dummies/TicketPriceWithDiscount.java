class TicketPriceWithDiscount
{
	public static void main(String args[])
	{
		int age;
		double price=0.00;
		char reply;
		
		System.out.print("How old are you? ");
		age = DummiesIO.getInt();
		
		System.out.print("Do you have a coupon? (Y/N) ");
		reply = DummiesIO.getChar();
		reply = Character.toUpperCase(reply);
		
		if (age >= 12 && age < 65)
			price = 9.25;
		if (age < 12 || age > 65)
			price = 5.25;
			
		if (reply=='Y')
			price -= 2.00;
		if (reply !='Y' && reply !='N')
			System.out.println("Huh?");
			
		System.out.print("Please pay $");
		System.out.print(price);
		System.out.println(".  Enjoy the show!");
	}
}