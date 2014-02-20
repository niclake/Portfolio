/*
 * @(#)DummiesIO.java   08/04/2003
 *
 * Copyright 2003 John Wiley & Sons, Inc. All Rights Reserved.
 * <p>This code complements the material in the book "Beginning 
 * Programming with Java For Dummies." For another version of 
 * DummiesIO.java (a version that complements the book "Java 2 
 * For Dummies," visit http://www.BurdBrain.com/.
 *
 * This code is preliminary.
 * Visit http://www.BurdBrain.com/ again for updates.
 */

import java.io.*;
import java.util.StringTokenizer;
import java.util.Hashtable;

/**
 * This class implments simple text-based input and output
 * for the keyboard and for disk files. For examples of the use of
 * methods in this class, see <i>Beginning Programming with For Dummies</i> by Barry
 * Burd, &copy;2003 John Wiley & Sons, Inc.
 * <p>Most of the methods in this class are
 * <code>get<i>Type</i></code> methods, <code>print</code> methods, or
 * <code>print<b>ln</b></code> methods. For instance, 
 * to read an <code>int</code> value from the keyboard, call 
 * <pre>   <i>intVariable</i> = DummiesIO.getInt();</pre>
 * To read an <code>int</code> value from a file
 * named <code>myFile.txt</code>, call 
 * <pre>   <i>intVariable</i> = DummiesIO.getInt("myFile.txt");</pre>
 * <p>A disk file's name can be relative to the directory containing the code
 * (as in <code>"myFile.txt"</code>). Alternatively, the file name can
 * be absolute, as in 
 * <pre>   <i>intVariable</i> = DummiesIO.getInt("c:\\JavaPrograms\\myFiletxt");</pre>
 * For absolute file names in Windows, be sure to use two backslashes in 
 * place of each single backslash (as file separators).
 * <p>(Note: Supplying file name strings to input/output methods is unique
 * to this DummiesIO program. With real, industrial-strength IO programs, you generally
 * don't use file-name strings to refer to files.)
 * <p>To read several values, one after another, separate the values with any
 * number of blank spaces and/or any number of newlines. For instance, to
 * read the number <code>23</code> followed by the word <code>Hello</code>
 * from the keyboard, use the following Java code:
 * <pre>   <i>intVariable</i> = DummiesIO.getInt();
 *   <i>stringVariable</i> = DummiesIO.getString();</pre>
 * You can enter the input on the keyboard in any of the following ways:
 * <pre>23 Hello</pre>
 * <hr>
 * <pre>23     Hello</pre>
 * <hr>
 * <pre>     23
 *
 *
 *    Hello</pre>
 * <hr>
 * <pre>23
 * Hello</pre>
 * <hr>
 * To write the value <code>77</code> to a file named <code>myOutput.txt</code>,
 * call
 * <pre>   DummiesIO.print("myOutput.txt", 77);</pre>
 * To write the value <code>77</code> to the same file, and to go to the next line
 * after writing that value, call
 * <pre>   DummiesIO.print<b>ln</b>("myOutput.txt", 77);</pre>
 * The latter call to <code>println</code> is equivalent to the following two calls:
 * <pre>   DummiesIO.print("myOutput.txt", 77);
 *   DummiesIO.println("myOutput.txt");</pre>
 * @author    Barry Burd
 */

public class DummiesIO
{
   private static Hashtable hashtable = new Hashtable();

   private static BufferedReader keyboard =
      new BufferedReader(new InputStreamReader(System.in));

   private static boolean isForgiving=false;

   static
   {
      hashtable.put("keyboard", new InFileState(keyboard));
   }
   
   private DummiesIO()
   {}

   /**
    * With <code>forgiving</code> set to <code>true</code>,
    * DummiesIO is generally more willing to continue running
    * when it encounters an IO error. For example, if you call getInt(), the user types
    * a letter rather than an integer, and <code>forgiving</code> is true, then the call to getInt()
    * returns the value 0, and the program continues to run. By default, <code>forgiving</code> is <code>false</code>.
    * @param  value Either <code>true</code> for forgiving, or <code>false</code> for unforgiving
    */
   public static void setForgiving (boolean value)
   {
      isForgiving=value;
   }


