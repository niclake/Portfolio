class AnswerYesOrNo
{
	public static void main(String args[])
	{
		int randomNumber;
		
		System.out.print("Type your question, my child:  ");
		DummiesIO.getLine();
		
		randomNumber = DummiesRandom.getInt();
		if (randomNumber > 5)
			System.out.println("Yes.  Isn't it obvious?");
		else
			System.out.println("No, and don't ask again.");
	}
}