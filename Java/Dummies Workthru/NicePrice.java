class NicePrice
{
	public static void main(String args[])
	{
		int age;
		double price=0.00;
		char reply;
		boolean isKid,  isSenior, hasCoupon, hasNoCoupon;
		
		System.out.print("How old are you? ");
		age = DummiesIO.getInt();
		
		System.out.print("Do you have a coupon? (Y/N) ");
		reply = DummiesIO.getChar();
		reply = Character.toUpperCase(reply);
		
		isKid = age<12;
		isSenior = age>65;
		hasCoupon = reply=='Y';
		hasNoCoupon = reply=='N';
		
		if (!isKid && !isSenior)
			price = 9.25;
		if (isKid || isSenior)
			price = 5.25;
			
		if ((hasCoupon) && (!isKid && !isSenior))
			price -= 2.00;
		if (!hasCoupon && !hasNoCoupon)
			System.out.println("Huh?");
			
		System.out.print("Please pay $");
		System.out.print(price);
		System.out.println(".  Enjoy the show!");
	}
}