   private static InFileState openOrUseExisting (String fileName)
   {
      InFileState inFileState=null;

      try
      {
         inFileState = (InFileState)hashtable.get(fileName);
      }
      catch (ClassCastException e)
      {
         System.out.println("Warning: You are reading from a file to which you've already");
         System.out.println("written data (file: " + fileName + ").");
         System.out.println("Subsequent write operations to this file will delete any");
         System.out.println("data that you've already written.");
      }

      if (inFileState == null)
      {
         getFileForReading(fileName);
         inFileState = (InFileState)hashtable.get(fileName);
      }
      return inFileState;
   }


   private static void fillTokenBuffer (InFileState inFileState)
   {
      String tempLineBuffer = null;

      while (inFileState.tokenizer==null || !inFileState.tokenizer.hasMoreTokens())
      {
         try
         {
            tempLineBuffer = inFileState.reader.readLine();
         }
         catch (IOException e)
         {
            System.out.println("Cannot read the next value.");
            e.printStackTrace();
         }

         if (tempLineBuffer != null)
         {
            inFileState.tokenizer =
               new StringTokenizer(tempLineBuffer, " ", true);
         }
         else
         {
            inFileState.isAtEOF = true;
            break;
         }
      }

      try
      {
         inFileState.tokenBuffer = inFileState.tokenizer.nextToken();
      }
      catch (Exception e)
      {
         inFileState.tokenBuffer = "";
      }
   }


   /**
    * Tests to see if you've reached the end of a particular disk file.
    * If so, the method returns <code>true</code>. Otherwise the method
    * returns <code>false</code>. For instance, to find out if you've read
    * up to the very end of <code>myFile.txt</code> check
    * <pre>   if (DummiesIO.endOfFile("myFile.txt")) ... <i>Etc.</i></pre>
    * @param  fileName The name of a file
    * @return  <code>true</code> if you've reached the end of the file, and <code>false</code> otherwise
    */
   public static boolean endOfFile(String fileName)
   {
      InFileState inFileState = openOrUseExisting(fileName);
      while ((inFileState.tokenBuffer == null || inFileState.tokenBuffer.equals(""))
             && !inFileState.isAtEOF)
         fillTokenBuffer(inFileState);

      return inFileState.isAtEOF;
   }


   private static String getNonblankToken(String fileName)
   {
      InFileState inFileState = openOrUseExisting(fileName);

      String tempTokenBuffer = null;

      while (inFileState.tokenBuffer == null || inFileState.tokenBuffer.equals(" ")
            && !inFileState.isAtEOF)
         fillTokenBuffer(inFileState);

      try
      {
         if (inFileState.isAtEOF)
           throw new EOFException();
      }
      catch (EOFException e)
      {
         System.out.println("No more data in the file.");
         e.printStackTrace();
         System.exit(1);
      }

      tempTokenBuffer = inFileState.tokenBuffer;
      inFileState.tokenBuffer = null;
      return tempTokenBuffer;
   }


   private static char getCharFromToken (String fileName)
   {
      InFileState inFileState = openOrUseExisting(fileName);
      char tempCharBuffer;

      while ((inFileState.tokenBuffer==null || inFileState.tokenBuffer.length()==0)
            && !inFileState.isAtEOF)
      {
         fillTokenBuffer(inFileState);
      }

      try
      {
         if (inFileState.isAtEOF)
           throw new EOFException();
      }
      catch (EOFException e)
      {
         System.out.println("No more data in the file.");
         e.printStackTrace();
         System.exit(1);
      }

      tempCharBuffer = inFileState.tokenBuffer.charAt(0);
      if (inFileState.tokenBuffer.length()>=2)
      {
         inFileState.tokenBuffer = inFileState.tokenBuffer.substring(1);
      }
      else
      {
         inFileState.tokenBuffer = null;
      }
      return tempCharBuffer;
   }



   private static String getRestOfLine(String fileName)
   {
      InFileState inFileState = openOrUseExisting(fileName);
      StringBuffer tempLine = new StringBuffer();

      while (inFileState.tokenBuffer==null || inFileState.tokenBuffer.length()==0
            && !inFileState.isAtEOF)
         fillTokenBuffer(inFileState);

      try
      {
         if (inFileState.isAtEOF)
           throw new EOFException();
      }
      catch (EOFException e)
      {
         System.out.println("No more data in the file.");
         e.printStackTrace();
         System.exit(1);
      }

      tempLine.append(inFileState.tokenBuffer);
      inFileState.tokenBuffer = null;

      while (inFileState.tokenizer.hasMoreTokens())
         tempLine.append(inFileState.tokenizer.nextToken());
      inFileState.tokenizer = null;

      return new String(tempLine);
   }


