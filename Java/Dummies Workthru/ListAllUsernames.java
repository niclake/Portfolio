class ListAllUsernames
{
	public static void main(String args[])
	{
		char symbol;
		
		while (!DummiesIO.endOfFile("email.txt"))
		{
			symbol = DummiesIO.getChar("email.txt");
			
			while (symbol != '@')
			{
				DummiesIO.print("usernames.txt", symbol);
				symbol = DummiesIO.getChar("email.txt");
			}
			
			DummiesIO.getLine("email.txt");
			DummiesIO.println("usernames.txt");
		}
	}
}