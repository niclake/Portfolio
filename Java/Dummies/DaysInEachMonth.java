class DaysInEachMonth
{
	public static void main(String args[])
	{
		int month, numberOfDays=0;
		boolean isLeapYear;
		
		System.out.print("Which month? (enter #): ");
		month = DummiesIO.getInt();
		
		switch (month)
		{
			case 1:
			case 3:
			case 5:
			case 7:
			case 8:
			case 10:
			case 12:
				numberOfDays=31;
				break;
			case 4:
			case 6:
			case 9:
			case 11:
				numberOfDays=30;
				break;
			case 2:
				System.out.print("Leap year, T/F? ");
				isLeapYear = DummiesIO.getBoolean();
				numberOfDays = isLeapYear ? 29 : 28;
				
		}
		
		System.out.println(numberOfDays+" days");
	}
}