   private static void getFileForReading(String string)
   {
      FileInputStream f=null;
      try
      {
         f = new FileInputStream (string);
      }
      catch (FileNotFoundException e)
      {
         e.printStackTrace();
         System.exit(1);
      }
      InputStreamReader inp = new InputStreamReader(f);
      BufferedReader b = new BufferedReader(inp);

      hashtable.put(string, new InFileState(b));
   }

  /**
   * Reads an <code>int</code> value from the keyboard. At the keyboard,
   * the user types a sequence of digits, optionally preceded by a minus
   * sign.
   * @return  The <code>int</code> value typed on the keyboard by the user
   * @see     #getInt(java.lang.String)
   */    
   static public int getInt()
   {
      return getInt("keyboard");
   }

  /**
   * Reads an <code>int</code> value from a disk file
   * @param  fileName The name of a file
   * @return  The <code>int</code> value found in the file
   * @see #getInt()
   */  
   static public int getInt(String fileName)
   {
      String token="";

      try
      {
         return Integer.parseInt(token=getNonblankToken(fileName));
      }
      catch (Exception e)
      {
         System.out.println("Cannot read an int value.");
         System.out.print("Expected an int value;");
         System.out.println(" Received >>" + token + "<< instead.");
         e.printStackTrace();
         if (!isForgiving)
            System.exit(1);
         return 0;
      }
   }


  /**
   * Reads a <code>double</code> value from the keyboard. At the keyboard,
   * the user types a double literal. Examples of double literals include
   * <pre>   1e1   2.   .3   0.0   3.14   1e-9d</pre>
   * @return  The <code>double</code> value typed on the keyboard by the user
   * @see     #getDouble(java.lang.String)
   */    
   static public double getDouble()
   {
      return getDouble("keyboard");
   }


  /**
   * Reads a <code>double</code> value from a disk file
   * @param  fileName The name of a file
   * @return  The <code>double</code> value found in the file
   * @see #getDouble()
   */  
   static public double getDouble(String fileName)
   {
      String token="";

      try
      {
         return Double.parseDouble(token=getNonblankToken(fileName));
      }
      catch (Exception e)
      {
         System.out.println("Cannot read a double value.");
         System.out.print("Expected a double value;");
         System.out.println(" Received >>" + token + "<< instead.");
         e.printStackTrace();
         if (!isForgiving)
            System.exit(1);
         return 0.0;
      }
   }


  /**
   * Reads a <code>char</code> value from the keyboard. At the keyboard,
   * the user types a single character. The character
   * can be a letter, a digit, a punctuation symbol, or whatever.
   * In typing the character, the user does not surround the character
   * with quote marks (as you would in typing a character literal in
   * a Java program).
   * <p>Unlike other <code>DummiesIO.get</code>
   * methods, the <code>getChar</code> method does not expect blank spaces to
   * separate one value from another. For instance, the following code
   * <pre>   char1 = DummiesIO.getChar();
   *   char2 = DummiesIO.getChar();
   *   char3 = DummiesIO.getChar();</pre>
   * with the following input
   * <pre>   xyz</pre>
   * will put <code>x</code> in the variable <code>char1</code>, <code>y</code> in
   * the variable <code>char2</code>, and <code>z</code> in the variable <code>char3</code>.
   * With the following (slightly different) input
   * <pre>   x y z</pre>
   * and the same three calls to <code>getChar</code>, the value of <code>char1</code> will be
   * <code>x</code>, but <code>char2</code> will contain a blank space, and the value of
   * <code>char3</code> will be <code>y</code>.
   * @return  The <code>char</code> value typed on the keyboard by the user
   * @see     #getChar(java.lang.String)
   */    
   static public char getChar()
   {
      return getChar("keyboard");
   }


  /**
   * Reads a <code>char</code> value from a disk file
   * @param  fileName The name of a file
   * @return  The <code>char</code> value found in the file
   * @see #getChar()
   */  
   static public char getChar(String fileName)
   {
      char token=' ';

      try
      {
         return token=getCharFromToken(fileName);
      }
      catch (Exception e)
      {
         System.out.println("Cannot read a char value.");
         System.out.print("Expected a char value;");
         System.out.print(" Received >>");
         System.out.print(token);
         System.out.println("<< instead.");
         e.printStackTrace();
         if (!isForgiving)
            System.exit(1);
         return ' ';
      }
   }


