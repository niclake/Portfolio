class ReadAndWrite
{
	public static void main(String args[])
	{
		double unitPrice, quantity, total;
		
		unitPrice = DummiesIO.getDouble("rawData.txt");
		quantity = DummiesIO.getInt("rawData.txt");
		
		total = unitPrice * quantity;
		
		DummiesIO.println("cookedData.txt", total);
	}
}