  /**
   * Reads a <code>boolean</code> value from the keyboard. Returns
   * true if the user types <code>true</code>; returns false otherwise.
   * The input is not case sensitive. (The method returns true if the
   * user types <code>tRuE</code>.)
   * @return  The <code>boolean</code> value typed on the keyboard by the user
   * @see     #getBoolean(java.lang.String)
   */    
   static public boolean getBoolean()
   {
      return getBoolean("keyboard");
   }


  /**
   * Reads a <code>boolean</code> value from a disk file
   * @param  fileName The name of a file
   * @return  The <code>boolean</code> value found in the file
   * @see #getBoolean()
   */  
   static public boolean getBoolean(String fileName)
   {
      String token="";

      try
      {
         return (Boolean.valueOf(token=getNonblankToken(fileName))).booleanValue();
      }
      catch (Exception e)
      {
         System.out.println("Cannot read a boolean value.");
         System.out.print("Expected a boolean value;");
         System.out.println(" Received >>" + token + "<< instead.");
         e.printStackTrace();
         if (!isForgiving)
            System.exit(1);
         return false;
      }
   }


  /**
   * Reads a string of characters from the keyboard. At the keyboard,
   * the user types a sequence of characters followed by a blank space or by
   * the end of a line. In typing the sequence of characters, 
   * the user does not surround these characters
   * with quote marks (as you would in typing a String literal in
   * a Java program).
   * @return  The next sequence of characters typed on the keyboard by the user (up to but not including the first blank space or the end of a line)
   * @see     #getString(java.lang.String)
   * @see     #getLine()
   * @see     #getLine(java.lang.String)
   */    
   static public String getString()
   {
      return getString("keyboard");
   }


  /**
   * Reads a string of characters (up to the next blank space or the end of a line) from a disk file
   * @param  fileName The name of a file
   * @return  The next sequence of characters from a disk file (up to but not including the first blank space or the end of a line)
   * @see #getString()
   */  
   static public String getString(String fileName)
   {
      String token="";

      try
      {
         return token=getNonblankToken(fileName);
      }
      catch (Exception e)
      {
         System.out.println("Cannot read a String value.");
         System.out.print("Expected a String value;");
         System.out.println(" Received >>" + token + "<< instead.");
         e.printStackTrace();
         if (!isForgiving)
            System.exit(1);
         return "";
      }
   }


   /**
    * This method (which is not yet working correctly) is meant to read a byte 
    * (eight bits) from the keyboard. 
    * @return  a <code>byte</code> value
    * @see     #getByte(java.lang.String)
    */
   static private byte getByte()
   {
      return getByte("keyboard");
   }


   /**
    * This method (which is not yet working correctly) is meant to read a byte 
    * (eight bits) from a disk file. 
    * @param  fileName The name of a file
    * @return  The <code>byte</code> value found in the file
    * @see     #getByte()
    */
   static private byte getByte(String fileName)
   {
      try
      {
         ///THIS METHOD ISN'T FINISHED BEING WRITTEN YET
         return Byte.parseByte(getNonblankToken(fileName));
      }
      catch (Exception e)
      {
         System.out.println("Cannot read a byte value.");
         e.printStackTrace();
         if (!isForgiving)
            System.exit(1);
         return (byte)0;
      }
   }


  /**
   * Reads a <code>short</code> value from the keyboard. At the keyboard,
   * the user types a sequence of digits, optionally preceded by a minus
   * sign.
   * @return  The <code>short</code> value typed on the keyboard by the user
   * @see     #getShort(java.lang.String)
   */    
   static public short getShort()
   {
      return getShort("keyboard");
   }


  /**
   * Reads a <code>short</code> value from a disk file
   * @param  fileName The name of a file
   * @return  The <code>short</code> value found in the file
   * @see #getShort()
   */  
   static public short getShort(String fileName)
   {
      String token="";

      try
      {
         return Short.parseShort(token=getNonblankToken(fileName));
      }
      catch (Exception e)
      {
         System.out.println("Cannot read a short value.");
         System.out.print("Expected a short value;");
         System.out.println(" Received >>" + token + "<< instead.");
         e.printStackTrace();
         if (!isForgiving)
            System.exit(1);
         return (short)0;
      }
   }


  /**
   * Reads a <code>long</code> value from the keyboard. At the keyboard,
   * the user types a sequence of digits, optionally preceded by a minus
   * sign. The user does <i>not</i> type the letter <code>L</code> or 
   * <code>l</code>, as you would for a <code>long</code> literal in a
   * Java program.
   * @return  The <code>long</code> value typed on the keyboard by the user
   * @see     #getLong(java.lang.String)
   */    
   static public long getLong()
   {
      return getLong("keyboard");
   }


  /**
   * Reads a <code>long</code> value from a disk file
   * @param  fileName The name of a file
   * @return  The <code>long</code> value found in the file
   * @see #getLong()
   */  
   static public long getLong(String fileName)
   {
      String token="";

      try
      {
         return Long.parseLong(token=getNonblankToken(fileName));
      }
      catch (Exception e)
      {
         System.out.println("Cannot read a long value.");
         System.out.print("Expected a long value;");
         System.out.println(" Received >>" + token + "<< instead.");
         e.printStackTrace();
         if (!isForgiving)
            System.exit(1);
         return 0L;
      }
   }


  /**
   * Reads a <code>float</code> value from the keyboard. At the keyboard,
   * the user types a float literal. Examples of float literals include
   * <pre>   1e1f   2.f   .3f   0f   3.14f   6.022137e+23f</pre>
   * @return  The <code>float</code> value typed on the keyboard by the user
   * @see     #getFloat(java.lang.String)
   */    
   static public float getFloat()
   {
      return getFloat("keyboard");
   }


  /**
   * Reads a <code>float</code> value from a disk file
   * @param  fileName The name of a file
   * @return  The <code>float</code> value found in the file
   * @see #getFloat()
   */  
   static public float getFloat(String fileName)
   {
      String token="";

      try
      {
         return Float.parseFloat(token=getNonblankToken(fileName));
      }
      catch (Exception e)
      {
         System.out.println("Cannot read a float value.");
         System.out.print("Expected a float value;");
         System.out.println(" Received >>" + token + "<< instead.");
         e.printStackTrace();
         if (!isForgiving)
            System.exit(1);
         return 0.0F;
      }
   }


  /**
   * Reads the remaining line (up to the pressing of the Enter key) from the keyboard. 
   * This method reads past blank spaces. For instance, if the user types
   * <pre>   Hello, how are you?</pre>
   * then one call to the <code>getLine</code> method gets all four words and the
   * two punctuation symbols.<p>This method doesn't necessarily read an entire line from
   * beginning to end. Instead, the method can read from a point in the middle of a line to
   * the end of the line. For example, if the user types the following:
   * <pre>   42 Hello there!
   *   Goodbye! 88</pre>
   * and the Java program calls
   * <pre>   x = getInt();
   *   y = getLine();
   *   z = getLine();</pre>
   * then the value of <code>x</code> is <code>42</code>, the value of <code>y</code> is
   * <code>"Hello there!"</code>, and the value of <code>z</code> is <code>"Goodbye! 88"</code>.
   * @return  The next sequence of characters typed on the keyboard by the user (up to the user's pressing of the Enter key)
   * @see     #getLine(java.lang.String)
   * @see     #getString()
   * @see     #getString(java.lang.String)
   */    
   static public String getLine()
   {
      return getLine("keyboard");
   }


  /**
   * Reads the remaining line (up to the start of a new line) from a disk file.
   * @param  fileName The name of a file
   * @return  The next sequence of characters found in the file (up to the end of the current line)
   * @see #getLine()
   */  
   static public String getLine(String fileName)
   {
      try
      {
         return getRestOfLine(fileName);
      }
      catch (Exception e)
      {
         System.out.println("Cannot read the rest of the line.");
         e.printStackTrace();
         if (!isForgiving)
            System.exit(1);
         return "";
      }
   }


   /**
    * Writes the word <code>true</code> or the word <code>false</code> to a disk file.
    * After writing the word, this method goes to the next line in the disk file 
    * (in preparation for any subsequent <code>print</code> or <code>println</code> calls
    * that write to this file).
    * @param  fileName The name of a file
    * @param  value      The <code>boolean</code> value that's to be written to the file
    * @see #print(java.lang.String, boolean)
    */
   public static void println(String fileName, boolean value)
   {
      OutFileState outFileState = openForWriteOrUseExisting(fileName);
      outFileState.printStream.println(value);
   }

   /**
    * Writes the word <code>true</code> or the word <code>false</code> to a disk file.
    * After writing the word, this method remains on the same line in the disk file 
    * (in preparation for any subsequent <code>print</code> or <code>println</code> calls
    * that write to this file).
    * @param  fileName The name of a file
    * @param  value      The <code>boolean</code> value that's to be written to the file
    * @see #println(java.lang.String, boolean)
    */
   public static void print(String fileName, boolean value)
   {
      OutFileState outFileState = openForWriteOrUseExisting(fileName);
      outFileState.printStream.print(value);
   }



   /**
    * Writes a single character (without single quote marks) to a disk file.
    * After writing the character, this method goes to the next line in the disk file 
    * (in preparation for any subsequent <code>print</code> or <code>println</code> calls
    * that write to this file).
    * @param  fileName The name of a file
    * @param  value      The <code>char</code> value that's to be written to the file
    * @see #print(java.lang.String, char)
    */
   public static void println(String fileName, char value)
   {
      OutFileState outFileState = openForWriteOrUseExisting(fileName);
      outFileState.printStream.println(value);
   }

   /**
    * Writes a single character (without single quote marks) to a disk file.
    * After writing the character, this method remains on the same line in the disk file 
    * (in preparation for any subsequent <code>print</code> or <code>println</code> calls
    * that write to this file).
    * @param  fileName The name of a file
    * @param  value      The <code>char</code> value that's to be written to the file
    * @see #println(java.lang.String, char)
    */
   public static void print(String fileName, char value)
   {
      OutFileState outFileState = openForWriteOrUseExisting(fileName);
      outFileState.printStream.print(value);
   }



   /**
    * Writes a <code>double</code> value to a disk file.
    * After writing the value, this method goes to the next line in the disk file 
    * (in preparation for any subsequent <code>print</code> or <code>println</code> calls
    * that write to this file).
    * @param  fileName The name of a file
    * @param  value      The <code>double</code> value that's to be written to the file
    * @see #print(java.lang.String, double)
    */
   public static void println(String fileName, double value)
   {
      OutFileState outFileState = openForWriteOrUseExisting(fileName);
      outFileState.printStream.println(value);
   }

   /**
    * Writes a <code>double</code> value to a disk file.
    * After writing the value, this method remains on the same line in the disk file 
    * (in preparation for any subsequent <code>print</code> or <code>println</code> calls
    * that write to this file).
    * @param  fileName The name of a file
    * @param  value      The <code>double</code> value that's to be written to the file
    * @see #println(java.lang.String, double)
    */
   public static void print(String fileName, double value)
   {
      OutFileState outFileState = openForWriteOrUseExisting(fileName);
      outFileState.printStream.print(value);
   }



   /**
    * Writes a <code>float</code> value to a disk file.
    * After writing the value, this method goes to the next line in the disk file 
    * (in preparation for any subsequent <code>print</code> or <code>println</code> calls
    * that write to this file).
    * @param  fileName The name of a file
    * @param  value      The <code>float</code> value that's to be written to the file
    * @see #print(java.lang.String, float)
    */
   public static void println(String fileName, float value)
   {
      OutFileState outFileState = openForWriteOrUseExisting(fileName);
      outFileState.printStream.println(value);
   }

   /**
    * Writes a <code>float</code> value to a disk file.
    * After writing the value, this method remains on the same line in the disk file 
    * (in preparation for any subsequent <code>print</code> or <code>println</code> calls
    * that write to this file).
    * @param  fileName The name of a file
    * @param  value      The <code>float</code> value that's to be written to the file
    * @see #println(java.lang.String, float)
    */
   public static void print(String fileName, float value)
   {
      OutFileState outFileState = openForWriteOrUseExisting(fileName);
      outFileState.printStream.print(value);
   }



   /**
    * Writes an <code>int</code> value to a disk file.
    * After writing the value, this method goes to the next line in the disk file 
    * (in preparation for any subsequent <code>print</code> or <code>println</code> calls
    * that write to this file).
    * @param  fileName The name of a file
    * @param  value      The <code>int</code> value that's to be written to the file
    * @see #print(java.lang.String, int)
    */
   public static void println(String fileName, int value)
   {
      OutFileState outFileState = openForWriteOrUseExisting(fileName);
      outFileState.printStream.println(value);
   }

   /**
    * Writes an <code>int</code> value to a disk file.
    * After writing the value, this method remains on the same line in the disk file 
    * (in preparation for any subsequent <code>print</code> or <code>println</code> calls
    * that write to this file).
    * @param  fileName The name of a file
    * @param  value      The <code>int</code> value that's to be written to the file
    * @see #println(java.lang.String, int)
    */
   public static void print(String fileName, int value)
   {
      OutFileState outFileState = openForWriteOrUseExisting(fileName);
      outFileState.printStream.print(value);
   }



   /**
    * Writes a <code>long</code> to a disk file.
    * After writing the value, this method goes to the next line in the disk file 
    * (in preparation for any subsequent <code>print</code> or <code>println</code> calls
    * that write to this file).
    * @param  fileName The name of a file
    * @param  value      The <code>long</code> value that's to be written to the file
    * @see #print(java.lang.String, long)
    */
   public static void println(String fileName, long value)
   {
      OutFileState outFileState = openForWriteOrUseExisting(fileName);
      outFileState.printStream.println(value);
   }

   /**
    * Writes a <code>long</code> to a disk file.
    * After writing the value, this method remains on the same line in the disk file 
    * (in preparation for any subsequent <code>print</code> or <code>println</code> calls
    * that write to this file).
    * @param  fileName The name of a file
    * @param  value      The <code>long</code> value that's to be written to the file
    * @see #println(java.lang.String, long)
    */
   public static void print(String fileName, long value)
   {
      OutFileState outFileState = openForWriteOrUseExisting(fileName);
      outFileState.printStream.print(value);
   }



   /**
    * Writes a string of characters to a disk file. This method does not add
    * double quote marks to the beginning and end of the string (and for most purposes,
    * there's no reason to
    * surround the string with double quote marks).
    * After writing the string, this method goes to the next line in the disk file 
    * (in preparation for any subsequent <code>print</code> or <code>println</code> calls
    * that write to this file).
    * @param  fileName The name of a file
    * @param  value      The <code>String</code> value that's to be written to the file
    * @see #print(java.lang.String, java.lang.String)
    */
   public static void println(String fileName, String value)
   {
      OutFileState outFileState = openForWriteOrUseExisting(fileName);
      outFileState.printStream.println(value);
   }

   /**
    * Writes a string of characters to a disk file. This method does not add
    * double quote marks to the beginning and end of the string (and for most purposes,
    * there's no reason to
    * surround the string with double quote marks).
    * After writing the value, this method remains on the same line in the disk file 
    * (in preparation for any subsequent <code>print</code> or <code>println</code> calls
    * that write to this file).
    * @param  fileName The name of a file
    * @param  value      The <code>String</code> value that's to be written to the file
    * @see #println(java.lang.String, java.lang.String)
    */
   public static void print(String fileName, String value)
   {
      OutFileState outFileState = openForWriteOrUseExisting(fileName);
      outFileState.printStream.print(value);
   }


   /**
    * Writes no visible text to a disk file, but goes to the next line in the disk file 
    * (in preparation for any subsequent <code>print</code> or <code>println</code> calls
    * that write to this file).
    * @param  fileName The name of a file
    */
   public static void println(String fileName)
   {
      OutFileState outFileState = openForWriteOrUseExisting(fileName);
      outFileState.printStream.println();
   }


   private static OutFileState openForWriteOrUseExisting (String fileName)
   {
      OutFileState outFileState=null;

      try
      {
         outFileState = (OutFileState)hashtable.get(fileName);
      }
      catch (ClassCastException e)
      {
         System.out.println("Warning: You are writing to a file from which you've already");
         System.out.println("read data (file: " + fileName + ").");
         System.out.println("Write operations to this file will delete any data in the");
         System.out.println("file.");
      }


      if (outFileState == null)
      {
         getFileForWriting(fileName);
         outFileState = (OutFileState)hashtable.get(fileName);
      }
      return outFileState;
   }


   private static void getFileForWriting(String string)
   {
      FileOutputStream f=null;
      try
      {
         f = new FileOutputStream(string);
      }
      catch (FileNotFoundException e)
      {
         e.printStackTrace();
         System.exit(1);
      }
      PrintStream p = new PrintStream(f);
      hashtable.put(string, new OutFileState(p));
   }
}


class InFileState
{
   BufferedReader reader = null;
   StringTokenizer tokenizer = null;
   String tokenBuffer = null;
   boolean isAtEOF = false;

   InFileState(BufferedReader reader)
   {
      this.reader = reader;
   }
}


class OutFileState
{
   PrintStream printStream;

   OutFileState(PrintStream printStream)
   {
      this.printStream=printStream;
   }
}